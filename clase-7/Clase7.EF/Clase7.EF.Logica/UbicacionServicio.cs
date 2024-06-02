using Clase7.EF.Data.Entidades;
using Clase7.EF.Logica;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase7.EF.Logica
{
    public interface IUbicacionServicio : IRepositorio<Ubicacion>
    {
        List<Ubicacion> ObtenerTodos();
    }
  
    public class UbicacionServicio : IUbicacionServicio
    {
        private readonly Pw32cIslaTesoroContext _context;

        public UbicacionServicio(Pw32cIslaTesoroContext context)
        {
            this._context = context;
        }

      

        public void Agregar(Ubicacion ubicacion)
        {
            this._context.Ubicacions.Add(ubicacion);
            this._context.SaveChanges();
        }

     
       

        public List<Ubicacion> ObtenerTodos()
        {
            return this._context.Ubicacions.ToList();
        }

     
    }
}
