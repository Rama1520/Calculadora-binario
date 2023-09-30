namespace Entidades
{
    public class Numeracion
    {
        private eSistema sistema;
        private double valorNumerico;

        public Numeracion(string valor, eSistema sistema)
        {
            InicializarValores(valor, sistema);
        }

        private void InicializarValores(string valor, eSistema sistema)
        {
            switch (sistema)
            {
                case eSistema.Binario:
                    this.valorNumerico = BinarioDecimal(valor);
                    break;
                case eSistema.Decimal:
                    this.valorNumerico = double.Parse(DecimalBinario(valor));
                    break;
                default:
                    this.valorNumerico = double.MinValue;
                    break;
            }
        }

        public string ConvertirA(eSistema sistema)
        {
            if (sistema == eSistema.Binario )
                return DecimalBinario(this.ValorNumerico);
            else
                return ValorNumerico;
        }

        public string ValorNumerico
        {
            get { return valorNumerico.ToString(); }
        }

        private bool EsBinario(string valor)
        {
            foreach (char c in valor)
            {
                if (c != '0' || c != '1')
                {
                    return false;
                }
                else
                {
                    return true;
                }
            }
            return true;
        }

        private double BinarioDecimal(string valor)
        {
            if (!EsBinario(valor))
                return 0;

            double decimalValue = 0;
            int length = valor.Length;

            for (int i = 0; i < length; i++)
            {
                int bit = int.Parse(valor[i].ToString());
                decimalValue += bit * Math.Pow(2, length - 1 - i);
            }

            return decimalValue;
        }

        private string DecimalBinario(int valor)
        {
            if (valor < 0)
                return "Número inválido";

            int parteEntera = (int)Math.Abs(valor);
            string binario = Convert.ToString(parteEntera, 2);
            return binario;
        }
        private string DecimalBinario(string valor)
        {
            if (int.TryParse(valor, out int valor2))
            {
                int parteEntera = (int)Math.Abs(valor2);
                string binario = Convert.ToString(parteEntera, 2);
                return binario;
            }
            else if (valor2 < 0)
            {

                return "Número inválido";

            }
            else
            {
                return "numero invalido";
            }
        }
        public static bool operator !=(eSistema sistema, Numeracion numeracion)
        {
            return numeracion.sistema != sistema;
        }
        public static bool operator ==(eSistema sistema, Numeracion numeracion)
        {
            return numeracion.sistema == sistema;
        }
        public static bool operator !=(Numeracion n1, Numeracion n2)
        {
            return n1.sistema != n2.sistema; 
        }
        public static bool operator ==(Numeracion n1, Numeracion n2)
        {
            return n1.sistema == n2.sistema; 
        }
        public static double operator +(Numeracion n1,Numeracion n2)
        {
            return n1 + n2; 
        }
        public static double operator -(Numeracion n1, Numeracion n2)
        {
            return n1 - n2;
        }
        public static double operator /(Numeracion n1, Numeracion n2)
        {
            return n1 / n2;
        }
        public static double operator *(Numeracion n1, Numeracion n2)
        {
            return n1 * n2;
        }
    }
    public enum eSistema
    {
        Binario,
        Decimal
    }
}

