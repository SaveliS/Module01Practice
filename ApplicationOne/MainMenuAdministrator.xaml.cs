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
    }
}
