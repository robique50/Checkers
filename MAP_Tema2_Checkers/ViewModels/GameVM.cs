using System.Collections.ObjectModel;
using System.Linq;

using MAP_Tema2_Checkers.Models;
using MAP_Tema2_Checkers.Utils;

namespace MAP_Tema2_Checkers.ViewModels
{
    class GameVM : BaseNotification
    {
        private GameLogic gameLogic;
        private Game game;
        public Game Game
        {
            get { return game; }
            set
            {
                game = value;
                NotifyPropertyChanged("Game");
            }
        }
        private ObservableCollection<ObservableCollection<CellVM>> gameBoard;
        public ObservableCollection<ObservableCollection<CellVM>> GameBoard
        {
            get { return gameBoard; }
            set
            {
                gameBoard = value;
                NotifyPropertyChanged("GameBoard");
            }
        }

        public GameVM()
        {
            Init(new Game(BoardGenerator.NewGame()));
        }

        private ObservableCollection<ObservableCollection<CellVM>> CellBoardToCellVMBoard(ObservableCollection<ObservableCollection<Cell>> gameBoard)
        {
            return gameBoard.Select(row => row.Select(cell => new CellVM(cell, gameLogic)).ToObservableCollection()).ToObservableCollection();
        }

        public void Init(Game game)
        {
            if (game == null) { return; }
            this.Game = game;
            //this.Game.Reset();
            this.gameLogic = new GameLogic(Game);
            this.gameLogic.ResetPreviousCell();
            this.GameBoard = CellBoardToCellVMBoard(Game.GameBoard);
        }

        public void ResetGame()
        {
            BoardGenerator.ResetNewGame(game);
            game.Reset();
            gameLogic.ResetPreviousCell();
        }
    }
}
