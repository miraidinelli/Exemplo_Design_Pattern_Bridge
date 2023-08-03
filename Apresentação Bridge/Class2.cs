using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Apresentação
{
    public class CorVermelho : ICores
    {
        public void AplicarCores()
        {
            Console.WriteLine("Aplicando a cor vermelha.");
        }
    }

    public class CorAzul : ICores
    {
        public void AplicarCores()
        {
            Console.WriteLine("Aplicando a cor azul.");
        }
    }
}
