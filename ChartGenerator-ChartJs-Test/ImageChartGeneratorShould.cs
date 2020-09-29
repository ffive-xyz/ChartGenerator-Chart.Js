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
        [Fact]
        public async Task CreateBarImageAsync()
        {
            using var sut = new ImageChartGenerator(true);
            var config = new ChartConfig
            {
                Type = ChartConfig.ChartTypes.Bar,
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
                            Label="# of voters",
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
                            Label="# of testers",
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
                Type = ChartConfig.ChartTypes.Bar,
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
                            Label="# of voters",
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
                            Label="# of testers",
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
                Type = ChartConfig.ChartTypes.Line,
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
                            Label="# of voters",
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
                            Label="# of testers",
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
                Type = ChartConfig.ChartTypes.Doughnut,
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
                            Label="# of voters",
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
                            Label="# of testers",
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
                Type = ChartConfig.ChartTypes.Pie,
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
                            Label="# of voters",
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
                            Label="# of testers",
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
    }
}
