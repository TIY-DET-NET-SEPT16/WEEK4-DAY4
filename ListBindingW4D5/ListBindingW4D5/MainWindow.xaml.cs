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

namespace ListBindingW4D5
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        List<User> users = new List<User>();

        public MainWindow()
        {
            InitializeComponent();

            users.Add(new User() { UserId = 1, UserName = "Fred", UserEmail = "fred@bedrock.com" });
            users.Add(new User() { UserId = 2, UserName = "Barney", UserEmail = "barney@bedrock.com" });
            users.Add(new User() { UserId = 3, UserName = "Wilma", UserEmail = "wilma@bedrock.com" });
            users.Add(new User() { UserId = 4, UserName = "Betty", UserEmail = "betty@bedrock.com" });

            mylistView.ItemsSource = users;
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            User newUser = new User();
            newUser.UserId = 5;
            newUser.UserName = "Pebbles";
            newUser.UserEmail = "pebbles@bedrock.com";

            users.Add(newUser);

            mylistView.ItemsSource = null;
            mylistView.ItemsSource = users;
        }
    }
}
