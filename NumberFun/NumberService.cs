using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumberFun
{
    public class NumberService
    {
        public string GetNumberString(int i)
        {
            StringBuilder sb = new StringBuilder();
            if (i % 3 == 0)
                sb.Append("Fizz");
            if (i % 5 == 0)
                sb.Append("Buzz");

            if (sb.Length > 0)
                return sb.ToString();
            else
                return Convert.ToString(i);
        }
    }
}
