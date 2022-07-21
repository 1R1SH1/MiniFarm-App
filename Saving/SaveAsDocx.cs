using MiniFarm_Patterns_MVP_Wpf_App.Model.Classes;
using MiniFarm_Patterns_MVP_Wpf_App.Model.Interfases;
using System.Collections.Generic;
using System.IO;
using System.Xml.Serialization;

namespace MiniFarm_Patterns_MVP_Wpf_App.Saving
{
    public class SaveAsDocx : IDataSaving
    {
        private string nameOfFile;
        public SaveAsDocx(string NameOfFile)
        {
            this.nameOfFile = NameOfFile;
        }

        public void SaveDataCow(string filePath, List<Cow> cow)
        {
            XmlSerializer xmlSerializer = new XmlSerializer(typeof(List<Cow>));

            Stream fStream = new FileStream(filePath, FileMode.Create, FileAccess.Write);

            xmlSerializer.Serialize(fStream, cow);

            fStream.Close();
        }

        public void SaveDataChicken(string filePath, List<Chicken> bird)
        {
            XmlSerializer xmlSerializer = new XmlSerializer(typeof(List<Chicken>));

            Stream fStream = new FileStream(filePath, FileMode.Create, FileAccess.Write);

            xmlSerializer.Serialize(fStream, bird);

            fStream.Close();
        }

        public void SaveDataTurtle(string filePath, List<Turtle> turtles)
        {
            XmlSerializer xmlSerializer = new XmlSerializer(typeof(List<Turtle>));

            Stream fStream = new FileStream(filePath, FileMode.Create, FileAccess.Write);

            xmlSerializer.Serialize(fStream, turtles);

            fStream.Close();
        }
    }
}
