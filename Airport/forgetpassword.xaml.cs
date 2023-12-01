using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
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
    /// Interaction logic for forgetpassword.xaml
    /// </summary>
    public partial class forgetpassword : Page
    {
        AIRPROTEntities entities=new AIRPROTEntities();
        public forgetpassword()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            

        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            ADMINLOG_ aDMINLOG_ = entities.ADMINLOG_.FirstOrDefault(x => x.USERNAME_ == username.Text);
            if (aDMINLOG_ == null)
            {
                MessageBox.Show("invalid");
            }
            else if (aDMINLOG_ != null)
            {
                aDMINLOG_.PASSWORD_ = password.Text;
                entities.ADMINLOG_.AddOrUpdate(aDMINLOG_);
                entities.SaveChanges();
                MessageBox.Show("successfully");
            }
        }
    }
}
