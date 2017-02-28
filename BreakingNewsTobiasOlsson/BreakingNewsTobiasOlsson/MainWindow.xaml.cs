using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
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
using WebHandler;

using BreakingNewsTobiasOlsson.Classes;

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

        /// <summary>
        /// This method haandles all radio button click events.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void rbtn_Click(object sender, RoutedEventArgs e)
        {
            #region NewsPaperSearchOptions
            if (sender == rbtnTrmup)
            {
                GlobalVariabels.SerchCriteria = ("Donald Trump");
            }
            else if (sender == rbtnEconomy)
            {
                GlobalVariabels.SerchCriteria = ("Ekonomi");
            }
            else if (sender == rbtnCop)
            {
                GlobalVariabels.SerchCriteria = ("Polis");
            }
            else if (sender == rbtnSecret)
            {
                GlobalVariabels.SerchCriteria = ("Hemligt");
            }
            #endregion NewsPaperSearchOptions
            #region NewsPapers
            else if (sender == rbtnAftonbladet)
            {
                GlobalVariabels.Url = ("https://www.aftonbladet.se");
            }
            else if (sender == rbtnExpressen)
            {
                GlobalVariabels.Url = ("https://www.expressen.se/");
            }
            else if (sender == rbtnDagensNyheter)
            {
                GlobalVariabels.Url = ("https://www.dn.se/");
            }
            #endregion NewsPapers
        }

        private async void btnStatitics_Click(object sender, RoutedEventArgs e)
        {
            if (GlobalVariabels.SerchCriteria != ("") & GlobalVariabels.Url != (""))
            {
                MyWebHandler ToWebHandler = new MyWebHandler();
                var res = await Task.Run(() => ToWebHandler.UpdateGUI(GlobalVariabels.Url, GlobalVariabels.SerchCriteria));

                txtResult.Text = res.ToString();
            }
            #region else if
            else if ((GlobalVariabels.SerchCriteria == ("")) & (GlobalVariabels.Url != ("")))
            {
                MessageBoxResult result = MessageBox.Show("No search criteria was selected, would you like to visit \r" + GlobalVariabels.Url,  "", MessageBoxButton.YesNo, MessageBoxImage.Question);
                #region MessageBoxResult.Yes
                if (result == MessageBoxResult.Yes)
                {
                    switch (GlobalVariabels.Url)
                    {
                        case ("http://www.aftonbladet.se"):

                            System.Diagnostics.Process.Start("http://www.aftonbladet.se");
                            break;

                        case ("http://www.expressen.se/"):

                            System.Diagnostics.Process.Start("http://www.expressen.se/");
                            break;

                        case ("http://www.dn.se/"):

                            System.Diagnostics.Process.Start("http://www.dn.se/");
                            break;
                    }
                }
                #endregion MessageBoxResult
                else
                {

                }
            }
            else if (GlobalVariabels.SerchCriteria + GlobalVariabels.SerchCriteria == (""))
            {
                MessageBoxResult result = MessageBox.Show("empty");
            }
            else if ((GlobalVariabels.SerchCriteria != ("") & (GlobalVariabels.Url == (""))))
            {

            }
            #endregion else if
            // System.Diagnostics.Process.Start(url);
        }

        private void txtResult_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (string.IsNullOrEmpty(txtResult.Text.ToString()))
            {
                txtResult.Background = Brushes.Red;
            }
            else
            {
                txtResult.Background = Brushes.Gainsboro;
            }
        }

        private void txtResult_TextInput(object sender, TextCompositionEventArgs e)
        {
            lblStatusBarNr.Content = GlobalVariabels.StatusBarNr;
        }
    }
}