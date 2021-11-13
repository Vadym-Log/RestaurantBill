using System;
using System.Collections.Generic;
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

namespace LoginUserControl
{
    /// <summary>
    /// Логика взаимодействия для MyUserControl.xaml
    /// </summary>
    public partial class MyUserControl : UserControl
    {
        /*
        public string MyName
        {
            get { return (string)GetValue(MyNameProperty); }
            set { SetValue(MyNameProperty, value); }
        }        
        // Using a DependencyProperty as the backing store for MyProperty.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty MyNameProperty =
            DependencyProperty.Register(nameof(MyName), typeof(string), typeof(MyUserControl), new PropertyMetadata(0));
        public string MyPass
        {
            get { return (string)GetValue(MyPassProperty); }
            set { SetValue(MyPassProperty, value); }
        }
        // Using a DependencyProperty as the backing store for MyProperty.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty MyPassProperty =
            DependencyProperty.Register(nameof(MyPass), typeof(string), typeof(MyUserControl), new PropertyMetadata(0));
*/
        public MyUserControl()
        {
            InitializeComponent();
        }
    }
}
