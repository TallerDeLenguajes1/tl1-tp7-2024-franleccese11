// using EspacioCalculadora;
// Console.WriteLine("Hello, World!");
// Calculadora calculadora1 = new Calculadora();
// int menu = 0;
// string cadMenu;
// do
// {
//     do
//     {
//         Console.WriteLine("*/*/* MENU CALCULADORA*/*/*");
//         Console.WriteLine("ingrese 0 para salir");
//         Console.WriteLine("ingrese 1 para realizar una suma");
//         Console.WriteLine("ingrese 2 para realizar una resta");
//         Console.WriteLine("ingrese 3 para realizar una multiplicacion");
//         Console.WriteLine("ingrese 4 para realizar una division");
//         Console.WriteLine("ingrese 5 para reiniciar la calculadora");
//         cadMenu = Console.ReadLine();

//     } while (!int.TryParse(cadMenu,out menu));
//     if (menu !=0)
//     {
//         string cadOperador ="";
//         double operador=0;
//         switch (menu)
//         {
//             case 1:
//                 do
//                 {
//                     Console.WriteLine("ingrese cuanto sumara");
//                     cadOperador = Console.ReadLine();

//                 } while (!double.TryParse(cadOperador,out operador));
//                 calculadora1.Sumar(operador);
//             break;
//             case 2:
//                 do
//                     {
//                         Console.WriteLine("ingrese cuanto restara");
//                         cadOperador = Console.ReadLine();

//                     } while (!double.TryParse(cadOperador,out operador));
//                 calculadora1.restar(operador);
//             break;

//             case 3:
//                 do
//                     {
//                         Console.WriteLine("ingrese por cuanto multiplicara");
//                         cadOperador = Console.ReadLine();

//                     } while (!double.TryParse(cadOperador,out operador));
//                 calculadora1.multiplicar(operador);
//             break;

//             case 4:
//                 do
//                     {
//                         Console.WriteLine("ingrese por cuanto multiplicara");
//                         cadOperador = Console.ReadLine();

//                     } while (!double.TryParse(cadOperador,out operador));
//                 calculadora1.dividir(operador);
//             break;

//             default:
//                 Console.WriteLine("numero ingresado no valido");
//             break;
//         }
//     Console.WriteLine($"el resultado es: {calculadora1.Resultado}");
//     }

// } while (menu !=0);




// Punto 2
 using Empresa;
 Console.WriteLine("*/*/*carga de empleados*/*/*");
 Empleado[] empleados = new Empleado[3];
 int j=1;
 for (int i = 0; i <empleados.Length; i++)
 {
    Console.WriteLine("--------------------------------");
    Console.WriteLine("EMPLEADO NUMERO "+ j+":");
    Console.WriteLine("ingrese su nombre");
    string nombre = Console.ReadLine();
    Console.WriteLine("ingrese su apellido");
    string apellido = Console.ReadLine();
    string cadenaNacimiento;
    DateTime fechaNacimiento;
    string cadenaIngreso;
    DateTime fechaIngreso;

    do
    {
        Console.WriteLine("ingrese la fecha de nacimiento (formato: dd/MM/yyyy):");
         cadenaNacimiento = Console.ReadLine();
    } while (!DateTime.TryParse(cadenaNacimiento,out fechaNacimiento));

    do
    {
        Console.WriteLine("ingrese la fecha de ingreso a la empresa (formato: dd/MM/yyyy):");
         cadenaIngreso = Console.ReadLine();
    } while (!DateTime.TryParse(cadenaIngreso,out fechaIngreso));

    string cadenaCivil;
    char estadoCivil='o';
    do
    {
       Console.WriteLine("ingrese el estado civil('c' para casado o 's' para soltero )");
       cadenaCivil = Console.ReadLine();
        
       if (cadenaCivil.Length ==1)
       {
            cadenaCivil = cadenaCivil.ToLower();
            estadoCivil = cadenaCivil[0];
       } else
       {
            Console.WriteLine("ingreso un estado civil no valido,por favor vuelva a ingresar un valor:('c' para casado o 's' para soltero)");
       }
    } while (cadenaCivil.Length !=1);

    string cadenaSueldo;
    double sueldoBasico;
    bool bandera;
    do
    {
        Console.WriteLine("ingrese el sueldo basico del empleado:");
        cadenaSueldo = Console.ReadLine();
         bandera = double.TryParse(cadenaSueldo,out sueldoBasico);
        if (!bandera)
        {
            Console.WriteLine("sueldo basico ingresado no valido por favor ingrese el monto nuevamente");
        }
    } while (!bandera);
    string cadenaCargo = "";
    bandera = false;
    Cargos empleo;
    do
    {
        Console.WriteLine("ingrese el cargo del empleado: (Auxiliar, Administrativo, Ingeniero, Especialista,Investigador");
        cadenaCargo = Console.ReadLine();
        if (Enum.TryParse(cadenaCargo,true,out empleo)&&Enum.IsDefined(typeof(Empresa.Cargos),empleo))
        {
            bandera = true;
        }else
        {
            Console.WriteLine("cargo ingresado no valido");
        }

    } while (!bandera);
    
    // public Empleado(string Nombre, string Apellido, DateTime fechaDeNacimiento,char EstadoCivil,double SueldoBasico,DateTime FechaIngreso,Cargos Cargos,DateTime now)
    Empleado empleado = new Empleado(nombre,apellido
    ,fechaNacimiento,estadoCivil,sueldoBasico,fechaIngreso,empleo);
    empleados[i] = empleado;

    j++;
    
 }
double montoTotal=0;
int maxedad= 0;
int k=0;
 for (int i = 0; i < empleados.Length; i++)
 {
    Console.WriteLine(empleados[i].MostrarEmpleado());
    Console.WriteLine("-----------------------------------");
    montoTotal = montoTotal + empleados[i].Salario;
    if (empleados[i].Edad1>maxedad)
    {
      k=i;
      maxedad=empleados[i].Edad1;  
    }
 }
 if(k>0)
 {
    Console.WriteLine("El empleado mas cercano a jubilarse es:");
    Console.WriteLine(empleados[k].MostrarEmpleadoMasViejo());
 }

 