using Business;
using Entity;
using System.Collections.Generic;
using System.Windows;

namespace Semana04
{
    public partial class MainWindow : Window
    {
        public int ID { get; set; }
        public MainWindow(int id=0)
        {
            InitializeComponent();
            ID = id;
            if (ID > 0)
            {
                BCategoria bcategoria = new BCategoria();
                List<Categoria> categorias = new List<Categoria>();
                categorias = bcategoria.Listar(ID);
                if (categorias.Count > 0)
                {
                    txtId.Content = categorias[0].IdCategoria;
                    txtNombre.Text = categorias[0].NombreCategoria;
                    txtDescripcion.Text = categorias[0].Descripcion;
                }
            }
        }




        private void BntGrabar_Click(object sender, RoutedEventArgs e)
        {
            BCategoria bCategoria = null;
            bool result = true;
            try
            {
                bCategoria = new BCategoria();
                if (ID > 0)
                {
                    result = bCategoria.Actualizar(new Categoria
                    {
                        IdCategoria = ID,
                        NombreCategoria = txtNombre.Text,
                        Descripcion = txtDescripcion.Text
                    });
                }
                else
                {
                    result = bCategoria.Insert(new Categoria
                    {
                        NombreCategoria = txtNombre.Text,
                        Descripcion = txtDescripcion.Text
                    });
                }
                if (!result)
                {
                    MessageBox.Show("Comunicarse con el Administrador");
                }

                Close();
            }
            finally
            {
                bCategoria = null;
            }
        }

        private void BntCerrar_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void BtnEliminar_Click(object sender, RoutedEventArgs e)
        {
            BCategoria bCategoria = null;
            bool result = true;
            try
            {
                System.Console.WriteLine("ID =>>>>" + ID);
                bCategoria = new BCategoria();
                result = bCategoria.Eliminar(ID);
                if (!result)
                {
                    MessageBox.Show("Comunicarse con el Administrador");
                }

                Close();
            }
            finally
            {
                bCategoria = null;
            }
        }
    }
}
