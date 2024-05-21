using EspacioCalculadora;
Console.WriteLine("Hello, World!");
Calculadora calculadora1 = new Calculadora();
int menu = 0;
calculadora1.limpiar();
string cadMenu;
do
{
    do
    {
        Console.WriteLine("*/*/* MENU CALCULADORA*/*/*");
        Console.WriteLine("ingrese 0 para salir");
        Console.WriteLine("ingrese 1 para realizar una suma");
        Console.WriteLine("ingrese 2 para realizar una resta");
        Console.WriteLine("ingrese 3 para realizar una multiplicacion");
        Console.WriteLine("ingrese 4 para realizar una division");
        cadMenu = Console.ReadLine();

    } while (!int.TryParse(cadMenu,out menu));
    if (menu !=0)
    {
        string cadOperador ="";
        double operador=0;
        switch (menu)
        {
            case 1:
                do
                {
                    Console.WriteLine("ingrese cuanto sumara");
                    cadOperador = Console.ReadLine();
                    
                } while (!double.TryParse(cadOperador,out operador));
                calculadora1.Sumar(operador);
            break;
            case 2:
                do
                    {
                        Console.WriteLine("ingrese cuanto restara");
                        cadOperador = Console.ReadLine();
                        
                    } while (!double.TryParse(cadOperador,out operador));
                calculadora1.restar(operador);
            break;

            case 3:
                do
                    {
                        Console.WriteLine("ingrese por cuanto multiplicara");
                        cadOperador = Console.ReadLine();
                        
                    } while (!double.TryParse(cadOperador,out operador));
                calculadora1.multiplicar(operador);
            break;

            case 4:
                do
                    {
                        Console.WriteLine("ingrese por cuanto multiplicara");
                        cadOperador = Console.ReadLine();
                        
                    } while (!double.TryParse(cadOperador,out operador));
                calculadora1.dividir(operador);
            break;

            default:
                Console.WriteLine("numero ingresado no valido");
            break;
        }
    Console.WriteLine($"el resultado es: {calculadora1.Resultado}");
    }

} while (menu !=0);


