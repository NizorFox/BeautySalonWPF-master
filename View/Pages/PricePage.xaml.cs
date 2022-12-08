﻿using BeautySalonWPF.Controllers;
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

namespace BeautySalonWPF.View.Pages
{
    /// <summary>
    /// Логика взаимодействия для PricePage.xaml
    /// </summary>
    public partial class PricePage : Page
    {
        public PricePage(int idCategory)
        {
            InitializeComponent();
            ServiceList_View.ItemsSource = ServicesController.GetServices(idCategory);
            TitleTextBlock.Text = ServiceCategoryesClass.GetInfoCategoryes(idCategory).CategoryTitle;
        }
    }
}
