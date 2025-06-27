using System;

public class Point<T>
{
    T x;
    T y;

    public T X { get => x; set => x = value; }
    public T Y { get => y; set => y = value; }
    public Point(T x, T y)
    {
        this.X = x;
        this.Y = y;
    }
    public void Print()
    {
        Console.WriteLine($"Координаты точки: X = {X}, Y = {Y}");
    }
}