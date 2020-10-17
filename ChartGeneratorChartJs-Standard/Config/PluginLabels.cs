using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace ChartGeneratorChartJs.Config
{
    public class PluginLabels
    {
        #region Public Enums

        public enum RenderEnum
        {
            label, value, percentage
        }

        public enum PositionEnum
        {
            @default, border, outside
        }

        #endregion Public Enums

        #region Public Properties

        [JsonConverter(typeof(StringEnumConverter))]
        public RenderEnum Render { get; set; } = RenderEnum.percentage;

        public double Precision { get; set; } = 0;
        public bool ShowZero { get; set; } = false;
        public double FontSize { get; set; } = 12;
        public string FontColor { get; set; } = "#000";
        public string FontStyle { get; set; } = "normal";
        public string FontFamily { get; set; } = "'Helvetica Neue', 'Helvetica', 'Arial', sans-serif";
        public bool TextShadow { get; set; } = false;
        public double ShadowBlur { get; set; } = 6;
        public double ShadowOffsetX { get; set; } = 3;
        public double ShadowOffsetY { get; set; } = 3;
        public string ShadowColor { get; set; } = "rgba(0,0,0,0.3)";
        public bool Arc { get; set; } = false;

        [JsonConverter(typeof(StringEnumConverter))]
        public PositionEnum Position { get; set; } = PositionEnum.@default;

        public bool Overlap { get; set; } = true;
        public bool ShowActualPercentage { get; set; } = true;
        public double OutsidePadding { get; set; } = 2;
        public double TextMargin { get; set; } = 2;

        #endregion Public Properties
    }
}