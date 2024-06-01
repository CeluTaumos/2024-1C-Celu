using System;
using System.Collections.Generic;

namespace Clase7.EF.Data.Entidades;

public partial class Tesoro
{
    public int Id { get; set; }

    public string Nombre { get; set; } = null!;

    public string? ImagenRuta { get; set; }
}
