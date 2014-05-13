﻿using BriceLambson.ImageResizer.Properties;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace BriceLambson.ImageResizer.Views
{
    /// <summary>
    /// Interaction logic for AdvancedPageView.xaml
    /// </summary>
    public partial class AdvancedPageView : Window
    {
        public AdvancedPageView()
        {
            InitializeComponent();
            
            ListBox_Choose.SelectedIndex = 0;
            ListBox_Choose.Focus();
            ListBoxItem_Selected(null,null);

            // Set value
            QualityValue.Content = AdvancedSettings.Default.QualityLevel + "%";
            QualitySlider.Value = AdvancedSettings.Default.QualityLevel;
            
            // Handlers
            QualitySlider.ValueChanged += Slider_ValueChanged;
            ListBox_Choose.SelectionChanged += ListBoxItem_Selected;
            Save_Btn.Click += Save_Click;
            Cancel_Btn.Click += Cancel_Click;
        }

        private void Slider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            QualityValue.Content = Convert.ToInt32(QualitySlider.Value) + "%";      
        }

        private void Save_Click(object sender, RoutedEventArgs e)
        {
            AdvancedSettings.Default.QualityLevel = Convert.ToInt32(QualitySlider.Value);      
            AdvancedSettings.Default.Save();
            this.Close();
        }

        private void Cancel_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void ListBoxItem_Selected(object sender, RoutedEventArgs e)
        {
            switch (ListBox_Choose.SelectedIndex)
            {
                case 0:  
                    QualityListView.Visibility = Visibility.Visible;
                    FilenameListView.Visibility = Visibility.Hidden;
                    MetadataListView.Visibility = Visibility.Hidden;
                    break;
                case 1:
                    QualityListView.Visibility = Visibility.Hidden;
                    FilenameListView.Visibility = Visibility.Visible;
                    MetadataListView.Visibility = Visibility.Hidden;
                    break;
                case 2:
                    QualityListView.Visibility = Visibility.Hidden;
                    FilenameListView.Visibility = Visibility.Hidden;
                    MetadataListView.Visibility = Visibility.Visible;
                    break;
            }
        }

    }
}
