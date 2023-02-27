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
using System.Windows.Shapes;

namespace ApplicationOne
{
    /// <summary>
    /// Логика взаимодействия для MainMenuAdministrator.xaml
    /// </summary>
    public partial class MainMenuAdministrator : Window
    {
        public List<Offices> officeList { get; set; }
        public List<Users> usersList { get; set; }
        public List<Roles> rolesList { get; set; }
        public MainMenuAdministrator()
        {
            InitializeComponent();
            ProgressDataInDB();
            this.DataContext = this;
        }

        public void ProgressDataInDB()
        {
            using (var db = new SessionEntities())
            {
                officeList = db.Offices.ToList();
                usersList = db.Users.ToList();
                rolesList = db.Roles.ToList();
            }
        }

        private void SortOffice_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            try
            {
                Offices selectedOffices = SortOffice.SelectedItem as Offices;
                if (selectedOffices == null) return;
                usersList = usersList.Where(p => p.Offices.Title == selectedOffices.Title).ToList();
                MainDataGrid.ItemsSource = usersList;
                ProgressDataInDB();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void GoWindowAddUser_Click(object sender, RoutedEventArgs e)
        {
            AddNewUser addNewUser = new AddNewUser();
            if (addNewUser.ShowDialog() == true) return;
        }

        private void MainDataGrid_LoadingRow(object sender, DataGridRowEventArgs e)
        {
            var row = e.Row;
            var oneUser = row.DataContext as Users;
            if (oneUser == null) return;
            if(oneUser.Active != true)
            {
                row.Background = new SolidColorBrush(Colors.Red);
            }
        }

        private void ChangeRoleButton_Click(object sender, RoutedEventArgs e)
        {
            Users users = MainDataGrid.SelectedItem as Users;
            if (users == null)
                MessageBox.Show("Выберите пользователя для редактирования", Title = "Ошибка");
            EditProfileUser editProfileUser = new EditProfileUser(users);
            if(editProfileUser.ShowDialog() == true)
                ProgressDataInDB();
        }

        private void EnableDisableLogin_Click(object sender, RoutedEventArgs e)
        {
            Users users = MainDataGrid.SelectedItem as Users;
            if(users == null)
                MessageBox.Show("Выберите пользователя для редактирования", Title = "Ошибка");
            SessionEntities.GetContext().Users.Where(p => p.ID == users.ID).FirstOrDefault().Active = false;
            SessionEntities.GetContext().SaveChanges();
            ProgressDataInDB();
        }
    }
}
