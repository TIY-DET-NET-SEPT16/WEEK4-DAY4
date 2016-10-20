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

namespace InClassWeek4Day4
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            double oldWidth = textBoxTop.Width;
            textBoxTop.Text = "You clicked the button!";
            textBoxTop.Width = 150;
            button1.Margin = new Thickness(
                textBoxTop.Margin.Left + textBoxTop.Width + 10,
                button1.Margin.Top, button1.Margin.Right,
                button1.Margin.Right - button1.Width);
        }

        private void topButton_Click(object sender, RoutedEventArgs e)
        {

        }

        private void checkBox_Checked(object sender, RoutedEventArgs e)
        {
            if (sender.GetType() == typeof(CheckBox))
            {
                CheckBox cb = (CheckBox)sender;
                if (cb.Name == checkBox1.Name)
                    MessageBox.Show("Hey");

                Grid parent = (Grid)cb.Parent;

                if (parent != null)
                {
                    foreach (object obj in parent.Children)
                    {
                        CheckBox newCB = obj as CheckBox;
                        if (newCB != null)
                        {
                            if (newCB.Name != cb.Name)
                                newCB.IsChecked = false;
                        }
                    }

                    textBoxTop.Text = "You clicked " + cb.Content;
                }
            }
        }
    }
}
