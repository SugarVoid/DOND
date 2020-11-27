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

namespace DondWPapp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        private double[] moneyOptions = new double[26]
        {
                1, 2, 5, 10, 25, 50, 75, 100, 200, 300, 400, 500, 750, 1000, 5000, 10000, 25000, 50000, 75000, 100000, 200000, 300000, 400000, 500000, 750000,  1000000
        };

        public MainWindow()
        {
            InitializeComponent();
            SetUpButtons();
            SetUpMoneyLabels();
        }

        private void SetUpButtons()
        {
            Button newBtn = new Button();

            void SetButtonProp(int x)
            {
                newBtn = new Button();
                newBtn.Content = x.ToString();
                newBtn.Content = $"{x}";
                newBtn.Margin = new Thickness(0, 2, 0, 2);
                newBtn.Click += Button_Click;
                newBtn.Name = $"btn_case{x}";
            }

          
            for (int i = 1; i < 14; i++)
            {
                SetButtonProp(i);
                sp1.Children.Add(newBtn);
            }

            for (int i = 14; i < 27; i++)
            {
                SetButtonProp(i);
                sp2.Children.Add(newBtn);
            }

        }

        private void SetUpMoneyLabels()
        {
            Label newLbl = new Label();


            foreach(double x in moneyOptions)
            {
                //newLbl.Content = x.ToString();
                //newLbl.Name = $"lbl_{x.ToString()}";
                //spDollarAmount.Children.Add(newLbl);
            }

            
        }

        void Button_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            // use Name or Tag of button
            MessageBox.Show(button.Name);
        }
    }
}
