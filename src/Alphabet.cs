using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

    static class Alphabet
{
    public static int _row = 0;
    private static int Row, Col;
    public static void A(int _col)
    {
        for (Row = 0; Row < 7; Row++)
        {
            Console.SetCursorPosition(_col * 7, _row+Row);
            for (Col = 0; Col < 7; Col++)
            {
                if (((Col == 1 || Col == 5) && Row != 0) || ((Row == 0 || Row == 3) && (Col > 1 && Col < 5)))
                    Console.Write("#");
                else
                    Console.Write(" ");
            }
            
        }
    }
    public static void B(int _col)
    {
        for (Row = 0; Row < 7; Row++)
        {
            Console.SetCursorPosition(_col * 7, Row+_row);
            for (Col = 0; Col < 7; Col++)
            {
                if (Col == 1 || ((Row == 0 || Row == 3 || Row == 6) && (Col < 5 && Col > 1)) || (Col == 5 && (Row != 0 && Row != 3 && Row != 6)))
                    Console.Write("#");
                else
                    Console.Write(" ");
            }
        }
    }
    public static void C(int _col)
    {
        for (Row = 0; Row < 7; Row++)
        {
            Console.SetCursorPosition(_col * 7, Row+_row);
            for (Col = 0; Col < 7; Col++)
            {
                if ((Col == 1 && (Row != 0 && Row != 6)) || ((Row == 0 || Row == 6) && (Col > 1 && Col < 5)) || (Col == 5 && (Row == 1 || Row == 5)))
                    Console.Write("#");
                else
                    Console.Write(" ");
            }
        }
    }
    public static void D(int _col)
    {
        for (Row = 0; Row < 7; Row++)
        {
            Console.SetCursorPosition(_col * 7, Row+_row);
            for (Col = 0; Col < 7; Col++)
            {
                if (Col == 1 || ((Row == 0 || Row == 6) && (Col > 1 && Col < 5)) || (Col == 5 && Row != 0 && Row != 6))
                    Console.Write("#");
                else
                    Console.Write(" ");
            }
        }
    }
    public static void E(int _col)
    {
        for (Row = 0; Row < 7; Row++)
        {
            Console.SetCursorPosition(_col * 7, Row+_row);
            for (Col = 0; Col < 7; Col++)
            {
                if (Col == 1 || ((Row == 0 || Row == 6) && (Col > 1 && Col < 6)) || (Row == 3 && Col > 1 && Col < 5))
                    Console.Write("#");
                else
                    Console.Write(" ");
            }
        }
    }
    public static void F(int _col)
    {
        for (Row = 0; Row < 7; Row++)
        {
            Console.SetCursorPosition(_col * 7, Row+_row);
            for (Col = 0; Col < 7; Col++)
            {
                if (Col == 1 || (Row == 0 && Col > 1 && Col < 6) || (Row == 3 && Col > 1 && Col < 5))
                    Console.Write("#");
                else
                    Console.Write(" ");
            }
        }
    }
    public static void G(int _col)
    {
        for (Row = 0; Row < 7; Row++)
        {
            Console.SetCursorPosition(_col * 7, Row+_row);
            for (Col = 0; Col < 7; Col++)
            {
                if ((Col == 1 && Row != 0 && Row != 6) || ((Row == 0 || Row == 6) && Col > 1 && Col < 5) || (Row == 3 && Col > 2 && Col < 6) || (Col == 5 && Row != 0 && Row != 2 && Row != 6))
                    Console.Write("#");
                else
                    Console.Write(" ");
            }
        }
    }
    public static void H(int _col)
    {
        for (Row = 0; Row < 7; Row++)
        {
            Console.SetCursorPosition(_col * 7, Row+_row);
            for (Col = 0; Col < 7; Col++)
            {
                if ((Col == 1 || Col == 5) || (Row == 3 && Col > 1 && Col < 6))
                    Console.Write("#");
                else
                    Console.Write(" ");
            }
        }
    }
    public static void I(int _col)
    {
        for (Row = 0; Row < 7; Row++)
        {
            Console.SetCursorPosition(_col * 7, Row+_row);
            for (Col = 0; Col < 7; Col++)
            {
                if (Col == 3 || (Row == 0 && Col > 0 && Col < 6) || (Row == 6 && Col > 0 && Col < 6))
                    Console.Write("#");
                else
                    Console.Write(" ");
            }
        }
    }
    public static void J(int _col)
    {
        for (Row = 0; Row < 7; Row++)
        {
            Console.SetCursorPosition(_col * 7, Row+_row);
            for (Col = 0; Col < 7; Col++)
            {
                if ((Col == 4 && Row != 6) || (Row == 0 && Col > 2 && Col < 6) || (Row == 6 && Col == 3) || (Row == 5 && Col == 2))
                    Console.Write("#");
                else
                    Console.Write(" ");
            }
        }
    }
    public static void K(int _col)
    {
        int i, j;
        j = 5;
        i = 0;
        for (Row = 0; Row < 7; Row++)
        {
            Console.SetCursorPosition(_col * 7, Row+_row);
            for (Col = 0; Col < 7; Col++)
            {

                if (Col == 1 || ((Row == Col + 1) && Col != 0))
                {
                    Console.Write("#");
                }
                else if (Row == i && Col == j)
                {
                    Console.Write("#");
                    i++;
                    j--;
                }
                else
                    Console.Write(" ");
            }
        }
    }
    public static void L(int _col)
    {
        for (Row = 0; Row < 7; Row++)
        {
            Console.SetCursorPosition(_col * 7, Row+_row);
            for (Col = 0; Col < 7; Col++)
            {
                if (Col == 1 || (Row == 6 && Col != 0 && Col < 6))
                    Console.Write("#");
                else
                    Console.Write(" ");
            }
        }
    }
    public static void M(int _col)
    {
        for (Row = 0; Row < 7; Row++)
        {
            Console.SetCursorPosition(_col * 7, Row+_row);
            for (Col = 0; Col < 7; Col++)
            {
                if (Col == 1 || Col == 5 || (Row == 2 && (Col == 2 || Col == 4)) || (Row == 3 && Col == 3))
                    Console.Write("#");
                else
                    Console.Write(" ");
            }
        }
    }
    public static void N(int _col)
    {
        for (Row = 0; Row < 7; Row++)
        {
            Console.SetCursorPosition(_col * 7, Row+_row);
            for (Col = 0; Col < 7; Col++)
            {
                if (Col == 1 || Col == 5 || (Row == Col && Col != 0 && Col != 6))
                    Console.Write("#");
                else
                    Console.Write(" ");
            }
        }
    }
    public static void O(int _col)
    {
        for (Row = 0; Row < 7; Row++)
        {
            Console.SetCursorPosition(_col * 7, Row+_row);
            for (Col = 0; Col < 7; Col++)
            {
                if (((Col == 1 || Col == 5) && Row != 0 && Row != 6) || ((Row == 0 || Row == 6) && Col > 1 && Col < 5))
                    Console.Write("#");
                else
                    Console.Write(" ");
            }
        }
    }
    public static void P(int _col)
    {
        for (Row = 0; Row < 7; Row++)
        {
            Console.SetCursorPosition(_col * 7, Row+_row);
            for (Col = 0; Col < 7; Col++)
            {
                if (Col == 1 || ((Row == 0 || Row == 3) && Col > 0 && Col < 5) || ((Col == 5 || Col == 1) && (Row == 1 || Row == 2)))
                    Console.Write("#");
                else
                    Console.Write(" ");
            }
        }
    }
    public static void Q(int _col)
    {
        for (Row = 0; Row < 7; Row++)
        {
            Console.SetCursorPosition(_col * 7, Row+_row);
            for (Col = 0; Col < 7; Col++)
            {
                if ((Col == 1 && Row != 0 && Row != 6) || (Row == 0 && Col > 1 && Col < 5) || (Col == 5 && Row != 0 && Row != 5) || (Row == 6 && Col > 1 && Col < 4) || (Col == Row - 1 && Row > 3))
                    Console.Write("#");
                else
                    Console.Write(" ");
            }
        }
    }
    public static void R(int _col)
    {
        for (Row = 0; Row < 7; Row++)
        {
            Console.SetCursorPosition(_col * 7, Row+_row);
            for (Col = 0; Col < 7; Col++)
            {
                if (Col == 1 || ((Row == 0 || Row == 3) && Col > 1 && Col < 5) || (Col == 5 && Row != 0 && Row < 3) || (Col == Row - 1 && Row > 2))
                    Console.Write("#");
                else
                    Console.Write(" ");
            }
        }
    }
    public static void S(int _col)
    {
        for (Row = 0; Row < 7; Row++)
        {
            Console.SetCursorPosition(_col * 7, Row+_row);
            for (Col = 0; Col < 7; Col++)
            {
                if (((Row == 0 || Row == 3 || Row == 6) && Col > 1 && Col < 5) || (Col == 1 && (Row == 1 || Row == 2 || Row == 6)) || (Col == 5 && (Row == 0 || Row == 4 || Row == 5)))
                    Console.Write("#");
                else
                    Console.Write(" ");
            }
        }
    }
    public static void T(int _col)
    {
        for (Row = 0; Row < 7; Row++)
        {
            Console.SetCursorPosition(_col * 7, Row+_row);
            for (Col = 0; Col < 7; Col++)
            {
                if (Col == 3 || (Row == 0 && Col > 0 && Col < 6))
                    Console.Write("#");
                else
                    Console.Write(" ");
            }
        }
    }
    public static void U(int _col)
    {
        for (Row = 0; Row < 7; Row++)
        {
            Console.SetCursorPosition(_col * 7, Row+_row);
            for (Col = 0; Col < 7; Col++)
            {
                if (((Col == 1 || Col == 5) && Row != 6) || (Row == 6 && Col > 1 && Col < 5))
                    Console.Write("#");
                else
                    Console.Write(" ");
            }
        }
    }
    public static void V(int _col)
    {
        for (Row = 0; Row < 7; Row++)
        {
            Console.SetCursorPosition(_col * 7, Row+_row);
            for (Col = 0; Col < 7; Col++)
            {
                if (((Col == 1 || Col == 5) && Row < 5) || (Row == 6 && Col == 3) || (Row == 5 && (Col == 2 || Col == 4)))
                    Console.Write("#");
                else
                    Console.Write(" ");
            }
        }
    }
    public static void W(int _col)
    {
        for (Row = 0; Row < 7; Row++)
        {
            Console.SetCursorPosition(_col * 7, Row+_row);
            for (Col = 0; Col < 7; Col++)
            {
                if (((Col == 1 || Col == 5) && Row < 6) || ((Row == 5 || Row == 4) && Col == 3) || (Row == 6 && (Col == 2 || Col == 4)))
                    Console.Write("#");
                else
                    Console.Write(" ");
            }
        }
    }
    public static void X(int _col)
    {
        for (Row = 0; Row < 7; Row++)
        {
            Console.SetCursorPosition(_col * 7, Row+_row);
            for (Col = 0; Col < 7; Col++)
            {
                if (((Col == 1 || Col == 5) && (Row > 4 || Row < 2)) || Row == Col && Col > 0 && Col < 6 || (Col == 2 && Row == 4) || (Col == 4 && Row == 2))
                    Console.Write("#");
                else
                    Console.Write(" ");
            }
        }
    }
    public static void Y(int _col)
    {
        for (Row = 0; Row < 7; Row++)
        {
            Console.SetCursorPosition(_col * 7, Row+_row);
            for (Col = 0; Col < 7; Col++)
            {
                if (((Col == 1 || Col == 5) && Row < 2) || Row == Col && Col > 0 && Col < 4 || (Col == 4 && Row == 2) || ((Col == 3) && Row > 3))
                    Console.Write("#");
                else
                    Console.Write(" ");
            }
        }
    }
    public static void Z(int _col)
    {
        for (Row = 0; Row < 7; Row++)
        {
            Console.SetCursorPosition(_col * 7, Row+_row);
            for (Col = 0; Col < 7; Col++)
            {
                if (((Row == 0 || Row == 6) && Col >= 0 && Col <= 6) || Row + Col == 6)
                    Console.Write("#");
                else
                    Console.Write(" ");
            }
        }
    }
}
