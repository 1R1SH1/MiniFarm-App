using MiniFarm_Patterns_MVP_Wpf_App.Model.Classes;
using MiniFarm_Patterns_MVP_Wpf_App.Presenter;
using MiniFarm_Patterns_MVP_Wpf_App.Saving;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace MiniFarm_Patterns_MVP_Wpf_App.View.AnimalWindows
{
    /// <summary>
    /// Логика взаимодействия для TurtlesWindow.xaml
    /// </summary>
    public partial class TurtlesWindow : UserControl
    {
        private AnimalPresenter _ap;
        private NullAnimal _null = new();

        public TurtlesWindow()
        {
            _ap = new AnimalPresenter();
            InitializeComponent();
            animalsList.ItemsSource = _ap.GetTurtle();
        }

        private void MenuItem_Add_Animal_Click(object sender, RoutedEventArgs e)
        {
            pAddAnimal.IsOpen = true;
        }

        private void MenuItem_Delete_Animal_Click(object sender, RoutedEventArgs e)
        {
            pDeleteAnimal.IsOpen = true;
        }

        private void MenuItem_Change_Animal_Click(object sender, RoutedEventArgs e)
        {
            pChange.IsOpen = true;
        }

        private void MenuItem_Saving_Click(object sender, RoutedEventArgs e)
        {
            pSave.IsOpen = true;
        }

        private void animalList_OnPreviewMouseRightButtonUp(object sender, MouseButtonEventArgs e)
        {
            var item = (sender as ListView).SelectedItem;
            if (item != null)
            {
                ContextMenu cm = this.FindResource("CmButton") as ContextMenu;
                cm.PlacementTarget = sender as Button;
                cm.IsOpen = true;
            }
        }

        private void Button_Ok_AddAnimal(object sender, RoutedEventArgs e)
        {
            if (Name_txt.Text != "Черепашка")
            {
                Turtle turtle = new()
                {
                    Name = _null.Name,
                    Producing = _null.Producing,
                    AmountProduce = _null.AmountProduce
                };
                _ap.Add_Turtle(turtle);
                animalsList.ItemsSource = _ap.GetTurtle();
                pAddAnimal.IsOpen = false;
            }
            else if (Name_txt.Text == "Черепашка")
            {
                Turtle turtle = new()
                {
                    Name = Name_txt.Text,
                    Producing = Producing_txt.Text,
                    AmountProduce = AmountProduce_txt.Text
                };
                _ap.Add_Turtle(turtle);
                animalsList.ItemsSource = _ap.GetTurtle();
                pAddAnimal.IsOpen = false;
            }
        }

        private void Button_Ok_DeleteAnimal(object sender, RoutedEventArgs e)
        {
            var turtle = animalsList.SelectedItem as Turtle;
            _ap.Delete_Turtle(turtle);
            animalsList.ItemsSource = _ap.GetTurtle();
            pDeleteAnimal.IsOpen = false;
        }

        private void Button_Ok_ChangeAnimalData(object sender, RoutedEventArgs e)
        {
            var name = (animalsList.SelectedItem as Turtle);
            name.AmountProduce = ChangedProduce_txt.Text;
            _ap.Change_Turtle(name);
            animalsList.ItemsSource = _ap.GetTurtle();
            pChange.IsOpen = false;
        }

        private void Button_Ok_Saving(object sender, RoutedEventArgs e)
        {
            var saveToDocx = new SaveAsDocx("Сохранение.docx");

            DataSaving bw = new DataSaving(saveToDocx);

            bw.Mode = saveToDocx;
            bw.SaveTurtle();
            CleareTextBox();
            pSave.IsOpen = false;
        }

        private void CleareTextBox()
        {
            Name_txt.Clear();
            Producing_txt.Clear();
            AmountProduce_txt.Clear();
            ChangedProduce_txt.Clear();
        }
    }
}
