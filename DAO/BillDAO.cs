using CoffeeShopManager.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeShopManager.DAO
{
    public class BillDAO
    {

        private static BillDAO instance;
        public static BillDAO Instance
        {
            get { if (instance == null) instance = new BillDAO(); return instance; }
            private set { instance = value; }
        }
        private BillDAO() { }

        public void Checkout(int id, int discount, float totalPrice)
        {
            string query = "UPDATE  dbo.Bill SET dateCheckOut = GETDATE(),status = 1, " + "discount = " + discount + ", totalPrice = " + totalPrice + " WHERE idBill = " + id;
            DataProvider.Instance.ExecuteNonQuery(query);
        }
        public int GetUncheckBillIdByTableId(int id)
        {
            DataTable data = DataProvider.Instance.ExecuteQuery("SELECT * FROM dbo.Bill WHERE idTable = " + id + " AND status = 0");
            if (data.Rows.Count > 0)
            {
                Bill bill = new Bill(data.Rows[0]);
                return bill.ID;
            }
            return -1;
        }
        public void InsertBill(int id)
        {
            DataProvider.Instance.ExecuteQuery("EXEC InsertBill @idTable", new object[] { id });
        }

        public DataTable GetListBillByDate(DateTime dateCheckin, DateTime dateCheckout)
        {
            return DataProvider.Instance.ExecuteQuery(" exec GetListBillByDate @dateCheckin , @dateCheckout", new object[] { dateCheckin, dateCheckout });
        }
        public int GetMaxIdBill()
        {

            try
            {
                return (int)DataProvider.Instance.ExecuteScalar("SELECT MAX(idBill) FROM dbo.Bill");
            }
            catch
            {
                return 1;
            }
        }
        public void DeleteBillByTableId(int idTable)
        {
            DataTable data = DataProvider.Instance.ExecuteQuery(" DELETE dbo.Bill WHERE idTable = " + idTable);
        }
    }
}
