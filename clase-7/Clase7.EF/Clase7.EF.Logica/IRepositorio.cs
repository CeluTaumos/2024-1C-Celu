using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase7.EF.Logica
{
    public interface IRepositorio<T>
    {
       
        void Agregar(T obj);
    
    }
}
