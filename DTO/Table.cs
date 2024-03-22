using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeShopManager.DTO
{
    public class Table
    {
        private int iD;

        private string name;

        private string status;
        public int ID { get => iD; set => iD = value; }
        public string Name { get => name; set => name = value; }
        public string Status { get => status; set => status = value; }

        public Table(int id, string name, string status)
        {
            this.iD = id;
            this.name = name;
            this.status = status;
        }
        public Table(DataRow row)
        {
            this.ID = (int)row["idTable"];
            this.Name= row["name"].ToString();
            this.Status = row["status"].ToString();
        }
    }
}
