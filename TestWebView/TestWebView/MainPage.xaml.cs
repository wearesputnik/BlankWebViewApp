using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace TestWebView
{
    public interface IBaseUrl { string Get(); }

    public partial class MainPage : ContentPage
    {
        public MainPage()   
        {
            InitializeComponent();

            var source = new HtmlWebViewSource();
            source.BaseUrl = DependencyService.Get<IBaseUrl>().Get();
            source.Html = @"<html>
                                <head>
                                <link rel=""stylesheet"" href=""default.css"">
                                </head>
                                <body>
                                <h1>Xamarin.Forms WebView</h1>
                                <p>The CSS and JS are loaded from local files!</p>
                                <button onclick=""myFunction()"">ALERT!</button>
                                <script src=""bundle.js""></script>
                                </body>
                            </html>";
            webView.Source = source;
        }
    }
}
