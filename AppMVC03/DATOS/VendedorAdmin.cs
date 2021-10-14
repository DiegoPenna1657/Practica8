using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using AppMVC03.Models;

namespace AppMVC03.Datos
{
    public class VendedorAdmin
    {
        public IEnumerable<VENDEDOR> Consultar()
        {
            using (VENTASEntities1 contexto = new VENTASEntities1())
            {
                return contexto.VENDEDOR.AsNoTracking().ToList();
            }
        }
        public VENDEDOR Consultar(int id)
        {
            using (VENTASEntities1 contexto = new VENTASEntities1())
            {
                return contexto.VENDEDOR.AsNoTracking().FirstOrDefault(c =>
               c.CodVendedor == id);
            }
        }
        public void Guardar(VENDEDOR modelo)
        {
            using (VENTASEntities1 contexto = new VENTASEntities1())
            {
                contexto.VENDEDOR.Add(modelo);
                contexto.SaveChanges();
            }
        }
        public void Modificar(VENDEDOR modelo)
        {
            using (VENTASEntities1 contexto = new VENTASEntities1())
            {
                contexto.Entry(modelo).State =
               System.Data.Entity.EntityState.Modified;
                contexto.SaveChanges();
            }
        }
        public void Eliminar(VENDEDOR modelo)
        {
            using (VENTASEntities1 contexto = new VENTASEntities1())
            {
                contexto.Entry(modelo).State =
               System.Data.Entity.EntityState.Deleted;
                contexto.SaveChanges();
            }
        }
    }
}