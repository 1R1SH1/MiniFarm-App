using MiniFarm_Patterns_MVP_Wpf_App.Model.Classes;
using MiniFarm_Patterns_MVP_Wpf_App.Presenter;
using MiniFarm_Patterns_MVP_Wpf_App.Saving;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace MiniFarm_Patterns_MVP_Wpf_App.View.AnimalWindows
{
    /// <summary>
    /// Логика взаимодействия для CowsWindow.xaml
    /// </summary>
    public partial class CowsWindow : UserControl
    {
        private AnimalPresenter _ap;
        private NullAnimal _null = new();
        public CowsWindow()
        {
            _ap = new AnimalPresenter();
            InitializeComponent();
            animalsList.ItemsSource = _ap.GetCow();
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
            if (Name_txt.Text != "Корова")
            {
                Cow cow = new()
                {
                    Name = _null.Name,
                    Producing = _null.Producing,
                    AmountProduce = _null.AmountProduce
                };
                _ap.Add_Cow(cow);
                animalsList.ItemsSource = _ap.GetCow();
                CleareTextBox();
                pAddAnimal.IsOpen = false;
            }
            else if (Name_txt.Text == "Корова")
            {
                Cow cow = new()
                {
                    Name = Name_txt.Text.ToString(),
                    Producing = Producing_txt.Text.ToString(),
                    AmountProduce = AmountProduce_txt.Text.ToString()
                };
                _ap.Add_Cow(cow);
                animalsList.ItemsSource = _ap.GetCow();
                CleareTextBox();
                pAddAnimal.IsOpen = false;
            }
        }

        private void Button_Ok_DeleteAnimal(object sender, RoutedEventArgs e)
        {
            var cow = animalsList.SelectedItem as Cow;
            _ap.Delete_Cow(cow);
            animalsList.ItemsSource = _ap.GetCow();
            pDeleteAnimal.IsOpen = false;
        }

        private void Button_Ok_ChangeAnimalData(object sender, RoutedEventArgs e)
        {
            var name = (animalsList.SelectedItem as Cow);
            name.AmountProduce = ChangedProduce_txt.Text;
            _ap.Change_Cow(name);
            animalsList.ItemsSource = _ap.GetCow();
            pChange.IsOpen = false;
        }

        private void Button_Ok_Saving(object sender, RoutedEventArgs e)
        {
            var saveToDocx = new SaveAsDocx("Сохранение");

            DataSaving bw = new DataSaving();

            bw.Save();
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
