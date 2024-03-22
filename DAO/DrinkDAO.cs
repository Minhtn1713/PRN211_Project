using CoffeeShopManager.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeShopManager.DAO
{
    public class DrinkDAO
    {
        private static DrinkDAO instance;
        public static DrinkDAO Instance
        {
            get { if (instance == null) instance = new DrinkDAO(); return instance; }
            private set { instance = value; }
        }
        private DrinkDAO() { }
        public List<Drink> GetDrinkByCategoryID(int id)
        {
            List<Drink> listDrink = new List<Drink>();
            string query = "SELECT* FROM dbo.Drinks WHERE idCategory = " + id;
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            foreach (DataRow item in data.Rows)
            {
                Drink drink = new Drink(item);
                listDrink.Add(drink);
            }
            return listDrink;
        }

        public List<Drink> GetListDrink()
        {
            List<Drink> listDrink = new List<Drink>();
            string query = "SELECT* FROM dbo.Drinks";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            foreach (DataRow item in data.Rows)
            {
                Drink drink = new Drink(item);
                listDrink.Add(drink);
            }
            return listDrink;
        }

        public List<Drink> SearchDrinkByName(string name)
        {
            List<Drink> listDrink = new List<Drink>();
            string query = string.Format("SELECT* FROM dbo.Drinks where dbo.fuConvertToUnsign1(name) LIKE N'%' + dbo.fuConvertToUnsign1(N'{0}') + '%'", name);
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            foreach (DataRow item in data.Rows)
            {
                Drink drink = new Drink(item);
                listDrink.Add(drink);
            }
            return listDrink;
        }
        public void DeleteDrinkByCategoryID(int idCategory)
        {
            DataTable data = DataProvider.Instance.ExecuteQuery("DELETE FROM dbo.Drinks WHERE idCategory =" + idCategory);
        }

        public Boolean InsertDrink(string name, int idCategory, double price)
        {
            string query = string.Format(" INSERT dbo.Drinks(name,idCategory,price)VALUES(N'{0}' , {1} , {2} )", name, idCategory, price);
            int result = DataProvider.Instance.ExecuteNonQuery(query);
            return result > 0;
        }
        public Boolean UpdateDrink(int idDrink, string name, int idCategory, double price)
        {
            string query = string.Format(" UPDATE dbo.Drinks SET name = N'{0}', idCategory = {1}, price = {2} WHERE idDrinks = {3}", name, idCategory, price, idDrink);
            int result = DataProvider.Instance.ExecuteNonQuery(query);
            return result > 0;
        }

        public Boolean DeleteDrink(int idDrink)
        {
            BillInfoDAO.Instance.DeleteBillInfoByDrinkId(idDrink);
            string query = string.Format("  DELETE FROM dbo.Drinks WHERE idDrinks = {0}", idDrink);
            int result = DataProvider.Instance.ExecuteNonQuery(query);
            return result > 0;
        }
        public int checkDrinkExist(string drinkName)
        {
            string query = string.Format(" SELECT COUNT(*) FROM dbo.Drinks WHERE name = N'{0}'", drinkName);
            int result =Convert.ToInt32 (DataProvider.Instance.ExecuteScalar(query));
            return result;
        }
    }
}
