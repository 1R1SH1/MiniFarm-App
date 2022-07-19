using MiniFarm_Patterns_MVP_Wpf_App.Model.Classes;
using MiniFarm_Patterns_MVP_Wpf_App.Model.Interfases;
using MiniFarm_Patterns_MVP_Wpf_App.Model.Repository;
using MiniFarm_Patterns_MVP_Wpf_App.Presenter;
using System.Windows.Controls;

namespace MiniFarm_Patterns_MVP_Wpf_App.Saving
{
    public class DataSaving
    {
        private const string FilePath = "Сохранение";
        AnimalContext db = new();
        public IDataSaving Mode { get; set; }
        public ListView animals { get; set; }

        public Repository rep { get; set; }
        public Cow GetCow { get; set; }
        public Chicken GetChicken { get; set; }
        public Turtle GetTurtle { get; set; }

        //public DataSaving(IDataSaving Method)
        //{
        //    this.Mode = Method;
        //}

        private void AnyPages()
        {
            GetCow = new();
            GetChicken = new();
            GetTurtle = new();

            var getCow = new Cow()
            {
                Name = GetCow.Name.ToString(),
                Producing = GetCow.Producing.ToString(),
                AmountProduce = GetCow.AmountProduce.ToString()
            };
            var getChicken = new Chicken()
            {
                Name = GetChicken.Name.ToString(),
                Producing = GetChicken.Producing.ToString(),
                AmountProduce = GetChicken.AmountProduce.ToString()
            };
            var getTurtle = new Turtle()
            {
                Name = GetTurtle.Name.ToString(),
                Producing = GetTurtle.Producing.ToString(),
                AmountProduce = GetTurtle.AmountProduce.ToString()
            };

            this.GetCow = getCow;
            this.GetChicken = getChicken;
            this.GetTurtle = getTurtle;
        }

        public void Save()
        {
            this.AnyPages();
            Mode.SaveDataCow(FilePath, GetCow);
            Mode.SaveDataChicken(FilePath, GetChicken);
            Mode.SaveDataTurtle(FilePath, GetTurtle);
        }
    }
}
