﻿using LibraryApp.Models;
using LibraryApp.Services;
using LibraryApp.ViewModels;
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

namespace LibraryApp.Views
{
    /// <summary>
    /// Logique d'interaction pour ReservationView.xaml
    /// </summary>
    public partial class ReservationView : Page
    {
        private readonly ReservationService _reservationservice;
        public ReservationView()
        {
            InitializeComponent();
            DataContext = new ReservationViewModel();
            _reservationservice = new ReservationService(new LibraryDbContext());
        }
    }
}
