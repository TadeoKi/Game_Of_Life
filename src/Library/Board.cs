using System;

namespace PII_Game_Of_Life
{
    public class Board
    {
        public static void Tablero()
        {
            for (int  y=0; y<ReadFile.contentLines.Length;y++)
            {
                for (int x=0; x<ReadFile.contentLines[y].Length; x++)
                {
                    if(ReadFile.contentLines[y][x]=='1')
                    {
                        ReadFile.board[x,y]=true;
                    }
                }
            }
        }
    }
}
