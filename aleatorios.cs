using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vehiculos
{
    public class aleatorios
    {
        Random _rnd;//objeto capaz de generar un número aleatorio
        int[] _misNumeros;//Tabla de números
        int _cantNumeros;//Cuantos números hay actualmente en la tabla
        int _limite;//Cantidad max de números en la tabla

        //constructor
        /* Cantidad de números que quiere que insertemos
         * ¡NO recomendado!!! -->>>>>>Bucle<<<<<------ hasta ese límite para pedir los números por teclado
         */

        public aleatorios(int limite)
        {
            _limite = limite;//Limite de números
            _rnd = new Random();
            _misNumeros = new int[limite];
            _cantNumeros = 0;

        }
        public void aniadirNumero(int num)
        {
            if (_cantNumeros < _misNumeros.Length)
            {
                _misNumeros[_cantNumeros] = num;
                _cantNumeros++;
            }
        }
        public void eliminarNumero(int num)
        {
            if (_cantNumeros != 0)
            {

                int posicion = -1;
                for (int i = 0; i < _cantNumeros; i++)
                {
                    if (num == _misNumeros[i])
                    {
                        posicion = i;
                    }
                }

                if (posicion == -1)
                {
                    Console.WriteLine("No existe el número");
                }
                else
                {
                    _misNumeros[posicion] = 0;

                    for (int i = posicion; i < _cantNumeros; i++)
                    {
                        _misNumeros[i] = _misNumeros[i + 1];

                    }
                    
                    _cantNumeros--;

                }

            }
        }
  


        public void mostrarNumeros()
        {
            for (int i = 0; i < _cantNumeros; i++)
            {
                Console.WriteLine(_misNumeros[i] + "\n");

            }
        }
     
        public int NumeroAleatorio()
        {
            int num = _rnd.Next(_cantNumeros);
            return num;
        }
        public int NumeroDeLaPosicionPos(int pos)
        {
            int num = _misNumeros[pos];
            return num;
        }
    }
    }

