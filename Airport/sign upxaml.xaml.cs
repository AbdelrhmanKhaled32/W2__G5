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
    /// Interaction logic for sign_upxaml.xaml
    /// </summary>
    public partial class sign_upxaml : Page
    {
        AIRPROTEntities entities=new AIRPROTEntities();
        public sign_upxaml()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            ADMINLOG_ aDMINLOG=new ADMINLOG_();
            aDMINLOG.USERNAME_ = username.Text;
            aDMINLOG.PASSWORD_=password.Text;
            entities.ADMINLOG_.Add(aDMINLOG);
            entities.SaveChanges();
            MessageBox.Show("Sign up successful");
            log_in log_=new log_in();
            this.NavigationService.Navigate(log_);
            username.Text = password.Text = "";
        }
    }
}
