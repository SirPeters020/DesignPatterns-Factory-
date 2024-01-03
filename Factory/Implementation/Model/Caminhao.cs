using DesignPatterns.Factory.Factory.Interfaces.Model;

namespace DesignPatterns.Factory.Factory.Implementation.Model;

public class Caminhao : ITransporte
{
    public string TipoTransporte()
    {
        return "Caminhão";
    }
}
