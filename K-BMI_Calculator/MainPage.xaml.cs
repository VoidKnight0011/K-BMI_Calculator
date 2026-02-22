// using AndroidX.Activity.Result;

namespace K_BMI_Calculator;

public partial class MainPage : ContentPage
{

    public MainPage()
    {
        InitializeComponent();
    }

    public void CalculateBMI(object sender, EventArgs e)
    {
        double BMI = 0;
        // string sex = Sex.SelectedItem?.ToString();
        // int age = (int)Age.Value;
        string units = Units.SelectedItem?.ToString();
        if (units == null) return;
        if (units.Contains("Imperial")) {
            double heightImperial = (double)HeightImperial.Value;
            double weightImperial = (double)WeightImperial.Value;

            BMI = 703 * (weightImperial / Math.Pow((heightImperial * 12), 2));
        } else if (units.Contains("Metric"))
        {
            double heightMetric = (double)HeightMetric.Value;
            double weightMetric = (double)WeightMetric.Value;

            BMI = weightMetric / Math.Pow((heightMetric / 100), 2);
        } else {
            BMI = -1;
        }
        
        ResultLabel.Text = $"Your BMI: {BMI:F1}";
    }

    public void ChangeUnits(object sender, EventArgs e)
    {
        Picker picker = (Picker)sender;
        string selected = picker.SelectedItem?.ToString();
        
        ImperialUnits.IsVisible = selected == "Imperial";
        MetricUnits.IsVisible = selected == "Metric";
    }
    
}