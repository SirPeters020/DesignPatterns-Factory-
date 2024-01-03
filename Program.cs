using DesignPatterns.Factory.Factory.Implementation.Model;
using DesignPatterns.Factory.Factory.Implementation.Operacao;
using DesignPatterns.Factory.Factory.Interfaces.Model;
using DesignPatterns.Factory.Factory.Interfaces.Operacao;

namespace DesignPatterns.Factory;

public class Program
{
    static void Main(string[] args)
    {
        //Console.WriteLine("Hello, World!");
        new Logistica().Main();
    }

}

public class Logistica
{
    public void Main()
    {
        Console.WriteLine("Iniciando Logistica Aerea");
        InformacoesTransporte(new CorreioAerio());

        Console.WriteLine("");

        Console.WriteLine("Iniciando Logistica Terreste");
        InformacoesTransporte(new CorreioTerreste());

        Console.WriteLine("");

        Console.WriteLine("Iniciando Logistica Ferroviario");
        InformacoesTransporte(new CorreioFerroviario());

    }


    public void InformacoesTransporte(ICorreio correio)
    {
        Console.WriteLine(correio.InformacaoTransporte());
    }
}
