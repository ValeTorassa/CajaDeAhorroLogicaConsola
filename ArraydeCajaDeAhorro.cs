using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CajadeAhorroyConsola
{
    class ArrayDeCajasDeAhorro
    {
        // Declaración de atributos privados
        private CajaDeAhorro[] _array;
        private int _contador;


        // Constructor que recibe el tamaño del array y lo inicializa
        public ArrayDeCajasDeAhorro(int size)
        {
            _array = new CajaDeAhorro[size];
            _contador = 0;
        }


        // Método que muestra la información de una CajaDeAhorro
        public void MostrarCajaDeAhorro()
        {
            int buscar;

            Console.WriteLine("Busqueda de Numero de cuenta");

            // Pide al usuario que ingrese un número de cuenta a buscar
            buscar = MetodosEstaticos.ComprobarValor();

            // Recorre el array buscando una CajaDeAhorro con el número de cuenta ingresado
            for (int i = 0; i < _contador; i++)
            {
                if (_array[i].NumeroCuenta == buscar)
                {
                    Console.WriteLine("El usuario ha sido encontrado con éxito, sus datos son los siguientes:");
                    _array[i].MostrarInformacion();
                    return;
                }
            }

            Console.WriteLine("No se ha encontrado la cuenta asociado al numero de cuenta");
        }


        // Método que crea una nueva CajaDeAhorro y la agrega al array
        public void CrearCajadeAhorro()
        {
            //si el array todavia tiene posiciones disponibles
            if (_contador < _array.Length)
            {
                // Declaración de variables
                Random Aleatorio = new Random();
                string nombre, tipomoneda;
                int saldo, numeroCuenta;

                Console.WriteLine("Creacion de caja de ahorro");

                //se almacenan todos los inputs en variables
                Console.WriteLine("Escriba el nombre del titular de la cuenta:");
                nombre = Console.ReadLine();

                Console.WriteLine("Ingrese el Tipo de moneda");
                tipomoneda = Console.ReadLine();

                Console.WriteLine("Ingrese su saldo incial");
                saldo = MetodosEstaticos.ComprobarValor();

                // Genera un número de cuenta aleatorio
                numeroCuenta = Aleatorio.Next(1, 500);

                Console.WriteLine("El numero de cuenta es " + numeroCuenta);

                //se cargan las variables en un constructor de la clase CajaDeAhorro
                //y posteriormente se almacenan en una posicion del array
                _array[_contador] = new CajaDeAhorro(numeroCuenta, nombre, saldo, tipomoneda); ;

                //el contador se aumenta para que la proxima instanciacion se almacene en la proxima posicion
                _contador++;
            }
            //en caso de que el array de CajasDeaAhorro este completo
            else
            {
                Console.WriteLine("No se pueden agregar más cajas de ahorro al arreglo");
            }

        }

        // Método que deposita un valor en una CajaDeAhorro
        public void DepositarEnCuenta()
        {
            int buscar, deposito;

            Console.WriteLine("Deposito en cuenta");

            // Pide al usuario que ingrese un número de cuenta a buscar
            buscar = MetodosEstaticos.ComprobarValor();

            // Recorre el array buscando una CajaDeAhorro con el número de cuenta ingresado
            for (int i = 0; i < _array.Length; i++)
            {

                // si la caja de ahorro en la posición i no es nula y su número de cuenta coincide con el buscado
                if (_array[i] != null && buscar == _array[i].NumeroCuenta)
                {
                    Console.WriteLine("El usuario ha sido encontrado con éxito, su saldo actual es de: " + _array[i].Saldo);

                    // se pide la cantidad a depositar
                    Console.WriteLine("Ingrese la cantidad a depositar:");
                    deposito = MetodosEstaticos.ComprobarValor();

                    // se realiza el depósito en la caja de ahorro correspondiente
                    _array[i].Depositar(deposito);

                    // se termina la función
                    return;
                }

                Console.WriteLine("No se ha encontrado la cuenta asociado al numero de cuenta");

            }
        }

        // Método para retirar un valor en una CajaDeAhorro
        public void RetirarDeCuenta()
        {
            int buscar, retiro;

            Console.WriteLine("Retiro en cuenta");

            // Pide al usuario que ingrese un número de cuenta a buscar
            buscar = MetodosEstaticos.ComprobarValor();

            // Recorre el array buscando una CajaDeAhorro con el número de cuenta ingresado
            for (int i = 0; i < _array.Length; i++)
            {
                // si la caja de ahorro en la posición i no es nula y su número de cuenta coincide con el buscado
                if (_array[i] != null && buscar == _array[i].NumeroCuenta)
                {
                    Console.WriteLine("El usuario ha sido encontrado con éxito, su saldo actual es de: " + _array[i].Saldo);

                    // se pide la cantidad a retirar
                    Console.WriteLine("Ingrese la cantidad a depositar:");
                    retiro = MetodosEstaticos.ComprobarValor();

                    // se realiza el retiro en la caja de ahorro correspondiente
                    _array[i].Depositar(retiro);

                    // se termina la función
                    return;
                }

                Console.WriteLine("No se ha encontrado la cuenta asociado al numero de cuenta");

            }
        }

    }
                
}   