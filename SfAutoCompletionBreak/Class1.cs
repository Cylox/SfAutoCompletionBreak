using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;

namespace SfAutoCompletionBreak
{

    [Binding]
    public class Class1
    {
        [Given(@"I have a step with coordinates like this: \(([\d\.\,]+|x),\s?([\d\.\,]+|y)\)")]
        public void PrintCoordinates(double x, double y)
        {
            Console.WriteLine($"The coordinates are: x={x}, y={y}");
        }
    }
}
