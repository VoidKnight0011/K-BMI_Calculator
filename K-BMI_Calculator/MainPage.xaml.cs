// using Android.Telephony.Gsm;

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
        string sex = Sex.SelectedItem?.ToString();
        int age = (int)Age.Value;
        string units = Units.SelectedItem?.ToString();

        if (units.Contains("ImperialUnits")) {
                double heightFt = HeightFt.Value;
                double heightIn = HeightIn.Value;
            double heightImperial = (heightFt * 12) + heightIn;
            double weightImperial = double.Parse(WeightLbs.Text);

            BMI = 703 * (weightImperial / Math.Pow(heightImperial, 2));
        } else if (units.Contains("MetricUnits")) {
            double heightMetric = double.Parse(HeightCm.Text);
            double weightMetric = double.Parse(WeightKg.Text);

            BMI = weightMetric / Math.Pow(heightMetric, 2);
        }
        else
        {
            BMI = -1;
        }
        
        ResultLabel.Text = $"Your BMI: {BMI:F1}";
    }

    public void ChangeUnits(object sender, EventArgs e)
    {
        // To Do
    }
    
}