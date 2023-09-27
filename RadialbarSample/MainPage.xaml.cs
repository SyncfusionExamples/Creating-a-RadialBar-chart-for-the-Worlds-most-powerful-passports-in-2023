using Syncfusion.Maui.Charts;

namespace RadialbarSample;

public partial class MainPage : ContentPage
{

	public MainPage()
	{
		InitializeComponent();
	}

    private void DataPointSelectionBehavior_SelectionChanged(object sender, Syncfusion.Maui.Charts.ChartSelectionChangedEventArgs e)
    {
        var series = sender as RadialBarSeries;

        if (series != null)
        {
            int selectedIndex = series.SelectionBehavior.SelectedIndex;

            if (selectedIndex < new PowerfulPassportViewModel().MostData.Count)
            {
                string selectedCountry = new PowerfulPassportViewModel().MostData[selectedIndex].Country;
                double freeAccess = new PowerfulPassportViewModel().MostData[selectedIndex].Access;
                StackLayout layout = new StackLayout();

                var label = new Label { Text = "Free Access", TextColor = Colors.Black, HorizontalOptions = LayoutOptions.Center, VerticalOptions = LayoutOptions.Fill,Margin=new Thickness(0,20,0,0),FontAttributes= FontAttributes.Bold}; 
                var label1 = new Label { Text = "Permitted by", Margin=new Thickness(10,0,0,0), FontAttributes = FontAttributes.Bold };
                var label2 = new Label { Text = selectedCountry + " : " + freeAccess,Margin= new Thickness(10, 0, 0, 0), FontAttributes = FontAttributes.Bold };
                layout.SetBinding(HeightRequestProperty, nameof(RadialBarSeries.CenterHoleSize));
                layout.SetBinding(WidthRequestProperty, nameof(RadialBarSeries.CenterHoleSize));
                layout.Background = Colors.White;
                layout.Children.Add(label);
                layout.Children.Add(label1);
                layout.Children.Add(label2);
                series.CenterView = layout;
            }
        }
    }

}

