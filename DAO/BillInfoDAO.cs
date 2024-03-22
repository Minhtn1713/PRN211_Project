using CoffeeShopManager.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeShopManager.DAO
{
    public class BillInfoDAO
    {
        private static BillInfoDAO instance;
        public static BillInfoDAO Instance
        {
            get { if (instance == null) instance = new BillInfoDAO(); return instance; }
            private set { instance = value; }
        }
        private BillInfoDAO() { }
        public List<BillInfo> GetListBillInfo(int id)
        {
            List<BillInfo> listBillInfor = new List<BillInfo>();
            DataTable data = DataProvider.Instance.ExecuteQuery("SELECT * FROM dbo.BillInfo WHERE idBill=" + id);
            foreach (DataRow item in data.Rows)
            {
                BillInfo billInfo = new BillInfo(item);
                listBillInfor.Add(billInfo);
            }
            return listBillInfor;
        }
        public void InsertBillInfo(int idBill, int idDrink, int count)
        {
            DataProvider.Instance.ExecuteQuery("InsertBillInfor @idBill , @idDrink , @count", new object[] { idBill, idDrink, count });
        }

        public void DeleteBillInfoByDrinkId(int id)
        {
            DataTable data = DataProvider.Instance.ExecuteQuery("Delete FROM dbo.BillInfo WHERE idDrinks=" + id);
        }

        public void DeleteBillInfoByCategoryId(int idCategory)
        {
            DataTable data = DataProvider.Instance.ExecuteQuery("DELETE bi FROM  dbo.BillInfo bi INNER JOIN dbo.Drinks d ON d.idDrinks = bi.idDrinks INNER JOIN dbo.Category c ON c.idCategory = d.idCategory WHERE c.idCategory = " + idCategory);
        }
        public void DeleteBillInfoByTableID(int idTable)
        {
            DataTable data = DataProvider.Instance.ExecuteQuery("DELETE bi FROM dbo.BillInfo bi INNER JOIN dbo.Bill ON Bill.idBill = bi.idBill INNER JOIN dbo.TableCoffee tb ON tb.idTable = Bill.idTable WHERE tb.idTable = " + idTable);
        }
        public void DeleteBillInfoByBillID(int idBill)
        {
            DataTable data = DataProvider.Instance.ExecuteQuery("DELETE dbo.BillInfo WHERE idBill =" + idBill);
        }
    }
}
