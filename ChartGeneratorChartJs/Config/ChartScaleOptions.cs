namespace ChartGeneratorChartJs.Config
{
    public class ChartScaleOptions
    {
        public ChartScaleOptions(bool XAxisStacked = false, bool YAxisStacked = false)
        {
            XAxes = new StackedProperty[] { new StackedProperty(XAxisStacked) };
            YAxes = new StackedProperty[] { new StackedProperty(YAxisStacked) };
        }

        public StackedProperty[] XAxes { get; }
        public StackedProperty[] YAxes { get; }

        public class StackedProperty
        {
            public StackedProperty(bool Stacked)
            {
                this.Stacked = Stacked;
            }
            public bool Stacked { get; }
        }
    }
}