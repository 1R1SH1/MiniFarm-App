using System.Collections.Generic;

namespace MiniFarm_Patterns_MVP_Wpf_App.Model.Interfases
{
    public interface IRepository<T>
    {
        IEnumerable<T> GetAllCow();
        IEnumerable<T> GetAllChicken();
        IEnumerable<T> GetAllTurtle();
        T GetCowById(int id);
        T GetChickenById(int id);
        T GetTurtleById(int id);
        void Add(T entity);
        void UpdateCow(T entity);
        void UpdateChicken(T entity);
        void UpdateTurtle(T entity);
        void Delete(T entity);
    }
}
