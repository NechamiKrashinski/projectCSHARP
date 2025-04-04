﻿namespace UI
{
    partial class CustomerOrder
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
            listBoxCustomers = new ListBox();
            tabControlCustomers = new TabControl();
            add = new TabPage();
            label6 = new Label();
            numericUpDown1 = new NumericUpDown();
            buttonAdd = new Button();
            textBoxId = new TextBox();
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
            delete = new TabPage();
            BtnDelete = new Button();
            textBoxDeleteId = new TextBox();
            label5 = new Label();
            tabControlCustomers.SuspendLayout();
            add.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            update.SuspendLayout();
            delete.SuspendLayout();
            SuspendLayout();
            // 
            // listBoxCustomers
            // 
            listBoxCustomers.FormattingEnabled = true;
            listBoxCustomers.Location = new Point(430, 33);
            listBoxCustomers.Name = "listBoxCustomers";
            listBoxCustomers.Size = new Size(345, 384);
            listBoxCustomers.TabIndex = 10;
            // 
            // tabControlCustomers
            // 
            tabControlCustomers.Controls.Add(add);
            tabControlCustomers.Controls.Add(update);
            tabControlCustomers.Controls.Add(delete);
            tabControlCustomers.Location = new Point(25, 33);
            tabControlCustomers.Name = "tabControlCustomers";
            tabControlCustomers.RightToLeft = RightToLeft.Yes;
            tabControlCustomers.RightToLeftLayout = true;
            tabControlCustomers.SelectedIndex = 0;
            tabControlCustomers.Size = new Size(357, 384);
            tabControlCustomers.TabIndex = 9;
            // 
            // add
            // 
            add.Controls.Add(label6);
            add.Controls.Add(numericUpDown1);
            add.Controls.Add(buttonAdd);
            add.Controls.Add(textBoxId);
            add.Controls.Add(ID);
            add.Location = new Point(4, 29);
            add.Name = "add";
            add.Padding = new Padding(3);
            add.Size = new Size(349, 351);
            add.TabIndex = 0;
            add.Text = "הוסף מוצר להזמנה";
            add.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(240, 136);
            label6.Name = "label6";
            label6.Size = new Size(42, 20);
            label6.TabIndex = 4;
            label6.Text = "כמות";
            // 
            // numericUpDown1
            // 
            numericUpDown1.Location = new Point(93, 131);
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(125, 27);
            numericUpDown1.TabIndex = 3;
            numericUpDown1.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // buttonAdd
            // 
            buttonAdd.Location = new Point(143, 199);
            buttonAdd.Name = "buttonAdd";
            buttonAdd.Size = new Size(94, 29);
            buttonAdd.TabIndex = 2;
            buttonAdd.Text = "הוסף להזמנה";
            buttonAdd.UseVisualStyleBackColor = true;
            // 
            // textBoxId
            // 
            textBoxId.Location = new Point(93, 76);
            textBoxId.Name = "textBoxId";
            textBoxId.Size = new Size(125, 27);
            textBoxId.TabIndex = 1;
            // 
            // ID
            // 
            ID.AutoSize = true;
            ID.Location = new Point(230, 82);
            ID.Name = "ID";
            ID.Size = new Size(65, 20);
            ID.TabIndex = 0;
            ID.Text = "קוד מוצר";
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
            update.Location = new Point(4, 29);
            update.Name = "update";
            update.Padding = new Padding(3);
            update.Size = new Size(349, 351);
            update.TabIndex = 1;
            update.Text = "עדכן מוצר בהזמנה";
            update.UseVisualStyleBackColor = true;
            // 
            // BtnUpdate
            // 
            BtnUpdate.Location = new Point(44, 300);
            BtnUpdate.Name = "BtnUpdate";
            BtnUpdate.Size = new Size(94, 29);
            BtnUpdate.TabIndex = 11;
            BtnUpdate.Text = "עדכן";
            BtnUpdate.UseVisualStyleBackColor = true;
            BtnUpdate.Visible = false;
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
            label2.Location = new Point(253, 246);
            label2.Name = "label2";
            label2.Size = new Size(42, 20);
            label2.TabIndex = 5;
            label2.Text = "כמות";
            label2.Visible = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(231, 195);
            label3.Name = "label3";
            label3.Size = new Size(112, 20);
            label3.TabIndex = 6;
            label3.Text = "מחיר לפני הנחה";
            label3.Visible = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(264, 143);
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
            sendIdToUpdate.Name = "sendIdToUpdate";
            sendIdToUpdate.Size = new Size(94, 29);
            sendIdToUpdate.TabIndex = 4;
            sendIdToUpdate.Text = "שלח";
            sendIdToUpdate.UseVisualStyleBackColor = true;
            // 
            // textBoxUpdateId
            // 
            textBoxUpdateId.Location = new Point(88, 43);
            textBoxUpdateId.Name = "textBoxUpdateId";
            textBoxUpdateId.Size = new Size(125, 27);
            textBoxUpdateId.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(231, 58);
            label1.Name = "label1";
            label1.Size = new Size(65, 20);
            label1.TabIndex = 2;
            label1.Text = "קוד מוצר";
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
            delete.Text = "מחק מוצר מהזמנה";
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
            label5.Size = new Size(85, 20);
            label5.TabIndex = 5;
            label5.Text = "תעודת זהות";
            // 
            // CustomerOrder
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(listBoxCustomers);
            Controls.Add(tabControlCustomers);
            Name = "CustomerOrder";
            Text = "CustomerOrder";
            Load += CustomerOrder_Load;
            tabControlCustomers.ResumeLayout(false);
            add.ResumeLayout(false);
            add.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            update.ResumeLayout(false);
            update.PerformLayout();
            delete.ResumeLayout(false);
            delete.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private ListBox listBoxCustomers;
        private TabControl tabControlCustomers;
        private TabPage add;
        private Label label6;
        private NumericUpDown numericUpDown1;
        private Button buttonAdd;
        private TextBox textBoxId;
        private Label ID;
        private TabPage update;
        private Button BtnUpdate;
        private TextBox textBoxUpdatePhone;
        private TextBox textBoxUpdateAddress;
        private TextBox textBoxUpdateName;
        private Label label2;
        private Label label3;
        private Label label4;
        private Button sendIdToUpdate;
        private TextBox textBoxUpdateId;
        private Label label1;
        private TabPage delete;
        private Button BtnDelete;
        private TextBox textBoxDeleteId;
        private Label label5;
    }
}