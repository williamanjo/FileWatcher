using System;
using System.Windows.Forms;
using Microsoft.WindowsAPICodePack.Dialogs;

namespace FileWatcher
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            checkedListBox1.SetItemChecked(0, true);
            comboBox1.SelectedIndex = 4;
            button1.Select();
            
        }

        private void comboBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {

            if (comboBox1.SelectedIndex == 0)
            {

                tabControl1.TabPages.Remove(tabPage3);
                tabControl1.TabPages.Remove(tabPage4);
                tabControl1.TabPages.Remove(tabPage5);

                if (!tabControl1.TabPages.Contains(tabPage2))
                {
                    tabControl1.TabPages.Insert(1, tabPage2);
                }


            }
            else if (comboBox1.SelectedIndex == 1)
            {

                tabControl1.TabPages.Remove(tabPage2);
                tabControl1.TabPages.Remove(tabPage4);
                tabControl1.TabPages.Remove(tabPage5);

                if (!tabControl1.TabPages.Contains(tabPage3))
                {
                    tabControl1.TabPages.Insert(1, tabPage3);
                }


            }
            else if (comboBox1.SelectedIndex == 2)
            {
                tabControl1.TabPages.Remove(tabPage4);
                tabControl1.TabPages.Remove(tabPage5);

                if (!tabControl1.TabPages.Contains(tabPage2))
                {
                    tabControl1.TabPages.Insert(1, tabPage2);
                }
                if (!tabControl1.TabPages.Contains(tabPage3))
                {
                    tabControl1.TabPages.Insert(2, tabPage3);
                }


            }
            else if (comboBox1.SelectedIndex == 3)
            {
                tabControl1.TabPages.Remove(tabPage2);
                tabControl1.TabPages.Remove(tabPage3);
                tabControl1.TabPages.Remove(tabPage5);

                if (!tabControl1.TabPages.Contains(tabPage4))
                {
                    tabControl1.TabPages.Insert(1, tabPage4);
                }



            }
            else if (comboBox1.SelectedIndex == 4)
            {
                tabControl1.TabPages.Remove(tabPage2);
                tabControl1.TabPages.Remove(tabPage5);
                if (!tabControl1.TabPages.Contains(tabPage4))
                {
                    tabControl1.TabPages.Insert(1, tabPage4);
                }
                if (!tabControl1.TabPages.Contains(tabPage3))
                {
                    tabControl1.TabPages.Insert(2, tabPage3);
                }


            }
            else {
                tabControl1.TabPages.Remove(tabPage2);
                tabControl1.TabPages.Remove(tabPage3);
                tabControl1.TabPages.Remove(tabPage4);
                if (!tabControl1.TabPages.Contains(tabPage5))
                {
                    tabControl1.TabPages.Insert(1, tabPage5);
                }

            }



        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            var dialog = new CommonOpenFileDialog
            {
                IsFolderPicker = true,
                InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments)
            };
            CommonFileDialogResult result = dialog.ShowDialog();
            if (result.ToString() == "Ok")
            {

                textBox2.Text = dialog.FileName;
            }
            dialog = null;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            
        }
    }
}
