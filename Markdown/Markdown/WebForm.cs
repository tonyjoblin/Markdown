using System;
using System.Windows.Forms;

namespace Markdown
{
    public partial class WebForm : Form
    {
        public WebForm()
        {
            InitializeComponent();
        }

        private void WebForm_Load(object sender, EventArgs e)
        {
        }

        public void SetTitle(string title)
        {
            Text = title;
        }

        public void SetHtml(string html)
        {
            webBrowser1.DocumentText = html;
        }
    }
}
