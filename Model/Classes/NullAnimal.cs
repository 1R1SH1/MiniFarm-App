namespace MiniFarm_Patterns_MVP_Wpf_App.Model.Classes
{
    public class NullAnimal
    {
        public NullAnimal()
        {
            Name = "Бдительный Суслик";
            Producing = "Сигнализатор опасности";
            AmountProduce = "Орёт, по чём, зря...";
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Producing { get; set; }
        public string AmountProduce { get; set; }
    }
}
