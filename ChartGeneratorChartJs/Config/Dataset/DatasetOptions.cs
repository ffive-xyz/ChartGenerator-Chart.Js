namespace ChartGeneratorChartJs.Config.Dataset
{
    public class DatasetOptions
    {
        public string Label { get; set; } = "";
        public double[] Data { get; set; } = new double[0];
        public string[] BackgroundColor { get; set; } = new string[0];
        public string[] BorderColor { get; set; } = new string[0];
        public double BorderWidth { get; set; } = 1;
    }
}