// Chad Weirick
// Grand Canyon Univeristy
// CST-117
// Dr. J!
//
// Milestone project for CST-117
//
// I am adding a datagridview so I can experiment with it and datatables
// it has taken me a lot of exploration, but I feel that this iteration is heads and shoulder better than the first two tries.
// this allows users to make new items, protects against items being malformed, etc. by dint of the default values in the datagridview
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

    // for retrieving the window.
    public partial class InventoryManager : Form
    {
        public static InventoryManager managerWindow;
        public string searchString;

        public DataTable dataTable;
        public DataTable discardTable; 

        public BindingSource bindingSource = new BindingSource();

        public InventoryManager()
        {
            InitializeComponent();
            searchString = "";
            if (inventoryForm.itemList.Count == 0)
            {
                // restrict button that should not be used.
                restockButton.Enabled = false;
            }
            // populateSearchList();
            
            // inventoryDataView.DataSource = searchList;
            
            managerWindow = this;

            // create the discard table
            discardTable = new DataTable();
            discardTable.Columns.Add("Name", typeof(string));        
            discardTable.Columns.Add("Brand", typeof(string));
            discardTable.Columns.Add("Price", typeof(double));
            discardTable.Columns.Add("Cost", typeof(double));
            discardTable.Columns.Add("Quantity", typeof(int));

            // create and fill data table
            dataTable = new DataTable();
            dataTable.Columns.Add("Name", typeof(string));
            dataTable.Columns.Add("Brand", typeof(string));
            dataTable.Columns.Add("Price", typeof(double));            
            dataTable.Columns.Add("Cost", typeof(double));
            dataTable.Columns.Add("Quantity", typeof(int));

           

            fillDataTable();

            // create a binding source
            
            bindingSource.DataSource = dataTable;

            //set  the inventoryDataView source to be the dataTable
            inventoryDataView.DataSource = bindingSource;
            // protect against errors during search that do not impact stability/output
            this.inventoryDataView.DataError += this.inventoryDataView_DataError;
            // protect against partially formed items
            this.inventoryDataView.DefaultValuesNeeded += this.inventoryDataView_DefaultValuesNeeded;
        }


        private void inventoryDataView_DefaultValuesNeeded(object sender, System.Windows.Forms.DataGridViewRowEventArgs e)
        {
            // this sets the default values for the items in the inventoryDataView, it acts as a railguard against items being sent back to the main form without all of their fields
            // this could also be done with different inventoryItem constructor combos, but the combinations could get out of hand
            e.Row.Cells["itemName"].Value = "Default";
            e.Row.Cells["itemBrand"].Value = "Default";
            e.Row.Cells["itemPrice"].Value = 2.00;
            e.Row.Cells["itemCost"].Value = 1.00;
            e.Row.Cells["itemQuantity"].Value = 1;
        }

        void inventoryDataView_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            // I am supressing an error I found during testing that seems more formating relating than anything else
            e.ThrowException = false;
        }

        public void fillDataTable()
        {
            // populate the dataTable from the inventoryForm.itemList
            for (int i = 0; i < inventoryForm.itemList.Count; i++)
            {
                dataTable.Rows.Add(inventoryForm.itemList[i].itemName, inventoryForm.itemList[i].itemBrand, inventoryForm.itemList[i].itemPrice, inventoryForm.itemList[i].itemCost, inventoryForm.itemList[i].itemQuantity);
            }
            // sort by name for professionalism
            dataTable.DefaultView.Sort = "Name";
            // confirm changes
            dataTable.AcceptChanges();
            // post UI updates
            inventoryDataView.Update();
            inventoryDataView.Refresh();
            Application.DoEvents();
        }

           
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void restockButton_Click(object sender, EventArgs e)
        {
           
            int rowCount = inventoryDataView.Rows.GetRowCount(DataGridViewElementStates.Selected);
            if (rowCount > 0)
            {
                // adjust inventory for each selected item.  Right now I am enforcing 1 item in the GUI.
                for (int i = 0; i < rowCount; i++)
                {
                    // there is a 2 way association with the dataTable, so setting the value in inventoryDataView is a shortcut to adjusting the table contents.                                                        
                    inventoryDataView.SelectedRows[0].Cells["itemQuantity"].Value = 100;
                }
                dataTable.AcceptChanges();
            } else
            {
                // notify user a row was not selected.
                MessageBox.Show("Please select an entire row.");
            }

        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            // end program
            inventoryForm.myMainWindow.Close();
            this.Close();            
        }

        private void InventoryManager_Load(object sender, EventArgs e)
        {

        }

        private void controlButton_Click(object sender, EventArgs e)
        {
            // send data back to the main form
            writeDataTableToInventoryList();
            inventoryForm.myMainWindow.Show();
            this.Close();
        }

        private void writeDataTableToInventoryList()
        {
            // writes the dataTable to the inventory list after clearing the list

            // thisRow stores each line in dataTable in turn
            DataRow thisRow;
            string thisItemName = "";
            string thisItemBrand = "";
            double thisItemCost = 0.00;
            double thisItemPrice = 0.00;
            int thisItemQuantity = 0;

            // clear the list
            inventoryForm.itemList.Clear();            

            for (int i = 0; i < dataTable.Rows.Count; i++)
            {
                // set thisRow
                thisRow = dataTable.Rows[i];
                // Writing out the variable assignments here and conversions for the sake of clarity.
                thisItemName = thisRow["Name"].ToString();
                thisItemBrand = thisRow["Brand"].ToString();
                thisItemPrice = Convert.ToDouble(thisRow["Price"].ToString());
                thisItemCost = Convert.ToDouble(thisRow["Cost"].ToString());
                thisItemQuantity = Int32.Parse(thisRow["Quantity"].ToString());

                inventoryForm.itemList.Add(new InventoryItem() { itemName = thisItemName, itemBrand = thisItemBrand, itemPrice = thisItemPrice, itemCost = thisItemCost, itemQuantity = thisItemQuantity });
            }

            inventoryForm.myMainWindow.refillList();

        }

        private void removeButton_Click(object sender, EventArgs e)
        {
        }

        public void searchTermTextBox_TextChanged(object sender, EventArgs e)
        {
            searchString = searchTermTextBox.Text;
            if (searchString.Length > 0)
            {
                remakeDataTable();
                // filter 
                // use discardThis to determine what should be added to the discardTable
                bool discardThis = true;

                // search variables and a test row
                string thisName = "";
                string thisBrand = "";
                DataRow thisRow;

                // prime do while loop
                bool itemsChanged = true;
                do
                {
                    // assume no changes are made
                    itemsChanged = false;
                    for (int i = 0; i < dataTable.Rows.Count; i++)
                    {
                        // reseting variables to ensure no serious issues.
                        discardThis = true;
                        thisName = "";
                        thisBrand = "";
                        thisRow = dataTable.Rows[i];
                        thisName = thisRow["Name"].ToString();
                        thisBrand = thisRow["Brand"].ToString();
                        if (thisName.ToUpper().Contains(searchString.ToUpper()))
                        {
                            discardThis = false;
                        }
                        if (thisBrand.ToUpper().Contains(searchString.ToUpper()))
                        {
                            discardThis = false;
                        }
                        if (discardThis)
                        {
                            itemsChanged = true;
                            discardTable.Rows.Add(thisName, thisBrand, thisRow["Price"], thisRow["Cost"], thisRow["Quantity"]);
                            dataTable.Rows.RemoveAt(i);
                            // trip the for loop to exit it
                            i = dataTable.Rows.Count + 1;
                        }
                    }
                } while (itemsChanged);
                discardTable.AcceptChanges();
                dataTable.AcceptChanges();
                inventoryDataView.Update();
                inventoryDataView.Refresh();
                Application.DoEvents();


            } else
            {
                remakeDataTable();
                // make sure anything in the discardTable is added back to dataTable and discardTable is cleared.
            }

        }

        private void remakeDataTable()
        {
            // add the discard table back into the mix.
            DataRow aRow;
            for (int i = 0; i < discardTable.Rows.Count; i++)
            {
                aRow = discardTable.Rows[i];
                dataTable.Rows.Add(aRow["Name"], aRow["Brand"], aRow["Price"], aRow["Cost"], aRow["Quantity"]);
            }
            discardTable.Rows.Clear();
            discardTable.AcceptChanges();

            // sort by name to keep this looking professional
            dataTable.DefaultView.Sort = "Name";
            dataTable.AcceptChanges();
            inventoryDataView.Update();
            inventoryDataView.Refresh();
            Application.DoEvents();
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void addButton_Click(object sender, EventArgs e)
        {
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            // write a CSV 
            if (dataTable.Rows.Count > 0)
            {
                SaveFileDialog saveFile = new SaveFileDialog();
                saveFile.Filter = "Comma Separated Values|*.csv";
                saveFile.Title = "Save Inventory File";
                saveFile.ShowDialog();

                if (saveFile.FileName != "")
                {
                    // filename is valid, write it out!
                    handleCSV.writeCSV(saveFile.FileName, dataTable);
                }
            } else
            {
                // make sure items are present to prevent errors.
                MessageBox.Show("Table is empty, please add items.");
            }
            
        }

        private void loadButton_Click(object sender, EventArgs e)
        {
            // load a CSV
            OpenFileDialog openFile = new OpenFileDialog();
            openFile.Filter = "Comma Separated Values|*.csv";
            openFile.Title = "Select a CSV File";

            // test to be sure that the file is ok
            if (openFile.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                // eliminate current dataTable
                dataTable.Clear();


                dataTable = handleCSV.readCSV(openFile.FileName, dataTable);
                dataTable.DefaultView.Sort = "Name";
                bindingSource.ResetBindings(false);
                dataTable.AcceptChanges();
                inventoryDataView.EndEdit();
                inventoryDataView.Update();
                inventoryDataView.Refresh();
                inventoryDataView.Hide();
                inventoryDataView.Show();
                Application.DoEvents();

                // deposit reader back to the main user view.
                controlButton.PerformClick();

            }
        }
    }

    public static class handleCSV
    {
        public static void writeCSV(String outputFileName, DataTable outTable)
        {
            // open streamwriter
            System.IO.StreamWriter sw = new System.IO.StreamWriter(outputFileName, false);

            // write out the header
            for (int i = 0; i < outTable.Columns.Count; i++)
            {
                sw.Write(outTable.Columns[i]);

                // control comma usage
                if (i < outTable.Columns.Count - 1)
                {
                    sw.Write(",");
                }
            }
            sw.Write(sw.NewLine);


            foreach (DataRow dr in outTable.Rows)
            {
                for (int i = 0; i < outTable.Columns.Count; i++)
                {
                    // do until the null condition.
                    if (!Convert.IsDBNull(dr[i]))
                    {

                        // convert properly for writing things which may already have commas in them
                        string valueToWrite = dr[i].ToString();
                        if (valueToWrite.Contains(','))
                        {
                            valueToWrite = String.Format("\"{0}\"", valueToWrite);
                            sw.Write(valueToWrite);
                        }
                        else
                        {
                            sw.Write(dr[i].ToString());
                        }
                    }

                    // control comma usage
                    if (i < outTable.Columns.Count - 1)
                    {
                        sw.Write(",");
                    }
                }
                sw.Write(sw.NewLine);            
            }

            // close and let the user know all is well in the world.
            sw.Close();
            MessageBox.Show("File written successfully");
        }

        public static DataTable readCSV(String inputFileName, DataTable inTable)
        {
            // prepare return dataTable
            DataTable outDataTable = new DataTable();

            using (System.IO.StreamReader sr = new System.IO.StreamReader(inputFileName))
            {
                string[] headers = sr.ReadLine().Split(',');
                foreach (string header in headers)
                {
                    outDataTable.Columns.Add(header);
                }
                while (!sr.EndOfStream)
                {
                    string[] rows = sr.ReadLine().Split(',');
                    DataRow dr = outDataTable.NewRow();
                    for (int i = 0; i < headers.Length; i++)
                    {
                        dr[i] = rows[i];
                    }
                    outDataTable.Rows.Add(dr);
                }

            }
            outDataTable.AcceptChanges();
            MessageBox.Show("File read successfully");
            return outDataTable;
        }    
    }

}


