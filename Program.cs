using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using pg_chess.Chess;

namespace pg_chess
{
    class Program
    {
        static void Header()
        {
            Console.WriteLine("#######################################################");
            Console.WriteLine("##                  Laboratorium nr2                 ##");
            Console.WriteLine("#######################################################");
            Console.WriteLine();
        }

        static void CheckNewAndOverride()
        {
            Console.WriteLine("Checking new and override differences...\n");
            Pawn p = new Pawn();
            Console.WriteLine("ChildClass: " + p); //Child class
            Figure f = p;
            Console.WriteLine("ParentClass: " + f); //Parent class
        }

        static void Main(string[] args)
        {
            //Writing header
            Header();

            //Checkint new and override operators
            CheckNewAndOverride();

            //Making figures
            Figure figure1 = new Pawn();
            figure1.Color = ChessColor.Black;
            figure1.Position = new Position(1,4);

            Figure figure2 = new Pawn();
            figure2.Color = ChessColor.White;
            figure2.Position = new Position(3, 4);

            Figure figure3 = new King();
            figure3.Color = ChessColor.Black;
            figure3.Position = new Position(5, 4);

            Figure figure4 = new Bishop();
            figure4.Color = ChessColor.White;
            figure4.Position = new Position(5, 5);

            Figure figure5 = new Castle();
            figure5.Color = ChessColor.White;
            figure5.Position = new Position(3, 7);

            //Creating ChessBoard
            ChessBoard chessBoard = new ChessBoard();

            //Putting figures on chessboard
            chessBoard[figure1.Position] = figure1;
            chessBoard[figure2.Position] = figure2;
            chessBoard[figure3.Position] = figure3;
            chessBoard[figure4.Position] = figure4;
            chessBoard[figure5.Position] = figure5;

            //Checking that is figures on position
            Console.WriteLine(chessBoard[figure1.Position]);
            Console.WriteLine(chessBoard[figure2.Position]);
            Console.WriteLine(chessBoard[figure3.Position]);
            Console.WriteLine(chessBoard[figure4.Position]);
            Console.WriteLine(chessBoard[figure5.Position]);

            //Is figure on position
            Console.WriteLine(chessBoard.IsFigureOn(figure1.Position));
            Console.WriteLine(!chessBoard.IsFigureOn(new Position(0,0)));

            //Reading Key
            Console.ReadKey();
        }
    }
}
