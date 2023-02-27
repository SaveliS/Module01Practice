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
    /// Логика взаимодействия для EditProfileUser.xaml
    /// </summary>
    public partial class EditProfileUser : Window
    {
        public Users Users { get; set; }
        public List<Offices> offices { get; set; }
        public EditProfileUser(Users user)
        {
            InitializeComponent();
            offices = SessionEntities.GetContext().Offices.ToList();
            this.Users = user;
            this.DataContext = Users;

        }

        private void CancelChangeUser_Click(object sender, RoutedEventArgs e)
        {
            this.DialogResult = true;
        }

        private void ApplyChangeUser_Click(object sender, RoutedEventArgs e)
        {
            if (AdminRole.IsChecked == true)
            {
                var currentUser = SessionEntities.GetContext().Users.Where(p => p.ID == Users.ID).FirstOrDefault();
                currentUser.Roles = SessionEntities.GetContext().Roles.Where(p => p.ID == 1).FirstOrDefault();
                currentUser = Users;
                SessionEntities.GetContext().SaveChanges();
                this.DialogResult = true;
            }
        }
    }
}
