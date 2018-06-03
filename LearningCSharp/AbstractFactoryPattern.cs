using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FDesignPatterns
{
    /*
     * Abstract Factory patterns acts a super-factory which creates other factories. This pattern is also called as Factory of factories. In Abstract Factory pattern an interface is responsible for creating a set of related objects, or dependent objects without specifying their concrete classes.
     *  A system should be configured with one of multiple families of products
        A system should be independent of how its products are created, composed and represented
        Products from the same family should be used all together, products from different families ahould not be used togheter and this constraint must be ensured.
        Only the product interfaces are revealed, the implementations remains hidden to the clients.
     * 
     * EXAMPLES:
     * 
     * Pizza Factory Example
        Another example, this time more simple and easier to understand, is the one of a pizza factory, which defines method names and returns types to make different kinds of pizza. The abstract factory can be named AbstractPizzaFactory, RomeConcretePizzaFactory and MilanConcretePizzaFactory being two extensions of the abstract class. The abstract factory will define types of toppings for pizza, like pepperoni, sausage or anchovy, and the concrete factories will
     * implement only a set of the toppings, which are specific for the area and even if one topping is implemented in both concrete factories, the resulting pizzas will be different subclasses, each for the area it was implemented in.
     * */
    public abstract class Shape
    {
        public abstract void printShape();
    }
    class Circle : Shape
    {
        public override void printShape()
        {
            Console.WriteLine("Shape::Circle");
        }
    }
    class Rectangle : Shape
    {
        public override void printShape()
        {
            Console.WriteLine("Shape::Rectancle");
        }
    }

    public abstract class Color
    {
        public abstract void printColor();
    }
    class Red : Color
    {
        public override void printColor()
        {
            Console.WriteLine("Color::Red");
        }
    }
    class Green : Color
    {
        public override void printColor()
        {
            Console.WriteLine("Color::Green");
        }
    }


    public abstract class AbstractFactory
    {
        public abstract Color getColor(String color);
        public abstract Shape getShape(String shape);
    }

    class ShapeFactory : AbstractFactory
    {

        public override Shape getShape(String shapeType)
        {
          if(shapeType.Equals("circle"))
          {
             return new Circle();
         
          }
          else if (shapeType.Equals("rectangle"))
          {
              return new Rectangle();
          }
          else
          {
              return null;
          }

       }
        public override Color getColor(String colorType)
        {
            return null;
        }
    }

    class ColorFactory : AbstractFactory
    {
        public override Color getColor(String color) 
           {
      
              if(color.Equals("red")){
                 return new Red();

              }
              else if (color.Equals("green"))
              {
                 return new Green();

              }
      
              return null;
           }
        public override Shape getShape(string shape)
        {
            return null;
        }
    }


    public class FactoryProducer
    {
        public static AbstractFactory getFactory(String choice)
        {

            if (choice.Equals("SHAPE"))
            {
                return new ShapeFactory();

            }
            else if (choice.Equals("COLOR"))
            {
                return new ColorFactory();
            }

            return null;
        }
    }
}
