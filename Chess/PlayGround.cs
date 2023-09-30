using System.Runtime.CompilerServices;
using Chess.Figures;

namespace Chess;

public class PlayGround
{
    private List<List<Figure>> Board = new List<List<Figure>>();

    public PlayGround()
    {
        
        for (int column = 0; column < 8; column++)
        {
            Board.Add(new List<Figure>());
            for (int place = 0; place < 8; place++)
            {
                Board[column].Add(new EmptyPlace());
            }
        }
        Board[0][0] = new Rook(Color.Black);
        Board[0][1] = new Knight(Color.Black);
        Board[0][2] = new Bishop(Color.Black);
        Board[0][3] = new Queen(Color.Black);
        Board[0][4] = new King(Color.Black);
        Board[0][5] = new Bishop(Color.Black);
        Board[0][6] = new Knight(Color.Black);
        Board[0][7] = new Rook(Color.Black);
        Board[^1][0] = new Rook(Color.White);
        Board[^1][1] = new Knight(Color.White);
        Board[^1][2] = new Bishop(Color.White);
        Board[^1][3] = new Queen(Color.White);
        Board[^1][4] = new King(Color.White);
        Board[^1][5] = new Bishop(Color.White);
        Board[^1][6] = new Knight(Color.White);
        Board[^1][7] = new Rook(Color.White);
        for (int place = 0; place < 8; place++)
        {
            Board[1][place] = new Pawn(Color.Black);
            Board[^2][place] = (new Pawn(Color.White));

        }
    }

    public void PrintBoard()
    {
        Console.WriteLine("X01234567");

        for (int column = 0; column < 8; column++)
        {
            Console.Write(column);
            for (int place = 0; place < 8; place++)
            {
                Console.Write(Board[column][place].Image);
            }
            Console.WriteLine();
        }
    }

    public bool MoveFigure(int oldRow, int oldColumn, int newRow, int newColumn)
    {
        if (oldColumn >= 8 || oldColumn < 0 || oldRow >= 8 || oldRow < 0 || newColumn >= 8 || newColumn < 0 ||
            newRow >= 8 || newRow < 0)
        {
            return false;
        }

        Board[newColumn][newRow] = Board[oldColumn][oldRow];
        Board[oldColumn][oldRow] = new EmptyPlace();
        return true;
    }
    
    
}