using System;

namespace ObjectOrientedProgramming
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Create Coffee Table Object
            CoffeeTable cf = new CoffeeTable(10,20,30,"Brown");
            Console.WriteLine(cf.ShowAsString());
            #endregion

            #region Create AbstractChildClass
            ChildClass cc = new ChildClass();
            cc.exampleAbstrackMethod();
            cc.exampleNormalMethod();
            cc.exampleVirtualMethod();
            #endregion
        }
    }
}
