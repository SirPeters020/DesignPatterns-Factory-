using DesignPatterns.Factory.Factory.Interfaces.Model;

namespace DesignPatterns.Factory.Factory.Implementation.Model;

public class Trem : ITransporte
{
    public string TipoTransporte()
    {
        return "Trem";
    }
}
