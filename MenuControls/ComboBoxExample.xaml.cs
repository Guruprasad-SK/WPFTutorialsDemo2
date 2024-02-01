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

namespace MenuControls
{
    /// <summary>
    /// Interaction logic for ComboBoxExample.xaml
    /// </summary>
    public partial class ComboBoxExample : Window
    {
        public ComboBoxExample()
        {
            InitializeComponent();
        }

        private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            MessageBox.Show("Yo seletes" + " " + Comb1.SelectedItem.ToString());
        }
    }
}
