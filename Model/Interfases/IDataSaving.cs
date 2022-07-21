using MiniFarm_Patterns_MVP_Wpf_App.Model.Classes;
using System.Collections.Generic;

namespace MiniFarm_Patterns_MVP_Wpf_App.Model.Interfases
{
    public interface IDataSaving
    {
        public void SaveDataCow(string filePath, List<Cow> cow);
        public void SaveDataChicken(string filePath, List<Chicken> bird);
        public void SaveDataTurtle(string filePath, List<Turtle> turtles);
    }
}
