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

namespace BreastCancerDiagnosis.App.Views
{
    /// <summary>
    /// Interaction logic for DiagnosisDetailView.xaml
    /// </summary>
    public partial class DiagnosisDetailView : Window
    {
        public DiagnosisDetailView()
        {
            InitializeComponent();
        }
        /*
         public Coffee SelectedCoffee { get; set; }

        public CoffeeDetailView()
        {
            InitializeComponent();

            this.Loaded += CoffeeDetailView_Loaded;
        }

        void CoffeeDetailView_Loaded(object sender, RoutedEventArgs e)
        {
            this.DataContext = SelectedCoffee;
        }

        private void ChangeCoffeeButton_Click(object sender, RoutedEventArgs e)
        {
            SelectedCoffee.CoffeeName = "Something really expensive";
            SelectedCoffee.Price = 10000;

        }

        private void SaveCoffeeButton_Click(object sender, RoutedEventArgs e)
        {
            var c = SelectedCoffee;
        }
         */
    }
}
