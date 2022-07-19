using MiniFarm_Patterns_MVP_Wpf_App.Model.Classes;

namespace MiniFarm_Patterns_MVP_Wpf_App.Model.Interfases
{
    public interface IDataSaving
    {
        public void SaveDataCow(string filePath, Cow cow);
        public void SaveDataChicken(string filePath, Chicken bird);
        public void SaveDataTurtle(string filePath, Turtle turtles);
    }
}
