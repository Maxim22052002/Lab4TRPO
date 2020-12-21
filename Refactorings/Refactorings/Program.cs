using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Text;
using System.Net;
using System.Net.Sockets;

namespace Refactorings
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = Console.ReadLine();
            Console.WriteLine(otherFoo(str));
            Console.WriteLine();           
            Console.WriteLine(GetTextDiv2(str));
        }
        static string otherFoo(string s)
        {
            string[] mas = s.Split(' ');
            switch (mas.Length)
            {
                case 1:
                    return "&nbsp" + mas[0];
                case 2:
                    return "&nbsp" + mas[0] + " " + mas[1];
                default:
                    return "&nbsp" + String.Join(" ", mas.Take((mas.Length + 1) / 2).ToArray()) + " <br/>&nbsp " + String.Join(" ", mas.Skip((mas.Length + 1) / 2).ToArray());
            }
        }

        static string GetTextDiv2(string text)
        {
            int mid = text.Length / 2;
            int r = text.IndexOf(" ", mid); if (r < 0) r = 5000;
            int l = text.IndexOf(" ", 0, mid); if (l < 0) l = 5000;
            if (r - mid > mid - l) // to left is closer
                mid = l;
            else mid = r;
            if (mid == 5000) return "&nbsp" + text;
            return "&nbsp" + text.Substring(0, mid) + " <br/>&nbsp" + text.Substring(mid, text.Length - mid);
        }
        
    }
}
