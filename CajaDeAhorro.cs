using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace CajadeAhorroyConsola
{
    class CajaDeAhorro
    {
        //Propiedades Publicas de los atributos privados
        public int NumeroCuenta { get { return _numeroCuenta; } }
        public string Titular { get { return _titular; } set { _titular = value; } }
        public int Saldo { get { return _saldo; } set { _saldo = value; } }
        public string TipoMoneda { get { return _tipoMoneda; } set { _tipoMoneda = value; } }



        // El constructor inicializa las propiedades NumeroCuenta, Titular, Saldo y TipoMoneda con los valores que recibe como parámetros
        public CajaDeAhorro(int numcuenta, string titular, int saldo, string tipomoneda)
        {
            _numeroCuenta = numcuenta;
            _titular = titular;
            _saldo = saldo;
            _tipoMoneda = tipomoneda;          
        }


        // El método MostrarInformacion muestra en consola la información de los atributos de la caja de ahorro
        public void MostrarInformacion()
        {
            Console.WriteLine($"Titular: {Titular}, Saldo Actual: {Saldo}, tipo de moneda: {TipoMoneda}, Numero de cuenta: {NumeroCuenta} {Environment.NewLine}");
        }


        // El método Depositar recibe una cantidad de dinero como parámetro, la agrega al saldo de la cuenta 
        //y muestra en consola el saldo actualizado
        public void Depositar(int cantidad)
        {
                _saldo += cantidad;
                Console.WriteLine($"Se ha depositado {cantidad} {TipoMoneda}. Saldo actual: {Saldo} {TipoMoneda} {Environment.NewLine}");
        }

        // El método Retirar recibe una cantidad de dinero como parámetro,
        // verifica que la cantidad no sea mayor al saldo actual y si no lo es, la resta del saldo
        public void Retirar(int cantidad)
        {
            if (cantidad <= _saldo)
            {
                _saldo -= cantidad;
                Console.WriteLine($"Se ha retirado {cantidad} {TipoMoneda}. Saldo actual: {Saldo} {TipoMoneda} {Environment.NewLine}");
            }
            else
            {
                Console.WriteLine($"No se puede retirar una cantidad mayor al saldo actual {Environment.NewLine}");
            }
        }

        //atributos privados 
        private int _numeroCuenta;
        private string _titular;
        private int _saldo;
        private string _tipoMoneda;
    }
}
