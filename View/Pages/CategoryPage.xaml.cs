using BeautySalonWPF.Controllers;
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
    /// Логика взаимодействия для StartPage.xaml
    /// </summary>
    public partial class StartPage : Page
    {
        int idCategory;
        public StartPage()
        {
            InitializeComponent();
            ServiceList_View.ItemsSource= ServiceCategoryesClass.GetServiceCategoryes();
        }

        private void Grid_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            Grid activeCategory = sender as Grid;
            ServiceCategoryes activeData = activeCategory.DataContext as ServiceCategoryes;
            idCategory = activeData.CategoryId;
            this.NavigationService.Navigate(new PricePage(idCategory));
        }
    }
}
