using ChartGeneratorChartJs.Config;
using PuppeteerSharp;
using System;
using System.IO;
using System.Threading.Tasks;

namespace ChartGeneratorChartJs
{
    public class ImageChartGenerator : IDisposable
    {
        #region Private Fields

        private readonly Browser browser;
        private readonly string indexHtml;

        #endregion Private Fields

        #region Public Constructors

        public ImageChartGenerator(bool headless = true)
        {
            indexHtml = @"<html>
                            <body>
                            <script src='https://polyfill.io/v3/polyfill.min.js'></script>
                            <script src='https://cdn.jsdelivr.net/npm/chart.js@2.8.0'></script>
                            <script src='https://cdn.jsdelivr.net/npm/chart.js@2.8.0/dist/Chart.min.js'></script>
                            <script src='https://cdn.jsdelivr.net/npm/chartjs-plugin-datalabels@0.7.0'></script>
                            <canvas id='myChart'></canvas>
                            <script>
                                var ctx = document.getElementById('myChart').getContext('2d');
                            </script>
                            </body>
                        </html>";

            new BrowserFetcher().DownloadAsync(BrowserFetcher.DefaultRevision).Wait();
            var browserTask = Puppeteer.LaunchAsync(new LaunchOptions
            {
                Headless = headless,
                Args = new[]
                {
                    "--no-sandbox"
                }
            });
            browserTask.Wait();
            browser = browserTask.Result;
        }

        #endregion Public Constructors

        #region Private Destructors

        ~ImageChartGenerator()
        {
            Dispose();
        }

        #endregion Private Destructors

        #region Public Methods

        public async void Dispose()
        {
            await browser.CloseAsync();
        }

        public async Task<byte[]> GenerateChartAsync(ChartConfig chartConfig)
        {
            var page = await browser.NewPageAsync();
            var html = indexHtml.Insert(indexHtml.IndexOf("</body>"), createScript(chartConfig));
            await page.SetContentAsync(html);
            var bytes = await page.ScreenshotDataAsync();
            await page.CloseAsync();
            return bytes;
        }

        #endregion Public Methods

        #region Private Methods

        private string createScript(ChartConfig chartConfig)
        {
            var script = @"<script>new Chart(ctx," + chartConfig.CreateScript() + ")</script>";
            return script;
        }

        #endregion Private Methods
    }
}