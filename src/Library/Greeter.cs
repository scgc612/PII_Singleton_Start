using System;

namespace Library
{

    /// <summary>
    /// A la clase Greeter solo se le deja el metodo SayHiToTheWorld()
    /// que será el utilizado cuando se declare el tipo Greeter en el generico 
    /// de Singleton en el Program
    /// </summary>
    public class Greeter
    {
        // private Greeter()
        // {

        // }

        // private static Greeter instance;

        // public static Greeter Instance
        // {
        //     get
        //     {
        //         if (instance == null)
        //         {
        //             instance = new Greeter();
        //         }

        //         return instance;
        //     }
        // } 

        public void SayHiToTheWorld()
        {
            Console.WriteLine("Hello World!");
        }
    }
}
