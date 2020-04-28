using Data;
using Entity;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Business
{
    public class BCategoria
    {
        private DCategoria DCategoria = null;

        public List<Categoria> Listar(int IdCategoria)
        {
            List<Categoria> categorias = null;
            try
            {
                DCategoria = new DCategoria();
                categorias = DCategoria.Listar(new Categoria { IdCategoria = IdCategoria });
            }
            catch(Exception ex)
            {
                throw ex;
            }
            return categorias;
        }

        public bool Insert(Categoria categoria)
        {
            bool result = true;
            int maxId = 0;
            try
            {
                DCategoria = new DCategoria();
                maxId  = DCategoria.maxIdCategoria();
                categoria.IdCategoria = maxId + 1;
                DCategoria.Insertar(categoria);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return result;
        } 

        public bool Actualizar(Categoria categoria)
        {
            bool result = true;
            try
            {
                DCategoria = new DCategoria();
                DCategoria.Actualizar(categoria);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return result;
        } 
        
        
        public bool Eliminar(int IdCategoria)
        {
            bool result = true;
            try
            {
                DCategoria = new DCategoria();
                DCategoria.Eliminar(IdCategoria);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return result;
        }


    }
}
