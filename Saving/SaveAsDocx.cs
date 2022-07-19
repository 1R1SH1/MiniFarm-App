using MiniFarm_Patterns_MVP_Wpf_App.Model.Classes;
using System.IO;

namespace MiniFarm_Patterns_MVP_Wpf_App.Saving
{
    public class SaveAsDocx
    {
        private string nameOfFile;
        public SaveAsDocx(string NameOfFile)
        {
            this.nameOfFile = NameOfFile;
        }

        private string CreateDocx(string Pages)
        {
            return Pages;
        }

        public void SaveDataCow(string filePath, Cow cow)
        {
            //string json = JsonConvert.SerializeObject(cow);

            using (StreamWriter sw = new StreamWriter($"{nameOfFile}.docx", true))
                sw.WriteLine(CreateDocx(cow.ToString()));
        }

        public void SaveDataChicken(string filePath, Chicken bird)
        {
            //string json = JsonConvert.SerializeObject(bird);

            using (StreamWriter sw = new StreamWriter($"{nameOfFile}.docx", true))
                sw.WriteLine(CreateDocx(bird.ToString()));
        }

        public void SaveDataTurtle(string filePath, Turtle turtles)
        {
            //string json = JsonConvert.SerializeObject(turtles);

            using (StreamWriter sw = new StreamWriter($"{nameOfFile}.docx", true))
                sw.WriteLine(CreateDocx(turtles.ToString()));
        }
    }
}
