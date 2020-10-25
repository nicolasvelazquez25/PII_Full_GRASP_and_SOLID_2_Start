using System;
namespace Full_GRASP_And_SOLID.Library
{
    public class ConsolePrinter 
    {
        /*

            Para cumplir con el principio de SRP 
            designamos a la clase ConsolePrinter para que se encargue de hacer las impresiones por pantalla, 
            creemos que de esta manera en caso de existir un problema en la impresión por pantalla será más fácil 
            de solucionar si todas las clases del programa derivan esa tarea a una clase en especifico.
            Por lo tanto creamos un método estatico en la clase ConsolePrinter llamado Print, el cual recibe una 
            cadena de carácteres y los imprime por consola. 

        */

        public static void Print(string printable)
        {
            Console.WriteLine(printable);
        }
    }
}