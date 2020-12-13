using System;
using System.Windows;
using System.Windows.Documents;

namespace AETCC
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Calculate_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                string route = new TextRange(InRoute.Document.ContentStart, InRoute.Document.ContentEnd).Text;
                string aircraft = new TextRange(InAircraft.Document.ContentStart, InAircraft.Document.ContentEnd).Text;
                double raw = (Convert.ToDouble(route) / Convert.ToDouble(aircraft)) * 7;

                raw = Math.Ceiling(raw);

                Out.Text = raw.ToString();
            }
            catch (System.FormatException)
            {
                Out.Text = "Check #'s";
            }
        }
    }
}
