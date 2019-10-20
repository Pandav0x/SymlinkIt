using System;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;

namespace Symlinker
{
    public partial class MainForm : Form
    {
        private string pathFrom;

        private string pathTo;

        public MainForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FolderDialogFrom.ShowDialog();
            pathFrom = FolderDialogFrom.SelectedPath.ToString();
            InputFrom.Text = pathFrom;
        }

        private void BrowseTo_Click(object sender, EventArgs e)
        {
            FileDialogTo.ShowDialog();
            pathTo = FileDialogTo.FileName;
            InputTo.Text = pathTo;
        }

        private void Proceed_Click(object sender, EventArgs e)
        {
            pathFrom = InputFrom.Text;
            pathTo = InputTo.Text;

            if ((new FileInfo(pathFrom)).Exists)
            {
                using (Process process = new Process())
                {
                    ProcessStartInfo startInfo = new ProcessStartInfo();
                    startInfo.WindowStyle = ProcessWindowStyle.Hidden;
                    startInfo.FileName = "cmd.exe";
                    startInfo.Arguments = string.Format("/k mklink /D \"{0}\" \"{1}\"", pathTo, pathFrom);
                    process.StartInfo = startInfo;
                    process.Start();
                }
                MessageBox.Show(string.Format("Symlink created for {0} <===> {1}", pathFrom, pathTo));
            }
            else
            {
                MessageBox.Show(string.Format("Invalid path: \"{0}]\"", pathFrom), "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
