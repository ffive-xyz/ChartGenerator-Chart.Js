using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json.Serialization;
using System.Collections.Generic;

namespace ChartGeneratorChartJs.Config
{
    // https://github.com/DefinitelyTyped/DefinitelyTyped/blob/master/types/chart.js/index.d.ts
    public class ChartConfig
    {
        #region Public Enums

        public enum ChartTypes
        {
            line, bar, horizontalBar, radar, doughnut, polarArea, bubble, pie, scatter
        }

        public enum PointStyles
        {
            circle, cross, crossRot, dash, line, rect, rectRounded, rectRot, star, triangle
        }

        public enum PositionTypes
        {
            left, right, top, bottom
        }

        public enum AlignTypes
        {
            start, center, end
        }

        public enum ScaleTypes
        {
            category, linear, logarithmic, time, radialLinear
        }

        public enum TimeUnits
        {
            millisecond, second, minute, hour, day, week, month, quarter, year
        }

        #endregion Public Enums

        #region Public Properties

        [JsonConverter(typeof(StringEnumConverter))]
        public ChartTypes Type { get; set; } = ChartTypes.line;

        public ChartOptions Options { get; set; } = new ChartOptions();

        public ChartData Data { get; set; } = new ChartData();

        #endregion Public Properties

        #region Internal Methods

        internal string CreateScript()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented, new JsonSerializerSettings
            {
                ContractResolver = new KababCasePropertyNamesContractResolver(),
                Converters = new List<JsonConverter> { new StringEnumConverter(true) }
            });
        }

        #endregion Internal Methods
    }
}