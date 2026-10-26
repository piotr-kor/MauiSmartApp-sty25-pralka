using System.Diagnostics.Metrics;

namespace MauiSmartApp_sty25_pralka;

public partial class MainPage : ContentPage
{
    private int counter1 = 0;
    private int counter2 = 0;
    private int counter3 = 0;

    public MainPage()
    {
        InitializeComponent();
    }

    private void OnCounter1Clicked(object sender, EventArgs e)
    {
        counter1++;
        counter3--;
        CounterButton1.Text = $"Licznik 1: {counter1}";
        CounterButton3.Text = $"Licznik 3: {counter3}";
    }

    private void OnCounter2Clicked(object sender, EventArgs e)
    {
        counter2++;
        counter3--;
        CounterButton2.Text = $"Licznik 2: {counter2}";
        CounterButton3.Text = $"Licznik 3: {counter3}";
    }

    private void OnCounter3Clicked(object sender, EventArgs e)
    {
        counter3++;
        CounterButton3.Text = $"Licznik 3: {counter3}";
    }

    private async void OnEntryUnfocused(
        object sender, FocusEventArgs e)
    {
        string text = UserEntry.Text?.Trim() ?? "";

        if (string.IsNullOrWhiteSpace(text))
        {
            await DisplayAlertAsync(
                "SmartAPP",
                "Opuszczono pole edycyjne. Nie wpisano tekstu.",
                "OK");
        }
        else
        {
            await DisplayAlertAsync(
                "SmartAPP",
                $"Wpisany tekst: {text}",
                "OK");
        }
    }
}