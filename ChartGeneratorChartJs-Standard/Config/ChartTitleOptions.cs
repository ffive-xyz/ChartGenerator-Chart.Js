using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace ChartGeneratorChartJs.Config
{
    public class ChartTitleOptions
    {
        #region Public Properties

        public bool Display { get; set; } = false;

        public ChartConfig.PositionTypes Position { get; set; } = ChartConfig.PositionTypes.top;

        public double FontSize { get; set; } = 12;
        public string FontColor { get; set; } = "#666";
        public string FontStyle { get; set; } = "bold";

        public double Padding { get; set; } = 20;
        public double LineHeight { get; set; } = 1.2;
        public string Text { get; set; } = string.Empty;

        #endregion Public Properties
    }
}