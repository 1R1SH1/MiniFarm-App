using MiniFarm_Patterns_MVP_Wpf_App.Model.Classes;
using MiniFarm_Patterns_MVP_Wpf_App.Model.Interfases;
using MiniFarm_Patterns_MVP_Wpf_App.Model.Repository;
using MiniFarm_Patterns_MVP_Wpf_App.Presenter;
using System.Collections.Generic;

namespace MiniFarm_Patterns_MVP_Wpf_App.Saving
{
    public class DataSaving
    {
        private const string FilePathCow = "СохранениеКоровок.xml";
        private const string FilePathChicken = "СохранениеКурок.xml";
        private const string FilePathTurtle = "СохранениеЧерепашек.xml";
        AnimalContext db = new();
        public IDataSaving Mode { get; set; }

        public Repository rep { get; set; }
        public List<Cow> GetCow { get; set; }
        public List<Chicken> GetChicken { get; set; }
        public List<Turtle> GetTurtle { get; set; }

        public DataSaving(IDataSaving Method)
        {
            this.Mode = Method;
        }

        private void AnyPagesCow()
        {
            GetCow = new();

            this.GetCow.ToString();
        }
        private void AnyPagesChicken()
        {
            GetChicken = new();

            this.GetChicken.ToString();
        }
        private void AnyPagesTurtle()
        {
            GetTurtle = new();

            this.GetTurtle.ToString();
        }

        public void SaveCow()
        {
            this.AnyPagesCow();
            Mode.SaveDataCow(FilePathCow, GetCow);
        }
        public void SaveChicken()
        {
            this.AnyPagesChicken();
            Mode.SaveDataChicken(FilePathChicken, GetChicken);
        }
        public void SaveTurtle()
        {
            this.AnyPagesTurtle();
            Mode.SaveDataTurtle(FilePathTurtle, GetTurtle);
        }
    }
}
