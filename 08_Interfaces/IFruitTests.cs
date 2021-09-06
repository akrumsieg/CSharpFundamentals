using _08_Interfaces.Fruit;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace _08_Interfaces
{
    [TestClass]
    public class IFruitTests
    {
        [TestMethod]
        public void CallingInterfaceMethods()
        {
            IFruit banana = new Banana();
            Banana banana1 = new Banana();
            //can't create an interface object like below comment
            //IFruit banana = new IFruit();

            //var is wildcard argument; not best practice
            var output = banana.Peel();
            Console.WriteLine(output);

            Console.WriteLine("The banana is peeled: " + banana.IsPeeled);
            Assert.IsTrue(banana.IsPeeled);
        }

        [TestMethod]
        public void InterfacesInCollections()
        {
            Orange orange = new Orange();

            var fruitSalad = new List<IFruit>
            {
                new Banana(),
                new Orange(),
                orange,
                new Apple(),
                new Grape()
            };
            //orage exclusive methods still accessible outside of IFruit collection
            orange.Squeeze();

            foreach (var fruit in fruitSalad)
            {
                Console.WriteLine(fruit.Name);
                Console.WriteLine(fruit.Peel());
                //No longer accessible once in a collection
                //orange.Squeeze();

                Assert.IsInstanceOfType(fruit, typeof(IFruit));
            }

            Assert.IsInstanceOfType(orange, typeof(Orange));
        }

        private string GetFruitName(IFruit fruit)
        {
            return $"This fruit is called {fruit.Name}";
        }

        [TestMethod]
        public void InterfacesInMethods()
        {
            var grape = new Grape();

            //even though the method only takes IFruit, grape still qualifies
            string output = GetFruitName(grape);

            Console.WriteLine(output);
        }

        [TestMethod]
        public void TypeOfInstance()
        {
            var fruitSalad = new List<IFruit>
            {
                new Orange(true), //peeled
                new Orange(),
                new Grape(),
                new Orange(),
                new Banana(true), //peeled
                new Grape()
            };

            Console.WriteLine("Is the orange peeled?");
            foreach (var fruit in fruitSalad)
            {
                if (fruit is Orange orange) //checks if fruit is orange AND casts it back to orange type ("pattern matching")
                {
                    if (orange.IsPeeled)
                    {
                        Console.WriteLine("It's a peeled orange");
                        //regain orange exclusive properties
                        Console.WriteLine(orange.Squeeze());
                    }
                    else
                    {
                        Console.WriteLine("It's an orange");
                    }
                }
                else if (fruit.GetType() == typeof(Grape)) //similar to above pattern matching
                {
                    Console.WriteLine("It's a grape");

                    var grape = (Grape)fruit;
                    Console.WriteLine(grape.Peel());
                }
                else if (fruit.IsPeeled)
                {
                    Console.WriteLine("It's a peeled banana");
                }
                else
                {
                    Console.WriteLine("It's a banana");
                }
            }
        }
    }
}
