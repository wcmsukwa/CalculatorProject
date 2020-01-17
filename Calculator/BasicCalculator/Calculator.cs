using Add;
using Cube;
using Divide;
using Multiply;
using Square;
using SquareRoot;
using Subtract;

namespace BasicCalculator
{
    public interface ICalculator
    {
        public dynamic Add(dynamic a, dynamic b);
        public dynamic Add(dynamic a);
        public dynamic Cubed(dynamic a);
        public dynamic Divide(dynamic a, dynamic b);
        public dynamic Multiply(dynamic a, dynamic b);
        public dynamic Squared(dynamic a);
        public dynamic Squareroot(dynamic a);
        public dynamic Subtract(dynamic a, dynamic b);

    }
    public class    Calculator : IAdd, ICube, IMultiply, ISubtract, IDivide, ISquare, ISquareRoot
    {
        public dynamic result;
        Adding addObject = new Adding();
        Cubing cubeObject = new Cubing();
        Multiplying multiplyObject = new Multiplying();
        Subtracting subtractObject = new Subtracting();
        Dividing divideObject = new Dividing();
        Squaring squareObject = new Squaring();
        SquareRooting squareRootObject = new SquareRooting();


        public dynamic Add(dynamic a, dynamic b)
        {
            result = addObject.Add(a, b);
            return result;
        }

        public dynamic Add(dynamic a)
        {
            result = addObject.Add(a);
            return result;
        }

        public dynamic Cubed(dynamic a)
        {
            result = cubeObject.Cubed(a);
            return result;
        }

        public dynamic Divide(dynamic a, dynamic b)
        {
            result = divideObject.Divide(a, b);
            return result;
        }

        public dynamic Multiply(dynamic a, dynamic b)
        {
            result = multiplyObject.Multiply(a, b);
            return result;
        }

        public dynamic Squared(dynamic a)
        {
            result = squareObject.Squared(a);
            return result;
        }

        public dynamic Squareroot(dynamic a)
        {
            result = squareRootObject.Squareroot(a);
            return result;
        }

        public dynamic Subtract(dynamic a, dynamic b)
        {
            result = subtractObject.Subtract(a, b);
            return result;
        }
    }
}
