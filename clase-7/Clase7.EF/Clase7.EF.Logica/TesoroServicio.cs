using Clase7.EF.Data.Entidades;
using Microsoft.EntityFrameworkCore;

namespace Clase7.EF.Logica
{
   
        public interface ITesoroServicio : IRepositorio<Tesoro>
        {
           
        List<Tesoro> ObtenerTodos();
    }

        public class TesoroServicio : ITesoroServicio
        {
            private readonly Pw32cIslaTesoroContext _context;

            public TesoroServicio(Pw32cIslaTesoroContext context)
            {
                this._context = context;
            }

            public void Agregar(Tesoro tesoro)
            {
                this._context.Tesoros.Add(tesoro);
                this._context.SaveChanges();
            }
            public List<Tesoro> ObtenerTodos()
            {
                return this._context.Tesoros.ToList();
            }

           
            

            
    }
}
