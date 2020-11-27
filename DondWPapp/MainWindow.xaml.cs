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
        public MainWindow()
        {
            InitializeComponent();
            SetUpButtons();
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


        void Button_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            // use Name or Tag of button
            MessageBox.Show(button.Name);
        }
    }
}
