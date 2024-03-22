using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeShopManager.DTO
{
    public class Menu
    {
        private string drinkName;
        private int count;
        private float price;
        private float totalPrice;

        public Menu(string drinkName, int count, float price, float totalPrice = 0)
        {
            Count = count;
            Price = price;
            TotalPrice = totalPrice;
            DrinkName = drinkName;
        }
        public Menu(DataRow row)
        {
            DrinkName = row["name"].ToString();
            Count = (int)row["count"];
            Price = (float)Convert.ToDouble(row["price"].ToString());
            TotalPrice = (float)Convert.ToDouble(row["totalPrice"].ToString());

        }

        public int Count { get => count; set => count = value; }
        public float Price { get => price; set => price = value; }
        public float TotalPrice { get => totalPrice; set => totalPrice = value; }
        public string DrinkName { get => drinkName; set => drinkName = value; }
    }
}
