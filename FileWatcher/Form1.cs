using Microsoft.WindowsAPICodePack.Dialogs;
using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace FileWatcher
{
    
    public partial class Form1 : Form

    {
        FileSystemWatcher watcher = new FileSystemWatcher();
        public static string Logg { set; get; }
        public static string Nome { set; get; }
        public Form1()
        {
            InitializeComponent();
            CheckForIllegalCrossThreadCalls = false;
            checkedListBox1.SetItemChecked(0, true);
            checkedListBox2.SetItemChecked(0, true);
            checkedListBox2.SetItemChecked(1, true);
            checkedListBox2.SetItemChecked(3, true);
            checkedListBox2.SetItemChecked(5, true);
            comboBox1.SelectedIndex = 4;
            comboBox2.SelectedIndex = 3;
            textBox4.Text = "MMMM-yyyy";
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
            else
            {
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
                        
            try
            {

                if (button2.Text == "Start" || button2.Text == "Stoped")
                {
                    button3.Text = "Limpar Log";
                    watcher.Dispose();
                    watcher = new FileSystemWatcher();
                    watcher.Path = (@"" + textBox2.Text);
                    label3.Text = "Monitoring";
                    label3.ForeColor = Color.FromName("DarkGreen");
                    button2.Text = "Stop";

                    log.AppendText(" " + (log.Lines.Length > 0 ? log.Lines.Length : log.Lines.Length + 1) + " º : \\ FileWatcher - Directory (" + textBox2.Text + ") /" + Environment.NewLine);
                    
                    //NotifyFilter

                    if (checkedListBox2.GetItemChecked(0)) { watcher.NotifyFilter |= NotifyFilters.Attributes; }
                    if (checkedListBox2.GetItemChecked(1)) { watcher.NotifyFilter |= NotifyFilters.CreationTime; }
                    if (checkedListBox2.GetItemChecked(2)) { watcher.NotifyFilter |= NotifyFilters.DirectoryName; }
                    if (checkedListBox2.GetItemChecked(3)) { watcher.NotifyFilter |= NotifyFilters.FileName; }
                    if (checkedListBox2.GetItemChecked(4)) { watcher.NotifyFilter |= NotifyFilters.LastAccess; }
                    if (checkedListBox2.GetItemChecked(5)) { watcher.NotifyFilter |= NotifyFilters.LastWrite; }
                    if (checkedListBox2.GetItemChecked(6)) { watcher.NotifyFilter |= NotifyFilters.Security; }
                    if (checkedListBox2.GetItemChecked(7)) { watcher.NotifyFilter |= NotifyFilters.Size; }

                    //Eventos

                    if (checkedListBox1.GetItemChecked(0)) { watcher.Changed += OnEvent; }
                    if (checkedListBox1.GetItemChecked(1)) { watcher.Created += OnEvent; }
                    if (checkedListBox1.GetItemChecked(2)) { watcher.Deleted += OnEvent; }
                    if (checkedListBox1.GetItemChecked(3)) { watcher.Renamed += OnEvent; }

                    watcher.Error += OnError;
                    watcher.Filter = filter.Text;
                    watcher.IncludeSubdirectories = checkBox1.Checked;
                    watcher.EnableRaisingEvents = true;

                    log.AppendText("\n\n        Created By William.Silva\n" + Environment.NewLine + Environment.NewLine);


                }
                else
                {
                    watcher.EnableRaisingEvents = false;
                    watcher.Dispose();
                    log.AppendText(Environment.NewLine +"Monitoramento Parado : " + DateTime.Now.ToString() + Environment.NewLine);
                    Stop();
                }
            }
            catch (Exception error)
            {
                watcher.EnableRaisingEvents = false;
                watcher.Dispose();
                Error(error.Message.ToString());
            }

        }


        private void OnEvent(object sender, FileSystemEventArgs e)
        {
            switch (comboBox1.SelectedIndex)
            {
                case 0:
                    Console.WriteLine("Mover");
                    break;
                case 1:
                    Console.WriteLine("Renomear");
                    break;
                case 2:
                    Console.WriteLine("Mover e Renomear");
                    break;
                case 3:
                    Console.WriteLine("Copiar");
                    break;
                case 4:
                    Copy_Rename();
                    break;
                case 5:
                    Console.WriteLine("Deletar");
                    break;
                default:
                    Console.WriteLine("Caso não existe");
                    Error("Caso não existe");
                    comboBox1.Select();
                    break;
            }

        }
        private void Copy_Rename()
        {

            log.AppendText("Evento" + Environment.NewLine);

        }


        private void Stop()
        {

            button2.Text = "Start";
            label3.Text = "Stoped";
            label3.ForeColor = Color.FromName("DeepSkyBlue");
        }
        private void Error(string er)
        {
            button2.Text = "Start";
            label3.Text = "Error";
            label3.ForeColor = Color.FromName("Red");
            log.AppendText(er + Environment.NewLine);
        }
        private void OnError(object sender, ErrorEventArgs e)
        {
            PrintException(e.GetException());
        }
        private void PrintException(Exception ex)
        {
            if (ex != null)
            {
                string error = $"Message: {ex.Message}" + Environment.NewLine + "Stacktrace:" + Environment.NewLine + ex.StackTrace;
                Error(error);
                PrintException(ex.InnerException);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (button3.Text == "Limpar Log")
            {
                button3.Text = "Restaurar";
                Logg = log.Text;
                log.Text = "";
            }
            else {
                button3.Text = "Limpar Log";
                log.Text = Logg;
            }
        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (checkedListBox1.GetItemChecked(2))
            {
                if (comboBox1.SelectedIndex != 7){
                    comboBox1.SelectedIndex = 0;
                }
                comboBox1.Items.Clear();
                comboBox1.Items.AddRange(new object[] {
                "Mover",
                "Renomear",
                "Mover e Renomear ",
                "Copiar",
                "Copiar e Renomear"
            });

            }
            else {
                
                comboBox1.Items.Clear();
                comboBox1.Items.AddRange(new object[] {
                "Mover",
                "Renomear",
                "Mover e Renomear ",
                "Copiar",
                "Copiar e Renomear",
                "Deletar"
            });

            }

        }

        private void button4_Click(object sender, EventArgs e)
        {
            var dialog = new CommonOpenFileDialog
            {
                IsFolderPicker = true,
                InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments)
            };
            CommonFileDialogResult result = dialog.ShowDialog();
            if (result.ToString() == "Ok")
            {

                textBox1.Text = dialog.FileName;
            }
            dialog = null;

        }


        private void button5_Click(object sender, EventArgs e)
        {
            var dialog = new CommonOpenFileDialog
            {
                IsFolderPicker = true,
                InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments)
            };
            CommonFileDialogResult result = dialog.ShowDialog();
            if (result.ToString() == "Ok")
            {

                textBox3.Text = dialog.FileName;
            }
            dialog = null;
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox2.SelectedIndex != 0) { textBox4.Visible = true; } else { textBox4.Visible = false; }
            if (comboBox2.SelectedIndex == 1) { textBox4.Text = "MMMM"; }
            if (comboBox2.SelectedIndex == 2) { textBox4.Text = "dd"; }
            if (comboBox2.SelectedIndex == 3) { textBox4.Enabled = true; } else { textBox4.Enabled = false; }
        }
    }
}
