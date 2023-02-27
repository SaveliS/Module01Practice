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

namespace ApplicationOne
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        int couter = 0;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void loginButton_Click(object sender, RoutedEventArgs e)
        {
            var user = SessionEntities.GetContext().Users.Where(p => p.Email == loginBox.Text && p.Password == passwordBox.Password).FirstOrDefault();
            var enableUser = SessionEntities.GetContext().Users.Where(p => p.Active == true);
            if (user != null && enableUser != null)
            {
                MainMenuAdministrator mainMenuAdministrator = new MainMenuAdministrator();
                mainMenuAdministrator.Show();
                this.Close();
            }
            else
            {
                couter++;
                MessageBox.Show("Неправильный логин или пароль!" + couter);
            }

            if (couter == 3)
            {
                loginBox.IsEnabled = false;
                passwordBox.IsEnabled = false;
                loginButton.IsEnabled = false;
            }
        }

        private void exitButton_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}
