namespace CalcAreaLib
{
    //Класс добавлен как пример добавления других фигур
    public class Square : IShape
    {
        private readonly double _side;

        public Square(double side)
        {
            if (side <= 0) throw new ArgumentException("Длина стороны должна быть больше 0");
            _side = side;
        }

        public double CalculateArea()
        {
            return Math.Pow(_side, 2);
        }
    }
}