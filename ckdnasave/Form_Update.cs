using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Octokit;

namespace ckdnasave
{
    public partial class Form_Update : Form
    {
        GitHubClient client = new GitHubClient(new ProductHeaderValue("CK3-DNA-Archive"));
        public Form_Update()
        {
            InitializeComponent();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start(client.Repository.Release.GetLatest("Flestal", "CK3-DNA-Archive").Result.HtmlUrl);
            System.Windows.Forms.Application.Exit();
        }
    }
}
