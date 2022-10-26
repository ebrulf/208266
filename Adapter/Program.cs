using System;

namespace Adapter
{
    public interface Adaptee
    {
        void drawLine(int x1, int x2, int y1, int y2);
        void drawCircle(int x, int y, int r);
        void drawRectangle(int x, int y, int width, int hieght);
    }
    public class Adapter : Adaptee
    {
        public void drawLine(int x1, int x2, int y1, int y2)
        {
            Console.WriteLine("Narysowano linię od (" + x1 + ", " + y1 + ") do (" + x2", " + y2 + ")");
        }
        public void drawCircle(int x, int y, int r)
        {
            //itp.
        }
        public void drawRectangle(int x, int y, int width, int hieght)
        {

        }
        public void drawCar(int x, int y, int width, int height)
        {
            //1 prostokąt + 2 koła
        }
        public void drawRabbit(int x, int y, int czub)
        {
            //dwie kulki plus uszy - 2x Circle + 3xdrawLine
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            //Symulacja biblioteki graficznej o metodah:
            //drawLine(x1, x2, y1, y2)
            //drawCircle(x, y, r)
            //drawRectangle(x, y, width, height)
            //Zaimplementuj adapter z metodą drawCar i drawRabbit
            //(abstrakcja), nie trzeba aż tak szczegółowo 
            Console.WriteLine("Hello World!");
        }
    }
}
