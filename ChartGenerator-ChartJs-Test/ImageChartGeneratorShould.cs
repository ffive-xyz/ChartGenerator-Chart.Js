using ChartGeneratorChartJs;
using ChartGeneratorChartJs.Config;
using System;
using System.IO;
using System.Threading.Tasks;
using Xunit;

namespace ChartGenerator_ChartJs_Test
{
    public class ImageChartGeneratorShould
    {
        #region Public Methods

        [Fact]
        public async Task CreateBarImageAsync()
        {
            using var sut = new ImageChartGenerator(true);
            var config = new ChartConfig
            {
                Type = ChartConfig.ChartTypes.bar,
                Options = new ChartOptions
                {
                    Title = new ChartTitleOptions
                    {
                        Display = true,
                        Text = "This is cool"
                    },
                    AspectRatio = 1.4,
                    Scales = new ChartScaleOptions
                    {
                        YAxes = new ChartScaleOptions.IAxisProperty[]
                        {
                            new ChartScaleOptions.FontProperty
                            {
                                Ticks = new ChartScaleOptions.FontProperty.TicksProperty
                                {
                                    FontSize = 20
                                }
                            }
                        }
                    },
                    Legend = new LegendOptions
                    {
                        Labels = new LegendOptions.LegendLabelConfiguration
                        {
                            FontSize = 20
                        }
                    },
                    Plugins = new Plugins
                    {
                        Labels = new PluginLabels
                        {
                            FontSize = 20,
                            Render = PluginLabels.RenderEnum.value,
                            FontColor = "#000"
                        }
                    }
                },
                Data = new ChartData
                {
                    Labels = new string[] { "Red", "Blue", "Yellow", "Green", "Purple", "Orange" },
                    Datasets = new ChartGeneratorChartJs.Config.Dataset.DatasetOptions[]
                    {
                        new ChartGeneratorChartJs.Config.Dataset.DatasetOptions
                        {
                            Label="# of voters".Split(' '),
                            Data = new double[] { 12, 19, 3, 5, 2, 3 },
                            BackgroundColor = new string[]
                            {
                                "rgba(255, 99, 132, 0.2)",
                                "rgba(54, 162, 235, 0.2)",
                                "rgba(255, 206, 86, 0.2)",
                                "rgba(75, 192, 192, 0.2)",
                                "rgba(153, 102, 255, 0.2)",
                                "rgba(255, 159, 64, 0.2)"
                            },
                            BorderColor = new string[]
                            {
                                "rgba(255, 99, 132, 0.2)",
                                "rgba(54, 162, 235, 0.2)",
                                "rgba(255, 206, 86, 0.2)",
                                "rgba(75, 192, 192, 0.2)",
                                "rgba(153, 102, 255, 0.2)",
                                "rgba(255, 159, 64, 0.2)"
                            },
                            BorderWidth = 1
                        },
                        new ChartGeneratorChartJs.Config.Dataset.DatasetOptions
                        {
                            Label="# of testers".Split(' '),
                            Data = new double[] { 102, 109, 30, 50, 20, 30 },
                            BackgroundColor = new string[]
                            {
                                "rgba(255, 99, 132, 0.2)",
                                "rgba(54, 162, 235, 0.2)",
                                "rgba(255, 206, 86, 0.2)",
                                "rgba(75, 192, 192, 0.2)",
                                "rgba(153, 102, 255, 0.2)",
                                "rgba(255, 159, 64, 0.2)"
                            },
                            BorderColor = new string[]
                            {
                                "rgba(255, 99, 132, 0.2)",
                                "rgba(54, 162, 235, 0.2)",
                                "rgba(255, 206, 86, 0.2)",
                                "rgba(75, 192, 192, 0.2)",
                                "rgba(153, 102, 255, 0.2)",
                                "rgba(255, 159, 64, 0.2)"
                            },
                            BorderWidth = 1
                        }
                    }
                }
            };

            var x = await sut.GenerateChartAsync(config);
            File.WriteAllBytes("generatedBar.jpg", x);

            Assert.True(true);
        }

        [Fact]
        public async Task CreateStackedBarImageAsync()
        {
            using var sut = new ImageChartGenerator(true);
            var config = new ChartConfig
            {
                Type = ChartConfig.ChartTypes.bar,
                Options = new ChartOptions
                {
                    Title = new ChartTitleOptions
                    {
                        Display = true,
                        Text = "This is cool"
                    },
                    AspectRatio = 1.4,
                    Scales = new ChartScaleOptions(true, true)
                },
                Data = new ChartData
                {
                    Labels = new string[] { "Red", "Blue", "Yellow", "Green", "Purple", "Orange" },
                    Datasets = new ChartGeneratorChartJs.Config.Dataset.DatasetOptions[]
                    {
                        new ChartGeneratorChartJs.Config.Dataset.DatasetOptions
                        {
                            Label="# of voters".Split(' '),
                            Data = new double[] { 12, 19, 3, 5, 2, 3 },
                            BackgroundColor = new string[]
                            {
                                "rgba(255, 99, 132, 0.2)",
                                "rgba(54, 162, 235, 0.2)",
                                "rgba(255, 206, 86, 0.2)",
                                "rgba(75, 192, 192, 0.2)",
                                "rgba(153, 102, 255, 0.2)",
                                "rgba(255, 159, 64, 0.2)"
                            },
                            BorderColor = new string[]
                            {
                                "rgba(255, 99, 132, 1)",
                                "rgba(54, 162, 235, 1)",
                                "rgba(255, 206, 86, 1)",
                                "rgba(75, 192, 192, 1)",
                                "rgba(153, 102, 255, 1)",
                                "rgba(255, 159, 64, 1)"
                            },
                            BorderWidth = 1
                        },
                        new ChartGeneratorChartJs.Config.Dataset.DatasetOptions
                        {
                            Label="# of testers".Split(' '),
                            Data = new double[] { 102, 109, 30, 50, 20, 30 },
                            BackgroundColor = new string[]
                            {
                                "rgba(255, 99, 132, 0.2)",
                                "rgba(54, 162, 235, 0.2)",
                                "rgba(255, 206, 86, 0.2)",
                                "rgba(75, 192, 192, 0.2)",
                                "rgba(153, 102, 255, 0.2)",
                                "rgba(255, 159, 64, 0.2)"
                            },
                            BorderColor = new string[]
                            {
                                "rgba(255, 99, 132, 0.2)",
                                "rgba(54, 162, 235, 0.2)",
                                "rgba(255, 206, 86, 0.2)",
                                "rgba(75, 192, 192, 0.2)",
                                "rgba(153, 102, 255, 0.2)",
                                "rgba(255, 159, 64, 0.2)"
                            },
                            BorderWidth = 1
                        }
                    }
                }
            };

            var x = await sut.GenerateChartAsync(config);
            File.WriteAllBytes("generatedBarStack.jpg", x);

            Assert.True(true);
        }

        [Fact]
        public async Task CreateLineImageAsync()
        {
            using var sut = new ImageChartGenerator(true);
            var config = new ChartConfig
            {
                Type = ChartConfig.ChartTypes.line,
                Options = new ChartOptions
                {
                    Title = new ChartTitleOptions
                    {
                        Display = true,
                        Text = "This is cool"
                    },
                    AspectRatio = 1.4
                },
                Data = new ChartData
                {
                    Labels = new string[] { "Red", "Blue", "Yellow", "Green", "Purple", "Orange" },
                    Datasets = new ChartGeneratorChartJs.Config.Dataset.DatasetOptions[]
                    {
                        new ChartGeneratorChartJs.Config.Dataset.DatasetOptions
                        {
                            Label="# of voters".Split(' '),
                            Data = new double[] { 12, 19, 3, 5, 2, 3 },
                            BackgroundColor = new string[]
                            {
                                "rgba(255, 99, 132, 0.2)"
                            },
                            BorderColor = new string[]
                            {
                                "rgba(255, 99, 132, 0.2)"
                            },
                            BorderWidth = 1
                        },
                        new ChartGeneratorChartJs.Config.Dataset.DatasetOptions
                        {
                            Label="# of testers".Split(' '),
                            Data = new double[] { 102, 109, 30, 50, 20, 30 },
                            BackgroundColor = new string[]
                            {
                                "rgba(255, 99, 132, 0.2)"
                            },
                            BorderColor = new string[]
                            {
                                "rgba(255, 99, 132, 0.2)"
                            },
                            BorderWidth = 1
                        }
                    }
                }
            };

            var x = await sut.GenerateChartAsync(config);
            File.WriteAllBytes("generatedLine.jpg", x);

            Assert.True(true);
        }

        [Fact]
        public async Task CreateDoughnutImageAsync()
        {
            using var sut = new ImageChartGenerator(true);
            var config = new ChartConfig
            {
                Type = ChartConfig.ChartTypes.doughnut,
                Options = new ChartOptions
                {
                    Title = new ChartTitleOptions
                    {
                        Display = true,
                        Text = "This is cool"
                    },
                    AspectRatio = 1.4,
                    Plugins = new Plugins
                    {
                        Labels = new PluginLabels
                        {
                            FontSize = 23,
                            FontColor = "#000"
                        }
                    }
                },
                Data = new ChartData
                {
                    Labels = new string[] { "Red", "Blue", "Yellow", "Green", "Purple", "Orange" },
                    Datasets = new ChartGeneratorChartJs.Config.Dataset.DatasetOptions[]
                    {
                        new ChartGeneratorChartJs.Config.Dataset.DatasetOptions
                        {
                            Label="# of voters".Split(' '),
                            Data = new double[] { 12, 19, 3, 5, 2, 3 },
                            BackgroundColor = new string[]
                            {
                                "rgba(255, 99, 132, 0.2)",
                                "rgba(54, 162, 235, 0.2)",
                                "rgba(255, 206, 86, 0.2)",
                                "rgba(75, 192, 192, 0.2)",
                                "rgba(153, 102, 255, 0.2)",
                                "rgba(255, 159, 64, 0.2)"
                            },
                            BorderColor = new string[]
                            {
                                "rgba(255, 99, 132, 0.2)",
                                "rgba(54, 162, 235, 0.2)",
                                "rgba(255, 206, 86, 0.2)",
                                "rgba(75, 192, 192, 0.2)",
                                "rgba(153, 102, 255, 0.2)",
                                "rgba(255, 159, 64, 0.2)"
                            },
                            BorderWidth = 1
                        },
                        new ChartGeneratorChartJs.Config.Dataset.DatasetOptions
                        {
                            Label="# of testers".Split(' '),
                            Data = new double[] { 102, 109, 30, 50, 20, 30 },
                            BackgroundColor = new string[]
                            {
                                "rgba(255, 99, 132, 0.2)",
                                "rgba(54, 162, 235, 0.2)",
                                "rgba(255, 206, 86, 0.2)",
                                "rgba(75, 192, 192, 0.2)",
                                "rgba(153, 102, 255, 0.2)",
                                "rgba(255, 159, 64, 0.2)"
                            },
                            BorderColor = new string[]
                            {
                                "rgba(255, 99, 132, 0.2)",
                                "rgba(54, 162, 235, 0.2)",
                                "rgba(255, 206, 86, 0.2)",
                                "rgba(75, 192, 192, 0.2)",
                                "rgba(153, 102, 255, 0.2)",
                                "rgba(255, 159, 64, 0.2)"
                            },
                            BorderWidth = 1
                        }
                    }
                }
            };

            var x = await sut.GenerateChartAsync(config);
            File.WriteAllBytes("generatedDoughnut.jpg", x);

            Assert.True(true);
        }

        [Fact]
        public async Task CreatePieImageAsync()
        {
            using var sut = new ImageChartGenerator(true);
            var config = new ChartConfig
            {
                Type = ChartConfig.ChartTypes.pie,
                Options = new ChartOptions
                {
                    Title = new ChartTitleOptions
                    {
                        Display = true,
                        Text = "This is cool"
                    },
                    AspectRatio = 1.4
                },
                Data = new ChartData
                {
                    Labels = new string[] { "Red", "Blue", "Yellow", "Green", "Purple", "Orange" },
                    Datasets = new ChartGeneratorChartJs.Config.Dataset.DatasetOptions[]
                    {
                        new ChartGeneratorChartJs.Config.Dataset.DatasetOptions
                        {
                            Label="# of voters".Split(' '),
                            Data = new double[] { 12, 19, 3, 5, 2, 3 },
                            BackgroundColor = new string[]
                            {
                                "rgba(255, 99, 132, 0.2)",
                                "rgba(54, 162, 235, 0.2)",
                                "rgba(255, 206, 86, 0.2)",
                                "rgba(75, 192, 192, 0.2)",
                                "rgba(153, 102, 255, 0.2)",
                                "rgba(255, 159, 64, 0.2)"
                            },
                            BorderColor = new string[]
                            {
                                "rgba(255, 99, 132, 0.2)",
                                "rgba(54, 162, 235, 0.2)",
                                "rgba(255, 206, 86, 0.2)",
                                "rgba(75, 192, 192, 0.2)",
                                "rgba(153, 102, 255, 0.2)",
                                "rgba(255, 159, 64, 0.2)"
                            },
                            BorderWidth = 1
                        },
                        new ChartGeneratorChartJs.Config.Dataset.DatasetOptions
                        {
                            Label="# of testers".Split(' '),
                            Data = new double[] { 102, 109, 30, 50, 20, 30 },
                            BackgroundColor = new string[]
                            {
                                "rgba(255, 99, 132, 0.2)",
                                "rgba(54, 162, 235, 0.2)",
                                "rgba(255, 206, 86, 0.2)",
                                "rgba(75, 192, 192, 0.2)",
                                "rgba(153, 102, 255, 0.2)",
                                "rgba(255, 159, 64, 0.2)"
                            },
                            BorderColor = new string[]
                            {
                                "rgba(255, 99, 132, 0.2)",
                                "rgba(54, 162, 235, 0.2)",
                                "rgba(255, 206, 86, 0.2)",
                                "rgba(75, 192, 192, 0.2)",
                                "rgba(153, 102, 255, 0.2)",
                                "rgba(255, 159, 64, 0.2)"
                            },
                            BorderWidth = 1
                        }
                    }
                }
            };

            var x = await sut.GenerateChartAsync(config);
            File.WriteAllBytes("generatedPie.jpg", x);

            Assert.True(true);
        }

        #endregion Public Methods
    }
}