namespace EspacioCalculadora
{
    public class Calculadora
    {
        private double dato;

        public void Sumar(double termino)
        {
            dato = dato + termino;
        }

        public void restar(double termino)
        {
            dato = dato - termino;
        }

        public void multiplicar(double termino)
        {
            dato = dato * termino;
        }

        public void dividir(double termino)
        {
            if (termino !=0)
            {
                dato = dato / termino;
            }else
            {
                Console.WriteLine("la division sobre cero no esta definida");
            }
        }

        public void limpiar()
        {
            dato = 0;
        }

        public double Resultado
        {
            get{return dato;}
        }
    }
}