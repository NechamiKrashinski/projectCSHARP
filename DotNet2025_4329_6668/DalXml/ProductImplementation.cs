

using DalApi;
using DO;
using System.Xml.Linq;
using System.Xml.Serialization;

namespace Dal;

internal class ProductImplementation :IProduct
{
    static object lockObject = new object();
    public int Create(Product item)
    {
        if (item == null)
        {
            throw new DalExceptionNullReceived("Product");
        }
        List<Product> productsList = LoadProductFromXml();
        //הוספת המוצר החדש לרשימה
        Product p = item with { ID = Config.NextValProduct };
        productsList.Add(p);
        //כתיבת רשימת המוצרים לxml
        StoreProductToXml(productsList);
        return p.ID;

    }

    public void Delete(int id)
    {
        List<Product> productsList = LoadProductFromXml();
        Product? p = Read(id);
        productsList.Remove(p);
        StoreProductToXml(productsList);
    }

    public Product? Read(int id)
    {
        try
        {
            List<Product> productsList = LoadProductFromXml();
            Product p = productsList.Single(p => p?.ID == id);
            StoreProductToXml(productsList);
            return p;
        }
        catch
        {
            throw new DalExceptionIdDoesNotExistInTheList("Product");
        }

    }

    public Product? Read(Func<Product, bool>? filter)
    {
        List<Product> productsList = LoadProductFromXml();

        StoreProductToXml(productsList);
        try
        {
            return productsList.Single(p => filter(p));
        }
        catch
        {
            throw new DalExceptionNoValuesByCondition("customer");
        }
    }

    public List<Product?> ReadAll(Func<Product, bool>? filter = null)
    {
        List<Product> productsList = LoadProductFromXml();
        if (filter == null)
        {
            return productsList;
        }
        return productsList.Where(p => filter(p)).ToList();
    }

    public void Update(Product item)
    {
        List<Product> productsList = LoadProductFromXml();
        if (item == null)
        {
            throw new DalExceptionNullReceived("Product");
        }
        Delete(item.ID);
        productsList.Add(item);
        StoreProductToXml(productsList);
    }


    private List<Product> LoadProductFromXml()
    {
        try
        {
            List<Product> productsList;
            XmlSerializer serializer = new XmlSerializer(typeof(List<Product>));
            //קריאת הנתונים מהxml
            lock (lockObject)
            {
                using (FileStream fs = new FileStream("../xml/products.xml", FileMode.Open, FileAccess.Read))
                {
                    productsList = serializer.Deserialize(fs) as List<Product>;
                }
            }
            if (productsList == null)
            {
                productsList = new List<Product>();
            }
            return productsList;
        }
        catch
        {
            throw new DalExceptionErrorInReadFromXml("Product");
        }
    }

    private void StoreProductToXml(List<Product> productsList)
    {
        try
        {
            lock (lockObject)
            {
                using (FileStream fs = new FileStream("../xml/products.xml", FileMode.Open, FileAccess.Write))
                {
                    XmlSerializer serializer = new XmlSerializer(typeof(List<Product>));
                    serializer.Serialize(fs, productsList);
                }
            }
        }
        catch
        {
            throw new DalExceptionErrorInWriteToXml("Product");
        }
    }
}
