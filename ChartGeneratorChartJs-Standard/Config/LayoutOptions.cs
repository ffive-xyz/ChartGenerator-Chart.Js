namespace ChartGeneratorChartJs.Config
{
    public class LayoutOptions
    {
        #region Public Properties

        public PaddingOptions Padding { get; set; } = new PaddingOptions(0);

        #endregion Public Properties

        #region Public Classes

        public class PaddingOptions
        {
            #region Public Constructors

            public PaddingOptions(int value) => Left = Right = Top = Bottom = value;

            public PaddingOptions()
            {
            }

            #endregion Public Constructors

            #region Public Properties

            public double Left { get; set; }
            public double Right { get; set; }
            public double Top { get; set; }
            public double Bottom { get; set; }

            #endregion Public Properties
        }

        #endregion Public Classes
    }
}