using ChartGeneratorChartJs.Config;
using PuppeteerSharp;
using System;
using System.IO;
using System.Threading.Tasks;

namespace ChartGeneratorChartJs
{
    public class ImageChartGenerator : IDisposable
    {
        private readonly Browser browser;
        private readonly string indexHtml;

        public ImageChartGenerator(bool headless = true)
        {
            using var indexHtmlReader = new StreamReader("./html/index.html");
            indexHtml = indexHtmlReader.ReadToEnd();

            new BrowserFetcher().DownloadAsync(BrowserFetcher.DefaultRevision).Wait();
            var browserTask = Puppeteer.LaunchAsync(new LaunchOptions { Headless = headless });
            browserTask.Wait();
            browser = browserTask.Result;
        }

        public void Dispose()
        {
            browser.Dispose();
        }

        public async Task<byte[]> GenerateChartAsync(ChartConfig chartConfig)
        {
            var page = await browser.NewPageAsync();
            var html = indexHtml.Insert(indexHtml.IndexOf("</body>"), createScript(chartConfig));
            await page.SetContentAsync(html);
            var bytes = await page.ScreenshotDataAsync();
            return bytes;
        }

        private string createScript(ChartConfig chartConfig)
        {
            var script = @"<script>new Chart(ctx," + chartConfig.CreateScript() + ")</script>";
            return script;
        }
    }
}