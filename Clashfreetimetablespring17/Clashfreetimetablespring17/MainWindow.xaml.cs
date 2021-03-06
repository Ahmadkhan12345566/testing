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
using System.Windows.Navigation;
using System.Windows.Shapes;


namespace Clashfreetimetablespring17
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
     
        private void Label_MouseDown(object sender, MouseButtonEventArgs e)
        {
            Label lblFrom = e.Source as Label;
          

            if (e.LeftButton == MouseButtonState.Pressed)
                DragDrop.DoDragDrop(lblFrom, lblFrom.Content, DragDropEffects.Copy);
        }

        private void Label_QueryContinueDrag(object sender, QueryContinueDragEventArgs e)
        {
            Label lblFrom = e.Source as Label;

            if (!e.KeyStates.HasFlag(DragDropKeyStates.LeftMouseButton))
                lblFrom.Content = "RED";

        }

        private void Label_Drop(object sender, DragEventArgs e)
        {
            string draggedText = (string)e.Data.GetData(DataFormats.StringFormat);

            Label toLabel = e.Source as Label;
            toLabel.Content = draggedText;
        }
    }
}
