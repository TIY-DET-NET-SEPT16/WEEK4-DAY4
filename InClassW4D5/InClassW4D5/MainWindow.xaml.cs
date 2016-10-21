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

namespace InClassW4D5
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        string some = "Hey this is my string";

        public MainWindow()
        {
            InitializeComponent();
            this.DataContext = this;

        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            CoolNewWindow cnw = new CoolNewWindow();
            cnw.label.Content = some;
            cnw.Show();
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            BindingExpression binding = textBoxTitle.GetBindingExpression(TextBox.TextProperty);
            binding.UpdateSource();
        }
    }
}
