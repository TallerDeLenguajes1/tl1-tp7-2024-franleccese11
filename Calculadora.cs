// namespace EspacioCalculadora
// {
//     public class Calculadora
//     {
//         public Calculadora()
//         {
//             dato = 0;
//         }
//         private double dato;

//         public void Sumar(double termino)
//         {
//             dato = dato + termino;
//         }

//         public void restar(double termino)
//         {
//             dato = dato - termino;
//         }

//         public void multiplicar(double termino)
//         {
//             dato = dato * termino;
//         }

//         public void dividir(double termino)
//         {
//             if (termino !=0)
//             {
//                 dato = dato / termino;
//             }else
//             {
//                 Console.WriteLine("la division sobre cero no esta definida");
//             }
//         }

//         public void limpiar()
//         {
//             dato = 0;
//         }

//         public double Resultado
//         {
//             get{return dato;}
//         }
//     }
// }



// Punto 2

namespace Empresa
{ 
    public class Empleado
    {
        private string nombre;
        private string apellido;
        private char estadoCivil;
        private double sueldoBasico;
        private DateTime fechaNacimiento;
        private DateTime fechaIngreso;
        private Cargos cargos;
        
        private int edad;
        private double salario;

        public double Salario { get => salario; }
        public int Edad1 { get => edad;}

        public Empleado(string Nombre, string Apellido, DateTime fechaDeNacimiento,char EstadoCivil,double SueldoBasico,DateTime FechaIngreso,Cargos Cargos)
        {
            nombre = Nombre;
            apellido = Apellido;
            fechaNacimiento = fechaDeNacimiento;
            estadoCivil = EstadoCivil;
            sueldoBasico = SueldoBasico;
            fechaIngreso = FechaIngreso;
            cargos = Cargos;
            double adicional = Calc_adicional();
            salario = sueldoBasico + adicional;
            edad = Edad();
        }

        public double Calc_adicional()
        {
            int antiguedad = CalcularAntiguedad();
            double adicional;
            if (antiguedad < 1)
            {
                return(adicional = 0);
            }else
            {
                if (antiguedad <20)
                {
                    adicional = sueldoBasico * antiguedad * 0.01;
                } else
                {
                    adicional = sueldoBasico * 0.25;
                }
            }
            if (cargos == Cargos.Ingeniero || cargos== Cargos.Especialista)
            {
                adicional = adicional * 1.5;
            }

            if(estadoCivil == 'c')
            {
                adicional = adicional + 150.000;
            }
            return(adicional);
        }


        public int CalcularAntiguedad()
        {
            DateTime hoy = DateTime.Now;
            int antiguedad = hoy.Year - fechaIngreso.Year;
            if (hoy < fechaIngreso.AddYears(antiguedad))
            {
                antiguedad--;
            }
            return antiguedad;
        }

        public int Edad()
        {
            DateTime hoy = DateTime.Now;
            int edad = hoy.Year - fechaNacimiento.Year;
            if (hoy<fechaNacimiento.AddYears(edad))
            {
                edad--;
            }
            return edad;
        }

        public int Jubilacion()
        {
            int vividos = Edad();
            int Faltan = 65-vividos;
            return Faltan;
        }
        public string NombreCompleto()
        {
            return apellido + ", " + nombre;
        }
        public string MostrarEmpleado()
        {
            return NombreCompleto() + "|| edad:"+ Edad1 + "|| estado civil:"+ estadoCivil+"\n" + "empleo:"+cargos+"|| Antiguedad: " +CalcularAntiguedad(); 
        }

        public string MostrarEmpleadoMasViejo()
        {
            return NombreCompleto() + " ||Edad:"+Edad1+" ||antiguedad:"+CalcularAntiguedad()+" ||Le faltan "+ Jubilacion() + " para jubilarse "; 
        }
    }
}