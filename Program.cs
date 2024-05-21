// See https://aka.ms/new-console-template for more information
using EspacioCalculadora;
Calculadora Micalculadora = new Calculadora();
int opcion = 1;
while (opcion != 0)
{
    Console.WriteLine("/----------------CALCULADORA----------------/");
    Console.WriteLine($"VALOR INICIALIZADO = {Micalculadora.Resultado}");
    Console.WriteLine("1- Sumar");
    Console.WriteLine("2- Restar");
    Console.WriteLine("3- Multiplicar");
    Console.WriteLine("4- Dividir");
    Console.WriteLine("5- Limpiar");
    Console.WriteLine("6- Cerrar Programa");
    Console.WriteLine("Ingresar Opcion:");
    int opcion2 = 0;
    if (int.TryParse(Console.ReadLine(), out int menu))
        {
            switch (menu)
            {
                case 1:
                Console.WriteLine("Introducir numero que va a sumar");
                do
                {
                    if (double.TryParse(Console.ReadLine(),out double Value))
                    {
                        Micalculadora.Sumar(Value);
                        opcion2 = 1;
                    }else
                    {
                        Console.WriteLine("Linea no Valida, volver a ingresar una opcion");
                    }
                } while (opcion2 == 0);
                break;
                case 2:
                Console.WriteLine("Introducir numero que va a restar");
                do
                {
                    if (double.TryParse(Console.ReadLine(),out double Value))
                    {
                        Micalculadora.Restar(Value);

                        opcion2 = 1;
                    }else
                    {
                        Console.WriteLine("Linea no Valida, ingresar una opcion");
                    }
                } while (opcion2 == 0);           
                break;
                case 3:
                Console.WriteLine("Introducir numero que va a multiplicar");
                do
                {
                    if (double.TryParse(Console.ReadLine(),out  double Value))
                    {
                        Micalculadora.Multiplicar(Value);
                        opcion2 = 1;
                    }else
                    {
                        Console.WriteLine("Linea no Valida, ingresar un numero");
                    }
                } while (opcion2 == 0);
                break;
                case 4:
                Console.WriteLine("Introducir numero va a dividir");
                do
                {
                    if (double.TryParse(Console.ReadLine(),out double Value))
                    {
                        Micalculadora.dividir(Value);
                        opcion2 = 1;
                    }else
                    {
                        Console.WriteLine("Linea no Valida, ingresar un numero");
                    } 
                } while (opcion2 == 0);
                break;
                case 5:;
                        Micalculadora.limpiar();

                break;
                case 6:
                    opcion = 0;
                break;                                                                                
            }
        }else{
            Console.WriteLine("Linea no Valida, ingresar un numero entre (1 - 6)");
        }
}
