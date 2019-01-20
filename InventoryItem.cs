// Chad Weirick
// Grand Canyon Univeristy
// CST-117
// Dr. J!
//
// Milestone project for CST-117
//
// InventoryItem class has setters and getters for all public variables.  I've included an itemNumber in anticipation of possible database connectivity so I have a unique identifier.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CST_117_Milestone
{
    public class InventoryItem
    {
        public string itemName { get; set; }
        public string itemBrand { get; set; }
        public double itemPrice { get; set; }
        public double itemCost { get; set; }
        public int itemQuantity { get; set; }
        public int itemNumber { get; set; }

        public InventoryItem()
        {
            this.itemName = "";
            this.itemBrand = "";
            this.itemPrice = 0.0;
            this.itemCost = 0.0;
            this.itemQuantity = 0;
        }

        public override string ToString()
        {
            return this.itemName;
        }

    }
}
