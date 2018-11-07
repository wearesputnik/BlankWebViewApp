using System;
using TestWebView.Droid;
using Xamarin.Forms;

[assembly: Dependency(typeof(BaseUrl_Android))]
namespace TestWebView.Droid
{
	public class BaseUrl_Android : IBaseUrl
    {
        public string Get()
        {
            return "file:///android_asset/";
        }
    }
}
