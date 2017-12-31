using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Practise
{
    class Program
    {
        //array
        int [] myarray = new int[]{1,2,3,4,5,6,7,8,9,10};
        //Enum
        enum Days { Sun, Mon, tue, Wed, thu, Fri, Sat };
        public static AggregationA aggregationAObj = new AggregationA();
        static void Main(string[] args)
        {
        //----------------------object----------------------//
            Program p = new Program();
        //----------------------Array-----------------------//
            foreach (int i in p.myarray)
            {
                Console.WriteLine("The value at index {0} is {1}",i,i );
            }

        //---------------------string----------------------//
            //printing string
            string mystring = "AnkitPatel";
            Console.WriteLine(mystring);
            Console.WriteLine("---------------------");

            //slicing string
            //string substring = mystring.Substring(1, mystring.Length-1);
            string substring = mystring.Substring(1, 1);
            Console.WriteLine(substring);
            Console.WriteLine("---------------------");

            substring = mystring.Substring(2);
            Console.WriteLine(substring);
            Console.WriteLine("---------------------");

            //printing all chars in string
            foreach (char strchars in mystring)
                Console.WriteLine(strchars);
            Console.WriteLine("---------------------");

            //converting string to chararry
            char[] chararray = mystring.ToCharArray();
            foreach (char mychar in chararray)
                Console.WriteLine(mychar);
            Console.WriteLine("---------------------");

            //Reversing the string
            Console.WriteLine("\n Reversing string");
            chararray = mystring.ToCharArray();
            for (int i = 0; i < mystring.Length/2; i++)
            {
                char temp = chararray[i];
                chararray[i] = mystring[mystring.Length - i -1];
                chararray[mystring.Length - i -1] = temp;
            }

            foreach (char mychar in chararray)
                Console.WriteLine(mychar);
            
            //converting char array to string
            Console.WriteLine(new string(chararray));

            Console.WriteLine("---------------------");

            //Deleting chars from string
            Console.WriteLine("\nDeleting Chars from string");
            string replacestring = mystring.Remove(2, 1);
            Console.WriteLine(replacestring);
            Console.WriteLine("---------------------");

            //replacing chars in string
            Console.WriteLine("\n Replacing Chars from string");
            replacestring = mystring.Replace("a","b");
            Console.WriteLine(replacestring);
            Console.WriteLine("---------------------");

            //find index of char in string
            Console.WriteLine("\n Finding index from string");
            Console.WriteLine(mystring.IndexOf("i",3));
            Console.WriteLine("---------------------");

            //checking if substring is find in string
            string s = "hihellohowareyou";
            string ss = "how";
            Console.WriteLine(s.Contains(ss));
            Console.WriteLine("---------------------");

            string myUpperLowerString = "Hi I am Ankit Patel and I am a Software Engineer";
            myUpperLowerString = myUpperLowerString.ToLower();


        //---------------------Abstraction Demo----------------------//
            ShapeAbstract objCircle = new Circle();
            objCircle.printShape();
            ShapeAbstract objRect = new Rectancle();
            objRect.printShape();
            Console.WriteLine("---------------------");


        //-----------------------Inheritance Demo ---------------------//
            Square squareobj = new Square(10,20);
            squareobj.calculateArea();
            Console.WriteLine("---------------------");

            //inheritance no constructor
            Shape1 shapeobj1 = new Shape1();
            Square1 squareobj1 = new Square1();

            squareobj1.setLength(10);
            squareobj1.setWidth(10);
            
            squareobj1.calculateArea();
            Console.WriteLine("---------------------");


        //------------------Encapsulation Demo-------------------------//
            Encapsulation encapsobj = new Encapsulation();
            encapsobj.setLength(10);
            encapsobj.setWidth(10);
            encapsobj.calculateArea();
            Console.WriteLine("---------------------");

        //----------------------Polymorphism--------------------------//
            FunctionOverloading polyObj = new FunctionOverloading();
            polyObj.Sum(10, 20, 30);
            polyObj.Sum(10.5, 20.0);
            FunctionOverriding overrideObj = new FunctionOverriding();
            overrideObj.abstractsum();
            Console.WriteLine("---------------------");
            

            //----------------------Association--------------------------//
            AssociationA associationAObj = new AssociationA() ;
            AssociationB associationBObj = new AssociationB(associationAObj);
            Console.WriteLine("---------------------");

            //----------------------Aggregation--------------------------//
            
            AggregationB aggregationBObj = new AggregationB();
            aggregationBObj.PrintBMethod();
            Console.WriteLine("---------------------");

            //----------------------Composition--------------------------//

            CompositionB compositionBObj = new CompositionB();
            Console.WriteLine("---------------------");


            //----------------------Dictionary--------------------------//
            Dictionary dict = new Dictionary();
            dict.knowDictionary();
            Console.WriteLine("---------------------");


            /*#################################################################################
            ###################################################################################
             *                                  Design Patterns
             * ################################################################################
            */

            //----------------------Singleton Design pattern--------------------------//
            DesignPatterns.Singleton.getSingletonObj().PrintMethod();
            //Singleton single = new Singleton(); //this wont be allowed
            DesignPatterns.Singleton.getSingletonObj().PrintMethod();
           
            Console.WriteLine("---------------------");
            //----------------------Factory Design pattern--------------------------//
            DesignPatterns.FactoryDesignPattern factoryObj = new DesignPatterns.FactoryDesignPattern();
            factoryObj.shapeFactory("circle").printShape();
            Console.WriteLine("---------------------");

            //----------------------Abstract Factory Design pattern--------------------------//

            FDesignPatterns.AbstractFactory shapeFactory = FDesignPatterns.FactoryProducer.getFactory("SHAPE");//get shape factory
            FDesignPatterns.Shape shape1 = shapeFactory.getShape("circle");//get an object of Shape Circle
            shape1.printShape();//call draw method of Shape Circle
            FDesignPatterns.Shape shape2 = shapeFactory.getShape("rectangle");//get an object of Shape Rectangle
            shape2.printShape();//call draw method of Shape Rectangle


            FDesignPatterns.AbstractFactory colorFactory = FDesignPatterns.FactoryProducer.getFactory("COLOR");//get color factory
            FDesignPatterns.Color color1 = colorFactory.getColor("red");//get an object of Color Red
            color1.printColor();//call fill method of Red
            FDesignPatterns.Color color2 = colorFactory.getColor("green");//get an object of Color Green
            color2.printColor();//call fill method of Green

            //----------------------Decorator Design pattern--------------------------//
            Computer laptop = new Laptop();
            laptop = new CDDrive(laptop);
            laptop = new Mouse(laptop);
            laptop = new Mouse(laptop);
            Console.WriteLine(laptop.Description() + laptop.Cost());

            Console.Read();
        }
    }
   
}
