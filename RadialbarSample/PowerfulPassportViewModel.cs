using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RadialbarSample
{
    public  class PowerfulPassportViewModel
    {
        
        public string[] Region => new string[] { "Asia", "Europe", "World" };
        public ObservableCollection<PowerfulPassportModel> WorldMostData { get; set; } = new ObservableCollection<PowerfulPassportModel>();
        public ObservableCollection<PowerfulPassportModel> AsianMostData { get; set; } = new ObservableCollection<PowerfulPassportModel>();
        public ObservableCollection<PowerfulPassportModel> EuropeanMostData { get; set; } = new ObservableCollection<PowerfulPassportModel>();
        public ObservableCollection<PowerfulPassportModel> WorldLeastData { get; set; } = new ObservableCollection<PowerfulPassportModel>();
        public ObservableCollection<PowerfulPassportModel> AsianLeastData { get; set; } = new ObservableCollection<PowerfulPassportModel>();
        public ObservableCollection<PowerfulPassportModel> EuropeanLeastData { get; set; } = new ObservableCollection<PowerfulPassportModel>();
        public List<Brush> CustomBrushes { get; set; } = new List<Brush>();
        public List<Brush> CustomBrushes1 { get; set; } = new List<Brush>();

        public PowerfulPassportViewModel()
        {
            // Populate WorldMostData
            PopulateData(WorldMostData, new[]
            {
                ("Japan", 190),("Austria", 189),("Belgium",188),("Canada",187),("Greece",186)
            }); 

            // Populate AsianMostData
            PopulateData(AsianMostData, new[]
            {
                ("Singapore", 193), ("Malaysia", 181), ("UAE", 179),
                ("Hong Kong", 167), ("Israel", 159)
            });

            // Populate EuropeanMostData
            PopulateData(EuropeanMostData, new[]
            {
                ("Finland", 190), ("Austria", 189), ("Denmark", 189),
                ("Bulgaria", 176), ("Norway", 188)
            });

            // Populate WorldLeastData
            PopulateData(WorldLeastData, new[]
            {
                ("Iran", 43), ("Libya", 40), ("Sudan", 44),
                ("Yemen", 34), ("Somalia", 35)
            });

            // Populate AsianLeastData
            PopulateData(AsianLeastData, new[]
            {
                ("Afghanistan", 27), ("Syria", 28), ("Iraq", 29),
                ("Pakistan", 33), ("Nepal", 39)
            });

            // Populate EuropeanLeastData
            PopulateData(EuropeanLeastData, new[]
            {
                ("Belarus", 79), ("Albania", 119), ("Montenegro", 124),
                ("Moldova", 121), ("Kosovo", 40)
            });

            // Populate CustomBrushes
            CustomBrushes = new List<Brush>
            {
                new SolidColorBrush(Color.FromArgb("#F6991E")),
                new SolidColorBrush(Color.FromArgb("#439772")),
                new SolidColorBrush(Color.FromArgb("#A4382D")),
                new SolidColorBrush(Color.FromArgb("#2A78F4")),
                new SolidColorBrush(Color.FromArgb("#D82591")),
            };

            // Populate CustomBrushes1
            CustomBrushes1 = new List<Brush>
            {
                new SolidColorBrush(Color.FromArgb("#70ad47")),
                new SolidColorBrush(Color.FromArgb("#dd8abd")),
                new SolidColorBrush(Color.FromArgb("#7f84e8")),
                new SolidColorBrush(Color.FromArgb("#7bb4eb")),
                new SolidColorBrush(Color.FromArgb("#ea7a57"))
            };
        }

        private void PopulateData(ObservableCollection<PowerfulPassportModel> collection, IEnumerable<(string Country, int Access)> data)
        {
            foreach (var (country, access) in data)
            {
                collection.Add(new PowerfulPassportModel { Country = country, Access = access });
            }
        }
    }
}
