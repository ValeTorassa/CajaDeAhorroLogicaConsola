using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CajadeAhorroyConsola
{
    // La siguiente línea de código define una clase estática llamada "MetodosEstaticos"
    static class MetodosEstaticos
    {
        // El siguiente método es estático porque no es necesario instanciar un objeto de la clase "MetodosEstaticos" para usarlo.
        // Por lo tanto, es estático porque no depende de una instancia particular de la clase
        // puede ser llamado desde cualquier lugar del código sin crear un objeto nuevo.
        public static int ComprobarValor()
        {
            int num = 0;
            bool salir = false;

            // Este bucle "do-while" se ejecuta al menos una vez y se repite hasta que el usuario ingrese un valor válido.
            do
            {
                try
                {
                    Console.WriteLine("Ingrese un valor numerico y positivo");
                    // El siguiente código lee la entrada del usuario y la convierte a un número entero.
                    num = int.Parse(Console.ReadLine());

                    //condicional para asegurar que el numero sea mayor que cero
                    if (num >= 0)
                    {
                        salir = true;
                    }
                    else
                    {
                        Console.WriteLine("No puede ingresar valores negativos");
                    }

                }
                //si el usuario ingresa algo que no pueda transformarse en un valor numerico
                //lanzamos un catch que atrape el error y le permita al usuario volver a ingresarlo
                catch (Exception e)
                {
                    Console.WriteLine("Ha ingresado un valor que no es un numero");
                    Console.WriteLine($"{e.Message}");
                }
            } while (!salir);

            // Devuelve el valor ingresado por el usuario.
            return num;
        }
    }
}
