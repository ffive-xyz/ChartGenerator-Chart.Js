using ChartGeneratorChartJs.Config.Dataset;

namespace ChartGeneratorChartJs.Config
{
    public class ChartData
    {
        #region Public Properties

        public string[,] Labels { get; set; } = new string[0, 0];
        public DatasetOptions[] Datasets { get; set; } = new DatasetOptions[0];

        #endregion Public Properties
    }
}