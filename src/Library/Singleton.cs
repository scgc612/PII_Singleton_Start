using System;

namespace Library
{
    /// <summary>
    /// Para el genérico T el constructor pasa a ser la restriccion where T: new() por lo que 
    /// se debe quitar de la clase Greeter
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class Singleton<T> where T : new ()
    {
        private static T instance;

        private Singleton()
        {
            
        }

        public static T Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new T();
                }

                return instance;
            }
        }

    }
}
