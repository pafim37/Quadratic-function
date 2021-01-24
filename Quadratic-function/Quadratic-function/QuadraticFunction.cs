using System;
using System.Collections.Generic;
using System.Text;

namespace Quadratic_function
{
    class QuadraticFunction
    {
        QuadraticFunction() { }
        QuadraticFunction(double a) { }
        QuadraticFunction(double a, double b) { }
        QuadraticFunction(double a, double b, double c) { }
        
        public double A { get; private set; }
        public double B { get; private set; }
        public double C { get; private set; }

        public void ShowFunction() { }

        public void ShowZeros() { }
    }
}
