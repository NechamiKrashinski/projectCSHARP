

using DalApi;
using DO;
using System.Reflection;
using System.Xml.Serialization;
namespace Dal;

internal class CustomerImplementation : ICustomer
{
    static object lockObject = new object();

    private List<Customer> LoadCustomersListFromXml()
    {
        try
        {
            List<Customer> customersList;
            XmlSerializer serializer = new XmlSerializer(typeof(List<Customer>));
            lock (lockObject)
            {
                //קבלת רשימת הלקוחות מהXML
                using (FileStream fs = new FileStream("../xml/customers.xml", FileMode.Open, FileAccess.Read))
                {
                    customersList = serializer.Deserialize(fs) as List<Customer>;
                }
            }

            if (customersList == null)
            {
                customersList = new List<Customer>();
            }
            return customersList;
        }
        catch
        {
            throw new DalExceptionErrorInReadFromXml("customer");
        }


    }
    private void StoreCustomersListToXml(List<Customer> customersList)
    {
        try
        {
            XmlSerializer serializer = new XmlSerializer(typeof(List<Customer>));
            lock (lockObject)
            {
                //שומרים את הרשימה חזרה בקובץ הXML
                using (FileStream fs = new FileStream("../xml/customers.xml", FileMode.Open, FileAccess.Write))
                {
                    serializer.Serialize(fs, customersList);
                }
            }
        }
        catch
        {
            throw new DalExceptionErrorInWriteToXml("customer");
        }



    }
    public int Create(Customer item)
    {
        if (item == null)
        {
            throw new DalExceptionNullReceived("customer");
        }
        List<Customer> customersList;
        customersList = LoadCustomersListFromXml();
        //בדיקה האם קיים אובייקט עם אותו מזהה
        bool b = customersList.Any(c => c.ID == item.ID);
        if (b)
        {
            throw new DalExceptionIdIsAlreadyExistInTheList("customer");
        }
        customersList.Add(item);
        StoreCustomersListToXml(customersList);

        return item.ID;

    }

    public void Delete(int id)
    {
        List<Customer> customersList;
        customersList = LoadCustomersListFromXml();
        Customer c = Read(id);
        customersList.Remove(c);
        StoreCustomersListToXml(customersList);
    }

    public Customer? Read(int id)
    {
        List<Customer> customersList;
        customersList = LoadCustomersListFromXml();
        try
        {
            Customer c = customersList.Single(c => c?.ID == id);
            StoreCustomersListToXml(customersList);
            return c;
        }
        catch
        {
            throw new DalExceptionIdDoesNotExistInTheList("customer");
        }

    }

    public Customer? Read(Func<Customer, bool>? filter)
    {        
        if (filter == null) return null;
        List<Customer> customersList;
        customersList = LoadCustomersListFromXml();
        try
        {
            return customersList.Single(c => filter(c));
        }
        catch
        {
            throw new DalExceptionNoValuesByCondition("customer");
        }
    }

    public List<Customer?> ReadAll(Func<Customer, bool>? filter = null)
    {
        List<Customer> customersList;
        customersList = LoadCustomersListFromXml();
        if (filter == null)
        {
            return new List<Customer?>(customersList);

        }
        return customersList.Where(c => filter(c)).ToList();

    }

    public void Update(Customer item)
    {
        if (item == null)
        {
            throw new DalExceptionNullReceived("customer");
        }
        List<Customer> customersList;
        customersList = LoadCustomersListFromXml();
        Delete(item.ID);
        customersList.Add(item);
        StoreCustomersListToXml(customersList);
    }
}
