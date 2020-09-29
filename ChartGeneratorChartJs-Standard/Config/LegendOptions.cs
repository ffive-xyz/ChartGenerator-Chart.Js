using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace ChartGeneratorChartJs.Config
{
    public class LegendOptions
    {
        public enum Positions
        {
            top, left, bottom, right
        }

        public bool Display { get; set; } = true;

        [JsonConverter(typeof(StringEnumConverter))]
        public ChartConfig.PositionTypes Position { get; set; } = ChartConfig.PositionTypes.bottom;

        [JsonConverter(typeof(StringEnumConverter))]
        public ChartConfig.AlignTypes Align { get; set; } = ChartConfig.AlignTypes.Center;

        public bool FullWidth { get; set; } = true;
        public bool Reverse { get; set; } = false;
        public LegendLabelConfiguration Labels { get; set; } = new LegendLabelConfiguration();

        public class LegendLabelConfiguration
        {
            public double BoxWidth { get; set; } = 80;
            public double FontSize { get; set; } = 25;
            public string FontStyle { get; set; } = "bold";
            public string FontColor { get; set; } = "#666";
            public double Padding { get; set; } = 50;
        }
    }
}