using System;
using System.Text;
using System.IO;

namespace PII_Game_Of_Life
{
    public class PrintBoard
    {
        public static bool[,] b; //variable que representa el tablero
        public static int width; //variabe que representa el ancho del tablero
        public static int height; //variabe que representa altura del tablero

        public static void GameBoard()
        {  
            while (true)
            {
                Console.Clear();
                StringBuilder s = new StringBuilder();
                for (int y = 0; y<height;y++)
                {
                    for (int x = 0; x<width; x++)
                    {
                        if(b[x,y])
                        {
                            s.Append("|X|");
                        }
                        else
                        {
                            s.Append("___");
                        }
                    }
                    s.Append("\n");
                }
                Console.WriteLine(s.ToString());
                //=================================================
                //Invocar método para calcular siguiente generación
                //=================================================
                Thread.Sleep(300);
            }

        }
    }
}
