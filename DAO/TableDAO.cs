using CoffeeShopManager.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeShopManager.DAO
{

    public class TableDAO
    {
        private static TableDAO instance;
        public static TableDAO Instance
        {
            get { if (instance == null) instance = new TableDAO(); return instance; }
            private set { instance = value; }
        }
        private TableDAO() { }

        //public void SwitchTable (int id1 , int id2)
        //{
        //    DataProvider.Instance.ExecuteQuery("USP_SwitchTable @idTable1 , @idTable2 ", new object[] { id1, id2 });

        //}
        public List<Table> loadTableList()
        {
            List<Table> listTable = new List<Table>();
            DataTable data = DataProvider.Instance.ExecuteQuery("GetTableList");
            foreach (DataRow item in data.Rows)
            {
                Table table = new Table(item);
                listTable.Add(table);
            }
            return listTable;
        }
        public Boolean InsertTable(string nameTable)
        {
            string query = string.Format("INSERT INTO dbo.TableCoffee(name,status)VALUES(N'{0}', N'Trống')", nameTable);
            int result = DataProvider.Instance.ExecuteNonQuery(query);
            return result > 0;
        }
        public Boolean UpdateTable(int idTable, string nameTable)
        {
            string query = string.Format("UPDATE dbo.TableCoffee SET name = N'{0}' WHERE idTable = {1} ", nameTable, idTable);
            int result = DataProvider.Instance.ExecuteNonQuery(query);
            return result > 0;
        }

        public Boolean DeleteTable(int idTable)
        {
            BillInfoDAO.Instance.DeleteBillInfoByTableID(idTable);
            BillDAO.Instance.DeleteBillByTableId(idTable);
            string query = string.Format("DELETE FROM dbo.TableCoffee WHERE idTable = " + idTable);
            int result = DataProvider.Instance.ExecuteNonQuery(query);
            return result > 0;
        }
        public int checkTableExist(string tableName)
        {
            string query = string.Format(" SELECT COUNT(*) FROM dbo.TableCoffee WHERE name = N'{0}'", tableName);
            int result = Convert.ToInt32(DataProvider.Instance.ExecuteScalar(query));
            return result;
        }
    }
}
