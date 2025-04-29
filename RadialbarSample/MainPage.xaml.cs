namespace RadialbarSample
{
    public partial class MainPage : ContentPage
    {
        // PowerfulPassportViewModel viewModel = new PowerfulPassportViewModel();
        public MainPage()
        {
            InitializeComponent();
        }


        private void Picker_SelectedIndexChanged(object sender, EventArgs e)
        {
            var picker = sender as Picker;
            string selectedRegion = picker.SelectedIndex switch
            {
                0 => "Asia's",
                1 => "Europe's",
                _ => "World's"
            };

            label.Text = selectedRegion;
            label1.Text = selectedRegion;

            var mostData = picker.SelectedIndex switch
            {
                0 => viewModel.AsianMostData,
                1 => viewModel.EuropeanMostData,
                _ => viewModel.WorldMostData
            };

            var leastData = picker.SelectedIndex switch
            {
                0 => viewModel.AsianLeastData,
                1 => viewModel.EuropeanLeastData,
                _ => viewModel.WorldLeastData
            };

            series.ItemsSource = mostData;
            series1.ItemsSource = leastData;
        }
    }

}
