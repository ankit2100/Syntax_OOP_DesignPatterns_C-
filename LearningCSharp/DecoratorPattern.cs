using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Practise
{
    /* Used to decorate the objects at run time.
     * Attach additional responsibility to an object dynamically
     * 
     * Examples:
     *  Pizza shop
     *  Computer Shop
     * */
    public abstract class Computer
    {
         public abstract String Description();
         public abstract double Cost();
    }

    public class Laptop : Computer
    {
        public override String Description()
        {
            return "Laptop Computer";
        }
        public override double Cost()
        {
            return 399.99;
        }
    }



    public class CDDrive : Computer
    {
        Computer computer;
        public CDDrive(Computer computer)
        {
            this.computer = computer;
        }
        public override String Description()
        {
            if (this.computer != null) 
                return this.computer.Description() + " and a CD Drive";
            return String.Empty;
        }
        public override double Cost()
        {
            return 30 + this.computer.Cost();
        }
    }

    public class Mouse : Computer
    {
        Computer computer;
        public Mouse(Computer computer)
        {
            this.computer = computer;
        }
        public override String Description()
        {
            if (this.computer != null)
                return this.computer.Description() + " and a Mouse";
            return String.Empty;
        }
        public override double Cost()
        {
            return 10 + this.computer.Cost();
        }
    }



}

