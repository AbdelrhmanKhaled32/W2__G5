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

namespace Airport
{
    /// <summary>
    /// Interaction logic for log_in.xaml
    /// </summary>
    public partial class log_in : Page
    {
        AIRPROTEntities entities=new AIRPROTEntities();
        public log_in()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
         
       
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            sign_upxaml sign_=new sign_upxaml();
            this.NavigationService.Navigate(sign_);
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            if (combo.Text == "Admin Flight")
            {
                ADMINLOG_ adminlog=entities.ADMINLOG_.FirstOrDefault(x=>x.USERNAME_==username.Text&&x.PASSWORD_==password.Text);
                if (adminlog == null)
                {
                    MessageBox.Show("invalid");
                }
                else if(adminlog != null)
                {
                    MessageBox.Show("valid");

                    Admin admin = new Admin();
                this.NavigationService.Navigate(admin);
                    username.Text = password.Text = "";
                }
          
            }
            else if (combo.Text == "Admin Passenger")
            {
                ADMINLOG_ adminlog = entities.ADMINLOG_.FirstOrDefault(x => x.USERNAME_ == username.Text && x.PASSWORD_ == password.Text);
                if (adminlog == null)
                {
                    MessageBox.Show("invalid");
                }
                else if (adminlog != null)
                {
                    MessageBox.Show("valid");

                    adminpassenger adminpassenger = new adminpassenger();
                    this.NavigationService.Navigate(adminpassenger);
                    username.Text = password.Text = "";

                }

            }
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            forgetpassword forgetpassword=new forgetpassword();
            this.NavigationService.Navigate(forgetpassword);
        }
    }
}
