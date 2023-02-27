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
    /// Логика взаимодействия для AddNewUser.xaml
    /// </summary>
    public partial class AddNewUser : Window
    {
        private Users _currentUser = new Users();
        public AddNewUser()
        {
            InitializeComponent();
            DataContext = _currentUser;
            comboboxRole.ItemsSource = SessionEntities.GetContext().Roles.ToList();
            comboboxOffice.ItemsSource = SessionEntities.GetContext().Offices.ToList();
        }

        private void addButton_Click(object sender, RoutedEventArgs e)
        {
            StringBuilder errors = new StringBuilder();

            if (string.IsNullOrWhiteSpace(_currentUser.LastName))
                errors.AppendLine("Укажите Имя");
            if (string.IsNullOrWhiteSpace(_currentUser.FirstName))
                errors.AppendLine("Укажите Фамилию");
            if (string.IsNullOrWhiteSpace(_currentUser.Password))
                errors.AppendLine("Укажите Пароль");
            if (string.IsNullOrWhiteSpace(_currentUser.Email))
                errors.AppendLine("Укажите Почту");
            if (_currentUser.Roles == null)
                errors.AppendLine("Укажите Роль");
            if (_currentUser.Offices == null)
                errors.AppendLine("Укажите Оффис");

            _currentUser.Birthdate = Convert.ToDateTime(selectDate.SelectedDate);
            // MessageBox.Show(Convert.ToDateTime(selectDate.SelectedDate).ToString());
            if (_currentUser.Birthdate == null)
                errors.AppendLine("Укажите Дату рождения");

            _currentUser.Active = true;

            if (errors.Length > 0) { MessageBox.Show(errors.ToString()); return; }

            if (_currentUser.ID == 0) SessionEntities.GetContext().Users.Add(_currentUser);


            try { SessionEntities.GetContext().SaveChanges(); }
            catch (Exception rx)
            { MessageBox.Show(rx.Message.ToString()); }
        }
    }
}
