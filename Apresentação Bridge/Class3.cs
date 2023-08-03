using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Apresentação
{
    public abstract class Forma
    {
        protected ICores cor;
        public Forma(ICores cor)
        {
            this.cor = cor;
        }
        public abstract void Desenhar();
    }
}
