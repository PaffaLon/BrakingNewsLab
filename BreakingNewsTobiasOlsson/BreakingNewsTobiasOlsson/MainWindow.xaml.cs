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

namespace BreakingNewsTobiasOlsson
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void style()
        {
            
        }

        /// <summary>
        /// This method haandles all radio button click events.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void rbtn_Click(object sender, RoutedEventArgs e)
        {

           if(sender == rbtnTrmup)
            { 
                txtResult.Text = ("Trump");
            }
            else if (sender == rbtnEconomy)
            {
                txtResult.Text = ("Ekonomi");
            }
            else if (sender == rbtnCop)
            {
                txtResult.Text = ("polis");
            }
            else if (sender == rbtnSecret)
            {
                txtResult.Text = ("Helig");
            }
            else if (sender == rbtnAftonbladet)
            {
                txtResult.Text = ("Aftonbladet");
            }
            else if (sender == rbtnExpressen)
            {
                txtResult.Text = ("Expressen");
            }
            else if (sender == rbtnDagensNyheter)
            {
                txtResult.Text = ("Dagens nyheter");
            }
        }
    }
}
