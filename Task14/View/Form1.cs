using System.IO;
using System.Windows.Forms;
using System;
using System.Diagnostics;

namespace Task14.View
{
    public partial class Form1 : Form, IView
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSynchronize_Click(object sender, EventArgs e) //синхронізація
        {
            Synchronize(sender, e);
        }

        private void btnChooseFirst_Click(object sender, EventArgs e) //вибір першої директорії
        {
            var selectDirectory = new FolderBrowserDialog();
            if (selectDirectory.ShowDialog() == DialogResult.OK)
            {
                lblFirstFolder.Text = selectDirectory.SelectedPath;
                SetFirst(sender, new EventFileNameArgs(lblFirstFolder.Text));
            }
        }

        private void btnAddToFirst_Click(object sender, EventArgs e) //додати новий файл до першої директорії
        {
            if (lblFirstFolder.Text != "")
            {
                AddToFirst(sender, new EventFileNameArgs(textBox1.Text));
                textBox1.Clear();
            }
            else
            {
                MessageBox.Show("Please, select directory!");
            }
        }

        private void btnDeleteFirst_Click(object sender, EventArgs e) //видалити файл з першої директорії
        {
            var chooseFile = new OpenFileDialog();
            chooseFile.InitialDirectory = lblFirstFolder.Text;
            if (lblFirstFolder.Text != "" && chooseFile.ShowDialog() == DialogResult.OK)
            {
                DeleteToFirst(sender, new EventFileNameArgs(chooseFile.SafeFileName));
            }
            else
            {
                MessageBox.Show("Please, select directory!");
            }
        }


        private void btnChangeFirst_Click(object sender, EventArgs e) //змінити файл в першій директорії
        {
            var chooseFile = new OpenFileDialog();
            chooseFile.InitialDirectory = lblFirstFolder.Text;

            if (lblFirstFolder.Text != "" && chooseFile.ShowDialog() == DialogResult.OK)
            {
                var fi = new FileInfo(chooseFile.FileName);
                long start = fi.Length;
                using (var process = Process.Start(chooseFile.FileName))
                {
                    if (process != null) process.WaitForExit();
                }
                var fi1 = new FileInfo(chooseFile.FileName);
                long end = fi1.Length;
                if (start != end)
                {
                    MessageBox.Show("File has been changed...");
                    ChangeToFirst(sender, new EventFileNameArgs(chooseFile.SafeFileName));
                }
            }
            else
            {
                MessageBox.Show("Please, select directory!");
            }
        }

        private void btnChooseSecond_Click(object sender, EventArgs e) //вибір другої директорії
        {
            var selectDirectory = new FolderBrowserDialog();
            if (selectDirectory.ShowDialog() == DialogResult.OK)
            {
                lblSecondFolder.Text = selectDirectory.SelectedPath;
                SetSecond(sender, new EventFileNameArgs(lblSecondFolder.Text));
            }
        }

        private void btnAddFileToSecond_Click(object sender, EventArgs e) //додати новий файл до другох директорії
        {
            if (lblSecondFolder.Text != "")
            {
                AddToSecond(sender, new EventFileNameArgs(textFileSecond.Text));
                textFileSecond.Clear();
            }
            else
            {
                MessageBox.Show("Please, select directory!");
            }
        }

        private void btnDeleteSecond_Click(object sender, EventArgs e)  //видалити файл з другої директорії
        {
            var chooseFile = new OpenFileDialog();
            chooseFile.InitialDirectory = lblSecondFolder.Text;
            if (lblSecondFolder.Text!="" && chooseFile.ShowDialog() == DialogResult.OK)
            {
                DeleteToSecond(sender, new EventFileNameArgs(chooseFile.SafeFileName));
            }
            else
            {
                MessageBox.Show("Please, select directory!");
            }
        }

        private void btnChangeSecond_Click(object sender, EventArgs e) //змінити файл в першій директорії
        {
            var chooseFile = new OpenFileDialog();
            chooseFile.InitialDirectory = lblSecondFolder.Text;
            if (lblSecondFolder.Text != "" && chooseFile.ShowDialog() == DialogResult.OK)
            {
                var fi = new FileInfo(chooseFile.FileName);
                long start = fi.Length;
                using (var process = Process.Start(chooseFile.FileName))
                {
                    if (process != null) process.WaitForExit();
                }
                var fi1 = new FileInfo(chooseFile.FileName);
                long end = fi1.Length;
                if (start != end)
                {
                    MessageBox.Show("File has been changed...");
                    ChangeToSecond(sender, new EventFileNameArgs(chooseFile.SafeFileName));
                }
            }
            else
            {
                MessageBox.Show("Please, select directory!");
            }
        }

        public event EventHandler<EventArgs> Synchronize;
        public event EventHandler<EventFileNameArgs> SetFirst;
        public event EventHandler<EventFileNameArgs> SetSecond;
        public event EventHandler<EventFileNameArgs> AddToFirst;
        public event EventHandler<EventFileNameArgs> AddToSecond;
        public event EventHandler<EventFileNameArgs> DeleteToFirst;
        public event EventHandler<EventFileNameArgs> ChangeToFirst;
        public event EventHandler<EventFileNameArgs> DeleteToSecond;
        public event EventHandler<EventFileNameArgs> ChangeToSecond;
    }
}
