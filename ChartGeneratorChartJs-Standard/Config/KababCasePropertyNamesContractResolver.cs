using Newtonsoft.Json.Serialization;

namespace ChartGeneratorChartJs.Config
{
    internal class KababCasePropertyNamesContractResolver : CamelCasePropertyNamesContractResolver
    {
        #region Protected Methods

        protected override string ResolvePropertyName(string propertyName)
        {
            return char.ToLower(propertyName[0]) + propertyName.Substring(1);
        }

        #endregion Protected Methods
    }
}