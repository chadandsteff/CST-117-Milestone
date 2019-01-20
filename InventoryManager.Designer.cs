namespace CST_117_Milestone
{
    partial class InventoryManager
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
            this.exitButton = new System.Windows.Forms.Button();
            this.restockButton = new System.Windows.Forms.Button();
            this.searchTermTextBox = new System.Windows.Forms.TextBox();
            this.searchLabel = new System.Windows.Forms.Label();
            this.restockingLabel = new System.Windows.Forms.Label();
            this.controlButton = new System.Windows.Forms.Button();
            this.inventoryDataView = new System.Windows.Forms.DataGridView();
            this.itemName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.itemBrand = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.itemPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.itemCost = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.itemQuantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.saveButton = new System.Windows.Forms.Button();
            this.loadButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.inventoryDataView)).BeginInit();
            this.SuspendLayout();
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(529, 425);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(75, 23);
            this.exitButton.TabIndex = 1;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // restockButton
            // 
            this.restockButton.Location = new System.Drawing.Point(13, 425);
            this.restockButton.Name = "restockButton";
            this.restockButton.Size = new System.Drawing.Size(75, 23);
            this.restockButton.TabIndex = 2;
            this.restockButton.Text = "Restock";
            this.restockButton.UseVisualStyleBackColor = true;
            this.restockButton.Click += new System.EventHandler(this.restockButton_Click);
            // 
            // searchTermTextBox
            // 
            this.searchTermTextBox.Location = new System.Drawing.Point(180, 5);
            this.searchTermTextBox.Name = "searchTermTextBox";
            this.searchTermTextBox.Size = new System.Drawing.Size(424, 20);
            this.searchTermTextBox.TabIndex = 3;
            this.searchTermTextBox.TextChanged += new System.EventHandler(this.searchTermTextBox_TextChanged);
            // 
            // searchLabel
            // 
            this.searchLabel.AutoSize = true;
            this.searchLabel.Location = new System.Drawing.Point(12, 9);
            this.searchLabel.Name = "searchLabel";
            this.searchLabel.Size = new System.Drawing.Size(162, 13);
            this.searchLabel.TabIndex = 4;
            this.searchLabel.Text = "Search (Name, Quantity, Price) : ";
            this.searchLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // restockingLabel
            // 
            this.restockingLabel.AutoSize = true;
            this.restockingLabel.Location = new System.Drawing.Point(95, 430);
            this.restockingLabel.Name = "restockingLabel";
            this.restockingLabel.Size = new System.Drawing.Size(163, 13);
            this.restockingLabel.TabIndex = 6;
            this.restockingLabel.Text = "* Restocking sets quantity to 100";
            this.restockingLabel.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // controlButton
            // 
            this.controlButton.Location = new System.Drawing.Point(448, 425);
            this.controlButton.Name = "controlButton";
            this.controlButton.Size = new System.Drawing.Size(75, 23);
            this.controlButton.TabIndex = 7;
            this.controlButton.Text = "Control";
            this.controlButton.UseVisualStyleBackColor = true;
            this.controlButton.Click += new System.EventHandler(this.controlButton_Click);
            // 
            // inventoryDataView
            // 
            this.inventoryDataView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.inventoryDataView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.itemName,
            this.itemBrand,
            this.itemPrice,
            this.itemCost,
            this.itemQuantity});
            this.inventoryDataView.Location = new System.Drawing.Point(12, 31);
            this.inventoryDataView.MultiSelect = false;
            this.inventoryDataView.Name = "inventoryDataView";
            this.inventoryDataView.Size = new System.Drawing.Size(592, 384);
            this.inventoryDataView.TabIndex = 0;
            this.inventoryDataView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // itemName
            // 
            this.itemName.DataPropertyName = "Name";
            this.itemName.HeaderText = "Item Name";
            this.itemName.Name = "itemName";
            this.itemName.Width = 175;
            // 
            // itemBrand
            // 
            this.itemBrand.DataPropertyName = "Brand";
            this.itemBrand.HeaderText = "Brand";
            this.itemBrand.Name = "itemBrand";
            this.itemBrand.Width = 150;
            // 
            // itemPrice
            // 
            this.itemPrice.DataPropertyName = "Price";
            this.itemPrice.HeaderText = "Price";
            this.itemPrice.Name = "itemPrice";
            this.itemPrice.Width = 75;
            // 
            // itemCost
            // 
            this.itemCost.DataPropertyName = "Cost";
            this.itemCost.HeaderText = "Cost";
            this.itemCost.Name = "itemCost";
            this.itemCost.Width = 75;
            // 
            // itemQuantity
            // 
            this.itemQuantity.DataPropertyName = "Quantity";
            this.itemQuantity.HeaderText = "Quantity";
            this.itemQuantity.Name = "itemQuantity";
            this.itemQuantity.Width = 75;
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(367, 425);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(75, 23);
            this.saveButton.TabIndex = 8;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // loadButton
            // 
            this.loadButton.Location = new System.Drawing.Point(286, 425);
            this.loadButton.Name = "loadButton";
            this.loadButton.Size = new System.Drawing.Size(75, 23);
            this.loadButton.TabIndex = 9;
            this.loadButton.Text = "Load";
            this.loadButton.UseVisualStyleBackColor = true;
            this.loadButton.Click += new System.EventHandler(this.loadButton_Click);
            // 
            // InventoryManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(616, 452);
            this.Controls.Add(this.loadButton);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.controlButton);
            this.Controls.Add(this.restockingLabel);
            this.Controls.Add(this.searchLabel);
            this.Controls.Add(this.searchTermTextBox);
            this.Controls.Add(this.restockButton);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.inventoryDataView);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "InventoryManager";
            this.Text = "Inventory Manager";
            this.Load += new System.EventHandler(this.InventoryManager_Load);
            ((System.ComponentModel.ISupportInitialize)(this.inventoryDataView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Button restockButton;
        private System.Windows.Forms.TextBox searchTermTextBox;
        private System.Windows.Forms.Label searchLabel;
        private System.Windows.Forms.Label restockingLabel;
        private System.Windows.Forms.Button controlButton;
        private System.Windows.Forms.DataGridView inventoryDataView;
        private System.Windows.Forms.DataGridViewTextBoxColumn itemName;
        private System.Windows.Forms.DataGridViewTextBoxColumn itemBrand;
        private System.Windows.Forms.DataGridViewTextBoxColumn itemPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn itemCost;
        private System.Windows.Forms.DataGridViewTextBoxColumn itemQuantity;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Button loadButton;
    }
}