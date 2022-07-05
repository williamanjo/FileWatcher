
namespace FileWatcher
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.Filter = new System.Windows.Forms.TextBox();
            this.EventsTypes = new System.Windows.Forms.CheckedListBox();
            this.OnEventType = new System.Windows.Forms.ComboBox();
            this.NotifyFilters = new System.Windows.Forms.CheckedListBox();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label6 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.MoveTo = new System.Windows.Forms.TextBox();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.LabelVersion = new System.Windows.Forms.Label();
            this.Subdirectories = new System.Windows.Forms.CheckBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.Btn_Log = new System.Windows.Forms.Button();
            this.LabelStatus = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.Start = new System.Windows.Forms.Button();
            this.Status = new System.Windows.Forms.Label();
            this.FolderWatcher = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Btn_WatcherSelect = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.LogBox = new System.Windows.Forms.TextBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.ExtensionDoc = new System.Windows.Forms.TextBox();
            this.ExtensionDocType = new System.Windows.Forms.ComboBox();
            this.ChangeDocName = new System.Windows.Forms.TextBox();
            this.ChangeDocNameType = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.SplitDoc = new System.Windows.Forms.TextBox();
            this.TypeSplitDoc = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.button5 = new System.Windows.Forms.Button();
            this.CopyTo = new System.Windows.Forms.TextBox();
            this.tabPage2.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.panel3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.panel2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolTip1
            // 
            this.toolTip1.AutoPopDelay = 10000;
            this.toolTip1.InitialDelay = 500;
            this.toolTip1.ReshowDelay = 100;
            this.toolTip1.ShowAlways = true;
            // 
            // Filter
            // 
            this.Filter.Location = new System.Drawing.Point(57, 43);
            this.Filter.Name = "Filter";
            this.Filter.Size = new System.Drawing.Size(43, 20);
            this.Filter.TabIndex = 31;
            this.Filter.Text = "*.*";
            this.Filter.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.toolTip1.SetToolTip(this.Filter, " Filtro de Arquivos onde :\r\n*.*       - Todos os arquivos.\r\n*.pdf   - Só PDF\'s.\r\n" +
        "123*.*  - Arquivos Que Começam com 123.\r\n*567*   - Arquivos que tenham Em qualqu" +
        "er Lugar no nome 567.");
            // 
            // EventsTypes
            // 
            this.EventsTypes.BackColor = System.Drawing.SystemColors.Window;
            this.EventsTypes.FormattingEnabled = true;
            this.EventsTypes.Items.AddRange(new object[] {
            "Changed",
            "Created",
            "Deleted",
            "Renamed"});
            this.EventsTypes.Location = new System.Drawing.Point(0, 0);
            this.EventsTypes.Name = "EventsTypes";
            this.EventsTypes.Size = new System.Drawing.Size(95, 64);
            this.EventsTypes.TabIndex = 0;
            this.toolTip1.SetToolTip(this.EventsTypes, resources.GetString("EventsTypes.ToolTip"));
            this.EventsTypes.SelectedIndexChanged += new System.EventHandler(this.CheckedListBox1_SelectedIndexChanged);
            // 
            // OnEventType
            // 
            this.OnEventType.FormattingEnabled = true;
            this.OnEventType.Items.AddRange(new object[] {
            "Mover",
            "Renomear",
            "Mover e Renomear ",
            "Copiar",
            "Copiar e Renomear",
            "Deletar"});
            this.OnEventType.Location = new System.Drawing.Point(188, 41);
            this.OnEventType.Name = "OnEventType";
            this.OnEventType.Size = new System.Drawing.Size(121, 21);
            this.OnEventType.TabIndex = 37;
            this.toolTip1.SetToolTip(this.OnEventType, "Ação a ser executada quando ocorrer um Evento");
            this.OnEventType.SelectedIndexChanged += new System.EventHandler(this.ComboBox1_SelectedIndexChanged);
            // 
            // NotifyFilters
            // 
            this.NotifyFilters.BackColor = System.Drawing.SystemColors.Window;
            this.NotifyFilters.FormattingEnabled = true;
            this.NotifyFilters.Items.AddRange(new object[] {
            "Attributes",
            "CreationTime",
            "DirectoryName",
            "FileName",
            "LastAccess",
            "LastWrite",
            "Security",
            "Size"});
            this.NotifyFilters.Location = new System.Drawing.Point(0, 0);
            this.NotifyFilters.Name = "NotifyFilters";
            this.NotifyFilters.Size = new System.Drawing.Size(95, 124);
            this.NotifyFilters.TabIndex = 0;
            this.toolTip1.SetToolTip(this.NotifyFilters, resources.GetString("NotifyFilters.ToolTip"));
            // 
            // tabPage5
            // 
            this.tabPage5.Location = new System.Drawing.Point(4, 22);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Size = new System.Drawing.Size(688, 309);
            this.tabPage5.TabIndex = 4;
            this.tabPage5.Text = "Deletar";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.button4);
            this.tabPage2.Controls.Add(this.MoveTo);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(688, 309);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Mover";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(21, 24);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(76, 15);
            this.label6.TabIndex = 32;
            this.label6.Text = "Mover Para :";
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(561, 21);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(114, 23);
            this.button4.TabIndex = 31;
            this.button4.Text = "Selecionar";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.Button4_Click);
            // 
            // MoveTo
            // 
            this.MoveTo.Location = new System.Drawing.Point(107, 24);
            this.MoveTo.Margin = new System.Windows.Forms.Padding(7);
            this.MoveTo.Name = "MoveTo";
            this.MoveTo.ReadOnly = true;
            this.MoveTo.Size = new System.Drawing.Size(444, 20);
            this.MoveTo.TabIndex = 30;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.LabelVersion);
            this.tabPage1.Controls.Add(this.Subdirectories);
            this.tabPage1.Controls.Add(this.groupBox3);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.OnEventType);
            this.tabPage1.Controls.Add(this.Btn_Log);
            this.tabPage1.Controls.Add(this.LabelStatus);
            this.tabPage1.Controls.Add(this.groupBox2);
            this.tabPage1.Controls.Add(this.Start);
            this.tabPage1.Controls.Add(this.Status);
            this.tabPage1.Controls.Add(this.Filter);
            this.tabPage1.Controls.Add(this.FolderWatcher);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.Btn_WatcherSelect);
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(688, 309);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Painel";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // LabelVersion
            // 
            this.LabelVersion.AutoSize = true;
            this.LabelVersion.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.LabelVersion.Location = new System.Drawing.Point(608, 291);
            this.LabelVersion.Name = "LabelVersion";
            this.LabelVersion.Size = new System.Drawing.Size(69, 13);
            this.LabelVersion.TabIndex = 40;
            this.LabelVersion.Text = "Version 1.0.0";
            // 
            // Subdirectories
            // 
            this.Subdirectories.AutoSize = true;
            this.Subdirectories.Location = new System.Drawing.Point(19, 83);
            this.Subdirectories.Name = "Subdirectories";
            this.Subdirectories.Size = new System.Drawing.Size(118, 17);
            this.Subdirectories.TabIndex = 39;
            this.Subdirectories.Text = "Incluir Subdiretórios";
            this.Subdirectories.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.panel3);
            this.groupBox3.Location = new System.Drawing.Point(562, 44);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(110, 146);
            this.groupBox3.TabIndex = 35;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "NotifyFilters";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.NotifyFilters);
            this.panel3.Location = new System.Drawing.Point(9, 16);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(95, 131);
            this.panel3.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(125, 44);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 15);
            this.label4.TabIndex = 38;
            this.label4.Text = "OnEvent :";
            // 
            // Btn_Log
            // 
            this.Btn_Log.Location = new System.Drawing.Point(451, 106);
            this.Btn_Log.Name = "Btn_Log";
            this.Btn_Log.Size = new System.Drawing.Size(95, 23);
            this.Btn_Log.TabIndex = 36;
            this.Btn_Log.Text = "Limpar Log";
            this.Btn_Log.UseVisualStyleBackColor = true;
            this.Btn_Log.Click += new System.EventHandler(this.Btn_Log_Click);
            // 
            // LabelStatus
            // 
            this.LabelStatus.AutoSize = true;
            this.LabelStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelStatus.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.LabelStatus.Location = new System.Drawing.Point(275, 116);
            this.LabelStatus.Name = "LabelStatus";
            this.LabelStatus.Size = new System.Drawing.Size(61, 13);
            this.LabelStatus.TabIndex = 35;
            this.LabelStatus.Text = "Not Started";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.panel2);
            this.groupBox2.Location = new System.Drawing.Point(562, 195);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(110, 90);
            this.groupBox2.TabIndex = 34;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Eventos";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.EventsTypes);
            this.panel2.Location = new System.Drawing.Point(9, 16);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(95, 68);
            this.panel2.TabIndex = 0;
            // 
            // Start
            // 
            this.Start.Location = new System.Drawing.Point(451, 77);
            this.Start.Name = "Start";
            this.Start.Size = new System.Drawing.Size(95, 23);
            this.Start.TabIndex = 33;
            this.Start.Text = "Start";
            this.Start.UseVisualStyleBackColor = true;
            this.Start.Click += new System.EventHandler(this.Start_Click);
            // 
            // Status
            // 
            this.Status.AutoSize = true;
            this.Status.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Status.Location = new System.Drawing.Point(235, 116);
            this.Status.Name = "Status";
            this.Status.Size = new System.Drawing.Size(46, 13);
            this.Status.TabIndex = 32;
            this.Status.Text = "Status : ";
            // 
            // FolderWatcher
            // 
            this.FolderWatcher.Location = new System.Drawing.Point(108, 12);
            this.FolderWatcher.Margin = new System.Windows.Forms.Padding(7);
            this.FolderWatcher.Name = "FolderWatcher";
            this.FolderWatcher.ReadOnly = true;
            this.FolderWatcher.Size = new System.Drawing.Size(444, 20);
            this.FolderWatcher.TabIndex = 27;
            this.FolderWatcher.Text = "C:\\AIR Concluido";
            this.FolderWatcher.TextChanged += new System.EventHandler(this.FolderWatcher_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(16, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 15);
            this.label2.TabIndex = 30;
            this.label2.Text = "Filtro :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(16, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 15);
            this.label1.TabIndex = 29;
            this.label1.Text = "Pasta Watcher :";
            // 
            // Btn_WatcherSelect
            // 
            this.Btn_WatcherSelect.Location = new System.Drawing.Point(558, 10);
            this.Btn_WatcherSelect.Name = "Btn_WatcherSelect";
            this.Btn_WatcherSelect.Size = new System.Drawing.Size(114, 23);
            this.Btn_WatcherSelect.TabIndex = 28;
            this.Btn_WatcherSelect.Text = "Selecionar";
            this.Btn_WatcherSelect.UseVisualStyleBackColor = true;
            this.Btn_WatcherSelect.Click += new System.EventHandler(this.Btn_WatcherSelect_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.panel1);
            this.groupBox1.Location = new System.Drawing.Point(19, 138);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(533, 156);
            this.groupBox1.TabIndex = 26;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Log";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.LogBox);
            this.panel1.Location = new System.Drawing.Point(6, 16);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(521, 131);
            this.panel1.TabIndex = 0;
            // 
            // LogBox
            // 
            this.LogBox.Location = new System.Drawing.Point(0, 0);
            this.LogBox.Multiline = true;
            this.LogBox.Name = "LogBox";
            this.LogBox.ReadOnly = true;
            this.LogBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.LogBox.Size = new System.Drawing.Size(521, 131);
            this.LogBox.TabIndex = 0;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Controls.Add(this.tabPage5);
            this.tabControl1.Location = new System.Drawing.Point(0, -1);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(696, 335);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.ExtensionDoc);
            this.tabPage3.Controls.Add(this.ExtensionDocType);
            this.tabPage3.Controls.Add(this.ChangeDocName);
            this.tabPage3.Controls.Add(this.ChangeDocNameType);
            this.tabPage3.Controls.Add(this.label8);
            this.tabPage3.Controls.Add(this.textBox6);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(688, 309);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Renomear";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // ExtensionDoc
            // 
            this.ExtensionDoc.Location = new System.Drawing.Point(299, 82);
            this.ExtensionDoc.Name = "ExtensionDoc";
            this.ExtensionDoc.Size = new System.Drawing.Size(110, 20);
            this.ExtensionDoc.TabIndex = 43;
            this.ExtensionDoc.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // ExtensionDocType
            // 
            this.ExtensionDocType.FormattingEnabled = true;
            this.ExtensionDocType.Items.AddRange(new object[] {
            "Não Mudar a Extenção",
            "Extenção do Arquivo (Format)",
            "Extenção do Arquivo (Específica)"});
            this.ExtensionDocType.Location = new System.Drawing.Point(100, 82);
            this.ExtensionDocType.Name = "ExtensionDocType";
            this.ExtensionDocType.Size = new System.Drawing.Size(183, 21);
            this.ExtensionDocType.TabIndex = 42;
            this.ExtensionDocType.SelectedIndexChanged += new System.EventHandler(this.ExtensionDocType_SelectedIndexChanged);
            // 
            // ChangeDocName
            // 
            this.ChangeDocName.Location = new System.Drawing.Point(299, 55);
            this.ChangeDocName.Name = "ChangeDocName";
            this.ChangeDocName.Size = new System.Drawing.Size(110, 20);
            this.ChangeDocName.TabIndex = 41;
            this.ChangeDocName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // ChangeDocNameType
            // 
            this.ChangeDocNameType.FormattingEnabled = true;
            this.ChangeDocNameType.Items.AddRange(new object[] {
            "Adicionar Format no Final",
            "Adicionar Format no Começo",
            "Nome Específico"});
            this.ChangeDocNameType.Location = new System.Drawing.Point(100, 55);
            this.ChangeDocNameType.Name = "ChangeDocNameType";
            this.ChangeDocNameType.Size = new System.Drawing.Size(183, 21);
            this.ChangeDocNameType.TabIndex = 40;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(25, 25);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(62, 15);
            this.label8.TabIndex = 39;
            this.label8.Text = "Exemplo :";
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(100, 25);
            this.textBox6.Margin = new System.Windows.Forms.Padding(7);
            this.textBox6.Name = "textBox6";
            this.textBox6.ReadOnly = true;
            this.textBox6.Size = new System.Drawing.Size(444, 20);
            this.textBox6.TabIndex = 38;
            this.textBox6.Text = "C:\\AIR Backup";
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.SplitDoc);
            this.tabPage4.Controls.Add(this.TypeSplitDoc);
            this.tabPage4.Controls.Add(this.label7);
            this.tabPage4.Controls.Add(this.button5);
            this.tabPage4.Controls.Add(this.CopyTo);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(688, 309);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Copiar";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // SplitDoc
            // 
            this.SplitDoc.Location = new System.Drawing.Point(258, 58);
            this.SplitDoc.Name = "SplitDoc";
            this.SplitDoc.Size = new System.Drawing.Size(110, 20);
            this.SplitDoc.TabIndex = 37;
            this.SplitDoc.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.SplitDoc.Visible = false;
            // 
            // TypeSplitDoc
            // 
            this.TypeSplitDoc.FormattingEnabled = true;
            this.TypeSplitDoc.Items.AddRange(new object[] {
            "Não Separar Arquivos",
            "Separar Arquivos Por Mês",
            "Separar Arquivos Por Dia",
            "Outro Formato"});
            this.TypeSplitDoc.Location = new System.Drawing.Point(101, 58);
            this.TypeSplitDoc.Name = "TypeSplitDoc";
            this.TypeSplitDoc.Size = new System.Drawing.Size(151, 21);
            this.TypeSplitDoc.TabIndex = 36;
            this.TypeSplitDoc.SelectedIndexChanged += new System.EventHandler(this.TypeSplitDoc_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(15, 28);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(78, 15);
            this.label7.TabIndex = 35;
            this.label7.Text = "Copiar Para :";
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(555, 25);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(114, 23);
            this.button5.TabIndex = 34;
            this.button5.Text = "Selecionar";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.Button5_Click);
            // 
            // CopyTo
            // 
            this.CopyTo.Location = new System.Drawing.Point(101, 28);
            this.CopyTo.Margin = new System.Windows.Forms.Padding(7);
            this.CopyTo.Name = "CopyTo";
            this.CopyTo.ReadOnly = true;
            this.CopyTo.Size = new System.Drawing.Size(444, 20);
            this.CopyTo.TabIndex = 33;
            this.CopyTo.Text = "C:\\AIR Backup";
            this.CopyTo.TextChanged += new System.EventHandler(this.TextBox3_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(693, 330);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = " FileWatcher";
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.TextBox MoveTo;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Label LabelVersion;
        private System.Windows.Forms.CheckBox Subdirectories;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.CheckedListBox NotifyFilters;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox OnEventType;
        private System.Windows.Forms.Button Btn_Log;
        private System.Windows.Forms.Label LabelStatus;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.CheckedListBox EventsTypes;
        private System.Windows.Forms.Button Start;
        private System.Windows.Forms.Label Status;
        private System.Windows.Forms.TextBox Filter;
        private System.Windows.Forms.TextBox FolderWatcher;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Btn_WatcherSelect;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox LogBox;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.TextBox CopyTo;
        private System.Windows.Forms.ComboBox TypeSplitDoc;
        private System.Windows.Forms.TextBox SplitDoc;
        private System.Windows.Forms.TextBox ExtensionDoc;
        private System.Windows.Forms.ComboBox ExtensionDocType;
        private System.Windows.Forms.TextBox ChangeDocName;
        private System.Windows.Forms.ComboBox ChangeDocNameType;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBox6;
    }
}

