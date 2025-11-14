using System;
using System.Windows;
using Microsoft.Web.WebView2.Core;

namespace AmazonNovaDesktop
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            InitializeWebView();
        }

        private async void InitializeWebView()
        {
            try
            {
                await webView.EnsureCoreWebView2Async();
                
                // Optional: Configure WebView2 settings
                if (webView.CoreWebView2 != null)
                {
                    webView.CoreWebView2.Settings.AreDefaultContextMenusEnabled = true;
                    webView.CoreWebView2.Settings.AreDevToolsEnabled = false;
                    webView.CoreWebView2.Settings.IsStatusBarEnabled = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error initializing WebView: {ex.Message}", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void WebView_NavigationCompleted(object? sender, CoreWebView2NavigationCompletedEventArgs e)
        {
            if (!e.IsSuccess)
            {
                MessageBox.Show($"Failed to load page: {e.WebErrorStatus}", "Navigation Error", MessageBoxButton.OK, MessageBoxImage.Warning);
            }
        }
    }
}

