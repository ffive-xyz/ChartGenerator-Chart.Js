using ChartGeneratorChartJs.Config.Dataset;

namespace ChartGeneratorChartJs.Config
{
    public class ChartData
    {
        public string[] Labels { get; set; } = new string[0];
        public DatasetOptions[] Datasets { get; set; } = new DatasetOptions[0];
    }
}