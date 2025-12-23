using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace colloc
{
    public class Restaurant
    {
        public string Name { get;private set; }
        public List<Dish> Dishes { get; private set; }
        public Restaurant(string name)
        {
            Name = name;
            Dishes = new List<Dish>();
        }
        public void AddDish(Dish dish)  
        {
            Dishes.Add(dish); 
        }
    }
}
