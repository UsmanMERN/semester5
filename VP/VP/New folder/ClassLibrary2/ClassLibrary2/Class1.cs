using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary2
{
    public class Class1
    {
        public double addition(double x, double y)
        {

            return x + y;

        }

        public double subtraction(double x, double y)
        {

            return x - y;

        }


        public double multiplication(double x, double y)
        {

            return x * y;

        }

        public double divison(double x, double y)
        {

            if (y == 0)
            {
                throw  new DivideByZeroException();
            }
            else
            {
                return x/y;

            }


            

        }


    }

    }
