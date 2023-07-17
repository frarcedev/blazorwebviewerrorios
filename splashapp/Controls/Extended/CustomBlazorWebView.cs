using System;
using Microsoft.AspNetCore.Components.WebView.Maui;

#if IOS
using WebKit;
using UIKit;
using CoreGraphics;
using Microsoft.Maui.Platform;
using Microsoft.Maui.Handlers;
using RectangleF = CoreGraphics.CGRect;
#endif
namespace splashapp.Controls.Extended
{
	public class CustomBlazorWebView : BlazorWebView
	{
		public CustomBlazorWebView()
		{
			this.BlazorWebViewInitialized += CustomWebView_BlazorWebViewInitialized;

        }

        private void CustomWebView_BlazorWebViewInitialized(object sender, Microsoft.AspNetCore.Components.WebView.BlazorWebViewInitializedEventArgs e)
        {
            #if IOS
			var webView = (WKWebView)e.WebView;
            webView.Opaque=false;
            webView.BackgroundColor=UIColor.Black;
            #endif
        }
    }
}

