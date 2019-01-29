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
using System.Windows.Shapes;

namespace _21CardTrick
{
    /// <summary>
    /// Interaction logic for Window1.xaml
    /// </summary>
    public partial class gameBoard : Window
    {

        Dealer dealer;
        string currentState = "Waiting For Card to be chosen";
        string currentColumn = "";
        public gameBoard()
        {
            InitializeComponent();
            dealer = new Dealer();
            dealer.deal();
            updateCards();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            if (currentState == "Waiting For Card to be chosen")
            {
                HeaderLabel1.Content = "Alright, now please click on what collumn your card is in. You should what collumn you picked at the bottom of the screen.";
                dealer.player.pickCard();
                currentState = "Waiting for column 1";
            }
            else if (currentState == "Waiting for column 1")
            {
                if ((string)lblCurrentCollumn.Content != "")
                {
                    if (currentColumn == "1") { dealer.player.indicateColumn(0); }
                    if (currentColumn == "2") { dealer.player.indicateColumn(1); }
                    if (currentColumn == "3") { dealer.player.indicateColumn(2); }
                    dealer.pickupCards();
                    dealer.deal();
                    updateCards();
                    currentColumn = "";
                    lblCurrentCollumn.Content = "";
                    HeaderLabel1.Content = "Alright, now please click on what collumn your card is in again.";
                    currentState = "Waiting for column 2";
                }
            }
            else if (currentState == "Waiting for column 2")
            {
                if ((string)lblCurrentCollumn.Content != "")
                {
                    if (currentColumn == "1") { dealer.player.indicateColumn(0); }
                    if (currentColumn == "2") { dealer.player.indicateColumn(1); }
                    if (currentColumn == "3") { dealer.player.indicateColumn(2); }
                    dealer.pickupCards();
                    dealer.deal();
                    updateCards();
                    currentColumn = "";
                    lblCurrentCollumn.Content = "";
                    HeaderLabel1.Content = "Alright, now please click on what collumn your card is in again.";
                    currentState = "Waiting for column 3";
                }
            }
            else if (currentState == "Waiting for column 3")
            {
                if ((string)lblCurrentCollumn.Content != "")
                {
                    if (currentColumn == "1") { dealer.player.indicateColumn(0); }
                    if (currentColumn == "2") { dealer.player.indicateColumn(1); }
                    if (currentColumn == "3") { dealer.player.indicateColumn(2); }
                    dealer.pickupCards();
                    dealer.deal();
                    updateCards();
                    HeaderLabel1.Content = "Is this your Card?";
                    currentColumn = "";
                    lblCurrentCollumn.Content = "";
                    currentState = "quit";
                    btnSumbit.Content = "Yes";
                    column1R1.Opacity = 0;
                    column1R2.Opacity = 0;
                    column1R3.Opacity = 0;
                    column1R4.Opacity = 0;
                    column1R5.Opacity = 0;
                    column1R6.Opacity = 0;
                    column1R7.Opacity = 0;
                    column2R1.Opacity = 0;
                    column2R2.Opacity = 0;
                    column2R3.Opacity = 0;
                    //column2Re;
                    column2R5.Opacity = 0;
                    column2R6.Opacity = 0;
                    column2R7.Opacity = 0;
                    column3R1.Opacity = 0;
                    column3R2.Opacity = 0;
                    column3R3.Opacity = 0;
                    column3R4.Opacity = 0;
                    column3R5.Opacity = 0;
                    column3R6.Opacity = 0;
                    column3R7.Opacity = 0;
                    //Update classes
                    //show final card
                    //turn submit into close
                }
               
                
            }
            else if (currentState == "quit")
            {
                this.Close();
            }
        }

        private void updateCards()
        {
            BitmapImage image = new BitmapImage(new Uri(dealer.board.columns[0].cards[0].getImage(), UriKind.Relative));
            column1R1.Source = image;
            image = new BitmapImage(new Uri(dealer.board.columns[0].cards[1].getImage(), UriKind.Relative));
            column1R2.Source = image;
            image = new BitmapImage(new Uri(dealer.board.columns[0].cards[2].getImage(), UriKind.Relative));
            column1R3.Source = image;
            image = new BitmapImage(new Uri(dealer.board.columns[0].cards[3].getImage(), UriKind.Relative));
            column1R4.Source = image;
            image = new BitmapImage(new Uri(dealer.board.columns[0].cards[4].getImage(), UriKind.Relative));
            column1R5.Source = image;
            image = new BitmapImage(new Uri(dealer.board.columns[0].cards[5].getImage(), UriKind.Relative));
            column1R6.Source = image;
            image = new BitmapImage(new Uri(dealer.board.columns[0].cards[6].getImage(), UriKind.Relative));
            column1R7.Source = image;

            image = new BitmapImage(new Uri(dealer.board.columns[1].cards[0].getImage(), UriKind.Relative));
            column2R1.Source = image;
            image = new BitmapImage(new Uri(dealer.board.columns[1].cards[1].getImage(), UriKind.Relative));
            column2R2.Source = image;
            image = new BitmapImage(new Uri(dealer.board.columns[1].cards[2].getImage(), UriKind.Relative));
            column2R3.Source = image;
            image = new BitmapImage(new Uri(dealer.board.columns[1].cards[3].getImage(), UriKind.Relative));
            column2R4.Source = image;
            image = new BitmapImage(new Uri(dealer.board.columns[1].cards[4].getImage(), UriKind.Relative));
            column2R5.Source = image;
            image = new BitmapImage(new Uri(dealer.board.columns[1].cards[5].getImage(), UriKind.Relative));
            column2R6.Source = image;
            image = new BitmapImage(new Uri(dealer.board.columns[1].cards[6].getImage(), UriKind.Relative));
            column2R7.Source = image;

            image = new BitmapImage(new Uri(dealer.board.columns[2].cards[0].getImage(), UriKind.Relative));
            column3R1.Source = image;
            image = new BitmapImage(new Uri(dealer.board.columns[2].cards[1].getImage(), UriKind.Relative));
            column3R2.Source = image;
            image = new BitmapImage(new Uri(dealer.board.columns[2].cards[2].getImage(), UriKind.Relative));
            column3R3.Source = image;
            image = new BitmapImage(new Uri(dealer.board.columns[2].cards[3].getImage(), UriKind.Relative));
            column3R4.Source = image;
            image = new BitmapImage(new Uri(dealer.board.columns[2].cards[4].getImage(), UriKind.Relative));
            column3R5.Source = image;
            image = new BitmapImage(new Uri(dealer.board.columns[2].cards[5].getImage(), UriKind.Relative));
            column3R6.Source = image;
            image = new BitmapImage(new Uri(dealer.board.columns[2].cards[6].getImage(), UriKind.Relative));
            column3R7.Source = image;


        }

        private void DataGrid_MouseDown(object sender, MouseButtonEventArgs e)
        {
            lblCurrentCollumn.Content = "Current Column = 1";
            currentColumn = "1";
        }

        private void DataGrid_MouseDown_1(object sender, MouseButtonEventArgs e)
        {
            lblCurrentCollumn.Content = "Current Column = 2";
            currentColumn = "2";
        }

        private void DataGrid_MouseDown_2(object sender, MouseButtonEventArgs e)
        {
            lblCurrentCollumn.Content = "Current Column = 3";
            currentColumn = "3";
        }
    }
}

