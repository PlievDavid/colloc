using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace colloc
{
    public partial class FormRest : Form
    {
        public FormRest()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            listViewRests.Items.Clear();
            var listRests = ReadFromFile();
            foreach (var rest in listRests)
            {
                ListViewItem item = new ListViewItem(rest.Name);
                item.SubItems.Add(string.Join("|",rest.Dishes.Select(dish => $"{dish.DishName}, {dish.PortionWeight}, {dish.DailyPortions}, {dish.dishType}")));
                listViewRests.Items.Add(item);
            }
        }
        public List<Restaurant> ReadFromFile()
        {
            StreamReader streamReader = new StreamReader("data.txt");
            var restList = new List<Restaurant>();
            while (!streamReader.EndOfStream)
            {
                var s = streamReader.ReadLine();
                MessageBox.Show(s);
                var tempRest = new Restaurant(s);
                while (!string.IsNullOrEmpty(s))
                {
                    s = streamReader.ReadLine();
                    if (!string.IsNullOrEmpty(s))
                    {
                        var ss = s.Split('|');
                        switch (ss[3])
                        {
                            case "Закуска": tempRest.AddDish(new Dish(ss[0], Convert.ToInt32(ss[1]), Convert.ToInt32(ss[2]), DishType.Appetizer)); break;
                            case "Основное блюдо": tempRest.AddDish(new Dish(ss[0], Convert.ToInt32(ss[1]), Convert.ToInt32(ss[2]), DishType.MainCourse)); break;
                            case "Десерт ": tempRest.AddDish(new Dish(ss[0], Convert.ToInt32(ss[1]), Convert.ToInt32(ss[2]), DishType.Dessert)); break;
                            case "Напиток ": tempRest.AddDish(new Dish(ss[0], Convert.ToInt32(ss[1]), Convert.ToInt32(ss[2]), DishType.Beverage)); break;
                            case "Салат ": tempRest.AddDish(new Dish(ss[0], Convert.ToInt32(ss[1]), Convert.ToInt32(ss[2]), DishType.Salad)); break;
                        }
                    }

                }
                restList.Add(tempRest);
            }
            streamReader.Close();
            return restList;
        }
        public List<Dish> FilterDishesByWeight(List<Dish> dishes, int weight)
        {
            return dishes.Where(dish=>dish.PortionWeight == weight).ToList();
        }
        public List<Restaurant> SortRestaurantsByPortionsPerDay(List<Restaurant> restaurants)
        {
            return restaurants.OrderBy(rest => rest.Dishes.Select(dish => dish.DailyPortions).Sum()).ToList();
        }
        public List<Dish> GroupDishesByDishType(List<Dish> dishes) => (List<Dish>)dishes.GroupBy(dish => dish.dishType);
    }
}
