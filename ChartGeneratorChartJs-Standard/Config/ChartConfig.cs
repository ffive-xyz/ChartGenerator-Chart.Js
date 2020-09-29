using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json.Serialization;
using System.Collections.Generic;

namespace ChartGeneratorChartJs.Config
{
    // https://github.com/DefinitelyTyped/DefinitelyTyped/blob/master/types/chart.js/index.d.ts
    public class ChartConfig
    {
        public enum ChartTypes
        {
            Line, Bar, HorizontalBar, Radar, Doughnut, PolarArea, Bubble, Pie, Scatter
        }

        public enum PointStyles
        {
            Circle, Cross, CrossRot, Dash, Line, Rect, RectRounded, RectRot, Star, Triangle
        }

        public enum PositionTypes
        {
            left, right, top, bottom
        }

        public enum AlignTypes
        {
            Start, Center, End
        }

        public enum ScaleTypes
        {
            Category, Linear, Logarithmic, Time, RadialLinear
        }

        public enum TimeUnits
        {
            Millisecond, Second, Minute, Hour, Day, Week, Month, Quarter, Year
        }

        public ChartTypes Type { get; set; } = ChartTypes.Line;

        public ChartOptions Options { get; set; } = new ChartOptions();

        public ChartData Data { get; set; } = new ChartData();

        internal string CreateScript()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented, new JsonSerializerSettings
            {
                ContractResolver = new CamelCasePropertyNamesContractResolver(),
                Converters = new List<JsonConverter> { new StringEnumConverter(true) }
            });
        }
    }
}