using System;
using System.IO;

using MAP_Tema2_Checkers.ViewModels;

namespace MAP_Tema2_Checkers.Models
{
    sealed class GameInfo : BaseNotification
    {
        private int redWins;
        private int blackWins;
        public int RedWins
        {
            get { return redWins; }
            private set
            {
                redWins = value;
                NotifyPropertyChanged("RedWins");
            }
        }
        public int BlackWins
        {
            get { return blackWins; }
            private set
            {
                blackWins = value;
                NotifyPropertyChanged("BlackWins");
            }
        }
        public static GameInfo Instance { get; } = new GameInfo();

        static GameInfo() { }
        private GameInfo()
        {
            try
            {
                using (TextReader reader = File.OpenText("../../../gameInfo.txt"))
                {
                    string line = reader.ReadLine();
                    string[] separated = line.Split(' ');
                    this.RedWins = int.Parse(separated[0]);
                    this.BlackWins = int.Parse(separated[1]);
                }
            }
            catch (Exception exc)
            {
                Console.WriteLine("Error reading GameInfo from file");
                Console.WriteLine(exc.Message);
                this.RedWins = 0;
                this.BlackWins = 0;
            }
        }

        ~GameInfo()
        {
            try
            {
                File.WriteAllText("../../../gameInfo.txt", RedWins + " " + BlackWins);
            }
            catch (Exception exc)
            {
                Console.WriteLine("Error writing GameInfo to file");
                Console.WriteLine(exc.Message);
            }
        }

        public void AddWin(bool color)
        {
            _ = color ? ++RedWins : ++BlackWins;
        }
    }
}
