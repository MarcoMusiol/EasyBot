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
using wf = System.Windows.Forms;

namespace EasyBot.Views
{
    /// <summary>
    /// Interaktionslogik für CreateMouseAction.xaml
    /// </summary>
    public partial class CreateMouseActionWindow : Window
    {
        public CreateMouseActionWindow()
        {
            InitializeComponent();

            Label_X_Value.Content = 0;
            Label_Y_Value.Content = 0;
        }

        private void Button_Create_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Button_SetLocation_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
