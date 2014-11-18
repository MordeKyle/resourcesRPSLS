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
using gameLibrary;

namespace buttonRPSLS
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        int userChoice = -1;

        //TODO: Reference the display outcome in the library to get the outcome status below
        static string win = "You Win!";
        static string lose = "You Lose!";
        static string draw = "It's a Draw!";

        public MainWindow()
        {
            InitializeComponent();
            //userChoiceLabel.Text = String.Empty; //empties label
            computerChoiceLabel.Content = String.Empty; //empties label
            resultLabel.Content = String.Empty; //empties label
            //label2.Text = String.Empty; //empties label
            RPSLS results = new RPSLS();
            winsLabel.Content = results.readResults(win).ToString(); //prints past wins
            losesLabel.Content = results.readResults(lose).ToString(); //prints past loses
            drawsLabel.Content = results.readResults(draw).ToString(); //prints past draws
            //TODO: With results file available, add initial display of past results here.
        }

        private void rockButton_Click(object sender, RoutedEventArgs e)
        {

        }

        private void paperButton_Click(object sender, RoutedEventArgs e)
        {

        }

        private void scissorsButton_Click(object sender, RoutedEventArgs e)
        {

        }

        private void lizardButton_Click(object sender, RoutedEventArgs e)
        {

        }

        private void spockButton_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
