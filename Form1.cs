// Chad Weirick
// Grand Canyon Univeristy
// CST-117
// Dr. J!
//
// Milestone project for CST-117
// goal: inventory management system.
// Update for 12/16
// I have included a driver button with code to add a few items.
// these items can be manipulated, saved, removed, and there are some guard rails in place to prevent crashes.
//
// Milestone 3 - note the driver is in the Form1 - it is retained from previous tasks (I think I was ahead of schedule on this.)

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CST_117_Milestone
{
    public partial class inventoryForm : Form
    {
        int totalItems = 0;
        int currentItem = 0;
        
        // for handling the switching of windows
        public static List<InventoryItem> itemList { get; set; } = new List<InventoryItem>();       
        public static inventoryForm myMainWindow;

        public inventoryForm()
        {
            InitializeComponent();
            myMainWindow = this;
            saveButton.Enabled = false;
            removeButton.Enabled = false;         
        }

        public void refillList()
        {
            inventoryListBox.Items.Clear();
            for (int i = 0; i < itemList.Count; i++)
            {
                inventoryListBox.Items.Add(itemList[i]);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }



        private void button1_Click_1(object sender, EventArgs e)
        {
            // remove it from the list
            itemList.RemoveAt(inventoryListBox.SelectedIndex);
            // remove from the list
            inventoryListBox.Items.Remove(inventoryListBox.SelectedItem);
            totalItems--;
            // ensure UI elements are properly disabled when there should be no selectable items.
            if (totalItems <= 0)
            {
                saveButton.Enabled = false;
                removeButton.Enabled = false;
                totalItems = 0;
            }
        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            // add basic controls to prevent abuse of entering doubles and the int.
            string givenItemName = itemNameTextBox.Text;
            string givenItemBrand = itemBrandTextBox.Text;
            double givenItemPrice = checkDouble.parseDouble(itemPriceTextBox.Text);
            double givenItemCost = checkDouble.parseDouble(itemCostTextBox.Text);
            int givenItemQuantity = checkInt.parseInt(itemQuantityTextBox.Text);

            // add the item to the object list itemList and then add the top itemList item to the inventoryListBox 
            itemList.Add(new InventoryItem() { itemName = givenItemName, itemBrand = givenItemBrand, itemPrice = givenItemPrice, itemCost = givenItemCost, itemQuantity = givenItemQuantity });
            inventoryListBox.Items.Add(itemList[totalItems]);
            totalItems++;

            // reset UI fields
            itemNameTextBox.Text = "";
            itemBrandTextBox.Text = "";
            itemPriceTextBox.Text = "";
            itemCostTextBox.Text = "";
            itemQuantityTextBox.Text = "";
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click_3(object sender, EventArgs e)
        {

        }

        private void inventoryListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                string currentItem = inventoryListBox.SelectedItem.ToString();
                int indexLocation = inventoryListBox.FindString(currentItem);
                if (indexLocation != -1)
                {
                    // show the selected item in the fields
                    itemNameTextBox.Text = itemList[inventoryListBox.SelectedIndex].itemName;
                    itemBrandTextBox.Text = itemList[inventoryListBox.SelectedIndex].itemBrand;
                    itemPriceTextBox.Text = itemList[inventoryListBox.SelectedIndex].itemPrice.ToString("f2");
                    itemCostTextBox.Text = itemList[inventoryListBox.SelectedIndex].itemCost.ToString("f2");
                    itemQuantityTextBox.Text = itemList[inventoryListBox.SelectedIndex].itemQuantity.ToString();
                    // itemList.RemoveAt(inventoryListBox.SelectedIndex);

                    // set UI elements

                    saveButton.Enabled = true;
                    removeButton.Enabled = true;

                }
            }
            catch (NullReferenceException ex)
            {

            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void driverButton_Click(object sender, EventArgs e)
        {
            itemList.Add(new InventoryItem() { itemName = "Snacky cakes", itemBrand = "Snacky", itemPrice = 5.00, itemCost = 2.00, itemQuantity = 20 });
            inventoryListBox.Items.Add(itemList[totalItems]);
            totalItems++;
            itemList.Add(new InventoryItem() { itemName = "Snacky cakes Gonzo", itemBrand = "Snacky", itemPrice = 6.00, itemCost = 2.25, itemQuantity = 50 });
            inventoryListBox.Items.Add(itemList[totalItems]);
            totalItems++;
            itemList.Add(new InventoryItem() { itemName = "Snacky cakes Bonkers", itemBrand = "Snacky", itemPrice = 10.00, itemCost = 2.75, itemQuantity = 10 });
            inventoryListBox.Items.Add(itemList[totalItems]);
            totalItems++;
            itemList.Add(new InventoryItem() { itemName = "Snacky cakes Lite", itemBrand = "Snacky", itemPrice = 1.50, itemCost = 0.25, itemQuantity = 5 });
            inventoryListBox.Items.Add(itemList[totalItems]);
            totalItems++;
        }

        //private void adjustButton_Click(object sender, EventArgs e)
        //{

        //}

        private void saveButton_Click(object sender, EventArgs e)
        {
            // add basic controls to prevent abuse of entering doubles and the int.
            string givenItemName = itemNameTextBox.Text;
            string givenItemBrand = itemBrandTextBox.Text;
            double givenItemPrice = checkDouble.parseDouble(itemPriceTextBox.Text);
            double givenItemCost = checkDouble.parseDouble(itemCostTextBox.Text);
            int givenItemQuantity = checkInt.parseInt(itemQuantityTextBox.Text);

            // adjust current item
            string currentItem = inventoryListBox.SelectedItem.ToString();
            int indexLocation = inventoryListBox.FindString(currentItem);
            if (indexLocation != -1)
            {
                // show the selected item in the fields
                itemList[inventoryListBox.SelectedIndex].itemName = givenItemName;
                itemList[inventoryListBox.SelectedIndex].itemBrand = givenItemBrand;
                itemList[inventoryListBox.SelectedIndex].itemPrice = givenItemPrice;
                itemList[inventoryListBox.SelectedIndex].itemCost = givenItemCost;
                itemList[inventoryListBox.SelectedIndex].itemQuantity = givenItemQuantity;

                // set UI elements
                saveButton.Enabled = true;
                removeButton.Enabled = true;
            }

            // reset UI fields
            itemNameTextBox.Text = "";
            itemBrandTextBox.Text = "";
            itemPriceTextBox.Text = "";
            itemCostTextBox.Text = "";
            itemQuantityTextBox.Text = "";

        }



        private void button1_Click_4(object sender, EventArgs e)
        {
            InventoryManager manageInventory = new InventoryManager();
            if (InventoryManager.managerWindow == null)
            {
                manageInventory = InventoryManager.managerWindow;
            } 
                       
            manageInventory.Show();
            this.Hide();        
        }



    }

    public static class checkInt
    {
        public static int parseInt(this string value, int defaultValue = 0)
        {
            // initiate a return value
            int results = 0;
            if (int.TryParse(value, out results))
            {
                return results;
            }
            // if we made it this far, return 0
            MessageBox.Show("Value entered was invalid, set to 0.");
            return defaultValue;
        }

        public static int? nullDouble(this string value)
        {
            if (string.IsNullOrEmpty(value))
                return null;
            // return the value through the parser.
            return value.parseInt();
        }


    }

    public static class checkDouble
    {
        public static double parseDouble(this string value, double defaultValue = 0)
        {
            var cultureInfo = new System.Globalization.CultureInfo("en-US");
            // initiate a return value
            double results = 0;
            if (double.TryParse(value, out results))
            {
                return Double.Parse(value, cultureInfo);
            }
            // if we made it this far, return 0
            MessageBox.Show("Value entered was invalid, set to 0.");
            return defaultValue;
        }

        public static double? nullDouble(this string value)
        {
            if (string.IsNullOrEmpty(value))
                return null;
            // return the value through the parser.
            return value.parseInt();
        }
    }

}
