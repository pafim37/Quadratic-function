using System;
using System.Collections.Generic;
using System.Text;

namespace Quadratic_function
{
    class QuadraticFunction
    {
        public QuadraticFunction()
        {
            A = 0;
            B = 0;
            C = 0;
        }

        public QuadraticFunction(double a) 
        {
            A = a;
            B = 0;
            C = 0;
        }
        public QuadraticFunction(double a, double b)
        { 
            A = a;
            B = b;
            C = 0;
        }

        public QuadraticFunction(double a, double b, double c) 
        {
            A = a;
            B = b;
            C = c;
        }
        
        public double A { get; private set; }
        public double B { get; private set; }
        public double C { get; private set; }

        public void ShowFunction() { }

        public void ShowZeros() { }
    }
}
