using DesignPatterns.Factory.Factory.Interfaces.Model;

namespace DesignPatterns.Factory.Factory.Interfaces.Operacao;

public abstract class ICorreio
{
    public abstract ITransporte FactoryMethod();

    public string InformacaoTransporte()
    {
        var transporte = FactoryMethod();

        return $"A logistica foi feita atravez de: {transporte.TipoTransporte()}";
    }

}
