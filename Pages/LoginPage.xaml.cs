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
using WpfApp1.Entities;
using WpfApp1.Pages;



namespace WpfApp1.Pages
{
    /// <summary>
    /// Логика взаимодействия для LoginPage.xaml
    /// </summary>
    public partial class LoginPage : Page
    {
        public LoginPage()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            using (var db = new practiceEntities())
            { 
                string login = loginBox.Text;
                string password =PasswordBox.Password;
                var user = db.Users
                .FirstOrDefault(u => u.Login==login && u.PasswordHash ==password);
           if(user==null)
                {
                    MessageBox.Show("Неверный логин и пароль!кхм");
                    return;
                }
           
                MessageBox.Show($"Добро пожаловать! Роль: {user.Roles.Name}");
            }
        }
    }
}
