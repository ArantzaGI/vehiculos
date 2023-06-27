using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Reflection;
using System.Text.RegularExpressions;

namespace vehiculos
{
     class Program
    {
        
        public void escribirEnFichero() {
           
            String contenido = "Erase una vez un principito....";
            File.WriteAllText("miFicherito.txt", contenido);


        }
        static void menuNumero() {
            int opc = 0;
            int num = 0;
            int numBuscar = 0;
            int numAlea = 0;
            aleatorios numeros = new aleatorios(20);//sin evolucionar
            do
            {
                System.Console.WriteLine("¿Qué quieres hacer? \n 1)Añadir número \n 2)Mostrar números\n 3)vaciar número \n 4) Eliminar número\n 5)Mostrar aleatorio 0) Salir");
                opc = int.Parse(System.Console.ReadLine());
                switch (opc)
                {
                    case 1:
                        System.Console.WriteLine("Inserta un número:");
                        num = int.Parse(System.Console.ReadLine());
                        numeros.aniadirNumero(num);
                        System.Console.WriteLine("Añadido! ;)\n");
                        break;
                    case 2:
                        System.Console.WriteLine("vamos a mostrar los número\n");
                        numeros.mostrarNumeros();
                        break;
                    case 3:
                        System.Console.WriteLine("Vaciemos los números:\n");

                        System.Console.WriteLine("números reseteados! ;)\n");
                        break;
                    case 4:
                        System.Console.WriteLine("¿Qué número queremos eliminar?\n");
                        numBuscar = int.Parse(System.Console.ReadLine());

                        numeros.eliminarNumero(numBuscar);
                        System.Console.WriteLine("Eliminado! ;)");
                        break;
                    case 5:
                        System.Console.WriteLine("Creamos una pos aleatoria\n");
                        numAlea=numeros.NumeroAleatorio();
                        System.Console.WriteLine("El número que está en la tabla en la posición: " + numAlea + "es: " + numeros.NumeroDeLaPosicionPos(numAlea));
                        numBuscar = int.Parse(System.Console.ReadLine());

                      
                        break;

                    case 0:
                        System.Console.WriteLine("Hasta luego Mari Carmen! ;)\n");
                        break;
                    default: break;

                }

            } while (opc != 0);
        }

        static void Main(string[] args)
        {
            int id;
            String marca;
            String modelo;
            int km;
            double precio;
            int opc=1; // opción del menú
            concesionario cs=new concesionario(15);

            do
            {
                System.Console.WriteLine("¿Qué quieres hacer? \n 1)Añadir coche \n 2)Mostrar coches\n 3)vaciar concesionario \n 4) Eliminar coche\n 5) Escribir en ficher\n 6) Jugar con aleatorios\n 7)Sortear coche\n 0) Salir");
                opc = int.Parse(System.Console.ReadLine());
                switch  (opc)
                {
                    case 1:
                        System.Console.WriteLine("vamos a añadir un coche:\n");
                        System.Console.WriteLine("Inserta un id:");
                        id =int.Parse(System.Console.ReadLine());
                        System.Console.WriteLine("Inserta una marca:");
                        marca = System.Console.ReadLine();
                        System.Console.WriteLine("Inserta un modelo:");
                        modelo = System.Console.ReadLine();
                        System.Console.WriteLine("Inserta los km:");
                        km =int.Parse(System.Console.ReadLine());
                        System.Console.WriteLine("Inserta un precio:");
                        precio = double.Parse(System.Console.ReadLine()); 
                        coche nuevoCoche = new coche(id,marca,modelo,km,precio);
                        cs.aniadircoche(nuevoCoche);
                        System.Console.WriteLine("Añadido! ;)\n");
                        break;
                    case 2:
                        System.Console.WriteLine("vamos a mostrar los coches\n");
                        cs.mostrarcoches();
                        break;
                    case 3:
                        System.Console.WriteLine("Vaciemos el concesionario:\n");
                        cs.vaciarcoches();
                        System.Console.WriteLine("Concesionario reseteado! ;)\n");
                        break;
                    case 4:
                        System.Console.WriteLine("¿Qué coche queremos eliminar?( Inserta su id)\n");
                        id=int.Parse(System.Console.ReadLine());
                        
                        cs.eliminarcoche(cs.buscarCoche(id));
                        System.Console.WriteLine("Eliminado! ;)");
                        break;
                    case 5:
                        System.Console.WriteLine("Vamos a escribir en el fichero\n");
                        String contenido = "Erase una vez un principito....";
                        File.WriteAllText("miFicherito.txt", contenido);

                        break;
                    case 6:
                        menuNumero();

                        break;
                    case 7:
                        System.Console.WriteLine("¡Sorteemos un coche!! ¡SUERTE!!! ;)\n");
                        cs.mostrarCoche();

                        break;
                    case 0:
                        System.Console.WriteLine("Hasta luego Mari Carmen! ;)\n");
                        break;
                    default: break;


                }
           

            } while (opc!=0);


            System.Console.ReadKey();


        }

    }
}
