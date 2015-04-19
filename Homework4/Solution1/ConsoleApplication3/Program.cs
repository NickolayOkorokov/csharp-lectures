using System;
using System.Collections.Generic;

public struct Point : IEquatable<Point>
{
    public Point(double x, double y)
        : this()
    {
        X = x;
        Y = y;
    }

    public double X { get; set; }

    public double Y { get; set; }

    public bool Equals(Point p1)
    {
        return
            this.X == p1.X &&
            this.Y == p1.Y;
    }

    public double DistanceTo(Point p1)
    {
        double d = (this.X - p1.X) * (this.X - p1.X) +
            (this.Y - p1.Y) * (this.Y - p1.Y);
        return Math.Sqrt(d);
    }
}

public class Program
{
    public static void Main()
    {
        List<Point> points = new List<Point> {
            new Point(0, 0),
            new Point(4, 0),
            new Point(4, 4),
            new Point(0, 4)
        };
        double perimeter = 0;
        for (int i = 0; i < points.Count - 1; i++)
        {
            perimeter += points[i].DistanceTo(points[i + 1]);
        }
        perimeter += points[points.Count - 1].DistanceTo(points[0]);
        Console.WriteLine(perimeter);
        Console.ReadLine();
    }
}
            
            //if (pupil1 == goodpupil1)
            //{
            //    goodpupil1.Study(); goodpupil1.Read(); goodpupil1.Write(); goodpupil1.Relax();
            //}
            //else if (pupil1 == exelentpupil1)
            //{
            //    exelentpupil1.Study(); exelentpupil1.Read(); exelentpupil1.Write(); exelentpupil1.Relax();
            //}
            //else if (pupil1 == badpupil1) { 
            //    badpupil1.Study(); badpupil1.Read(); badpupil1.Write(); badpupil1.Relax();}