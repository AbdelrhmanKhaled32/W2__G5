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
    /// Interaction logic for passenger.xaml
    /// </summary>
    public partial class passenger : Page
    {
        AIRPROTEntities entities=new AIRPROTEntities();
        public passenger()
        {
            InitializeComponent();
            dg.ItemsSource = entities.FLIGHTS.ToList();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            int ee=int.Parse(flighttxt.Text);
            FLIGHT lIGHT = entities.FLIGHTS.FirstOrDefault(x => x.ID_F == ee);
            if (lIGHT == null)
            {
                MessageBox.Show("invalid");

            }
            else if (lIGHT != null)
            {
                int y = int.Parse(phonee.Text);
                PASSENGER1 aSSENGER1 = new PASSENGER1();
                aSSENGER1.NAME_ = name.Text;
                aSSENGER1.GENDER=gender.Text;
                aSSENGER1.ID_F = ee;
                aSSENGER1.PHONE = y;
                aSSENGER1.AGE = int.Parse(age.Text);
                entities.PASSENGER1.Add(aSSENGER1);
                entities.SaveChanges();
                MessageBox.Show("successful");
            }
        }

        private void Button_Click(object sender, object e)
        {

        }
    }
}
