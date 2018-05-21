using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2
{
    public class AreaOfRectangle
    {
        public int Width { get; set; }
        public int Length { get; set; }
        public AreaOfRectangle(int width, int length)
        {
            Width = width;
            Length = length;
        }
        public int Calculate(int width, int length)
        {
            int area = width * length;
            return area;
        }
    }
}