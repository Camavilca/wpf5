using Entity;
using System;
using System.Collections.ObjectModel;
using System.Web.UI.MobileControls;
using System.Windows;
using System.Windows.Input;

namespace Semana04.ViewModel
{
    public class ListaViewModel : ViewModelBase
    {
        public ObservableCollection<Categoria> Categorias { get; set; }
        public ICommand NuevoCommand { set; get; }
        public ICommand ConsultarCommand { set; get; }


        private ICommand _detalleCategoria;
        public ICommand DetalleCategoria =>
         _detalleCategoria ?? (_detalleCategoria = new RelayCommand<Window>(x => {
            var response = x;
        }));

        public void MyFuncion()
        {

        }


        public ListaViewModel()
        {

            Categorias = new Model.CategoriaModel().Categorias;
            NuevoCommand = new RelayCommand<Window>(param => Abrir());
            ConsultarCommand = new RelayCommand<object>(
                o => { Categorias = (new Model.CategoriaModel()).Categorias; }
            );
            //DetalleCategoria = new RelayCommand<Window>(
            //    o => { System.Console.WriteLine(o); }
            //);
            void Abrir()
            {
                View.ManCategoria window = new View.ManCategoria();
                window.ShowDialog();
            }

        }

        
    }
}
