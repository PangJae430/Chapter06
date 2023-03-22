using System;

namespace UsingOut
{
    class MainApp
    {
        static void Divide(int a, int b, out int quotitent, out int remainder)
        {
            quotitent = a / b;
            remainder = a % b;
        }
    }
}
