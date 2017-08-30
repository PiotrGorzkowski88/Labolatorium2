using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pg_chess.Chess
{
    abstract public class Figure
    {
        public ChessColor Color { get; set; }
        public Position Position { get; set; }

        public Figure() { }
        
        public abstract bool CanMove(Position position);

        public override string ToString()
        {
            return "?";
        }
    }
}
