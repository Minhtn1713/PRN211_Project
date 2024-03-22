using CoffeeShopManager.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeShopManager.DAO
{
    public class CategoryDAO
    {
        private static CategoryDAO instance;
        public static CategoryDAO Instance
        {
            get { if (instance == null) instance = new CategoryDAO(); return instance; }
            private set { instance = value; }
        }
        private CategoryDAO() { }
        public List<Category> GetListCategory()
        {
            List<Category> listCategory = new List<Category>();
            string query = "Select * from Category";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            foreach (DataRow item in data.Rows)
            {
                Category category = new Category(item);
                listCategory.Add(category);
            }
            return listCategory;
        }
        public Category GetCategoryByID(int id)
        {
            Category category = null;
            string query = "Select * from Category where idCategory=" + id;
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            foreach (DataRow item in data.Rows)
            {
                category = new Category(item);
                return category;
            }
            return category;
        }

        public Boolean InsertCategory(string name)
        {
            string query = string.Format("INSERT INTO dbo.Category(name) VALUES (N'{0}')", name);
            int result = DataProvider.Instance.ExecuteNonQuery(query);
            return result > 0;
        }
        public Boolean UpdateCategory( string name,int idCategory)
        {
            string query = string.Format("UPDATE dbo.Category SET name = N'{0}' WHERE idCategory = {1}", name, idCategory);
            int result = DataProvider.Instance.ExecuteNonQuery(query);
            return result > 0;
        }

        public Boolean DeleteCategory(int idCategory)
        {
            BillInfoDAO.Instance.DeleteBillInfoByCategoryId(idCategory);
            DrinkDAO.Instance.DeleteDrinkByCategoryID(idCategory);
            string query = string.Format("DELETE FROM dbo.Category WHERE idCategory = {0}", idCategory);
            int result = DataProvider.Instance.ExecuteNonQuery(query);
            return result > 0;
        }
        public int checkCategoryExist(string categoryName)
        {
            string query = string.Format(" SELECT COUNT(*) FROM dbo.Category WHERE name = N'{0}'", categoryName);
            int result = Convert.ToInt32(DataProvider.Instance.ExecuteScalar(query));
            return result;
        }
    }
}