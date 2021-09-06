using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_Interfaces.Fruit
{
    //Naming convention for interfaces: ISomething
    public interface IFruit
    {
        string Name { get; }
        bool IsPeeled { get; }
        //METHODS - methods in interfaces don't have a body; just returnType name and parameters
        string Peel();
    }
}
