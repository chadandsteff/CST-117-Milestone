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
    public partial class Form1 : Form
    {
        int totalItems = 0;
        int currentItem = 0;
        // for handling money issues        
        List<InventoryItem> itemList = new List<InventoryItem>();

        public Form1()
        {
            InitializeComponent();
            saveButton.Enabled = false;
            removeButton.Enabled = false;         
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
            itemList.Add(new InventoryItem() { ItemName = givenItemName, ItemBrand = givenItemBrand, ItemPrice = givenItemPrice, ItemCost = givenItemCost, ItemQuantity = givenItemQuantity });
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
                    itemNameTextBox.Text = itemList[inventoryListBox.SelectedIndex].ItemName;
                    itemBrandTextBox.Text = itemList[inventoryListBox.SelectedIndex].ItemBrand;
                    itemPriceTextBox.Text = itemList[inventoryListBox.SelectedIndex].itemPrice.ToString("f2");
                    itemCostTextBox.Text = itemList[inventoryListBox.SelectedIndex].ItemCost.ToString("f2");
                    itemQuantityTextBox.Text = itemList[inventoryListBox.SelectedIndex].ItemQuantity.ToString();
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
            itemList.Add(new InventoryItem() { ItemName = "Snacky cakes", ItemBrand = "Snacky", ItemPrice = 5.00, ItemCost = 2.00, ItemQuantity = 20 });
            inventoryListBox.Items.Add(itemList[totalItems]);
            totalItems++;
            itemList.Add(new InventoryItem() { ItemName = "Snacky cakes Gonzo", ItemBrand = "Snacky", ItemPrice = 6.00, ItemCost = 2.25, ItemQuantity = 50 });
            inventoryListBox.Items.Add(itemList[totalItems]);
            totalItems++;
            itemList.Add(new InventoryItem() { ItemName = "Snacky cakes Bonkers", ItemBrand = "Snacky", ItemPrice = 10.00, ItemCost = 2.75, ItemQuantity = 10 });
            inventoryListBox.Items.Add(itemList[totalItems]);
            totalItems++;
            itemList.Add(new InventoryItem() { ItemName = "Snacky cakes Lite", ItemBrand = "Snacky", ItemPrice = 1.50, ItemCost = 0.25, ItemQuantity = 5 });
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
                itemList[inventoryListBox.SelectedIndex].ItemName = givenItemName;
                itemList[inventoryListBox.SelectedIndex].ItemBrand = givenItemBrand;
                itemList[inventoryListBox.SelectedIndex].itemPrice = givenItemPrice;
                itemList[inventoryListBox.SelectedIndex].ItemCost = givenItemCost;
                itemList[inventoryListBox.SelectedIndex].ItemQuantity = givenItemQuantity;

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
