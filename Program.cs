using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MathNet.Numerics.LinearAlgebra;

namespace deterinanta
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var A = Matrix<double>.Build.DenseOfArray(new double[,]{
                 { 0, 1, 1, 2},
                 { 2 , 1, 2, -1},
                 { 1, -1, 3, -2},
                 { 3, 2, -1, 4}
                  });
            var b = Vector<double>.Build.Dense(new double[]
                { -3, 6 , 10 , -15});
            var x = A.Solve(b);

            Console.WriteLine(x);
        }
    }
}
