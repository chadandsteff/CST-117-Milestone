namespace CST_117_Milestone
{
    public partial class inventoryForm
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
            this.inventoryListBox = new System.Windows.Forms.ListBox();
            this.removeButton = new System.Windows.Forms.Button();
            this.createButton = new System.Windows.Forms.Button();
            this.itemNameLabel = new System.Windows.Forms.Label();
            this.itemNameTextBox = new System.Windows.Forms.TextBox();
            this.itemBrandTextBox = new System.Windows.Forms.TextBox();
            this.itemPriceTextBox = new System.Windows.Forms.TextBox();
            this.itemCostTextBox = new System.Windows.Forms.TextBox();
            this.itemQuantityTextBox = new System.Windows.Forms.TextBox();
            this.brandLabel = new System.Windows.Forms.Label();
            this.itemPriceLabel = new System.Windows.Forms.Label();
            this.itemCostLabel = new System.Windows.Forms.Label();
            this.quantityLabel = new System.Windows.Forms.Label();
            this.saveButton = new System.Windows.Forms.Button();
            this.driverButton = new System.Windows.Forms.Button();
            this.inventoryManagerButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // inventoryListBox
            // 
            this.inventoryListBox.FormattingEnabled = true;
            this.inventoryListBox.Location = new System.Drawing.Point(12, 40);
            this.inventoryListBox.Name = "inventoryListBox";
            this.inventoryListBox.Size = new System.Drawing.Size(396, 394);
            this.inventoryListBox.TabIndex = 0;
            this.inventoryListBox.SelectedIndexChanged += new System.EventHandler(this.inventoryListBox_SelectedIndexChanged);
            // 
            // removeButton
            // 
            this.removeButton.Location = new System.Drawing.Point(93, 11);
            this.removeButton.Name = "removeButton";
            this.removeButton.Size = new System.Drawing.Size(75, 23);
            this.removeButton.TabIndex = 2;
            this.removeButton.Text = "Remove";
            this.removeButton.UseVisualStyleBackColor = true;
            this.removeButton.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // createButton
            // 
            this.createButton.Location = new System.Drawing.Point(12, 11);
            this.createButton.Name = "createButton";
            this.createButton.Size = new System.Drawing.Size(75, 23);
            this.createButton.TabIndex = 3;
            this.createButton.Text = "Create";
            this.createButton.UseVisualStyleBackColor = true;
            this.createButton.Click += new System.EventHandler(this.button1_Click_2);
            // 
            // itemNameLabel
            // 
            this.itemNameLabel.AutoSize = true;
            this.itemNameLabel.Location = new System.Drawing.Point(34, 443);
            this.itemNameLabel.Name = "itemNameLabel";
            this.itemNameLabel.Size = new System.Drawing.Size(67, 13);
            this.itemNameLabel.TabIndex = 5;
            this.itemNameLabel.Text = "Item Name : ";
            // 
            // itemNameTextBox
            // 
            this.itemNameTextBox.AcceptsTab = true;
            this.itemNameTextBox.Location = new System.Drawing.Point(107, 440);
            this.itemNameTextBox.Name = "itemNameTextBox";
            this.itemNameTextBox.Size = new System.Drawing.Size(262, 20);
            this.itemNameTextBox.TabIndex = 6;
            // 
            // itemBrandTextBox
            // 
            this.itemBrandTextBox.Location = new System.Drawing.Point(107, 467);
            this.itemBrandTextBox.Name = "itemBrandTextBox";
            this.itemBrandTextBox.Size = new System.Drawing.Size(262, 20);
            this.itemBrandTextBox.TabIndex = 7;
            // 
            // itemPriceTextBox
            // 
            this.itemPriceTextBox.Location = new System.Drawing.Point(107, 494);
            this.itemPriceTextBox.Name = "itemPriceTextBox";
            this.itemPriceTextBox.Size = new System.Drawing.Size(262, 20);
            this.itemPriceTextBox.TabIndex = 8;
            // 
            // itemCostTextBox
            // 
            this.itemCostTextBox.Location = new System.Drawing.Point(107, 521);
            this.itemCostTextBox.Name = "itemCostTextBox";
            this.itemCostTextBox.Size = new System.Drawing.Size(262, 20);
            this.itemCostTextBox.TabIndex = 9;
            // 
            // itemQuantityTextBox
            // 
            this.itemQuantityTextBox.Location = new System.Drawing.Point(107, 548);
            this.itemQuantityTextBox.Name = "itemQuantityTextBox";
            this.itemQuantityTextBox.Size = new System.Drawing.Size(262, 20);
            this.itemQuantityTextBox.TabIndex = 10;
            this.itemQuantityTextBox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // brandLabel
            // 
            this.brandLabel.AutoSize = true;
            this.brandLabel.Location = new System.Drawing.Point(37, 473);
            this.brandLabel.Name = "brandLabel";
            this.brandLabel.Size = new System.Drawing.Size(67, 13);
            this.brandLabel.TabIndex = 11;
            this.brandLabel.Text = "Item Brand : ";
            // 
            // itemPriceLabel
            // 
            this.itemPriceLabel.AutoSize = true;
            this.itemPriceLabel.Location = new System.Drawing.Point(37, 500);
            this.itemPriceLabel.Name = "itemPriceLabel";
            this.itemPriceLabel.Size = new System.Drawing.Size(46, 13);
            this.itemPriceLabel.TabIndex = 12;
            this.itemPriceLabel.Text = "Price : $";
            // 
            // itemCostLabel
            // 
            this.itemCostLabel.AutoSize = true;
            this.itemCostLabel.Location = new System.Drawing.Point(40, 527);
            this.itemCostLabel.Name = "itemCostLabel";
            this.itemCostLabel.Size = new System.Drawing.Size(43, 13);
            this.itemCostLabel.TabIndex = 13;
            this.itemCostLabel.Text = "Cost : $";
            // 
            // quantityLabel
            // 
            this.quantityLabel.AutoSize = true;
            this.quantityLabel.Location = new System.Drawing.Point(40, 554);
            this.quantityLabel.Name = "quantityLabel";
            this.quantityLabel.Size = new System.Drawing.Size(55, 13);
            this.quantityLabel.TabIndex = 14;
            this.quantityLabel.Text = "Quantity : ";
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(252, 11);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(75, 23);
            this.saveButton.TabIndex = 17;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // driverButton
            // 
            this.driverButton.Location = new System.Drawing.Point(174, 11);
            this.driverButton.Name = "driverButton";
            this.driverButton.Size = new System.Drawing.Size(75, 23);
            this.driverButton.TabIndex = 18;
            this.driverButton.Text = "Driver";
            this.driverButton.UseVisualStyleBackColor = true;
            this.driverButton.Click += new System.EventHandler(this.driverButton_Click);
            // 
            // inventoryManagerButton
            // 
            this.inventoryManagerButton.Location = new System.Drawing.Point(333, 11);
            this.inventoryManagerButton.Name = "inventoryManagerButton";
            this.inventoryManagerButton.Size = new System.Drawing.Size(75, 23);
            this.inventoryManagerButton.TabIndex = 19;
            this.inventoryManagerButton.Text = "Manage";
            this.inventoryManagerButton.UseVisualStyleBackColor = true;
            this.inventoryManagerButton.Click += new System.EventHandler(this.button1_Click_4);
            // 
            // inventoryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(420, 578);
            this.Controls.Add(this.inventoryManagerButton);
            this.Controls.Add(this.driverButton);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.quantityLabel);
            this.Controls.Add(this.itemCostLabel);
            this.Controls.Add(this.itemPriceLabel);
            this.Controls.Add(this.brandLabel);
            this.Controls.Add(this.itemQuantityTextBox);
            this.Controls.Add(this.itemCostTextBox);
            this.Controls.Add(this.itemPriceTextBox);
            this.Controls.Add(this.itemBrandTextBox);
            this.Controls.Add(this.itemNameTextBox);
            this.Controls.Add(this.itemNameLabel);
            this.Controls.Add(this.createButton);
            this.Controls.Add(this.removeButton);
            this.Controls.Add(this.inventoryListBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "inventoryForm";
            this.Text = "Inventory Control";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.ListBox inventoryListBox;
        private System.Windows.Forms.Button removeButton;
        private System.Windows.Forms.Button createButton;
        private System.Windows.Forms.Label itemNameLabel;
        private System.Windows.Forms.TextBox itemNameTextBox;
        private System.Windows.Forms.TextBox itemBrandTextBox;
        private System.Windows.Forms.TextBox itemPriceTextBox;
        private System.Windows.Forms.TextBox itemCostTextBox;
        private System.Windows.Forms.TextBox itemQuantityTextBox;
        private System.Windows.Forms.Label brandLabel;
        private System.Windows.Forms.Label itemPriceLabel;
        private System.Windows.Forms.Label itemCostLabel;
        private System.Windows.Forms.Label quantityLabel;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Button driverButton;
        private System.Windows.Forms.Button inventoryManagerButton;
    }
}

