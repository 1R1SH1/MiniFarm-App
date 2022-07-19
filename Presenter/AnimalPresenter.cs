using MiniFarm_Patterns_MVP_Wpf_App.Model.Classes;
using MiniFarm_Patterns_MVP_Wpf_App.Model.Repository;
using System.Collections.Generic;

namespace MiniFarm_Patterns_MVP_Wpf_App.Presenter
{
    public class AnimalPresenter
    {
        private readonly AnimalContext _db = new();
        private Repository _rep = new();

        public IEnumerable<Cow> GetCow()
        {
            return _rep.GetAllCow();
        }

        public IEnumerable<Chicken> GetChicken()
        {
            return _rep.GetAllChicken();
        }

        public IEnumerable<Turtle> GetTurtle()
        {
            return _rep.GetAllTurtle();
        }

        public void Add_Cow(Cow animal)
        {
            _rep.Add(animal);
        }

        public void Add_Chicken(Chicken animal)
        {
            _rep.Add(animal);
        }

        public void Add_Turtle(Turtle animal)
        {
            _rep.Add(animal);
        }

        public void Delete_Cow(Cow animal)
        {
            _rep.Delete(animal);
        }
        public void Delete_Chicken(Chicken animal)
        {
            _rep.Delete(animal);
        }

        public void Delete_Turtle(Turtle animal)
        {
            _rep.Delete(animal);
        }

        public void Change_Cow(Cow animal)
        {
            _rep.UpdateCow(animal);
        }
        public void Change_Chicken(Chicken animal)
        {
            _rep.UpdateChicken(animal);
        }
        public void Change_Turtle(Turtle animal)
        {
            _rep.UpdateTurtle(animal);
        }
    }
}
