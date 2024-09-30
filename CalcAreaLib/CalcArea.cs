namespace CalcAreaLib
{
    public static class CalcArea
    {
        //Вычисление площади фигуры без знания типа фигуры в compile-time
        public static double GetArea(IShape shape)
        {
            return shape.CalculateArea();
        }
    }
}