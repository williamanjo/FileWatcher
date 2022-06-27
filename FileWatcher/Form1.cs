using Microsoft.WindowsAPICodePack.Dialogs;
using System;
using System.ComponentModel;
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
        public static uint QuantMoni { set; get; }
        public Form1()
        {
            InitializeComponent();
            QuantMoni = 0;
            CheckForIllegalCrossThreadCalls = false;
            EventsTypes.SetItemChecked(0, true);
            NotifyFilters.SetItemChecked(0, true);
            NotifyFilters.SetItemChecked(1, true);
            NotifyFilters.SetItemChecked(3, true);
            NotifyFilters.SetItemChecked(5, true);
            OnEventType.SelectedIndex = 4;
            TypeSplitDoc.SelectedIndex = 3;
            SplitDoc.Text = "MMMM-yyyy";
            Btn_WatcherSelect.Select();
            Closing += OnClosing;
        }

        private void OnClosing(object sender, CancelEventArgs e)
        {
            Properties.Settings.Default.Save();
            Btn_WatcherSelect.Enabled = true;
            OnEventType.Enabled = true;
            Filter.Enabled = true;
            Subdirectories.Enabled = true;
            NotifyFilters.Enabled = true;
            EventsTypes.Enabled = true;
            watcher.EnableRaisingEvents = false;
            watcher.Dispose();
            LogBox.AppendText(Environment.NewLine + "FileWatcher.exe Parado : " + DateTime.Now.ToString() + Environment.NewLine);
            Stop();
            using (StreamWriter sw = File.CreateText(Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location) + @"\\Log_LastSession.txt"))
            {
                sw.Write(LogBox.Text);
            }

        }

        private void ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (OnEventType.SelectedIndex == 0)
            {

                tabControl1.TabPages.Remove(tabPage3);
                tabControl1.TabPages.Remove(tabPage4);
                tabControl1.TabPages.Remove(tabPage5);

                if (!tabControl1.TabPages.Contains(tabPage2))
                {
                    tabControl1.TabPages.Insert(1, tabPage2);
                }


            }
            else if (OnEventType.SelectedIndex == 1)
            {

                tabControl1.TabPages.Remove(tabPage2);
                tabControl1.TabPages.Remove(tabPage4);
                tabControl1.TabPages.Remove(tabPage5);

                if (!tabControl1.TabPages.Contains(tabPage3))
                {
                    tabControl1.TabPages.Insert(1, tabPage3);
                }


            }
            else if (OnEventType.SelectedIndex == 2)
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
            else if (OnEventType.SelectedIndex == 3)
            {
                tabControl1.TabPages.Remove(tabPage2);
                tabControl1.TabPages.Remove(tabPage3);
                tabControl1.TabPages.Remove(tabPage5);

                if (!tabControl1.TabPages.Contains(tabPage4))
                {
                    tabControl1.TabPages.Insert(1, tabPage4);
                }



            }
            else if (OnEventType.SelectedIndex == 4)
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

        private void Btn_WatcherSelect_Click(object sender, EventArgs e)
        {
            var dialog = new CommonOpenFileDialog
            {
                IsFolderPicker = true,
                InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments)
            };
            CommonFileDialogResult result = dialog.ShowDialog();
            if (result.ToString() == "Ok")
            {

                FolderWatcher.Text = dialog.FileName;
            }
        }

        private void Start_Click(object sender, EventArgs e)
        {

            try
            {

                if (Start.Text == "Start" || Start.Text == "Stoped")
                {
                    QuantMoni++;
                    Btn_Log.Text = "Limpar Log";
                    Btn_WatcherSelect.Enabled = false;
                    Filter.Enabled = false;
                    OnEventType.Enabled = false;
                    NotifyFilters.Enabled = false;
                    EventsTypes.Enabled = false;
                    Subdirectories.Enabled = false;
                    watcher.Dispose();
                    watcher = new FileSystemWatcher();
                    watcher.Path = (@"" + FolderWatcher.Text);
                    LabelStatus.Text = "Monitoring";
                    LabelStatus.ForeColor = Color.FromName("DarkGreen");
                    Start.Text = "Stop";

                    LogBox.AppendText(" " + QuantMoni + " º : \\ FileWatcher - Directory (" + FolderWatcher.Text + ") /" + Environment.NewLine);

                    //NotifyFilter

                    if (NotifyFilters.GetItemChecked(0)) { watcher.NotifyFilter |= System.IO.NotifyFilters.Attributes; }
                    if (NotifyFilters.GetItemChecked(1)) { watcher.NotifyFilter |= System.IO.NotifyFilters.CreationTime; }
                    if (NotifyFilters.GetItemChecked(2)) { watcher.NotifyFilter |= System.IO.NotifyFilters.DirectoryName; }
                    if (NotifyFilters.GetItemChecked(3)) { watcher.NotifyFilter |= System.IO.NotifyFilters.FileName; }
                    if (NotifyFilters.GetItemChecked(4)) { watcher.NotifyFilter |= System.IO.NotifyFilters.LastAccess; }
                    if (NotifyFilters.GetItemChecked(5)) { watcher.NotifyFilter |= System.IO.NotifyFilters.LastWrite; }
                    if (NotifyFilters.GetItemChecked(6)) { watcher.NotifyFilter |= System.IO.NotifyFilters.Security; }
                    if (NotifyFilters.GetItemChecked(7)) { watcher.NotifyFilter |= System.IO.NotifyFilters.Size; }

                    //Eventos

                    if (EventsTypes.GetItemChecked(0)) { watcher.Changed += OnEvent; }
                    if (EventsTypes.GetItemChecked(1)) { watcher.Created += OnEvent; }
                    if (EventsTypes.GetItemChecked(2)) { watcher.Deleted += OnEvent; }
                    if (EventsTypes.GetItemChecked(3)) { watcher.Renamed += OnEvent; }

                    watcher.Error += OnError;
                    watcher.Filter = Filter.Text;
                    watcher.IncludeSubdirectories = Subdirectories.Checked;
                    watcher.EnableRaisingEvents = true;

                    LogBox.AppendText("\n\n        Created By William.Silva\n" + Environment.NewLine + Environment.NewLine);


                }
                else
                {
                    Btn_WatcherSelect.Enabled = true;
                    OnEventType.Enabled = true;
                    Filter.Enabled = true;
                    Subdirectories.Enabled = true;
                    NotifyFilters.Enabled = true;
                    EventsTypes.Enabled = true;
                    watcher.EnableRaisingEvents = false;
                    watcher.Dispose();
                    LogBox.AppendText(Environment.NewLine + "Monitoramento Parado : " + DateTime.Now.ToString() + Environment.NewLine);
                    LogBox.AppendText(Environment.NewLine + Environment.NewLine + "-------------------------------------------------" +
                    "-----------------------------------------------------------------------------------------" + 
                    Environment.NewLine + Environment.NewLine + Environment.NewLine);
                    Stop();
                }
            }
            catch (Exception error)
            {
                Btn_WatcherSelect.Enabled = true;
                OnEventType.Enabled = true;
                Filter.Enabled = true;
                Subdirectories.Enabled = true;
                NotifyFilters.Enabled = true;
                EventsTypes.Enabled = true;
                watcher.EnableRaisingEvents = false;
                watcher.Dispose();
                Error(error.Message.ToString());
            }

        }


        private void OnEvent(object sender, FileSystemEventArgs e)
        {
            switch (OnEventType.SelectedIndex)
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
                    Console.WriteLine("Caso não existe (" + OnEventType.SelectedIndex + ")");
                    Error("Caso não existe (" + OnEventType.SelectedIndex + ")");
                    OnEventType.Select();
                    break;
            }

        }
        private void Copy_Rename()
        {

            LogBox.AppendText("Evento" + Environment.NewLine);

        }


        private void Stop()
        {

            Start.Text = "Start";
            LabelStatus.Text = "Stoped";
            LabelStatus.ForeColor = Color.FromName("DeepSkyBlue");
        }
        private void Error(string er)
        {
            Start.Text = "Start";
            LabelStatus.Text = "Error";
            LabelStatus.ForeColor = Color.FromName("Red");
            LogBox.AppendText(er + Environment.NewLine);
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

        private void Btn_Log_Click(object sender, EventArgs e)
        {
            if (Btn_Log.Text == "Limpar Log")
            {
                Btn_Log.Text = "Restaurar";
                Logg = LogBox.Text;
                LogBox.Text = "";
            }
            else
            {
                Btn_Log.Text = "Limpar Log";
                LogBox.Text = Logg;
            }
        }

        private void CheckedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (EventsTypes.GetItemChecked(2))
            {
                if (OnEventType.SelectedIndex != 7)
                {
                    OnEventType.SelectedIndex = 0;
                }
                OnEventType.Items.Clear();
                OnEventType.Items.AddRange(new object[] {
                "Mover",
                "Renomear",
                "Mover e Renomear ",
                "Copiar",
                "Copiar e Renomear"
            });

            }
            else
            {

                OnEventType.Items.Clear();
                OnEventType.Items.AddRange(new object[] {
                "Mover",
                "Renomear",
                "Mover e Renomear ",
                "Copiar",
                "Copiar e Renomear",
                "Deletar"
            });

            }

        }

        private void Button4_Click(object sender, EventArgs e)
        {
            var dialog = new CommonOpenFileDialog
            {
                IsFolderPicker = true,
                InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments)
            };
            CommonFileDialogResult result = dialog.ShowDialog();
            if (result.ToString() == "Ok")
            {

                MoveTo.Text = dialog.FileName;
            }
        }


        private void Button5_Click(object sender, EventArgs e)
        {
            var dialog = new CommonOpenFileDialog
            {
                IsFolderPicker = true,
                InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments)
            };
            CommonFileDialogResult result = dialog.ShowDialog();
            if (result.ToString() == "Ok")
            {

                CopyTo.Text = dialog.FileName;
            }
        }

        private void TextBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void ComboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (TypeSplitDoc.SelectedIndex != 0) { SplitDoc.Visible = true; } else { SplitDoc.Visible = false; }
            if (TypeSplitDoc.SelectedIndex == 1) { SplitDoc.Text = "MMMM"; }
            if (TypeSplitDoc.SelectedIndex == 2) { SplitDoc.Text = "dd"; }
            if (TypeSplitDoc.SelectedIndex == 3) { SplitDoc.Enabled = true; } else { SplitDoc.Enabled = false; }
        }

        private void FolderWatcher_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
