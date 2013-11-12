using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzz
{
   public class FizzBuzz
    {

        private static int startVal = 1;
        private static int endVal = 20;
        private static int _intCount = 0;
        private static int _buzzCount = 0;
        private static int _fizzCount = 0;
        private static int _luckyCount = 0;
        private static int _fizzbuzzCount = 0;

        public static int IntCount
        {
            get { return _intCount; }
            set { _intCount = value; }
        }



        public static void Main()
        {

            Console.WriteLine("{0}", Display());
        }

        public static string Display()
        {
            StringBuilder output = new StringBuilder();
            for (int i = startVal; i <= endVal; i++)
            {
                output.Append(WorkOut(i) + ' ');
            }

            output.AppendLine("fizz:" + _fizzCount);
            output.AppendLine("buzz:" + _buzzCount);
            output.AppendLine("fizzbuzz:" + _fizzbuzzCount);
            output.AppendLine("lucky:" + _luckyCount);
            output.AppendLine("Integer:" + _intCount);
            return output.ToString();
        }

        public static string WorkOut(int number)
        {
            bool number3 = ((number % 3) == 0);
            bool number5 = ((number % 5) == 0);
      
            if (number.ToString().Contains("3"))
            {
                _luckyCount += 1;
                return "lucky";

            }
            if (number3 && number5)
            {
                _fizzbuzzCount += 1;
                return "fizzbuzz";
            }
            else if(number3)
            {
                _fizzCount += 1;
                return "fizz";
            }
            else if (number5)
            {
                _buzzCount += 1;
                return "buzz";

            }
           
            else
            {
                _intCount += 1;
                return number.ToString();
            }
            
        }

        public static int ReportInteger()
        {
            return _intCount;
        }
    }
}
