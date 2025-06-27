class Program
{
    static void Main()
    {
        Point<int> intPoint = new Point<int>(10, 20);
        intPoint.Print();

        Point<uint> uintPoint = new Point<uint>(30u, 40u);
        uintPoint.Print();

        Point<double> doublePoint = new Point<double>(12.5, 34.7);
        doublePoint.Print();
    }
}