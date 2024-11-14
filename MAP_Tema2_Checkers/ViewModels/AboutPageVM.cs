using System;
using System.Windows.Input;

using MAP_Tema2_Checkers.Commands;
using MAP_Tema2_Checkers.Models;
using MAP_Tema2_Checkers.Utils;

namespace MAP_Tema2_Checkers.ViewModels
{
    class AboutPageVM
    {
        public ICommand GamePageCommand { get; }
        public ICommand CloseWindowCommand { get; }
        public GameInfo GameWins => GameInfo.Instance;

        public AboutPageVM()
        {
            GamePageCommand = new ActionCommand(ViewNavigator.ChangeToGamePage);
            CloseWindowCommand = new ActionCommand(ViewNavigator.CloseWindow);
        }

        public string Foreground => "#c0c0c0";
        public int FontSize => 40;
        public String Programmer => "Lungu Robert-Cristian";
        public String Group => "10LF222";
        public String Email => "robert-cristian.lungu@student.unitbv.ro";
        public String Description => "Checkers, also called draughts, is a two-player board game played on an 8x8 grid.\n" +
            "Players move their pieces diagonally, aiming to capture their opponent's pieces by jumping over them.\n" +
            "It's a classic strategy game that's easy to learn but offers plenty of depth and challenge.";
    }
}
