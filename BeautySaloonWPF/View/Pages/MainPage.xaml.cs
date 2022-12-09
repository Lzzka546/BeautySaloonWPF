using BeautySaloonWPF.Controllers;
using BeautySaloonWPF.Models;
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

namespace BeautySaloonWPF.View.Pages
{
    /// <summary>
    /// Логика взаимодействия для MainPage.xaml
    /// </summary>
    public partial class MainPage : Page
    {
        int idCategory;
        public MainPage()
        {
            InitializeComponent();
           
            MainListView.ItemsSource = ServiceCategoryesController.GetServiceCategoryes();
        }


        private void Back_Button_Click(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new AuthorizationPage());
        }

        private void LogOutButton_Click(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new AuthorizationPage());
        }

        private void Grid_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            Grid activeGrid =sender as Grid;
            ServiceCategoryes activeServiceCategoryes = activeGrid.DataContext as ServiceCategoryes;
            idCategory = activeServiceCategoryes.CategoryId;
            this.NavigationService.Navigate(new CategoryPage(idCategory));
        }
    }

   
    }
