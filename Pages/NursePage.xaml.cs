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

namespace WpfApp1.Pages
{
    /// <summary>
    /// Логика взаимодействия для NursePage.xaml
    /// </summary>
    public partial class NursePage : Page
    {
        public Users _currentUser;
        public NursePage(Users user)
        {
            InitializeComponent();
            _currentUser = user;
        }
    }
}
