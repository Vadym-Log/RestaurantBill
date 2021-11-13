using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Collections.ObjectModel;
using System.Diagnostics;

namespace Restaurant_Bill_Calculator
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {            
            InitializeComponent();
            DataContext = new ComboBoxViewModel();
            MessageBox.Show("When you change the quantity of some dish, please, don't forget to refresh the field \"Quantity\"", "HINT");
        }

        ComboBox comboBox; 
        TempProduct tempProduct;
        ObservableCollection<TempProduct> dataList = new ObservableCollection<TempProduct>();
        
        private void statusBar_Loaded(object sender, RoutedEventArgs e)
        {
            TextBlockStatus.Text = "Select you dishes";
            tempProduct.Name = "";
            tempProduct.Category = "";
            tempProduct.Price = 0;
        }

        private void bev_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            comboBox = (ComboBox)sender;
            Beverage selectedItem = (Beverage)comboBox.SelectedItem;            
            TextBlockStatus.Text = selectedItem.Name + " - " + selectedItem.Category + " - $" + selectedItem.Price;
            tempProduct = new TempProduct();
            tempProduct.Name = selectedItem.Name;
            tempProduct.Category = selectedItem.Category;
            tempProduct.Price = selectedItem.Price;
        }
        private void appet_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            comboBox = (ComboBox)sender;
            Appetizer selectedItem = (Appetizer)comboBox.SelectedItem;            
            TextBlockStatus.Text = selectedItem.Name + " - " + selectedItem.Category + " - $" + selectedItem.Price;
            tempProduct = new TempProduct();
            tempProduct.Name = selectedItem.Name;
            tempProduct.Category = selectedItem.Category;
            tempProduct.Price = selectedItem.Price;
        }
        private void mainc_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            comboBox = (ComboBox)sender;
            MainCourse selectedItem = (MainCourse)comboBox.SelectedItem;            
            TextBlockStatus.Text = selectedItem.Name + " - " + selectedItem.Category + " - $" + selectedItem.Price;
            tempProduct = new TempProduct();
            tempProduct.Name = selectedItem.Name;
            tempProduct.Category = selectedItem.Category;
            tempProduct.Price = selectedItem.Price;
        }
        private void des_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            comboBox = (ComboBox)sender;
            Dessert selectedItem = (Dessert)comboBox.SelectedItem;            
            TextBlockStatus.Text = selectedItem.Name + " - " + selectedItem.Category + " - $" + selectedItem.Price;
            tempProduct = new TempProduct();
            tempProduct.Name = selectedItem.Name;
            tempProduct.Category = selectedItem.Category;
            tempProduct.Price = selectedItem.Price;
        }

        decimal subtotal, tax, total; bool present = false; int index;
        string statusName;
        private void plus_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (TextBlockStatus.Text.Contains("-"))            
                    statusName = TextBlockStatus.Text.Remove(TextBlockStatus.Text.IndexOf("-") - 1);
                if (tempProduct.Name == statusName)
                {
                    foreach (TempProduct tp in dataList)
                        if (tempProduct.Name == tp.Name)
                            present = true;
                    if (!present)
                        this.dataList.Add(tempProduct);
                    foreach (TempProduct tp in dataList)
                        if (tempProduct.Name == tp.Name)
                            index = dataList.IndexOf(tp);
                    dataList.ElementAt(index).Quantity++;
                    this.dataGrid.ItemsSource = dataList;
                    dataGrid.UpdateLayout();
                    present = false;
                    Calc(dataList);
                }
                else
                {
                    MessageBox.Show("Please, choose your dish in ComboBox correctly", "ERROR");
                }
            }
            catch
            {
                MessageBox.Show("Please, choose your dish in ComboBox correctly", "ERROR");
            }
        }
        private void minus_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                foreach (TempProduct tp in dataList)
                    if (((TempProduct)dataGrid.SelectedItem).Name == tp.Name)
                        index = dataList.IndexOf(tp);
                if (dataList.ElementAt(index).Quantity > 0)
                        dataList.ElementAt(index).Quantity--;
                if (dataList.ElementAt(index).Quantity == 0)
                    dataList.Remove(dataList.ElementAt(index));                
                dataGrid.ItemsSource = dataList;
                dataGrid.UpdateLayout();
                present = false;
                Calc(dataList);
            }
            catch
            {
                MessageBox.Show("Please, choose your dish in DataGrid correctly", "ERROR");
            }
        }
        private void clear_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                dataList.Clear();
                dataGrid.ItemsSource = dataList;
                txtSubtotal.Text = "0";
                txtTax.Text = "0";
                txtTotal.Text = "0";
                present = false;
            }
            catch { }            
        }
        private void dataGrid_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            dataGrid.ItemsSource = dataList;
            dataGrid.UpdateLayout();
            present = false;
            Calc(dataList);
        }
        private void Calc(ObservableCollection<TempProduct> dl)
        {
            subtotal = 0;
            foreach (TempProduct tp in dl)
                subtotal += tp.Price * tp.Quantity;
            txtSubtotal.Text = subtotal.ToString("c2") ;
            tax = subtotal * 0.13M;
            txtTax.Text = tax.ToString("c2");
            total = subtotal + tax;
            txtTotal.Text = total.ToString("c2");
        }

        private void Hyperlink_RequestNavigate(object sender, RequestNavigateEventArgs e)
        {
            Process.Start(new ProcessStartInfo(e.Uri.AbsoluteUri));
            e.Handled = true;
        }
    }
}
