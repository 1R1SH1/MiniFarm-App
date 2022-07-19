using MiniFarm_Patterns_MVP_Wpf_App.Model.Classes;
using System.Data.Entity;

namespace MiniFarm_Patterns_MVP_Wpf_App.Presenter
{
    public class AnimalContext : DbContext
    {
        public AnimalContext() : base("DbConnection") { }
        public DbSet<Cow> Cows { get; set; }
        public DbSet<Chicken> Chickens { get; set; }
        public DbSet<Turtle> Turtles { get; set; }
        public DbSet<NullAnimal> NullAnimals { get; set; }
    }
}
