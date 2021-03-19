using EasyTabs;
using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Real_Web
{
    public partial class frmBrowser : Form
    {
        public frmBrowser()
        {
            InitializeComponent();

            var appName = System.Diagnostics.Process.GetCurrentProcess().ProcessName + ".exe";
            using (var Key = Registry.CurrentUser.OpenSubKey(@"SOFTWARE\Microsoft\Internet Explorer\Main\FeatureControl\FEATURE_BROWSER_EMULATION", true))
            {
                Key.SetValue(appName, 99999, RegistryValueKind.DWord);
            }

            webBrowser1.Navigate("https://www.google.com/");
        }

        protected TitleBarTabs ParentTabs
        {
            get
            {
                return (ParentForm as TitleBarTabs);
            }
        }

        private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            btn_Refresh.Image = img_Refresh.Image;
        }

        private void btn_Back_Click(object sender, EventArgs e)
        {
            if (webBrowser1.CanGoBack)
            {
                webBrowser1.GoBack();
            }
        }

        private void btn_Forward_Click(object sender, EventArgs e)
        {
            if (webBrowser1.CanGoForward)
            {
                webBrowser1.GoForward();
            }
        }

        private void btn_Home_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate("https://www.google.com/");
        }

        private void btn_Refresh_Click(object sender, EventArgs e)
        {
            webBrowser1.Refresh();
        }

        private void webBrowser1_Navigating(object sender, WebBrowserNavigatedEventArgs e)
        {
            btn_Refresh.Image = img_Spinner.Image;
            tb_Search.Text = webBrowser1.Url.AbsolutePath;
        }

        private void tb_Search_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && tb_Search.Text.Trim().Length != 0)
            {
                if (tb_Search.Text.Contains("."))
                {
                    webBrowser1.Navigate(tb_Search.Text.Trim());
                }
                else
                {
                    webBrowser1.Navigate("https://www.google.com/search?client=opera&q=" + tb_Search.Text.Trim().Replace(" ", "+") + "&sourceid=opera&ie=UTF-8");
                }
            }
        }
    }
}
