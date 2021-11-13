using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant_Bill_Calculator
{
    public class ComboBoxViewModel
    {
        public ObservableCollection<Appetizer> appetizers { get; set; }        
        public ObservableCollection<Beverage> beverages { get; set; }
        public ObservableCollection<Dessert> desserts { get; set; }
        public ObservableCollection<MainCourse> mainCourses { get; set; }        

        public ComboBoxViewModel()
        {
            appetizers = new ObservableCollection<Appetizer>();            
            appetizers.Add(new Appetizer() { Name = "Buffalo Wings", Category = "Appetizer", Price = 5.95M });
            appetizers.Add(new Appetizer() { Name = "Buffalo Fingers", Category = "Appetizer", Price = 6.95M });
            appetizers.Add(new Appetizer() { Name = "Potato Skins", Category = "Appetizer", Price = 8.95M });
            appetizers.Add(new Appetizer() { Name = "Nachos", Category = "Appetizer", Price = 8.95M });
            appetizers.Add(new Appetizer() { Name = "Mushroom Caps", Category = "Appetizer", Price = 10.95M });
            appetizers.Add(new Appetizer() { Name = "Shrimp Coctail", Category = "Appetizer", Price = 12.95M });
            appetizers.Add(new Appetizer() { Name = "Chips and Salsa", Category = "Appetizer", Price = 6.95M });

            beverages = new ObservableCollection<Beverage>();
            beverages.Add(new Beverage() { Name = "Soda", Category = "Beverage", Price = 1.95M });
            beverages.Add(new Beverage() { Name = "Tea", Category = "Beverage", Price = 1.50M });
            beverages.Add(new Beverage() { Name = "Coffee", Category = "Beverage", Price = 1.25M });
            beverages.Add(new Beverage() { Name = "Mineral Water", Category = "Beverage", Price = 2.95M });
            beverages.Add(new Beverage() { Name = "Juice", Category = "Beverage", Price = 2.50M });
            beverages.Add(new Beverage() { Name = "Milk", Category = "Beverage", Price = 1.50M });

            desserts = new ObservableCollection<Dessert>();
            desserts.Add(new Dessert() { Name = "Apple Pie", Category = "Dessert", Price = 5.95M });
            desserts.Add(new Dessert() { Name = "Sundae", Category = "Dessert", Price = 3.95M });
            desserts.Add(new Dessert() { Name = "Carrot Cake", Category = "Dessert", Price = 5.95M });
            desserts.Add(new Dessert() { Name = "Mud Pie", Category = "Dessert", Price = 4.95M });
            desserts.Add(new Dessert() { Name = "Apple Crisp", Category = "Dessert", Price = 5.95M });

            mainCourses = new ObservableCollection<MainCourse>();
            mainCourses.Add(new MainCourse() { Name = "Seafood Alfredo", Category = "Main Course", Price = 15.95M });
            mainCourses.Add(new MainCourse() { Name = "Chicken Alfredo", Category = "Main Course", Price = 13.95M });
            mainCourses.Add(new MainCourse() { Name = "Chicken Picatta", Category = "Main Course", Price = 13.95M });
            mainCourses.Add(new MainCourse() { Name = "Turkey Club", Category = "Main Course", Price = 11.95M });
            mainCourses.Add(new MainCourse() { Name = "Lobster Pie", Category = "Main Course", Price = 19.95M });
            mainCourses.Add(new MainCourse() { Name = "Prime Rib", Category = "Main Course", Price = 20.95M });
            mainCourses.Add(new MainCourse() { Name = "Shrimp Scampi", Category = "Main Course", Price = 18.95M });
            mainCourses.Add(new MainCourse() { Name = "Turkey Dinner", Category = "Main Course", Price = 13.95M });
            mainCourses.Add(new MainCourse() { Name = "Stuffed Chicken", Category = "Main Course", Price = 14.95M });
        }
    }
}
