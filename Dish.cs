using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace colloc
{
    public class Dish
    {
        public string DishName {  get;}
        public int PortionWeight { get; private set; }
        public int DailyPortions {  get; private set; }
        public DishType dishType { get;}
        public Dish(string dishName,int portionWeight, int dailyPortions, DishType dishType)
        {
            DishName = dishName;
            DailyPortions = dailyPortions;
            PortionWeight = portionWeight;
            this.dishType = dishType;
        }
        public void Upgrade()
        {
            DailyPortions++;
            PortionWeight += 50;
        }
    }
    public enum DishType
    {
        Appetizer,
        MainCourse,
        Dessert,
        Beverage,
        Salad
    }
}
