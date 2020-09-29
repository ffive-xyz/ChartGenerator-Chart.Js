namespace ChartGeneratorChartJs.Config
{
    public class ChartOptions
    {
        public bool Responsive { get; set; } = true;
        public double ResponsiveAnimationDuration { get; set; } = 0;
        public double AspectRatio { get; set; } = 2;
        public bool MaintainAspectRatio { get; set; } = true;
        public ChartTitleOptions Title { get; set; } = new ChartTitleOptions();
        public AnimationOptions Animation { get; set; } = new AnimationOptions();
        public LayoutOptions Layout { get; set; } = new LayoutOptions();
        public LegendOptions Legend { get; set; } = new LegendOptions();
        public ChartScaleOptions? Scales { get; set; }
    }
}