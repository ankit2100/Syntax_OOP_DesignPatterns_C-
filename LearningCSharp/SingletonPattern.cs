using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DesignPatterns
{
    class Singleton
    {
        /// <summary>
        /// Singleton design pattern is used to make sure that your class has only one instance running through out the application.
        ///  Hardware interface access: The use of singleton depends on the requirements. However practically singleton can be used in case external hardware resource usage limitation required e.g. Hardware printers where the print spooler can be made a singleton to avoid multiple concurrent accesses and creating deadlock.
        /// Logger : Similarly singleton is a good potential candidate for using in the log files generation. Imagine an application where the logging utility has to produce one log file based on the messages received from the users. If there is multiple client application using this logging utility class they might create multiple instances of this class and it can potentially cause issues during concurrent access to the same logger file. We can use the logger utility class as a singleton and provide a global point of reference.
        /// Configuration File: This is another potential candidate for Singleton pattern because this has a performance benefit as it prevents multiple users to repeatedly access and read the configuration file or properties file. It creates a single instance of the configuration file which can be accessed by multiple calls concurrently as it will provide static config data loaded into in-memory objects. The application only reads from the configuration file at the first time and there after from second call onwards the client applications read the data from in-memory objects.
        /// Cache: We can use the cache as a singleton object as it can have a global point of reference and for all future calls to the cache object the client application will use the in-memory object.
        /// 
        /// Examples of Singleton Pattern :
        ///     1)Windows Task Manager
        ///     2)Hardware interface Access
        ///     3)Log manager
        ///
        /// </summary>
        private static Singleton singetonobj = null;

        private Singleton()
        {
            //Constructor is private
        }
        public static Singleton getSingletonObj()
        {
            if (singetonobj == null)
            {
                singetonobj = new Singleton();
            }
            return singetonobj;

        }

        public void PrintMethod()
        {
            Console.WriteLine("Singleton Print method");
        }
    }
}
