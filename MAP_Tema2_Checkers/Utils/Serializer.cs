using System;
using System.IO;
using System.Xml.Serialization;
using Microsoft.Win32;

using MAP_Tema2_Checkers.Models;

namespace MAP_Tema2_Checkers.Utils
{
    static class Serializer
    {
        public static void Serialize(Game game)
        {
            String file = SaveFile();
            if (String.IsNullOrEmpty(file)) { return; }
            using (StreamWriter myWriter = new StreamWriter(file, false))
            {
                XmlSerializer mySerializer = new XmlSerializer(typeof(Game));
                mySerializer.Serialize(myWriter, game);
            }
        }

        public static Game Desirialize()
        {
            String file = OpenFile();
            if (String.IsNullOrEmpty(file)) { return null; }
            using (var stream = System.IO.File.OpenRead(file))
            {
                var serializer = new XmlSerializer(typeof(Game));
                return serializer.Deserialize(stream) as Game;
            }
        }

        private static String SaveFile()
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Title = "Save game";
            saveFileDialog.Filter = "XML Files (*.xml)|*.xml";
            if (saveFileDialog.ShowDialog() == true)
            {
                return saveFileDialog.FileName;
            }
            return null;
        }

        private static String OpenFile()
        {
            OpenFileDialog op = new OpenFileDialog();
            //op.InitialDirectory = Environment.CurrentDirectory + "\\..\\..\\..\\Saves\\";
            op.Title = "Select save file";
            op.Filter = "XML Files (*.xml)|*.xml";
            if (op.ShowDialog() == true)
            {
                return op.FileName;
            }
            return null;
        }
    }
}
