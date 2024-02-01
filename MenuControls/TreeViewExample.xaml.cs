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
    /// Interaction logic for TreeViewExample.xaml
    /// </summary>
    public partial class TreeViewExample : Window
    {
        public TreeViewExample()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            TreeViewItem item = new TreeViewItem();
            item.Header=txtTreeSet.Text;
            FruitTreeSet.Items.Add(item);
        }

        
    }
}
