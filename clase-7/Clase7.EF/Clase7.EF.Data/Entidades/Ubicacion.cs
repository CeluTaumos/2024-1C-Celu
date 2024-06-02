using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase7.EF.Data.Entidades
{
    public partial class Ubicacion
    {
        public int Id { get; set; }

        public string Nombre { get; set; } = null!;
    }
}
