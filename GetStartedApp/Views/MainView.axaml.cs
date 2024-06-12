using Avalonia.Controls;
using Avalonia.Interactivity;
using System.Diagnostics;
using Avalonia.Interactivity;
using System.Diagnostics;
using System;
using Avalonia;

namespace GetStartedApp.Views;

public partial class MainView : UserControl
{
    public MainView()
    {
        InitializeComponent();
    }

    private void Button_Click(object? sender, Avalonia.Interactivity.RoutedEventArgs e)
    {
        ConvertCelsiusToFahrenheit();
    }

    private void ConvertCelsiusToFahrenheit()
    {
        if (Double.TryParse(celsius.Text, out double C))
        {
            var F = C * (9d / 5d) + 32;
            fahrenheit.Text = F.ToString("0.0");
        }
        else
        {
            celsius.Text = "0";
            fahrenheit.Text = "0";
        }

        Debug.WriteLine($"Click! Celsius={celsius.Text}, Fahrenheit={fahrenheit.Text}");
    }

    private void Celsius_TextChanged(object? sender, Avalonia.Controls.TextChangedEventArgs e)
    {
        ConvertCelsiusToFahrenheit();
    }
}
