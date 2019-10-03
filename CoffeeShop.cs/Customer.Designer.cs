namespace CoffeeShop.cs
{
    partial class Customer
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
            this.AddButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.AddresstextBox = new System.Windows.Forms.TextBox();
            this.contactTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.showdataGridView = new System.Windows.Forms.DataGridView();
            this.UpdateButton = new System.Windows.Forms.Button();
            this.SearchButton = new System.Windows.Forms.Button();
            this.DeleteButton = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.showButton = new System.Windows.Forms.Button();
            this.idTextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.namecomboBox = new System.Windows.Forms.ComboBox();
            this.customerModelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.NametextBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.showdataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerModelBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // AddButton
            // 
            this.AddButton.Location = new System.Drawing.Point(421, 217);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(75, 23);
            this.AddButton.TabIndex = 0;
            this.AddButton.Text = "Add";
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(42, 87);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Customer Name";
            // 
            // AddresstextBox
            // 
            this.AddresstextBox.Location = new System.Drawing.Point(153, 124);
            this.AddresstextBox.Name = "AddresstextBox";
            this.AddresstextBox.Size = new System.Drawing.Size(148, 20);
            this.AddresstextBox.TabIndex = 3;
            // 
            // contactTextBox
            // 
            this.contactTextBox.Location = new System.Drawing.Point(153, 173);
            this.contactTextBox.MaxLength = 11;
            this.contactTextBox.Name = "contactTextBox";
            this.contactTextBox.Size = new System.Drawing.Size(148, 20);
            this.contactTextBox.TabIndex = 4;
            this.contactTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.contactTextBox_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(38, 131);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Customer Address";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(38, 176);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Customer Contact";
            // 
            // showdataGridView
            // 
            this.showdataGridView.AllowUserToAddRows = false;
            this.showdataGridView.AllowUserToDeleteRows = false;
            this.showdataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.showdataGridView.Location = new System.Drawing.Point(327, 38);
            this.showdataGridView.Name = "showdataGridView";
            this.showdataGridView.ReadOnly = true;
            this.showdataGridView.Size = new System.Drawing.Size(443, 159);
            this.showdataGridView.TabIndex = 7;
            this.showdataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.showdataGridView_CellClick_1);
            // 
            // UpdateButton
            // 
            this.UpdateButton.Location = new System.Drawing.Point(614, 217);
            this.UpdateButton.Name = "UpdateButton";
            this.UpdateButton.Size = new System.Drawing.Size(75, 23);
            this.UpdateButton.TabIndex = 8;
            this.UpdateButton.Text = "Update";
            this.UpdateButton.UseVisualStyleBackColor = true;
            this.UpdateButton.Click += new System.EventHandler(this.UpdateButton_Click);
            // 
            // SearchButton
            // 
            this.SearchButton.Location = new System.Drawing.Point(327, 217);
            this.SearchButton.Name = "SearchButton";
            this.SearchButton.Size = new System.Drawing.Size(75, 23);
            this.SearchButton.TabIndex = 9;
            this.SearchButton.Text = "Search";
            this.SearchButton.UseVisualStyleBackColor = true;
            this.SearchButton.Click += new System.EventHandler(this.SearchButton_Click);
            // 
            // DeleteButton
            // 
            this.DeleteButton.Location = new System.Drawing.Point(695, 217);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(75, 23);
            this.DeleteButton.TabIndex = 10;
            this.DeleteButton.Text = "Delete";
            this.DeleteButton.UseVisualStyleBackColor = true;
            this.DeleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(42, 53);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 13);
            this.label4.TabIndex = 12;
            // 
            // showButton
            // 
            this.showButton.Location = new System.Drawing.Point(517, 217);
            this.showButton.Name = "showButton";
            this.showButton.Size = new System.Drawing.Size(75, 23);
            this.showButton.TabIndex = 13;
            this.showButton.Text = "show";
            this.showButton.UseVisualStyleBackColor = true;
            this.showButton.Click += new System.EventHandler(this.showButton_Click);
            // 
            // idTextBox
            // 
            this.idTextBox.Location = new System.Drawing.Point(153, 38);
            this.idTextBox.Name = "idTextBox";
            this.idTextBox.Size = new System.Drawing.Size(148, 20);
            this.idTextBox.TabIndex = 14;
            this.idTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.idTextBox_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(42, 45);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 13);
            this.label5.TabIndex = 15;
            this.label5.Text = "Customer Id";
            // 
            // namecomboBox
            // 
            this.namecomboBox.DataSource = this.customerModelBindingSource;
            this.namecomboBox.DisplayMember = "Name";
            this.namecomboBox.FormattingEnabled = true;
            this.namecomboBox.Location = new System.Drawing.Point(152, 217);
            this.namecomboBox.Name = "namecomboBox";
            this.namecomboBox.Size = new System.Drawing.Size(148, 21);
            this.namecomboBox.TabIndex = 16;
            this.namecomboBox.ValueMember = "ID";
            //this.namecomboBox.SelectedIndexChanged += new System.EventHandler(this.namecomboBox_SelectedIndexChanged);
            // 
            // customerModelBindingSource
            // 
            this.customerModelBindingSource.DataSource = typeof(CoffeeShop.cs.Model.CustomerModel);
            // 
            // NametextBox
            // 
            this.NametextBox.Location = new System.Drawing.Point(152, 87);
            this.NametextBox.Name = "NametextBox";
            this.NametextBox.Size = new System.Drawing.Size(148, 20);
            this.NametextBox.TabIndex = 17;
            // 
            // Customer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(817, 450);
            this.Controls.Add(this.NametextBox);
            this.Controls.Add(this.namecomboBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.idTextBox);
            this.Controls.Add(this.showButton);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.DeleteButton);
            this.Controls.Add(this.SearchButton);
            this.Controls.Add(this.UpdateButton);
            this.Controls.Add(this.showdataGridView);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.contactTextBox);
            this.Controls.Add(this.AddresstextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.AddButton);
            this.Name = "Customer";
            this.Text = "Customer";
            this.Load += new System.EventHandler(this.Customer_Load);
            ((System.ComponentModel.ISupportInitialize)(this.showdataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerModelBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox AddresstextBox;
        private System.Windows.Forms.TextBox contactTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView showdataGridView;
        private System.Windows.Forms.Button UpdateButton;
        private System.Windows.Forms.Button SearchButton;
        private System.Windows.Forms.Button DeleteButton;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button showButton;
        private System.Windows.Forms.TextBox idTextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox namecomboBox;
        private System.Windows.Forms.BindingSource customerModelBindingSource;
        private System.Windows.Forms.TextBox NametextBox;
    }
}

