namespace ChartGeneratorChartJs.Config
{
    public class LayoutOptions
    {
        public PaddingOptions Padding { get; set; } = new PaddingOptions(0);

        public class PaddingOptions
        {
            public double Left { get; set; }
            public double Right { get; set; }
            public double Top { get; set; }
            public double Bottom { get; set; }

            public PaddingOptions(int value) => Left = Right = Top = Bottom = value;
            public PaddingOptions(){}
        }
    }
}