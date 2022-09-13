using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lapicera
{
    class Pluma
    {
        private string marca;
        private Tinta tinta;
        private int cantidad;

        public Pluma()
        {
            this.marca = "sin marca";
            this.tinta = null;
            this.cantidad = 1;
        }

        public Pluma(string marca) : this()
        {
            this.marca = marca;
        }

        public Pluma(string marca, Tinta tinta) : this(marca)
        {
            this.tinta = tinta;
        }

        public Pluma(string marca, Tinta tinta, int cantidad) : this(marca, tinta)
        {
            this.cantidad = cantidad;
        }

        private string Mostrar()
        {
            return $"marca {this.marca}, cantidad {this.cantidad}, tipo {(string)this.tinta}";
        }

        public static bool operator == (Pluma pluma, Tinta tinta)
        {
            bool esIgual = false;
            if (pluma.tinta == tinta)
            {
                esIgual = true;
            }
            return esIgual;
        }

        public static bool operator !=(Pluma pluma, Tinta tinta)
        {
            bool esDistinto = false;
            if (!(pluma.tinta == tinta))
            {
                esDistinto = true;
            }
            return esDistinto;
        }

        public static Pluma operator +(Pluma pluma, Tinta tinta)
        {
            if(pluma == tinta)
            {
                pluma.cantidad++;
            }
            return pluma;
        }

        public static Pluma operator -(Pluma pluma, Tinta tinta)
        {
            if (pluma == tinta)
            {
                pluma.cantidad--;
            }
            return pluma;
        }

        public static implicit operator string(Pluma pluma)
        {
            return pluma.Mostrar();
        }
    }
}
