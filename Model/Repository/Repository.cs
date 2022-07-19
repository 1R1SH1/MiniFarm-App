using MiniFarm_Patterns_MVP_Wpf_App.Model.Classes;
using MiniFarm_Patterns_MVP_Wpf_App.Model.Interfases;
using MiniFarm_Patterns_MVP_Wpf_App.Presenter;
using MiniFarm_Patterns_MVP_Wpf_App.View;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Controls;

namespace MiniFarm_Patterns_MVP_Wpf_App.Model.Repository
{
    public class Repository : IRepository<Cow>, IRepository<Chicken>, IRepository<Turtle>
    {
        private readonly AnimalContext _db = new();
        ListView lv = new ListView();
        MainWindow mw = new();

        public void Add(Cow entity)
        {
            _db.Cows.Add(entity);
            _db.SaveChanges();
        }

        public void Add(Chicken entity)
        {
            _db.Chickens.Add(entity);
            _db.SaveChanges();
        }

        public void Add(Turtle entity)
        {
            _db.Turtles.Add(entity);
            _db.SaveChanges();
        }

        public void Delete(Cow entity)
        {
            _db.Cows.Remove(entity);
            _db.SaveChanges();
        }

        public void Delete(Chicken entity)
        {
            _db.Chickens.Remove(entity);
            _db.SaveChanges();
        }

        public void Delete(Turtle entity)
        {
            _db.Turtles.Remove(entity);
            _db.SaveChanges();
        }

        public void UpdateCow(Cow entity)
        {
            Cow cow = (from m in _db.Cows
                       where m.Id == entity.Id
                       select m).FirstOrDefault();
            _db.SaveChanges();
        }

        public void UpdateChicken(Chicken entity)
        {
            Chicken bird = (from m in _db.Chickens
                            where m.Id == entity.Id
                            select m).FirstOrDefault();
            _db.SaveChanges();
        }

        public void UpdateTurtle(Turtle entity)
        {
            Turtle turtle = (from m in _db.Turtles
                             where m.Id == entity.Id
                             select m).FirstOrDefault();
            _db.SaveChanges();
        }

        public IEnumerable<Cow> GetAllCow()
        {
            return _db.Cows.ToList();
        }

        public IEnumerable<Chicken> GetAllChicken()
        {
            return _db.Chickens.ToList();
        }

        public IEnumerable<Turtle> GetAllTurtle()
        {
            return _db.Turtles.ToList();
        }

        public Cow GetCowById(int id)
        {
            return _db.Cows.Find(id);
        }

        public Chicken GetChickenById(int id)
        {
            return _db.Chickens.Find(id);
        }

        public Turtle GetTurtleById(int id)
        {
            return _db.Turtles.Find(id);
        }

        IEnumerable<Cow> IRepository<Cow>.GetAllChicken()
        {
            throw new System.NotImplementedException();
        }

        IEnumerable<Cow> IRepository<Cow>.GetAllTurtle()
        {
            throw new System.NotImplementedException();
        }

        Cow IRepository<Cow>.GetChickenById(int id)
        {
            throw new System.NotImplementedException();
        }

        Cow IRepository<Cow>.GetTurtleById(int id)
        {
            throw new System.NotImplementedException();
        }

        IEnumerable<Chicken> IRepository<Chicken>.GetAllCow()
        {
            throw new System.NotImplementedException();
        }

        IEnumerable<Chicken> IRepository<Chicken>.GetAllTurtle()
        {
            throw new System.NotImplementedException();
        }

        Chicken IRepository<Chicken>.GetCowById(int id)
        {
            throw new System.NotImplementedException();
        }

        Chicken IRepository<Chicken>.GetTurtleById(int id)
        {
            throw new System.NotImplementedException();
        }

        IEnumerable<Turtle> IRepository<Turtle>.GetAllCow()
        {
            throw new System.NotImplementedException();
        }

        IEnumerable<Turtle> IRepository<Turtle>.GetAllChicken()
        {
            throw new System.NotImplementedException();
        }

        Turtle IRepository<Turtle>.GetCowById(int id)
        {
            throw new System.NotImplementedException();
        }

        Turtle IRepository<Turtle>.GetChickenById(int id)
        {
            throw new System.NotImplementedException();
        }

        public void UpdateChicken(Cow entity)
        {
            throw new System.NotImplementedException();
        }

        public void UpdateTurtle(Cow entity)
        {
            throw new System.NotImplementedException();
        }

        public void UpdateCow(Chicken entity)
        {
            throw new System.NotImplementedException();
        }

        public void UpdateTurtle(Chicken entity)
        {
            throw new System.NotImplementedException();
        }

        public void UpdateCow(Turtle entity)
        {
            throw new System.NotImplementedException();
        }

        public void UpdateChicken(Turtle entity)
        {
            throw new System.NotImplementedException();
        }
    }
}
