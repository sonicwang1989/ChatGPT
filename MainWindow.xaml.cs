﻿using Microsoft.Web.WebView2.Core;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace ChatGPT
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            InitWebView();
        }

        async void InitWebView()
        {
            var options = new CoreWebView2EnvironmentOptions("--proxy-server=socks5://127.0.0.1:1080");
            var env = await CoreWebView2Environment.CreateAsync(null, null, options);
            await MyWebView.EnsureCoreWebView2Async(env);
            MyWebView.CoreWebView2.Navigate("https://chatgpt.com/");
        }
    }
}