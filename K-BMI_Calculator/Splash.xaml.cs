using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace K_BMI_Calculator;

public partial class Splash : ContentPage
{
    public Splash()
    {
        InitializeComponent();
    }
    
    protected override async void OnAppearing()
    {
        base.OnAppearing(); // Inherits the functionalities of its parent(?)
        await Task.Delay(2500); // Delays by 3,000 Milliseconds or 3 Seconds
        await Shell.Current.GoToAsync("//MainPage"); // Redirect to Main Page
    }
}