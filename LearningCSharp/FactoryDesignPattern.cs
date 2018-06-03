using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DesignPatterns
{
    /*
     * Factory pattern is one of the most used design patterns. This type of design pattern comes under creational pattern as this pattern provides one of the best ways to create an object.
     * In Factory pattern, we create object without exposing the creation logic to the client and refer to newly created object using a common interface.
     * 
     * EXAMPLES:
     * A class implementing factory design pattern works as bridge between multiple classes. Consider an example of using multiple database servers like SQL Server and Oracle. If you are developing an application using SQL Server database as backend,
     * but in future need to change backend database to oracle, you will need to modify all your code, if you haven’t written your code following factory design pattern.
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
    class Rectancle : Shape
    {
        public override void printShape()
        {
            Console.WriteLine("Shape::Rectancle");
        }
    }
    class FactoryDesignPattern
    {

        public Shape shapeFactory(string shapeType)
        {
            switch (shapeType)
            {
                case "circle":
                    return new Circle();
                case "rectangle":
                    return new Rectancle();
                default:
                    return null;
            }
        }
    }
}
