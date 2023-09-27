using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RadialbarSample
{
    internal class PowerfulPassportViewModel
    {        
        public ObservableCollection<PowerfulPassportModel> MostData { get; set; }
        public ObservableCollection<PowerfulPassportModel> LeastData { get; set; }
        public List<Brush> CustomBrushes { get; set; }
        public List<Brush> CustomBrushes1 { get; set; }

        public PowerfulPassportViewModel()
        {
            MostData = new ObservableCollection<PowerfulPassportModel>();
            MostData.Add(new PowerfulPassportModel() { Country = "Japan", Access = 193, FlagSymbol = "uae.png" });
            MostData.Add(new PowerfulPassportModel() { Country = "Singapore", Access = 193 ,FlagSymbol="colombia.png"});
            MostData.Add(new PowerfulPassportModel() { Country = "South Korea", Access = 192,FlagSymbol="ukraine.png" });
            MostData.Add(new PowerfulPassportModel() { Country = "Germany", Access = 191, FlagSymbol= "moldova.png" });
            MostData.Add(new PowerfulPassportModel() { Country = "Spain", Access = 191,FlagSymbol= "vincent.png" });
            MostData.Add(new PowerfulPassportModel() { Country = "Finland", Access = 190, FlagSymbol = "dominica.png" });
            MostData.Add(new PowerfulPassportModel() { Country = "Italy", Access = 190, FlagSymbol= "greneda.png" });
            MostData.Add(new PowerfulPassportModel() { Country = "Luxembourg", Access = 190 ,FlagSymbol= "peru.png" });
            MostData.Add(new PowerfulPassportModel() { Country = "Austria", Access = 189 ,FlagSymbol= "geogeria.png" });
            MostData.Add(new PowerfulPassportModel() { Country = "Denmark", Access = 189,FlagSymbol= "lucia.png" });

            LeastData = new ObservableCollection<PowerfulPassportModel>();
            LeastData.Add(new PowerfulPassportModel() { Country = "Eritrea", Access = 44 });
            LeastData.Add(new PowerfulPassportModel() { Country = "Iran", Access = 44 });
            LeastData.Add(new PowerfulPassportModel() { Country = "S.Sudan", Access = 44 });
            LeastData.Add(new PowerfulPassportModel() { Country = "DRC", Access = 42 });
            LeastData.Add(new PowerfulPassportModel() { Country = "Sudan", Access = 42 });
            LeastData.Add(new PowerfulPassportModel() { Country = "Kosovo", Access = 41 });
            LeastData.Add(new PowerfulPassportModel() { Country = "Lebanon", Access = 41 });
            LeastData.Add(new PowerfulPassportModel() { Country = "Sri Lanka", Access = 41 });
            LeastData.Add(new PowerfulPassportModel() { Country = "Bangaladesh", Access = 40 });

            CustomBrushes = new List<Brush>
            {
               Color.FromRgb(36, 47, 155),    
               Color.FromRgb(8, 131, 149),
               Color.FromRgb(199, 0, 57),
               Color.FromRgb(255, 0, 96),
               Color.FromRgb(248, 111, 3),
               Color.FromRgb(85, 122, 70),
               Color.FromRgb(39, 158, 255),
               Color.FromRgb(123, 40, 105),
               Color.FromRgb(236, 83, 176),
               Color.FromRgb(46, 67, 116),

            };

            CustomBrushes1 = new List<Brush>
            {
                Color.FromRgb(0, 153, 102),
                Color.FromRgb(249, 76, 16),
                Color.FromRgb(102, 0, 204),
                Color.FromRgb(220, 20, 60),
                Color.FromRgb(255, 215, 0),
                Color.FromRgb(0, 128, 128),
                Color.FromRgb(48, 133, 195),
                Color.FromRgb(34, 139, 34),
                Color.FromRgb(255, 105, 180),
            };
        }
        

        
    }
}
