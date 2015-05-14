using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using MicroMVVM.Expence.Daily;
using System.Configuration;

namespace ExpenceBook
{
    /// <summary>
    /// Interaction logic for IndividualTypeView.xaml
    /// </summary>
    public partial class IndividualTypeView : UserControl
    {
        public IndividualTypeView()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            string transactionType = ComboBox1.Text;

            List<DailyExpence> lstDailyExpence = new List<DailyExpence>();

            string loginId = ConfigurationManager.AppSettings["loginUserId"];

            lstDailyExpence = DailyExpence.IndividualSort(loginId, transactionType);

            lvDailyExpence.DataContext = lstDailyExpence;
        }

    }
}
