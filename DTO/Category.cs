using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeShopManager.DTO
{
    public class Category
    {
        private int iD;
        private string name;
        public Category(int iD, string name)
        {
            ID = iD;
            Name = name;   
        }
        public Category(DataRow row)
        {
            this.iD = (int)row["idCategory"];
            this.name = row["name"].ToString();
        }

        public int ID { get => iD; set => iD = value; }
        public string Name { get => name; set => name = value; }
    }
}
