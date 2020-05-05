using Entity;
using Semana04.View;
using System;
using System.Collections.ObjectModel;
using System.Web.UI.MobileControls;
using System.Windows;
using System.Windows.Input;

namespace Semana04.ViewModel
{
    public class ListaViewModel : ViewModelBase
    {
        private readonly static ListaViewModel _instance = new ListaViewModel();
        public static ListaViewModel Instance
        {
            get
            {
                return _instance;
            }
        }

        public Categoria _SelectedCategoria;
        public Categoria SelectedCategoria
        {
            get { return _SelectedCategoria; }
            set
            {
                if (_SelectedCategoria != value)
                {
                    _SelectedCategoria = value;


                    if (_SelectedCategoria != null)
                    {
                        ManCategoria window = new ManCategoria(_SelectedCategoria);
                        window.ShowDialog();
                    }

                    OnPropertyChanged();
                }
            }
        }


        //public ObservableCollection<Categoria> Categorias { get; set; }
        public ObservableCollection<Categoria> _Categorias;
        public ObservableCollection<Categoria> Categorias
        {
            get { return _Categorias; }
            set
            {
                if (Categorias != value)
                {
                    _Categorias = value;
                    OnPropertyChanged();
                }
            }
        }
        public ICommand NuevoCommand { set; get; }
        public ICommand ConsultarCommand { set; get; }

        public ListaViewModel()
        {

            Categorias = new Model.CategoriaModel().Categorias;
            NuevoCommand = new RelayCommand<Window>(param => Abrir());
            ConsultarCommand = new RelayCommand<object>(
                o => { Categorias = (new Model.CategoriaModel()).Categorias; }
            );
            void Abrir()
            {
                View.ManCategoria window = new View.ManCategoria(new Categoria());
                window.ShowDialog();
            }

        }

        
    }
}
