﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Shapes;

namespace WpfApplication8
{
    public class Square : Shape
    {
        private Rectangle rect;

        public Square(int initX, int initY)
        {
            x = initX;
            y = initY;
            CreatRectangle();     
        }

        public override void DisplayOn(Canvas drawArea)
        {
            drawArea.Children.Add(rect);
        }

        private void CreatRectangle()
        {
            rect = new Rectangle();
            rect.Stroke = brush;
            rect.Width = size;
            rect.Height = size;
            rect.Margin = new Thickness(x, y, 0, 0);            
        }
    }
}
