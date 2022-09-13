using System;

namespace Lapicera
{
    public class Tinta
    {
        private ConsoleColor color;
        private ETipoTinta tipo;

        // constructores //
        public Tinta()
        {
            this.color = ConsoleColor.Black;
            this.tipo = ETipoTinta.Comun;
        }

        public Tinta(ETipoTinta tipo):this()
        {
            this.tipo = tipo;
        }

        public Tinta(ETipoTinta tipo, ConsoleColor color):this(tipo)
        {
            this.color = color;
        }

        //----------------//

        private string Mostrar()
        {
            return (string)this;
        }

        public string Mostrar(Tinta tinta)
        {
            return tinta.Mostrar();
        }


        // sobre carga operadores //

        public static bool operator == (Tinta t1, Tinta t2)
        {
            bool esIgual = false;
            if((t1.tipo == t2.tipo) && (t1.color == t2.color))
            {
                esIgual = true;
            }
            return esIgual; 
        }

        public static bool operator !=(Tinta t1, Tinta t2)
        {
            bool esDistinto = false;
            if (!((t1.tipo == t2.tipo) && (t1.color == t2.color)))
            {
                esDistinto = true;
            }
            return esDistinto;
        }

        public static explicit operator string(Tinta tinta)
        {
            return $"Tipo{tinta.tipo}, Color{tinta.color}";
        }
    }
}
