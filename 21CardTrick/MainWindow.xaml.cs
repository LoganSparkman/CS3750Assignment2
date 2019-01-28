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

namespace _21CardTrick
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        string currentState = "Waiting For Card to be chosen";
        public MainWindow()
        {
            InitializeComponent();
            //Init 21 Cards
            //Get 21 Cards and connect to image boxes
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            if (currentState == "Waiting For Card to be chosen")
            {
                //Change instructions to ask for column
                //Update classes
                currentState = "Waiting for column 1";
            }
            else if (currentState == "Waiting for column 1")
            {
                //Update classes
                //Redeal cards
                currentState = "Waiting for column 2";
            }
            else if (currentState == "Waiting for column 2")
            {
                //Update classes
                //Redeal cards
                currentState = "Waiting for column 3";
            }
            else if (currentState == "Waiting for column 3")
            {
                //Update classes
                //show final card
                //turn submit into close
                
            }
        }
    }
}
