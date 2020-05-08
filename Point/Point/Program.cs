using System;

namespace Point
{
    class Point
    {
        int x;
        int y;
        char c;
       
        void Draw()
        {
            Console.SetCursorPosition(x, y);
            Console.Write(c);
        }
    }
}
