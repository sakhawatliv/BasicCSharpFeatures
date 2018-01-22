using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FuncAndAction
{
    class Program
    {
        static void Main(string[] args)
        {

            // in delegte example we need declare a delegate first and then we need to create a object of that and +
            // againest of that we can use lambda expression. But func and action will help us not to declare can use instant.


            //Note : Func should have a return type. in angular bracket the last one is return type.


            Func<int, int,int> addHandaler = (X, Y) => X + Y;
            // Note: addHandaler variabletar kache amra method defination pathie dicchi.

            //but if we want a method defination that do not have a return type then we ca use Action

            Action aMethod = () => { };
        }
    }
}
