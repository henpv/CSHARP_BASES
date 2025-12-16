using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TechTransportControl
{
    internal interface ICalculable
    {
        double Calcular();

        string Nombre {  get; }

        string Tipo { get; }
    }
}
