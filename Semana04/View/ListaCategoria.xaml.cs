using Semana04.ViewModel;
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
using System.Windows.Shapes;

namespace Semana04.View
{
    public partial class ListaCategoria : Window
    {
        ListaViewModel viewModel;
        public ListaCategoria()
        {
            InitializeComponent();
            viewModel = new ListaViewModel();
            this.DataContext = viewModel;
        }
    }
}
