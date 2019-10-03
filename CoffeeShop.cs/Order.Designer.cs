namespace CoffeeShop.cs
{
    partial class Order
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
            this.components = new System.ComponentModel.Container();
            this.showdataGridView = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.quantityTextBox = new System.Windows.Forms.TextBox();
            this.addButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.searchButton = new System.Windows.Forms.Button();
            this.updateButton = new System.Windows.Forms.Button();
            this.showButton = new System.Windows.Forms.Button();
            this.deleteButton = new System.Windows.Forms.Button();
            this.idTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.customernamecomboBox = new System.Windows.Forms.ComboBox();
            this.orderModelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.itemnamecomboBox = new System.Windows.Forms.ComboBox();
            this.orderModelBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.showdataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderModelBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderModelBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // showdataGridView
            // 
            this.showdataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.showdataGridView.Location = new System.Drawing.Point(12, 212);
            this.showdataGridView.Name = "showdataGridView";
            this.showdataGridView.Size = new System.Drawing.Size(849, 150);
            this.showdataGridView.TabIndex = 0;
            this.showdataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.showdataGridView_CellClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 160);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Quantity";
            // 
            // quantityTextBox
            // 
            this.quantityTextBox.Location = new System.Drawing.Point(147, 153);
            this.quantityTextBox.Name = "quantityTextBox";
            this.quantityTextBox.Size = new System.Drawing.Size(192, 20);
            this.quantityTextBox.TabIndex = 2;
            this.quantityTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.quantityTextBox_KeyPress);
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(680, 34);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(75, 23);
            this.addButton.TabIndex = 3;
            this.addButton.Text = "Add";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(34, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Customer Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(34, 114);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Item Name";
            // 
            // searchButton
            // 
            this.searchButton.Location = new System.Drawing.Point(680, 183);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(75, 23);
            this.searchButton.TabIndex = 8;
            this.searchButton.Text = "search";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // updateButton
            // 
            this.updateButton.Location = new System.Drawing.Point(680, 74);
            this.updateButton.Name = "updateButton";
            this.updateButton.Size = new System.Drawing.Size(75, 23);
            this.updateButton.TabIndex = 9;
            this.updateButton.Text = "update";
            this.updateButton.UseVisualStyleBackColor = true;
            this.updateButton.Click += new System.EventHandler(this.updateButton_Click);
            // 
            // showButton
            // 
            this.showButton.Location = new System.Drawing.Point(680, 150);
            this.showButton.Name = "showButton";
            this.showButton.Size = new System.Drawing.Size(75, 23);
            this.showButton.TabIndex = 10;
            this.showButton.Text = "show";
            this.showButton.UseVisualStyleBackColor = true;
            this.showButton.Click += new System.EventHandler(this.showButton_Click);
            // 
            // deleteButton
            // 
            this.deleteButton.Location = new System.Drawing.Point(680, 114);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(75, 23);
            this.deleteButton.TabIndex = 11;
            this.deleteButton.Text = "delete";
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // idTextBox
            // 
            this.idTextBox.Location = new System.Drawing.Point(147, 36);
            this.idTextBox.Name = "idTextBox";
            this.idTextBox.Size = new System.Drawing.Size(192, 20);
            this.idTextBox.TabIndex = 12;
            this.idTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.idTextBox_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(34, 36);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(18, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "ID";
            // 
            // customernamecomboBox
            // 
            this.customernamecomboBox.DataSource = this.orderModelBindingSource;
            this.customernamecomboBox.DisplayMember = "Name";
            this.customernamecomboBox.FormattingEnabled = true;
            this.customernamecomboBox.Location = new System.Drawing.Point(147, 76);
            this.customernamecomboBox.Name = "customernamecomboBox";
            this.customernamecomboBox.Size = new System.Drawing.Size(192, 21);
            this.customernamecomboBox.TabIndex = 14;
            this.customernamecomboBox.ValueMember = "ID";
            this.customernamecomboBox.SelectedIndexChanged += new System.EventHandler(this.customernamecomboBox_SelectedIndexChanged);
            // 
            // orderModelBindingSource
            // 
            this.orderModelBindingSource.DataSource = typeof(CoffeeShop.cs.Model.OrderModel);
            // 
            // itemnamecomboBox
            // 
            this.itemnamecomboBox.DataSource = this.orderModelBindingSource1;
            this.itemnamecomboBox.DisplayMember = "ItemName";
            this.itemnamecomboBox.FormattingEnabled = true;
            this.itemnamecomboBox.Location = new System.Drawing.Point(147, 114);
            this.itemnamecomboBox.Name = "itemnamecomboBox";
            this.itemnamecomboBox.Size = new System.Drawing.Size(192, 21);
            this.itemnamecomboBox.TabIndex = 15;
            this.itemnamecomboBox.ValueMember = "ID";
            // 
            // orderModelBindingSource1
            // 
            this.orderModelBindingSource1.DataSource = typeof(CoffeeShop.cs.Model.OrderModel);
            // 
            // Order
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(873, 450);
            this.Controls.Add(this.itemnamecomboBox);
            this.Controls.Add(this.customernamecomboBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.idTextBox);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.showButton);
            this.Controls.Add(this.updateButton);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.quantityTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.showdataGridView);
            this.Name = "Order";
            this.Text = "Order";
            this.Load += new System.EventHandler(this.Order_Load);
            ((System.ComponentModel.ISupportInitialize)(this.showdataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderModelBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderModelBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView showdataGridView;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox quantityTextBox;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.Button updateButton;
        private System.Windows.Forms.Button showButton;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.TextBox idTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox customernamecomboBox;
        private System.Windows.Forms.ComboBox itemnamecomboBox;
        private System.Windows.Forms.BindingSource orderModelBindingSource;
        private System.Windows.Forms.BindingSource orderModelBindingSource1;
    }
}