using System;

using MAP_Tema2_Checkers.ViewModels;

namespace MAP_Tema2_Checkers.Models
{
    public class Piece : BaseNotification
    {
        private static readonly String RED_PIECE;
        private static readonly String BLACK_PIECE;
        private static readonly String RED_KING_PIECE;
        private static readonly String BLACK_KING_PIECE;

        static Piece()
        {
            RED_PIECE = "/Assets/Red_Piece.png";
            BLACK_PIECE = "/Assets/Black_Piece.png";
            RED_KING_PIECE = "/Assets/Black_King_Piece.png";
            BLACK_KING_PIECE = "/Assets/Black_Piece.png";
        }

        public enum COLOR
        {
            BLACK,
            RED
        }

        //true: RED
        //false: BLACK
        public bool Color { get; }
        private bool king;
        public bool King
        {
            get
            {
                return king;
            }
            set
            {
                king = value;
                NotifyPropertyChanged("PieceImage");
            }
        }
        public String PieceImage
        {
            get
            {
                return Color ? (King ? RED_KING_PIECE : RED_PIECE) : (King ? BLACK_KING_PIECE : BLACK_PIECE);
            }
        }

        public Piece(COLOR color)
        {
            this.Color = Convert.ToBoolean(color);
            this.King = false;
        }
    }
}
