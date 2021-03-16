using static ChartGeneratorChartJs.Config.ChartScaleOptions.FontProperty;

namespace ChartGeneratorChartJs.Config
{
    public class ChartScaleOptions
    {
        #region Public Constructors

        public ChartScaleOptions(bool XAxisStacked = false, bool YAxisStacked = false)
        {
            XAxes = new StackedProperty[] { new StackedProperty(XAxisStacked) };
            YAxes = new StackedProperty[] { new StackedProperty(YAxisStacked) };
        }

        #endregion Public Constructors

        #region Public Interfaces

        public interface IAxisProperty
        { }

        #endregion Public Interfaces

        #region Public Properties

        public IAxisProperty[] XAxes { get; set; } = new IAxisProperty[0];
        public IAxisProperty[] YAxes { get; set; } = new IAxisProperty[0];

        #endregion Public Properties

        #region Public Classes

        public class FontProperty : IAxisProperty
        {
            #region Public Properties

            public TicksProperty Ticks { get; set; }

            #endregion Public Properties

            #region Public Classes

            public class TicksProperty
            {
                #region Public Properties

                public double FontSize { get; set; }
                public double StepSize { get; set; }
                public double SuggestedMax { get;set;}
                public double SuggestedMin { get; set; }

                #endregion Public Properties
            }

            #endregion Public Classes
        }

        public class StackedProperty : IAxisProperty
        {
            #region Public Constructors

            public StackedProperty(bool Stacked)
            {
                this.Stacked = Stacked;
            }

            #endregion Public Constructors

            #region Public Properties

            public bool Stacked { get; }

            #endregion Public Properties
        }

        #endregion Public Classes
    }
}