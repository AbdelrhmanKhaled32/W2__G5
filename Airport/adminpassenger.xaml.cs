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
    /// Interaction logic for adminpassenger.xaml
    /// </summary>
    public partial class adminpassenger : Page
    {
        AIRPROTEntities entities=new AIRPROTEntities(); 
        public adminpassenger()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            int xx=int.Parse(id.Text);
            dg.ItemsSource = entities.PASSENGER1.Where(x => x.ID_PA == xx).ToList();
        }

        private void Button_Click_1(object sender, object e)
        {
            entities.PASSENGER1.Remove(entities.PASSENGER1.FirstOrDefault(x=>x.ID_PA==int.Parse(id.Text)));
            entities.SaveChanges();
            MessageBox.Show("Remove");
            id.Text = "";
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            var s=int.Parse(id.Text);
          PASSENGER1 pASSENGER1=entities.PASSENGER1.FirstOrDefault(x => x.ID_PA == s);
            if (pASSENGER1 == null)
            {
                MessageBox.Show("Not valid");
            }
            else if(pASSENGER1!=null)
            {
                pASSENGER1.PHONE = int.Parse(phone.Text);
                pASSENGER1.ID_F=int.Parse(flight.Text);
                entities.PASSENGER1.AddOrUpdate(pASSENGER1);
                entities.SaveChanges();
                MessageBox.Show("Update");
                phone.Text = flight.Text =id.Text = "";
            }
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            dg.ItemsSource = entities.PASSENGER1.ToList();
        }
    }
}
