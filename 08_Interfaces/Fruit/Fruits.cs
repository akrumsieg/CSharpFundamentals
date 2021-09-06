using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_Interfaces.Fruit
{
    public class Banana : IFruit //we have to have all properties of IFruit, but we can add more
    {
        //constructors
        public Banana() { }
        public Banana(bool isPeeled)
        {
            IsPeeled = isPeeled;
        }
        public string Name
        {
            get
            {
                return "Banana";
            }
        }
        public bool IsPeeled { get; private set; }
        //method
        public string Peel()
        {
            IsPeeled = true;
            return "You peeled the banana";
        }
    }

    public class Orange : IFruit
    {
        //constructors
        public Orange() { }
        public Orange(bool isPeeled)
        {
            IsPeeled = isPeeled;
        }
        //properties
        public string Name
        {
            get
            {
                return "Orange";
            }
        }
        public bool IsPeeled { get; private set; }
        //methods
        //can use the same interface method but bodies can be different as long as the return type matches
        public string Peel()
        {
            if (IsPeeled)
            {
                return "It's already peeled";
            }
            else
            {
                IsPeeled = true;
                return "You peeled the orange";
            }
        }
        //classes that use interfaces can still have unique props and methods
        public string Squeeze()
        {
            return "You squeezed the orange, and juice comes out";
        }
    }

    public class Grape : IFruit
    {
        public string Name
        {
            get
            {
                return "Grape";
            }
        }
        public bool IsPeeled { get; } = false; //a hard-coded property set bc nobody peels grapes
        public string Peel()
        {
            return "Who peels grapes?";
        }
    }

    //challenge: make an apple class inheriting from IFruit
    public class Apple : IFruit
    {
        public string Name => "Apple"; //lambda or 'fat arrow' ; same as below
        //public string Name
        //{
        //    get
        //    {
        //        return "Apple";
        //    }
        //}
        public bool IsPeeled { get; private set; }
        public bool IsSliced { get; private set; }
        public string Peel()
        {
            IsPeeled = true;
            return "You peeled it!";
        }
        public bool Slice()
        {
            IsSliced = true;
            return IsSliced;
        }
    }
}
