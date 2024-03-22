using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeShopManager.DTO
{
    public class Bill
    {
        private DateTime? dateCheckout;

        private int iD;

        private DateTime? dateCheckin;

        private int status;
        private int discount;

        public Bill(int iD, DateTime? dateCheckin, DateTime? dateCheckout, int status, int discount = 0)
        {
            this.ID = iD;
            this.DateCheckin = dateCheckin;
            this.DateCheckout = dateCheckout;
            this.Status = status;
            this.discount = discount;
          
        }
        public Bill(DataRow row)
        {
            this.ID = (int)row["idBill"];
            this.DateCheckin = (DateTime?)row["dateCheckin"];
            var dateCheckoutTemp = row["dateCheckout"];
            if (dateCheckoutTemp.ToString() != "")
            {
                this.DateCheckout = (DateTime?)row["dateCheckout"];
            }

            this.Status = (int)row["status"];

            if(row["discount"].ToString()!="")
            this.Discount = (int)row["discount"];
        }
        public int ID { get => iD; set => iD = value; }
        public DateTime? DateCheckin { get => dateCheckin; set => dateCheckin = value; }
        public DateTime? DateCheckout { get => dateCheckout; set => dateCheckout = value; }
        public int Status { get => status; set => status = value; }
        public int Discount { get => discount; set => discount = value; }
    }
}
