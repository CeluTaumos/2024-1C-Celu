
using Clase7.EF.Data.Entidades;
using Clase7.EF.Logica;
using Clase7.EF.Test.Comun;
using Microsoft.Extensions.DependencyInjection;
using Xunit;


namespace Clase7.EF.Test.Logica;





public class TesoroServicioTest : TestBase
{

    public TesoroServicioTest()
    {

    }

    [Fact]
    public void AgregarTest()
    {
        //Arrange
        Pw32cIslaTesoroContext context = ServiceProvider.GetService<Pw32cIslaTesoroContext>();
        ITesoroServicio tesoroServicio = new TesoroServicio(context);

        var tesoro = new Tesoro()
        {
            Nombre = "Cofre",
            ImagenRuta = "/imagenes/cofre.png",
        };

        //Act
        tesoroServicio.Agregar(tesoro);

        //Assert
        var tesoroEncontrado = context.Tesoros.Find(tesoro.Id);

        Assert.NotNull(tesoroEncontrado);
        Assert.Equal(tesoro.Nombre, tesoroEncontrado.Nombre);
        Assert.Equal(tesoro.ImagenRuta, tesoroEncontrado.ImagenRuta);
        Assert.Equal(1, context.Tesoros.Count());
    }

    
}
