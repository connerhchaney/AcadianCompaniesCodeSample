using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication9
{
    class Program
    {
        // private class that reads the account numbers in
        private ReadAccountNumbers accountNumberReader;

        // List to hold the string representation of the digits
        private ArrayList digits;

        // List to hold the string representation of the account numbers read in
        private ArrayList accountNumbers;

        // Just for kicks and illegibility
        // Semaphore mutex1;

        public Program()
        {

            accountNumberReader = new ReadAccountNumbers();
            accountNumbers = accountNumberReader.Read();
            accountNumberReader.BreakDownIntoDigits(out digits);
            TransformDigits digitTransform = new TransformDigits(digits);
            digitTransform.Transform();
            digitTransform.PrintAndCheckValidity(accountNumbers);
        }
        static void Main(string[] args)
        {
            new Program();
        }
    }
}
