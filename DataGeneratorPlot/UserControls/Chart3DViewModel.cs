using DataGeneratorPlot.Models;
using DevExpress.Mvvm.CodeGenerators;
using System.Collections.ObjectModel;

namespace DataGeneratorPlot.UserControls
{
    [GenerateViewModel]
    public partial class Chart3DViewModel
    {
        public ObservableCollection<ChartSeries> DataPoints { get; set; }

        public Chart3DViewModel()
        {
            DataPoints = new ObservableCollection<ChartSeries>
            {
                new ChartSeries(1, 2, 3),
                new ChartSeries(3, 4, 5),
                new ChartSeries(5, 6, 7)
            };
        }
    }
}

