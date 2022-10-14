using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using Jason;
namespace InventoryManagement
{
    public class Inventory
    {
        public TypesOfRice typesofRice;
      
    }
    public class TypesOfRice
    {
        public string name { get; set; }
        public int weight { get; set; }
        public int price { get; set; }
    }
    

}
