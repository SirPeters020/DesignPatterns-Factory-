using DesignPatterns.Factory.Factory.Implementation.Model;
using DesignPatterns.Factory.Factory.Interfaces.Model;
using DesignPatterns.Factory.Factory.Interfaces.Operacao;

namespace DesignPatterns.Factory.Factory.Implementation.Operacao;

public class CorreioFerroviario : ICorreio
{
    public override ITransporte FactoryMethod()
    {
        return new Trem();
    }
}
