using System.Threading;
using Microsoft.Maui.Controls;
using Microsoft.Maui.Graphics;
using System;

namespace DigitalClock
{
    public class GraphicsDrawable : IDrawable
    {
        public int distance = 50;

        public void Draw(ICanvas canvas, RectF dirtyRect)
        {
            canvas.StrokeColor = Colors.OrangeRed;
            canvas.StrokeSize = 3;
            

            Number(canvas, 0, DateTime.Now.Hour / 10);
            Number(canvas, 1, DateTime.Now.Hour % 10);
            if (DateTime.Now.Second % 2 == 0){
            canvas.DrawLine(20 + distance * 2, 25, 20 + distance * 2, 35);
            canvas.DrawLine(20 + distance * 2, 45, 20 + distance * 2, 55);
            }
            Number(canvas, 2, DateTime.Now.Minute / 10);
            Number(canvas, 3, DateTime.Now.Minute % 10);
            if (DateTime.Now.Second % 2 == 0){ 
            canvas.DrawLine(23 + distance * 4 + 20, 25, 23 + distance * 4 + 20, 35);
            canvas.DrawLine(23 + distance * 4 + 20, 45, 23 + distance * 4 + 20, 55);
            }
            Number(canvas, 4, DateTime.Now.Second / 10);
            Number(canvas, 5, DateTime.Now.Second % 10);

        }

        public void perebor(ICanvas canvas, int n)
        {
            canvas.StrokeColor = Colors.White;
            Random rnd = new Random();
            int rand;
            int pointOffset = 0;
            int i = 0;
            if (n > 1) pointOffset = 20;
            if (n > 3) pointOffset = 40;

            rand = rnd.Next(0, 9);

            for (i = 0; i < 4; i++)
            {
                canvas.StrokeColor = Colors.OrangeRed;
                rand = rnd.Next(1, 9);
                if (rand == 1)
                {
                    canvas.DrawLine(40 + distance * n + pointOffset, 0, 40 + distance * n + pointOffset, 70);
                    Thread.Sleep(100);
                }
                if (rand == 2)
                {
                    canvas.DrawLine(15 + distance * n + pointOffset, 0, 55 + distance * n + pointOffset, 0);
                    canvas.DrawLine(55 + distance * n + pointOffset, 0, 55 + distance * n + pointOffset, 35);
                    canvas.DrawLine(15 + distance * n + pointOffset, 35, 55 + distance * n + pointOffset, 35);
                    canvas.DrawLine(15 + distance * n + pointOffset, 35, 15 + distance * n + pointOffset, 70);
                    canvas.DrawLine(15 + distance * n + pointOffset, 70, 55 + distance * n + pointOffset, 70);
                    Thread.Sleep(100);
                }
                if (rand == 3)
                {
                    canvas.DrawLine(15 + distance * n + pointOffset, 0, 55 + distance * n + pointOffset, 0);
                    canvas.DrawLine(55 + distance * n + pointOffset, 0, 55 + distance * n + pointOffset, 70);
                    canvas.DrawLine(15 + distance * n + pointOffset, 70, 55 + distance * n + pointOffset, 70);
                    canvas.DrawLine(15 + distance * n + pointOffset, 35, 55 + distance * n + pointOffset, 35);
                    Thread.Sleep(100);
                }
                if (rand == 4)
                {
                    canvas.DrawLine(55 + distance * n + pointOffset, 0, 55 + distance * n + pointOffset, 70);
                    canvas.DrawLine(15 + distance * n + pointOffset, 35, 55 + distance * n + pointOffset, 35);
                    canvas.DrawLine(15 + distance * n + pointOffset, 0, 15 + distance * n + pointOffset, 35);
                    Thread.Sleep(100);
                }
                if (rand == 5)
                {
                    canvas.DrawLine(15 + distance * n + pointOffset, 0, 55 + distance * n + pointOffset, 0);
                    canvas.DrawLine(15 + distance * n + pointOffset, 0, 15 + distance * n + pointOffset, 35);
                    canvas.DrawLine(15 + distance * n + pointOffset, 35, 55 + distance * n + pointOffset, 35);
                    canvas.DrawLine(55 + distance * n + pointOffset, 35, 55 + distance * n + pointOffset, 70);
                    canvas.DrawLine(15 + distance * n + pointOffset, 70, 55 + distance * n + pointOffset, 70);
                    Thread.Sleep(100);
                }
                if (rand == 6)
                {
                    canvas.DrawLine(15 + distance * n + pointOffset, 0, 55 + distance * n + pointOffset, 0);
                    canvas.DrawLine(15 + distance * n + pointOffset, 0, 15 + distance * n + pointOffset, 70);
                    canvas.DrawLine(15 + distance * n + pointOffset, 35, 55 + distance * n + pointOffset, 35);
                    canvas.DrawLine(55 + distance * n + pointOffset, 35, 55 + distance * n + pointOffset, 70);
                    canvas.DrawLine(15 + distance * n + pointOffset, 70, 55 + distance * n + pointOffset, 70);
                    Thread.Sleep(100);
                }
                if (rand == 7)
                {
                    canvas.DrawLine(15 + distance * n + pointOffset, 0, 55 + distance * n + pointOffset, 0);
                    canvas.DrawLine(55 + distance * n + pointOffset, 0, 55 + distance * n + pointOffset, 72);
                    Thread.Sleep(100);
                }
                if (rand == 8)
                {
                    canvas.DrawLine(15 + distance * n + pointOffset, 0, 55 + distance * n + pointOffset, 0);
                    canvas.DrawLine(55 + distance * n + pointOffset, 0, 55 + distance * n + pointOffset, 70);
                    canvas.DrawLine(15 + distance * n + pointOffset, 70, 55 + distance * n + pointOffset, 70);
                    canvas.DrawLine(15 + distance * n + pointOffset, 0, 15 + distance * n + pointOffset, 70);
                    canvas.DrawLine(15 + distance * n + pointOffset, 35, 55 + distance * n + pointOffset, 35);
                    Thread.Sleep(100);
                }
                if (rand == 9)
                {
                    canvas.DrawLine(15 + distance * n + pointOffset, 0, 55 + distance * n + pointOffset, 0);
                    canvas.DrawLine(55 + distance * n + pointOffset, 0, 55 + distance * n + pointOffset, 70);
                    canvas.DrawLine(15 + distance * n + pointOffset, 70, 55 + distance * n + pointOffset, 70);
                    canvas.DrawLine(15 + distance * n + pointOffset, 0, 15 + distance * n + pointOffset, 35);
                    canvas.DrawLine(15 + distance * n + pointOffset, 35, 55 + distance * n + pointOffset, 35);
                    Thread.Sleep(100);

                }
                
            }


        }
        public void Number(ICanvas canvas, int n, int time)
        {
            
            int pointOffset = 0;
           
            if (n > 1) pointOffset = 20;
            if (n > 3) pointOffset = 40;
            
            switch (time)
            {

                case 0:
                    if (DateTime.Now.Second % 8 == 0)
                    {
                        perebor(canvas, n);
                        break;
                    }
                    canvas.DrawLine(15 + distance * n + pointOffset, 0, 55 + distance * n + pointOffset, 0);
                    canvas.DrawLine(55 + distance * n + pointOffset, 0, 55 + distance * n + pointOffset, 70);
                    canvas.DrawLine(15 + distance * n + pointOffset, 70, 55 + distance * n + pointOffset, 70);
                    canvas.DrawLine(15 + distance * n + pointOffset, 0, 15 + distance * n + pointOffset, 70);
                    break;
                case 1:
                    if (DateTime.Now.Second % 9 == 0)
                    {
                        perebor(canvas, n);
                        break;
                    }
                    canvas.DrawLine(55 + distance * n + pointOffset, 0, 55 + distance * n + pointOffset, 70);
                    break;
                case 2:
                    if (DateTime.Now.Second % 11 == 0)
                    {
                        perebor(canvas, n);
                        break;
                    }
                    canvas.DrawLine(15 + distance * n + pointOffset, 0, 55 + distance * n + pointOffset, 0);
                    canvas.DrawLine(55 + distance * n + pointOffset, 0, 55 + distance * n + pointOffset, 35);
                    canvas.DrawLine(15 + distance * n + pointOffset, 35, 55 + distance * n + pointOffset, 35);
                    canvas.DrawLine(15 + distance * n + pointOffset, 35, 15 + distance * n + pointOffset, 70);
                    canvas.DrawLine(15 + distance * n + pointOffset, 70, 55 + distance * n + pointOffset, 70);
                    break;
                case 3:
                    if (DateTime.Now.Second % 12 == 0)
                    {
                        perebor(canvas, n);
                        break;
                    }
                    canvas.DrawLine(15 + distance * n + pointOffset, 0, 55 + distance * n + pointOffset, 0);
                    canvas.DrawLine(55 + distance * n + pointOffset, 0, 55 + distance * n + pointOffset, 70);
                    canvas.DrawLine(15 + distance * n + pointOffset, 70, 55 + distance * n + pointOffset, 70);
                    canvas.DrawLine(15 + distance * n + pointOffset, 35, 55 + distance * n + pointOffset, 35);
                    break;
                case 4:
                    if (DateTime.Now.Second % 14 == 0)
                    {
                        perebor(canvas, n);
                        break;
                    }
                    canvas.DrawLine(55 + distance * n + pointOffset, 0, 55 + distance * n + pointOffset, 70);
                    canvas.DrawLine(15 + distance * n + pointOffset, 35, 55 + distance * n + pointOffset, 35);
                    canvas.DrawLine(15 + distance * n + pointOffset, 0, 15 + distance * n + pointOffset, 35);
                    break;
                case 5:
                    if (DateTime.Now.Second % 16 == 0)
                    {
                        perebor(canvas, n);
                        break;
                    }
                    canvas.DrawLine(15 + distance * n + pointOffset, 0, 55 + distance * n + pointOffset, 0);
                    canvas.DrawLine(15 + distance * n + pointOffset, 0, 15 + distance * n + pointOffset, 35);
                    canvas.DrawLine(15 + distance * n + pointOffset, 35, 55 + distance * n + pointOffset, 35);
                    canvas.DrawLine(55 + distance * n + pointOffset, 35, 55 + distance * n + pointOffset, 70);
                    canvas.DrawLine(15 + distance * n + pointOffset, 70, 55 + distance * n + pointOffset, 70);
                    break;
                case 6:
                    if (DateTime.Now.Second % 17 == 0)
                    {
                        perebor(canvas, n);
                        break;
                    }
                    canvas.DrawLine(15 + distance * n + pointOffset, 0, 55 + distance * n + pointOffset, 0);
                    canvas.DrawLine(15 + distance * n + pointOffset, 0, 15 + distance * n + pointOffset, 70);
                    canvas.DrawLine(15 + distance * n + pointOffset, 35, 55 + distance * n + pointOffset, 35);
                    canvas.DrawLine(55 + distance * n + pointOffset, 35, 55 + distance * n + pointOffset, 70);
                    canvas.DrawLine(15 + distance * n + pointOffset, 70, 55 + distance * n + pointOffset, 70);
                    break;
                case 7:
                    if (DateTime.Now.Second % 18 == 0)
                    {
                        perebor(canvas, n);
                        break;
                    }
                    canvas.DrawLine(15 + distance * n + pointOffset, 0, 55 + distance * n + pointOffset, 0);
                    canvas.DrawLine(55 + distance * n + pointOffset, 0, 55 + distance * n + pointOffset, 72);
                    break;
                case 8:
                    if (DateTime.Now.Second % 19 == 0)
                    {
                        perebor(canvas, n);
                        break;
                    }
                    canvas.DrawLine(15 + distance * n + pointOffset, 0, 55 + distance * n + pointOffset, 0);
                    canvas.DrawLine(55 + distance * n + pointOffset, 0, 55 + distance * n + pointOffset, 70);
                    canvas.DrawLine(15 + distance * n + pointOffset, 70, 55 + distance * n + pointOffset, 70);
                    canvas.DrawLine(15 + distance * n + pointOffset, 0, 15 + distance * n + pointOffset, 70);
                    canvas.DrawLine(15 + distance * n + pointOffset, 35, 55 + distance * n + pointOffset, 35);
                    break;
                case 9:
                    if (DateTime.Now.Second % 21 == 0)
                    {
                        perebor(canvas, n);
                        break;
                    }
                    canvas.DrawLine(15 + distance * n + pointOffset, 0, 55 + distance * n + pointOffset, 0);
                    canvas.DrawLine(55 + distance * n + pointOffset, 0, 55 + distance * n + pointOffset, 70);
                    canvas.DrawLine(15 + distance * n + pointOffset, 70, 55 + distance * n + pointOffset, 70);
                    canvas.DrawLine(15 + distance * n + pointOffset, 0, 15 + distance * n + pointOffset, 35);
                    canvas.DrawLine(15 + distance * n + pointOffset, 35, 55 + distance * n + pointOffset, 35);
                    break;
            }
        }
    }
}