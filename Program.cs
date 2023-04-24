using System;

namespace CajadeAhorroyConsola
{
    class Program
    {
        static void Main(string[] args)
        {
            // Creamos una instancia de la clase ArrayDeCajasDeAhorro
            ArrayDeCajasDeAhorro array = new ArrayDeCajasDeAhorro(10);
            int op = 1;

            // Mostramos un menú con las diferentes opciones para el usuario
            while (op != 0)
            {
                Console.WriteLine("(1) Si desea Ingresar un nuevo cliente");
                Console.WriteLine("(2) Si desea mostrar datos de una cuenta en concreto");
                Console.WriteLine("(3) Si desea Depositar en su cuenta");
                Console.WriteLine("(4) Si desea retirar dinero de su cuenta");
                Console.WriteLine("(0) Salir");
                Console.WriteLine("Ingrese una opcion del menu");

                // Usamos el método estático ComprobarValor para validar la entrada del usuario
                op = MetodosEstaticos.ComprobarValor();

                // Switch a las opciones del menu
                switch (op)
                {
                    case 0:
                        Console.WriteLine("Gracias por utilizar nuestro sistema");
                        break;
                    case 1:
                        // Instancia de la clase ArrayDeCajasDeAhorro para crear una nuevo objeto CajadeAhorro y añadirlo al array
                        array.CrearCajadeAhorro();
                        break;
                    case 2:
                        // Metodo para mostrar los datos de una cuenta en base a un numero de cuenta
                        array.MostrarCajaDeAhorro();
                        break;
                    case 3:
                        // Metodo para realizar un depósito en una cuenta en base a un numero de cuenta
                        array.DepositarEnCuenta();
                        break;
                    case 4:
                        // Metodo para realizar un retiro en una cuenta en base a un numero de cuenta
                        array.RetirarDeCuenta();
                        break;
                    default:
                        Console.WriteLine("Lo sentimos la opción ingresada no es válida");
                        break;
                }

            }
            Console.ReadKey();
        }
     
    }
}
