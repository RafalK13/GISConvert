using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GISConvert
{
    public class Converter1
    {
        List<PktClass1> p = new List<PktClass1>();

        int[] a1 = { 1, 2};
        int[] a2 = { 3, 4 };
        int[] a3 = { 5, 6 };
        int[] a4 = { 7, 8 };
        int[] a5 = { 9, 10 };

        public Converter1()
        {
            p.Add( new PktClass1( a1));
            p.Add( new PktClass1( a2));
            p.Add( new PktClass1( a3));
            p.Add( new PktClass1( a4));
            p.Add( new PktClass1( a5));

            foreach( var v in p)
                Console.WriteLine( $"{v.X_Coord}\t{v.Y_Coord}\r\n");
        }
        
    }

    public class PktClass1
    {
        public PktClass1(int[] array)
        {
            X_Coord = array[0];
            Y_Coord = array[1];
        }
        public double X_Coord;
        public double Y_Coord;
    }
}
