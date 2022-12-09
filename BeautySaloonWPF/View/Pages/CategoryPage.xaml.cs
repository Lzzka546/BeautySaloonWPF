
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
    /// Логика взаимодействия для CategoryPage.xaml
    /// </summary>
    public partial class CategoryPage : Page
    {
        public CategoryPage(ServiceCategoryes activeCategoryes)
        {
            InitializeComponent();
            ServiceListView.ItemsSource = ServiceCategoryesController.GetServiceCategoryes();
            ServiceListView.ItemsSource = ServiceController.GetServiceCategoryes(activeCategoryes.CategoryId);
            TitleTextBlock.Text = activeCategoryes.CategoryTitle;
        }
    }
}
