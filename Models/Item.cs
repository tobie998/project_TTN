using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ElectronicWEB.Models
{
    [Serializable]
    public class Item
    {
        
        public SANPHAM Product{ get; set; }
        
        public int Quantity { get; set; }
        //public int GetTotal()
        //{
        //    int total = 0;
        //    foreach (Item item in lst)
        //    {
        //        total += item.amount;
        //    }
        //    return total;
        //}
    }
    
}