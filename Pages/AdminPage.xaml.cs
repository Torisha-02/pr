using System;
using System.Collections.Generic;
using System.Data.Entity;
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
using WpfApp1.Entities;

namespace WpfApp1.Pages
{
    /// <summary>
    /// Логика взаимодействия для MainPage.xaml
    /// </summary>
    public partial class MainPage : Page
    {
        public Users _currentUser;
        public practiceEntities _context;

        public MainPage(Users user)
        {
            InitializeComponent();
            _currentUser = user;
            LoadUser();
            LoadEmployee();

        }
        public void LoadUser() //pfuheprf .pthjd
        {
            
            using (var context = new practiceEntities()) //connect with our bdshka
            {
                
              //we r creating new peremennyu
              var users = from u in context.Users // we come in to the table users 
                            join r in context.Roles on u.RoleId equals r.Id_Role // go to the table role and find id_role that equelse with roleId 
                            select new // here we choose things that we need( like login and  name of role/ we make it cause we want to see name of id, not id of the role.
                            {
                                u.RoleId,       
                                u.Login,
                             
                                RoleName = r.Name 
                            };


                
                UsersDataGrid.ItemsSource = users.ToList();
             
              
            }
        }

        public void LoadEmployee() //pfuheprf hf,jnybrjd 
        {
            using (var context = new practiceEntities())
            {
                var Employees = context.Employees.ToList();
                EmployeeDG.ItemsSource = Employees;

            }
        }
        
       
        private void BtnAdd_Click(object sender, RoutedEventArgs e)
        {

        }

        private void BtnDel_Click(object sender, RoutedEventArgs e)
        {
            if (UsersDataGrid.SelectedItems is Users user)
            {
                _context.Users.Remove(user); 
                _context.SaveChanges();
                LoadUser();
            }
        }
    }
}
