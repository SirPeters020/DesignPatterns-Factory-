using DesignPatterns.Factory.Factory.Interfaces.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Factory.Factory.Implementation.Model;

public class Aviao : ITransporte
{
    public string TipoTransporte()
    {
        return "Aviao";
    }
}
