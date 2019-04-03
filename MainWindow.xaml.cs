//David Laughton
//April 4th 2019
//Waterloo comuter problems
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

namespace _312576j1Problems
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

        private void btnInput_Click(object sender, RoutedEventArgs e)
        {
            //intput
            int H = 0;
            int.TryParse(numInput.Text, out H);
            string output = "";

            for (int i = 0; i < H; i++)
            {
                //first part

                int numbAstericks = (H / 2 - (int)Math.Abs(H / 2 - i)) * 2 + 1;

                //output the asteriks
                for (int a = 0; a < numbAstericks; a++)
                {
                    output += "*";
                }


                //spaces
                int s = (int)Math.Abs(2 * H - 2 * (2 * i + 1));
                int countspaces = 0;
                for (int j = 0; j < s; j++)
                {
                    output += " ";
                    countspaces ++;
                }
                // MessageBox.Show(countspaces.ToString());
                //last part
                for (int a = 0; a < numbAstericks; a++)
                {
                    output += "*";
                }
                output += Environment.NewLine;//fix
            }
            //debug:
            lblOutput.Content = output;
            MessageBox.Show(output);
            //pasted into notepad to ensure the formatting was cor
        }
    }
}

