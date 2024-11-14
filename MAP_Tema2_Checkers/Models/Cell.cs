using System;

using MAP_Tema2_Checkers.ViewModels;

namespace MAP_Tema2_Checkers.Models
{
    public class Cell : BaseNotification
    {
        private static readonly String LIGHT_TILE;
        private static readonly String DARK_TILE;

        static Cell()
        {
            LIGHT_TILE = "#FF6347"; 
            DARK_TILE = "#8B0000";
        }

        public enum TILE
        {
            DARK,
            LIGHT
        }

        //true: LIGHT_TILE
        //false: DARK_TILE
        private readonly bool tileColor;
        private Piece pieceSet;

        public int Row { get; }
        public int Column { get; }
        public String TileColor
        {
            get
            {
                return tileColor ? LIGHT_TILE : DARK_TILE;
            }
        }
        public Piece PieceSet
        {
            get
            {
                return pieceSet;
            }
            set
            {
                pieceSet = value;
                NotifyPropertyChanged("PieceSet");
            }
        }

        private bool selected;
        public bool Selected
        {
            get
            {
                return selected;
            }
            set
            {
                selected = value;
                NotifyPropertyChanged("Selected");
            }
        }

        public Cell(int row, int column, TILE tileColor, Piece pieceSet)
        {
            this.Row = row;
            this.Column = column;
            this.tileColor = Convert.ToBoolean(tileColor);
            this.PieceSet = pieceSet;
            this.Selected = false;
        }
    }
}
