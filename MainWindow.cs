using System;
using System.Collections.Generic;
using System.IO;
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

namespace János_Vitéz
{
    ///<summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window

    {

     //   string[] JanosVitezSor;
        public MainWindow()
            
        {
            InitializeComponent();
        }

                                         
        private void btnBetolt_Click(object sender, RoutedEventArgs e)
            {
                 StreamReader sr = new StreamReader("JánosVitéz.txt", encoding:Encoding.UTF8);

                 while (!sr.EndOfStream)
                 {
                     lbEredeti.Items.Add(sr.ReadLine()); 
                 }
                 sr.Close();       
             }
        /* 
                {
                    JanosVitezSor = File.ReadAllLines("JánosVitéz.txt");


                    for (int sorIndex = 0; sorIndex < JanosVitezSor.Length; sorIndex++)
                    {
                        lbEredeti.Items.Add(JanosVitezSor[sorIndex]);
                    }
                }
        */
        




        private void btnValogat_Click(object sender, RoutedEventArgs e)
        {
            if (txtSzoveg.Text=="")
            {
                MessageBox.Show("Nem található szöveg.");
                return;
            }
            if (lbEredeti.Items.Count ==0)
            {
                MessageBox.Show("Nincs mit elemzni.");
                return;
            }
        }
     //   private void txtSzoveg(object sender, RoutedEventArgs e)    

    }
}
