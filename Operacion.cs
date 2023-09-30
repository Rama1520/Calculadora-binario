namespace Entidades
{
    public class Operacion
    {
        private Numeracion primerOperando;
        private Numeracion segundoOperando;

        public Operacion(Numeracion primeroOperando, Numeracion segundoOperando)
        {
            this.primerOperando = primeroOperando;
            this.segundoOperando = segundoOperando;
        }

        public Numeracion PrimeroOperando
        {
            get { return primerOperando; }
            set { primerOperando = value; }
        }

        public Numeracion SegundoOperando
        {
            get { return segundoOperando; }
            set { segundoOperando = value; }
        }



        public Numeracion Operar(char operador)
        {
            double resultado = 0.0;
            switch (operador)
            {
                case '+':
                    resultado = this.primerOperando + this.segundoOperando;
                    break;
                case '-':
                    resultado = this.primerOperando - this.segundoOperando;
                    break;
                case '*':
                    resultado = this.primerOperando * this.segundoOperando;
                    break;
                case '/':
                    try
                    { resultado = this.primerOperando / this.segundoOperando; }
                    catch
                    {
                        throw new DivideByZeroException("No se puede dividir por cero.");
                    }
                    break;
                default:
                    throw new ArgumentException("Operador no válido.");
            }
            return new Numeracion(resultado.ToString() , eSistema.Decimal);
        }
    }
}