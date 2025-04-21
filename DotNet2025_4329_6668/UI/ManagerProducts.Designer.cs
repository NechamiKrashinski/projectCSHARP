namespace UI
{
    partial class ManagerProducts
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            tabControlCustomers = new TabControl();
            add = new TabPage();
<<<<<<< HEAD
            comboBoxCategory = new ComboBox();
            buttonAdd = new Button();
            textBoxAmont = new TextBox();
            textBoxPrice = new TextBox();
            textBoxName = new TextBox();
            amount = new Label();
            price = new Label();
            address = new Label();
            label7 = new Label();
            name = new Label();
            update = new TabPage();
            comboBoxUpdateCategory = new ComboBox();
            BtnUpdate = new Button();
            textBoxUpdateAmount = new TextBox();
            sendIdToUpdate = new Button();
            textBoxUpdatePrice = new TextBox();
            textBoxUpdateId = new TextBox();
            textBoxUpdateName = new TextBox();
            label2 = new Label();
            label1 = new Label();
            label3 = new Label();
            label9 = new Label();
            label4 = new Label();
            label8 = new Label();
=======
            buttonAdd = new Button();
            textBoxPhone = new TextBox();
            textBoxAddress = new TextBox();
            textBoxName = new TextBox();
            textBoxId = new TextBox();
            phone = new Label();
            address = new Label();
            name = new Label();
            ID = new Label();
            update = new TabPage();
            BtnUpdate = new Button();
            textBoxUpdatePhone = new TextBox();
            textBoxUpdateAddress = new TextBox();
            textBoxUpdateName = new TextBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            sendIdToUpdate = new Button();
            textBoxUpdateId = new TextBox();
            label1 = new Label();
>>>>>>> a6286ce92929cd05286a75453dcbe4bb1f77bc25
            delete = new TabPage();
            BtnDelete = new Button();
            textBoxDeleteId = new TextBox();
            label5 = new Label();
            readById = new TabPage();
<<<<<<< HEAD
            textBoxReadAmount = new TextBox();
            textBoxReadPrice = new TextBox();
            textBoxReadCategory = new TextBox();
            textBoxReadName = new TextBox();
            labelReadAmount = new Label();
            labelReadPrice = new Label();
            labelReadCategort = new Label();
=======
            textBoxReadPhone = new TextBox();
            textBoxReadAddress = new TextBox();
            textBoxReadName = new TextBox();
            labelReadPhone = new Label();
            labelReadAddress = new Label();
>>>>>>> a6286ce92929cd05286a75453dcbe4bb1f77bc25
            labelReadName = new Label();
            BtnRead = new Button();
            textBoxReadId = new TextBox();
            label6 = new Label();
<<<<<<< HEAD
            listBoxProducts = new ListBox();
=======
            listBoxCustomers = new ListBox();
>>>>>>> a6286ce92929cd05286a75453dcbe4bb1f77bc25
            tabControlCustomers.SuspendLayout();
            add.SuspendLayout();
            update.SuspendLayout();
            delete.SuspendLayout();
            readById.SuspendLayout();
            SuspendLayout();
            // 
            // tabControlCustomers
            // 
            tabControlCustomers.Controls.Add(add);
            tabControlCustomers.Controls.Add(update);
            tabControlCustomers.Controls.Add(delete);
            tabControlCustomers.Controls.Add(readById);
            tabControlCustomers.Location = new Point(29, 33);
            tabControlCustomers.Name = "tabControlCustomers";
            tabControlCustomers.RightToLeft = RightToLeft.Yes;
            tabControlCustomers.RightToLeftLayout = true;
            tabControlCustomers.SelectedIndex = 0;
            tabControlCustomers.Size = new Size(357, 384);
            tabControlCustomers.TabIndex = 3;
            // 
            // add
            // 
<<<<<<< HEAD
            add.Controls.Add(comboBoxCategory);
            add.Controls.Add(buttonAdd);
            add.Controls.Add(textBoxAmont);
            add.Controls.Add(textBoxPrice);
            add.Controls.Add(textBoxName);
            add.Controls.Add(amount);
            add.Controls.Add(price);
            add.Controls.Add(address);
            add.Controls.Add(label7);
            add.Controls.Add(name);
=======
            add.Controls.Add(buttonAdd);
            add.Controls.Add(textBoxPhone);
            add.Controls.Add(textBoxAddress);
            add.Controls.Add(textBoxName);
            add.Controls.Add(textBoxId);
            add.Controls.Add(phone);
            add.Controls.Add(address);
            add.Controls.Add(name);
            add.Controls.Add(ID);
>>>>>>> a6286ce92929cd05286a75453dcbe4bb1f77bc25
            add.Location = new Point(4, 29);
            add.Name = "add";
            add.Padding = new Padding(3);
            add.Size = new Size(349, 351);
            add.TabIndex = 0;
            add.Text = "הוספה";
            add.UseVisualStyleBackColor = true;
            // 
<<<<<<< HEAD
            // comboBoxCategory
            // 
            comboBoxCategory.FormattingEnabled = true;
            comboBoxCategory.Location = new Point(73, 126);
            comboBoxCategory.Name = "comboBoxCategory";
            comboBoxCategory.Size = new Size(125, 28);
            comboBoxCategory.TabIndex = 3;
            // 
            // buttonAdd
            // 
            buttonAdd.Location = new Point(127, 292);
=======
            // buttonAdd
            // 
            buttonAdd.Location = new Point(114, 281);
>>>>>>> a6286ce92929cd05286a75453dcbe4bb1f77bc25
            buttonAdd.Name = "buttonAdd";
            buttonAdd.Size = new Size(94, 29);
            buttonAdd.TabIndex = 2;
            buttonAdd.Text = "הוסף";
            buttonAdd.UseVisualStyleBackColor = true;
<<<<<<< HEAD
            buttonAdd.Click += buttonAdd_Click;
            // 
            // textBoxAmont
            // 
            textBoxAmont.Location = new Point(73, 221);
            textBoxAmont.Name = "textBoxAmont";
            textBoxAmont.Size = new Size(126, 27);
            textBoxAmont.TabIndex = 1;
            // 
            // textBoxPrice
            // 
            textBoxPrice.Location = new Point(73, 175);
            textBoxPrice.Name = "textBoxPrice";
            textBoxPrice.Size = new Size(125, 27);
            textBoxPrice.TabIndex = 1;
            // 
            // textBoxName
            // 
            textBoxName.Location = new Point(73, 72);
=======
            // 
            // textBoxPhone
            // 
            textBoxPhone.Location = new Point(87, 218);
            textBoxPhone.Name = "textBoxPhone";
            textBoxPhone.Size = new Size(125, 27);
            textBoxPhone.TabIndex = 1;
            // 
            // textBoxAddress
            // 
            textBoxAddress.Location = new Point(87, 167);
            textBoxAddress.Name = "textBoxAddress";
            textBoxAddress.Size = new Size(125, 27);
            textBoxAddress.TabIndex = 1;
            // 
            // textBoxName
            // 
            textBoxName.Location = new Point(87, 115);
>>>>>>> a6286ce92929cd05286a75453dcbe4bb1f77bc25
            textBoxName.Name = "textBoxName";
            textBoxName.Size = new Size(125, 27);
            textBoxName.TabIndex = 1;
            // 
<<<<<<< HEAD
            // amount
            // 
            amount.AutoSize = true;
            amount.Location = new Point(208, 228);
            amount.Name = "amount";
            amount.Size = new Size(87, 20);
            amount.TabIndex = 0;
            amount.Text = "כמות במלאי";
            // 
            // price
            // 
            price.AutoSize = true;
            price.Location = new Point(229, 178);
            price.Name = "price";
            price.Size = new Size(41, 20);
            price.TabIndex = 0;
            price.Text = "מחיר";
=======
            // textBoxId
            // 
            textBoxId.Location = new Point(87, 67);
            textBoxId.Name = "textBoxId";
            textBoxId.Size = new Size(125, 27);
            textBoxId.TabIndex = 1;
            // 
            // phone
            // 
            phone.AutoSize = true;
            phone.Location = new Point(243, 228);
            phone.Name = "phone";
            phone.Size = new Size(44, 20);
            phone.TabIndex = 0;
            phone.Text = "טלפון";
>>>>>>> a6286ce92929cd05286a75453dcbe4bb1f77bc25
            // 
            // address
            // 
            address.AutoSize = true;
<<<<<<< HEAD
            address.Location = new Point(221, 134);
            address.Name = "address";
            address.Size = new Size(0, 20);
            address.TabIndex = 0;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(220, 127);
            label7.Name = "label7";
            label7.RightToLeft = RightToLeft.Yes;
            label7.Size = new Size(62, 20);
            label7.TabIndex = 0;
            label7.Text = "קטגוריה";
=======
            address.Location = new Point(235, 177);
            address.Name = "address";
            address.Size = new Size(52, 20);
            address.TabIndex = 0;
            address.Text = "כתובת";
>>>>>>> a6286ce92929cd05286a75453dcbe4bb1f77bc25
            // 
            // name
            // 
            name.AutoSize = true;
<<<<<<< HEAD
            name.Location = new Point(220, 75);
            name.Name = "name";
            name.RightToLeft = RightToLeft.Yes;
            name.Size = new Size(66, 20);
            name.TabIndex = 0;
            name.Text = "שם מוצר";
            // 
            // update
            // 
            update.Controls.Add(comboBoxUpdateCategory);
            update.Controls.Add(BtnUpdate);
            update.Controls.Add(textBoxUpdateAmount);
            update.Controls.Add(sendIdToUpdate);
            update.Controls.Add(textBoxUpdatePrice);
            update.Controls.Add(textBoxUpdateId);
            update.Controls.Add(textBoxUpdateName);
            update.Controls.Add(label2);
            update.Controls.Add(label1);
            update.Controls.Add(label3);
            update.Controls.Add(label9);
            update.Controls.Add(label4);
            update.Controls.Add(label8);
=======
            name.Location = new Point(247, 125);
            name.Name = "name";
            name.RightToLeft = RightToLeft.Yes;
            name.Size = new Size(31, 20);
            name.TabIndex = 0;
            name.Text = "שם";
            // 
            // ID
            // 
            ID.AutoSize = true;
            ID.Location = new Point(221, 73);
            ID.Name = "ID";
            ID.Size = new Size(85, 20);
            ID.TabIndex = 0;
            ID.Text = "תעודת זהות";
            // 
            // update
            // 
            update.Controls.Add(BtnUpdate);
            update.Controls.Add(textBoxUpdatePhone);
            update.Controls.Add(textBoxUpdateAddress);
            update.Controls.Add(textBoxUpdateName);
            update.Controls.Add(label2);
            update.Controls.Add(label3);
            update.Controls.Add(label4);
            update.Controls.Add(sendIdToUpdate);
            update.Controls.Add(textBoxUpdateId);
            update.Controls.Add(label1);
>>>>>>> a6286ce92929cd05286a75453dcbe4bb1f77bc25
            update.Location = new Point(4, 29);
            update.Name = "update";
            update.Padding = new Padding(3);
            update.Size = new Size(349, 351);
            update.TabIndex = 1;
            update.Text = "עדכון";
            update.UseVisualStyleBackColor = true;
            // 
<<<<<<< HEAD
            // comboBoxUpdateCategory
            // 
            comboBoxUpdateCategory.FormattingEnabled = true;
            comboBoxUpdateCategory.Location = new Point(24, 185);
            comboBoxUpdateCategory.Name = "comboBoxUpdateCategory";
            comboBoxUpdateCategory.Size = new Size(189, 28);
            comboBoxUpdateCategory.TabIndex = 12;
            comboBoxUpdateCategory.Visible = false;
            // 
            // BtnUpdate
            // 
            BtnUpdate.Location = new Point(119, 316);
=======
            // BtnUpdate
            // 
            BtnUpdate.Location = new Point(44, 300);
>>>>>>> a6286ce92929cd05286a75453dcbe4bb1f77bc25
            BtnUpdate.Name = "BtnUpdate";
            BtnUpdate.Size = new Size(94, 29);
            BtnUpdate.TabIndex = 11;
            BtnUpdate.Text = "עדכן";
            BtnUpdate.UseVisualStyleBackColor = true;
            BtnUpdate.Visible = false;
<<<<<<< HEAD
            BtnUpdate.Click += BtnUpdate_Click;
            // 
            // textBoxUpdateAmount
            // 
            textBoxUpdateAmount.Location = new Point(24, 275);
            textBoxUpdateAmount.Name = "textBoxUpdateAmount";
            textBoxUpdateAmount.Size = new Size(189, 27);
            textBoxUpdateAmount.TabIndex = 9;
            textBoxUpdateAmount.Visible = false;
            // 
            // sendIdToUpdate
            // 
            sendIdToUpdate.Location = new Point(119, 86);
=======
            // 
            // textBoxUpdatePhone
            // 
            textBoxUpdatePhone.Location = new Point(85, 236);
            textBoxUpdatePhone.Name = "textBoxUpdatePhone";
            textBoxUpdatePhone.Size = new Size(125, 27);
            textBoxUpdatePhone.TabIndex = 8;
            textBoxUpdatePhone.Visible = false;
            // 
            // textBoxUpdateAddress
            // 
            textBoxUpdateAddress.Location = new Point(85, 185);
            textBoxUpdateAddress.Name = "textBoxUpdateAddress";
            textBoxUpdateAddress.Size = new Size(125, 27);
            textBoxUpdateAddress.TabIndex = 9;
            textBoxUpdateAddress.Visible = false;
            // 
            // textBoxUpdateName
            // 
            textBoxUpdateName.Location = new Point(85, 133);
            textBoxUpdateName.Name = "textBoxUpdateName";
            textBoxUpdateName.Size = new Size(125, 27);
            textBoxUpdateName.TabIndex = 10;
            textBoxUpdateName.Visible = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(241, 246);
            label2.Name = "label2";
            label2.Size = new Size(44, 20);
            label2.TabIndex = 5;
            label2.Text = "טלפון";
            label2.Visible = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(233, 195);
            label3.Name = "label3";
            label3.Size = new Size(52, 20);
            label3.TabIndex = 6;
            label3.Text = "כתובת";
            label3.Visible = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(245, 143);
            label4.Name = "label4";
            label4.RightToLeft = RightToLeft.Yes;
            label4.Size = new Size(31, 20);
            label4.TabIndex = 7;
            label4.Text = "שם";
            label4.Visible = false;
            // 
            // sendIdToUpdate
            // 
            sendIdToUpdate.Location = new Point(142, 86);
>>>>>>> a6286ce92929cd05286a75453dcbe4bb1f77bc25
            sendIdToUpdate.Name = "sendIdToUpdate";
            sendIdToUpdate.Size = new Size(94, 29);
            sendIdToUpdate.TabIndex = 4;
            sendIdToUpdate.Text = "שלח";
            sendIdToUpdate.UseVisualStyleBackColor = true;
<<<<<<< HEAD
            sendIdToUpdate.Click += sendIdToUpdate_Click;
            // 
            // textBoxUpdatePrice
            // 
            textBoxUpdatePrice.Location = new Point(24, 234);
            textBoxUpdatePrice.Name = "textBoxUpdatePrice";
            textBoxUpdatePrice.Size = new Size(189, 27);
            textBoxUpdatePrice.TabIndex = 10;
            textBoxUpdatePrice.Visible = false;
=======
>>>>>>> a6286ce92929cd05286a75453dcbe4bb1f77bc25
            // 
            // textBoxUpdateId
            // 
            textBoxUpdateId.Location = new Point(88, 43);
            textBoxUpdateId.Name = "textBoxUpdateId";
            textBoxUpdateId.Size = new Size(125, 27);
            textBoxUpdateId.TabIndex = 3;
            // 
<<<<<<< HEAD
            // textBoxUpdateName
            // 
            textBoxUpdateName.Location = new Point(24, 131);
            textBoxUpdateName.Name = "textBoxUpdateName";
            textBoxUpdateName.Size = new Size(189, 27);
            textBoxUpdateName.TabIndex = 11;
            textBoxUpdateName.Visible = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(222, 282);
            label2.Name = "label2";
            label2.Size = new Size(87, 20);
            label2.TabIndex = 4;
            label2.Text = "כמות במלאי";
            label2.Visible = false;
            // 
=======
>>>>>>> a6286ce92929cd05286a75453dcbe4bb1f77bc25
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(222, 49);
            label1.Name = "label1";
<<<<<<< HEAD
            label1.Size = new Size(79, 20);
            label1.TabIndex = 2;
            label1.Text = "מזהה מוצר";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(244, 237);
            label3.Name = "label3";
            label3.Size = new Size(41, 20);
            label3.TabIndex = 5;
            label3.Text = "מחיר";
            label3.Visible = false;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(235, 134);
            label9.Name = "label9";
            label9.RightToLeft = RightToLeft.Yes;
            label9.Size = new Size(66, 20);
            label9.TabIndex = 8;
            label9.Text = "שם מוצר";
            label9.Visible = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(236, 193);
            label4.Name = "label4";
            label4.Size = new Size(0, 20);
            label4.TabIndex = 6;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(235, 186);
            label8.Name = "label8";
            label8.RightToLeft = RightToLeft.Yes;
            label8.Size = new Size(62, 20);
            label8.TabIndex = 7;
            label8.Text = "קטגוריה";
            label8.Visible = false;
=======
            label1.Size = new Size(85, 20);
            label1.TabIndex = 2;
            label1.Text = "תעודת זהות";
>>>>>>> a6286ce92929cd05286a75453dcbe4bb1f77bc25
            // 
            // delete
            // 
            delete.Controls.Add(BtnDelete);
            delete.Controls.Add(textBoxDeleteId);
            delete.Controls.Add(label5);
            delete.Location = new Point(4, 29);
            delete.Name = "delete";
            delete.Size = new Size(349, 351);
            delete.TabIndex = 2;
            delete.Text = "מחיקה";
            delete.UseVisualStyleBackColor = true;
            // 
            // BtnDelete
            // 
            BtnDelete.Location = new Point(120, 182);
            BtnDelete.Name = "BtnDelete";
            BtnDelete.Size = new Size(94, 29);
            BtnDelete.TabIndex = 7;
            BtnDelete.Text = "מחיקה";
            BtnDelete.UseVisualStyleBackColor = true;
<<<<<<< HEAD
            BtnDelete.Click += BtnDelete_Click;
=======
>>>>>>> a6286ce92929cd05286a75453dcbe4bb1f77bc25
            // 
            // textBoxDeleteId
            // 
            textBoxDeleteId.Location = new Point(66, 139);
            textBoxDeleteId.Name = "textBoxDeleteId";
            textBoxDeleteId.Size = new Size(125, 27);
            textBoxDeleteId.TabIndex = 6;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(197, 142);
            label5.Name = "label5";
<<<<<<< HEAD
            label5.Size = new Size(79, 20);
            label5.TabIndex = 5;
            label5.Text = "מזהה מוצר";
            // 
            // readById
            // 
            readById.Controls.Add(textBoxReadAmount);
            readById.Controls.Add(textBoxReadPrice);
            readById.Controls.Add(textBoxReadCategory);
            readById.Controls.Add(textBoxReadName);
            readById.Controls.Add(labelReadAmount);
            readById.Controls.Add(labelReadPrice);
            readById.Controls.Add(labelReadCategort);
=======
            label5.Size = new Size(85, 20);
            label5.TabIndex = 5;
            label5.Text = "תעודת זהות";
            // 
            // readById
            // 
            readById.Controls.Add(textBoxReadPhone);
            readById.Controls.Add(textBoxReadAddress);
            readById.Controls.Add(textBoxReadName);
            readById.Controls.Add(labelReadPhone);
            readById.Controls.Add(labelReadAddress);
>>>>>>> a6286ce92929cd05286a75453dcbe4bb1f77bc25
            readById.Controls.Add(labelReadName);
            readById.Controls.Add(BtnRead);
            readById.Controls.Add(textBoxReadId);
            readById.Controls.Add(label6);
            readById.Location = new Point(4, 29);
            readById.Name = "readById";
            readById.Size = new Size(349, 351);
            readById.TabIndex = 3;
<<<<<<< HEAD
            readById.Text = "הצגת מוצר ע\"י מזהה";
            readById.UseVisualStyleBackColor = true;
            // 
            // textBoxReadAmount
            // 
            textBoxReadAmount.Location = new Point(92, 289);
            textBoxReadAmount.Name = "textBoxReadAmount";
            textBoxReadAmount.Size = new Size(125, 27);
            textBoxReadAmount.TabIndex = 14;
            textBoxReadAmount.Visible = false;
            // 
            // textBoxReadPrice
            // 
            textBoxReadPrice.Location = new Point(92, 245);
            textBoxReadPrice.Name = "textBoxReadPrice";
            textBoxReadPrice.Size = new Size(125, 27);
            textBoxReadPrice.TabIndex = 14;
            textBoxReadPrice.Visible = false;
            // 
            // textBoxReadCategory
            // 
            textBoxReadCategory.Location = new Point(92, 194);
            textBoxReadCategory.Name = "textBoxReadCategory";
            textBoxReadCategory.Size = new Size(125, 27);
            textBoxReadCategory.TabIndex = 15;
            textBoxReadCategory.Visible = false;
=======
            readById.Text = "הצגת לקוח ע\"י ת.ז.";
            readById.UseVisualStyleBackColor = true;
            // 
            // textBoxReadPhone
            // 
            textBoxReadPhone.Location = new Point(92, 245);
            textBoxReadPhone.Name = "textBoxReadPhone";
            textBoxReadPhone.Size = new Size(125, 27);
            textBoxReadPhone.TabIndex = 14;
            textBoxReadPhone.Visible = false;
            // 
            // textBoxReadAddress
            // 
            textBoxReadAddress.Location = new Point(92, 194);
            textBoxReadAddress.Name = "textBoxReadAddress";
            textBoxReadAddress.Size = new Size(125, 27);
            textBoxReadAddress.TabIndex = 15;
            textBoxReadAddress.Visible = false;
>>>>>>> a6286ce92929cd05286a75453dcbe4bb1f77bc25
            // 
            // textBoxReadName
            // 
            textBoxReadName.Location = new Point(92, 142);
            textBoxReadName.Name = "textBoxReadName";
            textBoxReadName.Size = new Size(125, 27);
            textBoxReadName.TabIndex = 16;
            textBoxReadName.Visible = false;
            // 
<<<<<<< HEAD
            // labelReadAmount
            // 
            labelReadAmount.AutoSize = true;
            labelReadAmount.Location = new Point(245, 296);
            labelReadAmount.Name = "labelReadAmount";
            labelReadAmount.Size = new Size(87, 20);
            labelReadAmount.TabIndex = 11;
            labelReadAmount.Text = "כמות במלאי";
            labelReadAmount.Visible = false;
            // 
            // labelReadPrice
            // 
            labelReadPrice.AutoSize = true;
            labelReadPrice.Location = new Point(245, 252);
            labelReadPrice.Name = "labelReadPrice";
            labelReadPrice.Size = new Size(41, 20);
            labelReadPrice.TabIndex = 11;
            labelReadPrice.Text = "מחיר";
            labelReadPrice.Visible = false;
            // 
            // labelReadCategort
            // 
            labelReadCategort.AutoSize = true;
            labelReadCategort.Location = new Point(237, 201);
            labelReadCategort.Name = "labelReadCategort";
            labelReadCategort.Size = new Size(62, 20);
            labelReadCategort.TabIndex = 12;
            labelReadCategort.Text = "קטגוריה";
            labelReadCategort.Visible = false;
=======
            // labelReadPhone
            // 
            labelReadPhone.AutoSize = true;
            labelReadPhone.Location = new Point(245, 252);
            labelReadPhone.Name = "labelReadPhone";
            labelReadPhone.Size = new Size(44, 20);
            labelReadPhone.TabIndex = 11;
            labelReadPhone.Text = "טלפון";
            labelReadPhone.Visible = false;
            // 
            // labelReadAddress
            // 
            labelReadAddress.AutoSize = true;
            labelReadAddress.Location = new Point(237, 201);
            labelReadAddress.Name = "labelReadAddress";
            labelReadAddress.Size = new Size(52, 20);
            labelReadAddress.TabIndex = 12;
            labelReadAddress.Text = "כתובת";
            labelReadAddress.Visible = false;
>>>>>>> a6286ce92929cd05286a75453dcbe4bb1f77bc25
            // 
            // labelReadName
            // 
            labelReadName.AutoSize = true;
            labelReadName.Location = new Point(249, 149);
            labelReadName.Name = "labelReadName";
            labelReadName.RightToLeft = RightToLeft.Yes;
            labelReadName.Size = new Size(31, 20);
            labelReadName.TabIndex = 13;
            labelReadName.Text = "שם";
            labelReadName.Visible = false;
            // 
            // BtnRead
            // 
            BtnRead.Location = new Point(123, 77);
            BtnRead.Name = "BtnRead";
            BtnRead.Size = new Size(94, 29);
            BtnRead.TabIndex = 10;
            BtnRead.Text = "שלח";
            BtnRead.UseVisualStyleBackColor = true;
<<<<<<< HEAD
            BtnRead.Click += BtnRead_Click;
=======
>>>>>>> a6286ce92929cd05286a75453dcbe4bb1f77bc25
            // 
            // textBoxReadId
            // 
            textBoxReadId.Location = new Point(69, 34);
            textBoxReadId.Name = "textBoxReadId";
            textBoxReadId.Size = new Size(125, 27);
            textBoxReadId.TabIndex = 9;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(200, 37);
            label6.Name = "label6";
            label6.Size = new Size(85, 20);
            label6.TabIndex = 8;
            label6.Text = "תעודת זהות";
            // 
<<<<<<< HEAD
            // listBoxProducts
            // 
            listBoxProducts.FormattingEnabled = true;
            listBoxProducts.Location = new Point(426, 33);
            listBoxProducts.Name = "listBoxProducts";
            listBoxProducts.Size = new Size(345, 384);
            listBoxProducts.TabIndex = 2;
            listBoxProducts.SelectedIndexChanged += listBoxCustomers_SelectedIndexChanged;
=======
            // listBoxCustomers
            // 
            listBoxCustomers.FormattingEnabled = true;
            listBoxCustomers.Location = new Point(426, 33);
            listBoxCustomers.Name = "listBoxCustomers";
            listBoxCustomers.Size = new Size(345, 384);
            listBoxCustomers.TabIndex = 2;
            listBoxCustomers.SelectedIndexChanged += listBoxCustomers_SelectedIndexChanged;
>>>>>>> a6286ce92929cd05286a75453dcbe4bb1f77bc25
            // 
            // ManagerProducts
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tabControlCustomers);
<<<<<<< HEAD
            Controls.Add(listBoxProducts);
            Name = "ManagerProducts";
            Text = "ManagerProducts";
            Load += ManagerProducts_Load;
=======
            Controls.Add(listBoxCustomers);
            Name = "ManagerProducts";
            Text = "ManagerProducts";
>>>>>>> a6286ce92929cd05286a75453dcbe4bb1f77bc25
            tabControlCustomers.ResumeLayout(false);
            add.ResumeLayout(false);
            add.PerformLayout();
            update.ResumeLayout(false);
            update.PerformLayout();
            delete.ResumeLayout(false);
            delete.PerformLayout();
            readById.ResumeLayout(false);
            readById.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControlCustomers;
        private TabPage add;
        private Button buttonAdd;
//<<<<<<< HEAD
//        private TextBox textBoxPrice;
//        private TextBox textBoxName;
//        private Label price;
//        private Label address;
//        private Label name;
//        private TabPage update;
//        private Button BtnUpdate;
//=======
//        private TextBox textBoxPhone;
//        private TextBox textBoxAddress;
//        private TextBox textBoxName;
//        private TextBox textBoxId;
//        private Label phone;
//        private Label address;
//        private Label name;
//        private Label ID;
//        private TabPage update;
//        private Button BtnUpdate;
//        private TextBox textBoxUpdatePhone;
//        private TextBox textBoxUpdateAddress;
//        private TextBox textBoxUpdateName;
//        private Label label2;
//        private Label label3;
//        private Label label4;
//>>>>>>> a6286ce92929cd05286a75453dcbe4bb1f77bc25
        private Button sendIdToUpdate;
        private TextBox textBoxUpdateId;
        private Label label1;
        private TabPage delete;
        private Button BtnDelete;
        private TextBox textBoxDeleteId;
        private Label label5;
        private TabPage readById;
        private TextBox textBoxReadPrice;
        private TextBox textBoxReadCategory;
        private TextBox textBoxReadName;
        private Label labelReadPrice;
        private Label labelReadCategort;

        private Label labelReadName;
        private Button BtnRead;
        private TextBox textBoxReadId;
        private Label label6;
        private ListBox listBoxProducts;
        private TextBox textBoxAmont;
        private Label amount;
        private Label label7;
        private ComboBox comboBoxCategory;
        private ComboBox comboBoxUpdateCategory;
        private TextBox textBoxUpdateAmount;
        private TextBox textBoxUpdatePrice;
        private TextBox textBoxUpdateName;
        private Label label2;
        private Label label3;
        private Label label9;
        private Label label4;
        private Label label8;
        private TextBox textBoxReadAmount;
        private Label labelReadAmount;

    }
}