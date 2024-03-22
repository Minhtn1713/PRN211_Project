using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeShopManager.DTO
{
    public class BillInfo
    {
        private int iD;
        private int idBill;
        private int idDrinks;
        private int count;
        public BillInfo(int iD, int idBill, int idDrinks, int count)
        {
            ID = iD;
            IdBill = idBill;
            IdDrinks = idDrinks;
            Count = count;
        }
        public BillInfo(DataRow row)
        {
            ID = (int)row["idBillInfo"];
            IdBill = (int)row["idBill"];
            IdDrinks = (int)row["idDrinks"];
            Count = (int)row["count"];
        }

        public int ID { get => iD; set => iD = value; }
        public int IdBill { get => idBill; set => idBill = value; }
        public int IdDrinks { get => idDrinks; set => idDrinks = value; }
        public int Count { get => count; set => count = value; }
    }
}
