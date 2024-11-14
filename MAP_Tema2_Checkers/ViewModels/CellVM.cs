using System.Windows.Input;

using MAP_Tema2_Checkers.Utils;
using MAP_Tema2_Checkers.Models;
using MAP_Tema2_Checkers.Commands;

namespace MAP_Tema2_Checkers.ViewModels
{
    class CellVM
    {
        private GameLogic gameLogic;

        public Cell CellObj { get; }

        public CellVM(Cell cell, GameLogic gameLogic)
        {
            this.CellObj = cell;
            this.gameLogic = gameLogic;
        }

        private ICommand moveCommand;
        public ICommand MoveCommand
        {
            get
            {
                if (moveCommand == null)
                {
                    moveCommand = new RelayCommand<Cell>(gameLogic.Move);
                }
                return moveCommand;
            }
        }
    }
}
