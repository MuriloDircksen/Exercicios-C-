using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex6
{
    internal class Retangulo
    {
        private double _altura;
        public double Altura {
            get { return _altura; } 
            set {
                if(value<0) _altura = 0;
                else _altura = value;
            } 
        }
        private double _largura;
        public double Largura
        {
            get { return _largura; }
            set
            {
                if (value < 0) _largura = 0;
                else _largura = value;
            }
        }

        public double CalculaArea()
        {
            return _largura*_altura;
        }
    }
}
