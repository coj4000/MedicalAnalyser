using System;

namespace Sandbox
{
    class InsertCodeHere
    {
        public void MyCode()
        {
            // The FIRST line of code should be BELOW this line
            BodyAnalyser analyse = new BodyAnalyser();
            Console.WriteLine(analyse.CalculateBMI(1.80, 75));
            Console.WriteLine(analyse.AnalyseBMI(1.80, 75));
            // The LAST line of code should be ABOVE this line
        }
    }
}
