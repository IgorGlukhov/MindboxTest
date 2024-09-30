namespace CalcAreaLib
{
    public class Triangle : IShape
    {
        private readonly double _sideA;
        private readonly double _sideB;
        private readonly double _sideC;

        public Triangle(double sideA, double sideB, double sideC)
        {
            if (sideA <= 0 || sideB <= 0 || sideC <= 0)
                throw new ArgumentException("Длина стороны должна быть больше 0");
            if (sideA + sideB <= sideC || sideA + sideC <= sideB || sideB + sideC <= sideA)
                throw new ArgumentException("Треугольника со сторнами данной длины не существует");

            _sideA = sideA;
            _sideB = sideB;
            _sideC = sideC;
        }

        public double CalculateArea()
        {
            double s = (_sideA + _sideB + _sideC) / 2;
            return Math.Sqrt(s * (s - _sideA) * (s - _sideB) * (s - _sideC));
        }
        //Проверка на то, является ли треугольник прямоугольным
        public bool IsRightTriangle()
        {
            double a = Math.Pow(_sideA, 2);
            double b = Math.Pow(_sideB, 2);
            double c = Math.Pow(_sideC, 2);
            return a + b == c || a + c == b || b + c == a;
        }
    }
}