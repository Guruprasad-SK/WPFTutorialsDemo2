﻿using System;
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
    /// Interaction logic for MenuExample.xaml
    /// </summary>
    public partial class MenuExample : Window
    {
        public MenuExample()
        {
            InitializeComponent();
        }

        private void MenuItem_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show($"You clicked on file menu item","File Menu");
        }
    }
}
