using System;
using System.Collections.Generic;

using MAP_Tema2_Checkers.Models;

namespace MAP_Tema2_Checkers.Utils
{
    class GameLogic
    {
        private readonly Game game;
        private Cell previousCell;
        private bool pieceTaken;
        private bool multipleJumpPossible;
        private List<Cell> cells = new List<Cell>();

        public GameLogic(Game game)
        {
            this.game = game;
            this.pieceTaken = false;
            this.multipleJumpPossible = false;
            this.cells = new List<Cell>();
        }

        public void ResetPreviousCell()
        {
            previousCell = null;
        }

        public void Move(Cell cell)
        {
            if (previousCell == cell || cell.PieceSet == null ? previousCell == null : cell.PieceSet.Color != game.Color) { return; }
            if (cell.PieceSet != null && cell.PieceSet.Color == game.Color && !multipleJumpPossible)
            {
                if (previousCell != null)
                {
                    previousCell.Selected = false;
                    SetSelectedForCells(false);
                }
                game.IsRunning = true;
                previousCell = cell;
                previousCell.Selected = true;
                PossibleMoves();
                SetSelectedForCells(true);
                return;
            }
            if (!cells.Contains(cell)) { return; }
            SetSelectedForCells(false);
            Jumped(cell);
            cell.PieceSet = previousCell.PieceSet;
            previousCell.PieceSet = null;
            previousCell.Selected = false;
            previousCell = null;
            CheckAndTransformToKing(cell);
            if (game.CheckForWin()) { return; }
            if (game.MultipleJump && pieceTaken && CheckMultipleJump(cell))
            {
                multipleJumpPossible = true;
                previousCell = cell;
                previousCell.Selected = true;
                PossibleMoves();
                SetSelectedForCells(true);
                return;
            }
            multipleJumpPossible = false;
            pieceTaken = false;
            game.Color = !game.Color;
        }

        public void SetSelectedForCells(bool selected)
        {
            if (cells == null) { return; }
            foreach (var cell in cells)
            {
                cell.Selected = selected;
            }
        }

        private void PossibleMoves()
        {
            cells.Clear();
            if (previousCell == null) { return; }
            if (previousCell.PieceSet.King || previousCell.PieceSet.Color)
            {
                OneTileMove(Direction.NW);
                OneTileMove(Direction.NE);
            }
            if (previousCell.PieceSet.King || !previousCell.PieceSet.Color)
            {
                OneTileMove(Direction.SE);
                OneTileMove(Direction.SW);
            }
        }

        private void OneTileMove(Direction direction)
        {
            var directionTuple = DirectionControl.Get(direction);
            int row = previousCell.Row + directionTuple.Item1;
            int column = previousCell.Column + directionTuple.Item2;
            if (row < 0 || row >= BoardGenerator.SIZE || column < 0 || column >= BoardGenerator.SIZE)
            {
                return;
            }
            if (game.GameBoard[row][column].PieceSet == null)
            {
                cells.Add(game.GameBoard[row][column]);
                return;
            }
            if (game.GameBoard[row][column].PieceSet.Color != game.Color)
            {
                TwoTileMove(direction);
            }
        }

        private void TwoTileMove(Direction direction)
        {
            var directionTuple = DirectionControl.Get(direction);
            int row = previousCell.Row + 2 * directionTuple.Item1;
            int column = previousCell.Column + 2 * directionTuple.Item2;
            if (row < 0 || row >= BoardGenerator.SIZE || column < 0 || column >= BoardGenerator.SIZE)
            {
                return;
            }
            if (game.GameBoard[row][column].PieceSet == null)
            {
                cells.Add(game.GameBoard[row][column]);
            }
        }

        private void Jumped(Cell cell)
        {
            if (Math.Abs(previousCell.Row - cell.Row) == 2 && Math.Abs(previousCell.Column - cell.Column) == 2)
            {
                Cell cellInBetween = game.GameBoard[(previousCell.Row + cell.Row) / 2][(previousCell.Column + cell.Column) / 2];
                game.RemovePiece(cellInBetween);
                pieceTaken = true;
            }
        }

        private void CheckAndTransformToKing(Cell cell)
        {
            if (cell.PieceSet.King)
            {
                return;
            }
            cell.PieceSet.King = cell.PieceSet.Color ? cell.Row == 0 : cell.Row == BoardGenerator.SIZE - 1;
        }

        private bool CheckMultipleJump(Cell cell)
        {
            if (cell == null || cell.PieceSet == null) { return false; }
            return (cell.PieceSet.King || cell.PieceSet.Color ? CheckJump(cell, cell.Row - 2, cell.Column - 2) || CheckJump(cell, cell.Row - 2, cell.Column + 2) : false) ||
                (cell.PieceSet.King || !cell.PieceSet.Color ? CheckJump(cell, cell.Row + 2, cell.Column - 2) || CheckJump(cell, cell.Row + 2, cell.Column + 2) : false);
        }

        private bool CheckJump(Cell cell, int row, int column)
        {
            if (row < 0 || row >= BoardGenerator.SIZE || column < 0 || column >= BoardGenerator.SIZE)
            {
                return false;
            }
            Piece piece = game.GameBoard[(cell.Row + row) / 2][(cell.Column + column) / 2].PieceSet;
            return game.GameBoard[row][column].PieceSet == null && piece != null && cell.PieceSet.Color != piece.Color;
        }
    }
}