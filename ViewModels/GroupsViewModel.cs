using System.Collections.ObjectModel;
using AnalyserTestMobileApp.ViewModels;
using TestAnalyserMaui.Models;

namespace TestAnalyserMaui.ViewModels;

public class GroupsViewModel : BaseViewModel
{
    static Random random = new();
    public ObservableCollection<Group> Items { get; } = new();

    public GroupsViewModel()
    {
        IsBusy = true;
        for (var i = 0; i < 200; i++)
        {
            Items.Add(new Group()
            {
                Id = i,
                Name = "Person " + i,
                CountStudents = random.Next(14, 85),
            });
        }

        IsBusy = false;
    }
}