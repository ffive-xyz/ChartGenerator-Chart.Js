using ChartGeneratorChartJs.Config;
using ChartGeneratorChartJs.Config.Dataset;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using Xunit.Abstractions;

namespace ChartGenerator_ChartJs_Test
{
    public class TestSerialization
    {
        #region Private Fields

        private static readonly string[] BackgroundColorSet1 = new[]
                        {
                            "rgba(255, 99, 132, 0.8)",
                            "rgba(255, 206, 86, 0.8)",
                            "rgba(54, 162, 235, 0.8)",
                            "rgba(75, 192, 192, 0.8)",
                            "rgba(153, 102, 255, 0.8)",
                            "rgba(255, 159, 64, 0.8)"
                        };

        private static readonly string[] BorderColorSet1 = BackgroundColorSet1;

        private readonly ITestOutputHelper output;

        #endregion Private Fields

        #region Public Constructors

        public TestSerialization(ITestOutputHelper output)
        {
            this.output = output;
        }

        #endregion Public Constructors

        #region Public Methods

        [Fact]
        public void barChart()
        {
            var config = new ChartConfig
            {
                Type = ChartConfig.ChartTypes.bar,
                Options = new ChartOptions
                {
                    Title = new ChartTitleOptions
                    {
                        Display = true,
                        Text = "hello",
                        FontSize = 50
                    },
                    AspectRatio = 1.4
                },
                Data = new ChartData
                {
                    Datasets = new DatasetOptions[]
                    {
                        new DatasetOptions
                        {
                            Label="asdkjh".Split(' '),
                            Data = new double[] { 10,20,30,40},
                            BackgroundColor = BackgroundColorSet1,
                            BorderColor = BorderColorSet1,
                            BorderWidth = 1
                        }
                    },
                    Labels = new[,] { { "asjkd" } }
                }
            };
            check(config);
        }

        #endregion Public Methods

        #region Private Methods

        private void check(ChartConfig config)
        {
            var json = JsonConvert.SerializeObject(config);
            Console.WriteLine(json);
            var unjson = JsonConvert.DeserializeObject<ChartConfig>(json);
            var rejson = JsonConvert.SerializeObject(unjson);
            output.WriteLine(json);
            Assert.Equal(json, rejson);
        }

        #endregion Private Methods
    }
}