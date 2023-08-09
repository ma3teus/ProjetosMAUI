using System;

namespace AppNumeroDaSorte;

public partial class MainPage : ContentPage
{
    public MainPage()
    {
        InitializeComponent();
    }

    private void OnGerenateLuckNumbers(object sender, EventArgs e)
    {
        AppName.IsVisible = false;
        ConainerLuckNumbers.IsVisible = true;

        var set = LuckNumbersGenerator();

        LuckNumber01.Text = set.ElementAt(0).ToString("D2");
        LuckNumber02.Text = set.ElementAt(1).ToString("D2");
        LuckNumber03.Text = set.ElementAt(1).ToString("D2");
        LuckNumber04.Text = set.ElementAt(3).ToString("D2");
        LuckNumber05.Text = set.ElementAt(4).ToString("D2");
        LuckNumber06.Text = set.ElementAt(5).ToString("D2");
    }

    private SortedSet<int> LuckNumbersGenerator()
    {
        var set = new SortedSet<int>();
        while (set.Count < 6)
        {
            var random = new Random();
            var lockNumber = random.Next(1, 60);

            set.Add(lockNumber);
        }

        return set;
    }
}