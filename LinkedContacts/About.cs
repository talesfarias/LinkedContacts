using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LinkedContacts
{
    public partial class About : Form
    {
        public About()
        {
            InitializeComponent();
        }

        private void About_Load(object sender, EventArgs e)
        {
            linkLabelGit.Links.Add(0,33, "https://github.com/talesfarias/LinkedContacts");
            linkLabelGit.LinkClicked += new LinkLabelLinkClickedEventHandler(linkLabelGit_LinkClicked);
        }

        private void linkLabelGit_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            linkLabelGit.LinkVisited = true;
            System.Diagnostics.Process.Start("https://github.com/talesfarias/LinkedContacts");
        }
    }
}
