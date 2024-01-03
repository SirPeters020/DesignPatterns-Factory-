using DesignPatterns.Factory.Factory.Implementation.Model;
using DesignPatterns.Factory.Factory.Interfaces.Model;
using DesignPatterns.Factory.Factory.Interfaces.Operacao;

namespace DesignPatterns.Factory.Factory.Implementation.Operacao;

public class CorreioTerreste : ICorreio
{
    public override ITransporte FactoryMethod()
    {
        return new Caminhao();
    }
}
