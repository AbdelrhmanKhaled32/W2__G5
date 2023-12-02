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
    /// Interaction logic for Admin.xaml
    /// </summary>
    public partial class Admin : Page
    {
        AIRPROTEntities entities=new AIRPROTEntities();
        public Admin()
        {
            InitializeComponent();
            
        }

        private void dg_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void add_Click(object sender, RoutedEventArgs e)
        {
            
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            dg.ItemsSource = entities.FLIGHTS.ToList();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            var s = int.Parse(id.Text);
            entities.FLIGHTS.Remove(entities.FLIGHTS.FirstOrDefault(x => x.ID_F == s));
            entities.SaveChanges();
            MessageBox.Show("Delete");
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            var s = int.Parse(id.Text);
            var ss = int.Parse(planenumber.Text);
            FLIGHT fLIGHT =entities.FLIGHTS.FirstOrDefault(x=>x.ID_F==s);
            if(fLIGHT == null)
            {
                MessageBox.Show("Not valid");
            }
            else if (fLIGHT != null)
            {
                if (ss >= 20 && ss <= 1)
                {
                    MessageBox.Show("This is Plane is Not Valid");
                }
                else
                {
                 fLIGHT.DATE_D =Convert.ToDateTime(reboot.Text);
                fLIGHT.DATE_A=Convert.ToDateTime(arrive.Text);
                fLIGHT.ID_A = int.Parse(planenumber.Text);
                entities.FLIGHTS.AddOrUpdate(fLIGHT);
                entities.SaveChanges();
                MessageBox.Show("Update");
                }
             
            }

        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            int s=int.Parse(planenumber.Text);
        
            if (s > 20 || s < 1)
            {
                MessageBox.Show("This is Plane is Not Valid");
            }
            else if(s <= 20 && s >= 1)
            {
                FLIGHT fLIGHT = new FLIGHT();
                fLIGHT.ID_F = int .Parse(id.Text);
                fLIGHT.DATE_D = Convert.ToDateTime(reboot.Text);
                fLIGHT.DATE_A = Convert.ToDateTime(arrive.Text);
                fLIGHT.ID_A = int.Parse(planenumber.Text);
                entities.FLIGHTS.Add(fLIGHT);
                entities.SaveChanges();
                MessageBox.Show("successful");
            }
        }
    }
}
