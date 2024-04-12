namespace WindowsFormsApp1
{
    partial class Climate
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Climate));
            System.Windows.Forms.TreeNode treeNode141 = new System.Windows.Forms.TreeNode("1");
            System.Windows.Forms.TreeNode treeNode142 = new System.Windows.Forms.TreeNode("Холод", new System.Windows.Forms.TreeNode[] {
            treeNode141});
            System.Windows.Forms.TreeNode treeNode143 = new System.Windows.Forms.TreeNode("1");
            System.Windows.Forms.TreeNode treeNode144 = new System.Windows.Forms.TreeNode("Тепло", new System.Windows.Forms.TreeNode[] {
            treeNode143});
            System.Windows.Forms.TreeNode treeNode145 = new System.Windows.Forms.TreeNode("Терморегистраторы", new System.Windows.Forms.TreeNode[] {
            treeNode142,
            treeNode144});
            System.Windows.Forms.TreeNode treeNode146 = new System.Windows.Forms.TreeNode("1");
            System.Windows.Forms.TreeNode treeNode147 = new System.Windows.Forms.TreeNode("Холод", new System.Windows.Forms.TreeNode[] {
            treeNode146});
            System.Windows.Forms.TreeNode treeNode148 = new System.Windows.Forms.TreeNode("1");
            System.Windows.Forms.TreeNode treeNode149 = new System.Windows.Forms.TreeNode("Тепло", new System.Windows.Forms.TreeNode[] {
            treeNode148});
            System.Windows.Forms.TreeNode treeNode150 = new System.Windows.Forms.TreeNode("Отопление", new System.Windows.Forms.TreeNode[] {
            treeNode147,
            treeNode149});
            System.Windows.Forms.TreeNode treeNode151 = new System.Windows.Forms.TreeNode("1");
            System.Windows.Forms.TreeNode treeNode152 = new System.Windows.Forms.TreeNode("Холод", new System.Windows.Forms.TreeNode[] {
            treeNode151});
            System.Windows.Forms.TreeNode treeNode153 = new System.Windows.Forms.TreeNode("1");
            System.Windows.Forms.TreeNode treeNode154 = new System.Windows.Forms.TreeNode("Тепло", new System.Windows.Forms.TreeNode[] {
            treeNode153});
            System.Windows.Forms.TreeNode treeNode155 = new System.Windows.Forms.TreeNode("Кондиционер", new System.Windows.Forms.TreeNode[] {
            treeNode152,
            treeNode154});
            System.Windows.Forms.TreeNode treeNode156 = new System.Windows.Forms.TreeNode("1");
            System.Windows.Forms.TreeNode treeNode157 = new System.Windows.Forms.TreeNode("Холод", new System.Windows.Forms.TreeNode[] {
            treeNode156});
            System.Windows.Forms.TreeNode treeNode158 = new System.Windows.Forms.TreeNode("1");
            System.Windows.Forms.TreeNode treeNode159 = new System.Windows.Forms.TreeNode("Тепло", new System.Windows.Forms.TreeNode[] {
            treeNode158});
            System.Windows.Forms.TreeNode treeNode160 = new System.Windows.Forms.TreeNode("Вентиляция", new System.Windows.Forms.TreeNode[] {
            treeNode157,
            treeNode159});
            System.Windows.Forms.TreeNode treeNode161 = new System.Windows.Forms.TreeNode("Тёплые");
            System.Windows.Forms.TreeNode treeNode162 = new System.Windows.Forms.TreeNode("Выходы");
            System.Windows.Forms.TreeNode treeNode163 = new System.Windows.Forms.TreeNode("Запасные");
            System.Windows.Forms.TreeNode treeNode164 = new System.Windows.Forms.TreeNode("Двери", new System.Windows.Forms.TreeNode[] {
            treeNode161,
            treeNode162,
            treeNode163});
            System.Windows.Forms.TreeNode treeNode165 = new System.Windows.Forms.TreeNode("Сигнализация");
            System.Windows.Forms.TreeNode treeNode166 = new System.Windows.Forms.TreeNode("Дым");
            System.Windows.Forms.TreeNode treeNode167 = new System.Windows.Forms.TreeNode("Генератор");
            System.Windows.Forms.TreeNode treeNode168 = new System.Windows.Forms.TreeNode("Техника");
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.splitContainer5 = new System.Windows.Forms.SplitContainer();
            this.panelWarning = new System.Windows.Forms.Panel();
            this.WarningMoist = new System.Windows.Forms.Label();
            this.WarningTemp = new System.Windows.Forms.Label();
            this.normMoist = new System.Windows.Forms.Label();
            this.Warning2 = new System.Windows.Forms.Label();
            this.Warning1 = new System.Windows.Forms.Label();
            this.normTemp = new System.Windows.Forms.Label();
            this.warning = new System.Windows.Forms.Label();
            this.buttonCold = new System.Windows.Forms.Button();
            this.buttonWarm = new System.Windows.Forms.Button();
            this.monthCalendar = new System.Windows.Forms.MonthCalendar();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.splitContainer4 = new System.Windows.Forms.SplitContainer();
            this.chartTemp = new LiveCharts.WinForms.CartesianChart();
            this.chartMoisture = new LiveCharts.WinForms.CartesianChart();
            this.Min = new System.Windows.Forms.Button();
            this.buttonExcel = new System.Windows.Forms.Button();
            this.Max = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.weather5 = new System.Windows.Forms.GroupBox();
            this.time4 = new System.Windows.Forms.Label();
            this.pres4 = new System.Windows.Forms.Label();
            this.groupBox8 = new System.Windows.Forms.GroupBox();
            this.deg_4 = new System.Windows.Forms.Label();
            this.speed_4 = new System.Windows.Forms.Label();
            this.hum4 = new System.Windows.Forms.Label();
            this.temp_4 = new System.Windows.Forms.Label();
            this.weatherDescription4 = new System.Windows.Forms.Label();
            this.weatherMain4 = new System.Windows.Forms.Label();
            this.image_4 = new System.Windows.Forms.Panel();
            this.weather4 = new System.Windows.Forms.GroupBox();
            this.time3 = new System.Windows.Forms.Label();
            this.pres3 = new System.Windows.Forms.Label();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.deg_3 = new System.Windows.Forms.Label();
            this.speed_3 = new System.Windows.Forms.Label();
            this.hum3 = new System.Windows.Forms.Label();
            this.temp_3 = new System.Windows.Forms.Label();
            this.weatherDescription3 = new System.Windows.Forms.Label();
            this.weatherMain3 = new System.Windows.Forms.Label();
            this.image_3 = new System.Windows.Forms.Panel();
            this.weather3 = new System.Windows.Forms.GroupBox();
            this.time2 = new System.Windows.Forms.Label();
            this.pres2 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.deg_2 = new System.Windows.Forms.Label();
            this.speed_2 = new System.Windows.Forms.Label();
            this.hum2 = new System.Windows.Forms.Label();
            this.temp_2 = new System.Windows.Forms.Label();
            this.weatherDescription2 = new System.Windows.Forms.Label();
            this.weatherMain2 = new System.Windows.Forms.Label();
            this.image_2 = new System.Windows.Forms.Panel();
            this.weather2 = new System.Windows.Forms.GroupBox();
            this.time1 = new System.Windows.Forms.Label();
            this.pres1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.deg_1 = new System.Windows.Forms.Label();
            this.speed_1 = new System.Windows.Forms.Label();
            this.hum1 = new System.Windows.Forms.Label();
            this.temp_1 = new System.Windows.Forms.Label();
            this.weatherDescription1 = new System.Windows.Forms.Label();
            this.weatherMain1 = new System.Windows.Forms.Label();
            this.image_1 = new System.Windows.Forms.Panel();
            this.gMapControl1 = new GMap.NET.WindowsForms.GMapControl();
            this.SMPcity = new System.Windows.Forms.ListBox();
            this.weather1 = new System.Windows.Forms.GroupBox();
            this.pres = new System.Windows.Forms.Label();
            this.wind_ = new System.Windows.Forms.GroupBox();
            this.deg_ = new System.Windows.Forms.Label();
            this.speed_ = new System.Windows.Forms.Label();
            this.hum = new System.Windows.Forms.Label();
            this.temp_ = new System.Windows.Forms.Label();
            this.time = new System.Windows.Forms.Label();
            this.weatherDescription = new System.Windows.Forms.Label();
            this.weatherMain = new System.Windows.Forms.Label();
            this.image_ = new System.Windows.Forms.Panel();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tech = new System.Windows.Forms.Panel();
            this.to = new System.Windows.Forms.Label();
            this.plan = new System.Windows.Forms.PictureBox();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.userList = new System.Windows.Forms.Panel();
            this.groupBox23 = new System.Windows.Forms.GroupBox();
            this.lastEntry_ = new System.Windows.Forms.Label();
            this.groupBox15 = new System.Windows.Forms.GroupBox();
            this.givenName_ = new System.Windows.Forms.Label();
            this.surname_ = new System.Windows.Forms.Label();
            this.patronymic_ = new System.Windows.Forms.Label();
            this.groupBox16 = new System.Windows.Forms.GroupBox();
            this.birthdate_ = new System.Windows.Forms.Label();
            this.groupBox17 = new System.Windows.Forms.GroupBox();
            this.city_ = new System.Windows.Forms.Label();
            this.groupBox18 = new System.Windows.Forms.GroupBox();
            this.email_ = new System.Windows.Forms.Label();
            this.groupBox19 = new System.Windows.Forms.GroupBox();
            this.gender_ = new System.Windows.Forms.Label();
            this.groupBox20 = new System.Windows.Forms.GroupBox();
            this.phone_ = new System.Windows.Forms.Label();
            this.groupBox21 = new System.Windows.Forms.GroupBox();
            this.post_ = new System.Windows.Forms.Label();
            this.groupBox22 = new System.Windows.Forms.GroupBox();
            this.age_ = new System.Windows.Forms.Label();
            this.groupBox14 = new System.Windows.Forms.GroupBox();
            this.photo_ = new System.Windows.Forms.PictureBox();
            this.account = new System.Windows.Forms.Panel();
            this.textOFF = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.givenName = new System.Windows.Forms.TextBox();
            this.surname = new System.Windows.Forms.TextBox();
            this.patronymic = new System.Windows.Forms.TextBox();
            this.groupBox13 = new System.Windows.Forms.GroupBox();
            this.photo = new System.Windows.Forms.PictureBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.birthdate = new System.Windows.Forms.DateTimePicker();
            this.save = new System.Windows.Forms.Button();
            this.texnON = new System.Windows.Forms.Button();
            this.groupBox12 = new System.Windows.Forms.GroupBox();
            this.city = new System.Windows.Forms.DomainUpDown();
            this.groupBox11 = new System.Windows.Forms.GroupBox();
            this.email = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.gender = new System.Windows.Forms.TextBox();
            this.groupBox9 = new System.Windows.Forms.GroupBox();
            this.phone = new System.Windows.Forms.TextBox();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.post = new System.Windows.Forms.TextBox();
            this.groupBox10 = new System.Windows.Forms.GroupBox();
            this.age = new System.Windows.Forms.TextBox();
            this.workers = new System.Windows.Forms.ListBox();
            this.database1DataSet = new WindowsFormsApp1.Database1DataSet();
            this.tableColdBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tableColdTableAdapter = new WindowsFormsApp1.Database1DataSetTableAdapters.tableColdTableAdapter();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.quit = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer5)).BeginInit();
            this.splitContainer5.Panel1.SuspendLayout();
            this.splitContainer5.Panel2.SuspendLayout();
            this.splitContainer5.SuspendLayout();
            this.panelWarning.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer4)).BeginInit();
            this.splitContainer4.Panel1.SuspendLayout();
            this.splitContainer4.Panel2.SuspendLayout();
            this.splitContainer4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.weather5.SuspendLayout();
            this.groupBox8.SuspendLayout();
            this.weather4.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.weather3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.weather2.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.weather1.SuspendLayout();
            this.wind_.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tech.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.plan)).BeginInit();
            this.tabPage4.SuspendLayout();
            this.userList.SuspendLayout();
            this.groupBox23.SuspendLayout();
            this.groupBox15.SuspendLayout();
            this.groupBox16.SuspendLayout();
            this.groupBox17.SuspendLayout();
            this.groupBox18.SuspendLayout();
            this.groupBox19.SuspendLayout();
            this.groupBox20.SuspendLayout();
            this.groupBox21.SuspendLayout();
            this.groupBox22.SuspendLayout();
            this.groupBox14.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.photo_)).BeginInit();
            this.account.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox13.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.photo)).BeginInit();
            this.groupBox5.SuspendLayout();
            this.groupBox12.SuspendLayout();
            this.groupBox11.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox9.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.groupBox10.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableColdBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1582, 853);
            this.tabControl1.TabIndex = 12;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.splitContainer1);
            this.tabPage1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tabPage1.Location = new System.Drawing.Point(4, 38);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1574, 811);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Климат";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(3, 3);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.splitContainer5);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.splitContainer2);
            this.splitContainer1.Size = new System.Drawing.Size(1568, 805);
            this.splitContainer1.SplitterDistance = 206;
            this.splitContainer1.SplitterWidth = 10;
            this.splitContainer1.TabIndex = 8;
            // 
            // splitContainer5
            // 
            this.splitContainer5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer5.Location = new System.Drawing.Point(0, 0);
            this.splitContainer5.Name = "splitContainer5";
            this.splitContainer5.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer5.Panel1
            // 
            this.splitContainer5.Panel1.Controls.Add(this.panelWarning);
            this.splitContainer5.Panel1.Controls.Add(this.buttonCold);
            this.splitContainer5.Panel1.Controls.Add(this.buttonWarm);
            // 
            // splitContainer5.Panel2
            // 
            this.splitContainer5.Panel2.Controls.Add(this.monthCalendar);
            this.splitContainer5.Size = new System.Drawing.Size(206, 805);
            this.splitContainer5.SplitterDistance = 375;
            this.splitContainer5.SplitterWidth = 10;
            this.splitContainer5.TabIndex = 13;
            // 
            // panelWarning
            // 
            this.panelWarning.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelWarning.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panelWarning.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelWarning.Controls.Add(this.WarningMoist);
            this.panelWarning.Controls.Add(this.WarningTemp);
            this.panelWarning.Controls.Add(this.normMoist);
            this.panelWarning.Controls.Add(this.Warning2);
            this.panelWarning.Controls.Add(this.Warning1);
            this.panelWarning.Controls.Add(this.normTemp);
            this.panelWarning.Controls.Add(this.warning);
            this.panelWarning.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.panelWarning.Location = new System.Drawing.Point(5, 107);
            this.panelWarning.Name = "panelWarning";
            this.panelWarning.Size = new System.Drawing.Size(194, 264);
            this.panelWarning.TabIndex = 12;
            // 
            // WarningMoist
            // 
            this.WarningMoist.AutoSize = true;
            this.WarningMoist.Location = new System.Drawing.Point(4, 189);
            this.WarningMoist.Name = "WarningMoist";
            this.WarningMoist.Size = new System.Drawing.Size(89, 16);
            this.WarningMoist.TabIndex = 7;
            this.WarningMoist.Text = "WarningMoist";
            // 
            // WarningTemp
            // 
            this.WarningTemp.AutoSize = true;
            this.WarningTemp.Location = new System.Drawing.Point(4, 157);
            this.WarningTemp.Name = "WarningTemp";
            this.WarningTemp.Size = new System.Drawing.Size(93, 16);
            this.WarningTemp.TabIndex = 6;
            this.WarningTemp.Text = "WarningTemp";
            // 
            // normMoist
            // 
            this.normMoist.AutoSize = true;
            this.normMoist.Location = new System.Drawing.Point(4, 89);
            this.normMoist.Name = "normMoist";
            this.normMoist.Size = new System.Drawing.Size(141, 48);
            this.normMoist.TabIndex = 5;
            this.normMoist.Text = "нормы влажности:\r\n - для теплой до 65\r\n - для холодной до 65";
            // 
            // Warning2
            // 
            this.Warning2.AutoSize = true;
            this.Warning2.Location = new System.Drawing.Point(4, 137);
            this.Warning2.Name = "Warning2";
            this.Warning2.Size = new System.Drawing.Size(64, 16);
            this.Warning2.TabIndex = 4;
            this.Warning2.Text = "Warning2";
            // 
            // Warning1
            // 
            this.Warning1.AutoSize = true;
            this.Warning1.Location = new System.Drawing.Point(4, 73);
            this.Warning1.Name = "Warning1";
            this.Warning1.Size = new System.Drawing.Size(64, 16);
            this.Warning1.TabIndex = 3;
            this.Warning1.Text = "Warning1";
            // 
            // normTemp
            // 
            this.normTemp.AutoSize = true;
            this.normTemp.Location = new System.Drawing.Point(4, 25);
            this.normTemp.Name = "normTemp";
            this.normTemp.Size = new System.Drawing.Size(177, 48);
            this.normTemp.TabIndex = 2;
            this.normTemp.Text = "нормы температуры:\r\n - для теплой от 0 до 6\r\n - для холодной от -4 до -18";
            // 
            // warning
            // 
            this.warning.AutoSize = true;
            this.warning.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.warning.Location = new System.Drawing.Point(2, 0);
            this.warning.Name = "warning";
            this.warning.Size = new System.Drawing.Size(175, 25);
            this.warning.TabIndex = 0;
            this.warning.Text = "Предупреждения";
            // 
            // buttonCold
            // 
            this.buttonCold.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCold.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonCold.Location = new System.Drawing.Point(5, 55);
            this.buttonCold.Name = "buttonCold";
            this.buttonCold.Size = new System.Drawing.Size(194, 46);
            this.buttonCold.TabIndex = 11;
            this.buttonCold.Text = "Холодная";
            this.buttonCold.UseVisualStyleBackColor = true;
            this.buttonCold.Click += new System.EventHandler(this.buttonCold_Click);
            // 
            // buttonWarm
            // 
            this.buttonWarm.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonWarm.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonWarm.Location = new System.Drawing.Point(5, 3);
            this.buttonWarm.Name = "buttonWarm";
            this.buttonWarm.Size = new System.Drawing.Size(194, 46);
            this.buttonWarm.TabIndex = 10;
            this.buttonWarm.Text = "Тёплая";
            this.buttonWarm.UseVisualStyleBackColor = true;
            this.buttonWarm.Click += new System.EventHandler(this.buttonWarm_Click);
            // 
            // monthCalendar
            // 
            this.monthCalendar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.monthCalendar.CalendarDimensions = new System.Drawing.Size(1, 2);
            this.monthCalendar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.monthCalendar.Location = new System.Drawing.Point(6, -9);
            this.monthCalendar.Name = "monthCalendar";
            this.monthCalendar.TabIndex = 0;
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.splitContainer4);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.Min);
            this.splitContainer2.Panel2.Controls.Add(this.buttonExcel);
            this.splitContainer2.Panel2.Controls.Add(this.Max);
            this.splitContainer2.Panel2.Controls.Add(this.dataGridView1);
            this.splitContainer2.Panel2.Controls.Add(this.dateTimePicker1);
            this.splitContainer2.Panel2.Controls.Add(this.dateTimePicker2);
            this.splitContainer2.Size = new System.Drawing.Size(1352, 805);
            this.splitContainer2.SplitterDistance = 929;
            this.splitContainer2.SplitterWidth = 10;
            this.splitContainer2.TabIndex = 15;
            // 
            // splitContainer4
            // 
            this.splitContainer4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer4.Location = new System.Drawing.Point(0, 0);
            this.splitContainer4.Name = "splitContainer4";
            this.splitContainer4.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer4.Panel1
            // 
            this.splitContainer4.Panel1.Controls.Add(this.chartTemp);
            // 
            // splitContainer4.Panel2
            // 
            this.splitContainer4.Panel2.Controls.Add(this.chartMoisture);
            this.splitContainer4.Size = new System.Drawing.Size(929, 805);
            this.splitContainer4.SplitterDistance = 375;
            this.splitContainer4.SplitterWidth = 10;
            this.splitContainer4.TabIndex = 0;
            // 
            // chartTemp
            // 
            this.chartTemp.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.chartTemp.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chartTemp.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.chartTemp.Location = new System.Drawing.Point(0, 0);
            this.chartTemp.Name = "chartTemp";
            this.chartTemp.Size = new System.Drawing.Size(929, 375);
            this.chartTemp.TabIndex = 6;
            this.chartTemp.Text = "Температура";
            // 
            // chartMoisture
            // 
            this.chartMoisture.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.chartMoisture.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chartMoisture.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.chartMoisture.Location = new System.Drawing.Point(0, 0);
            this.chartMoisture.Name = "chartMoisture";
            this.chartMoisture.Size = new System.Drawing.Size(929, 420);
            this.chartMoisture.TabIndex = 7;
            this.chartMoisture.Text = "chartMoisture";
            // 
            // Min
            // 
            this.Min.Location = new System.Drawing.Point(131, 36);
            this.Min.Name = "Min";
            this.Min.Size = new System.Drawing.Size(122, 33);
            this.Min.TabIndex = 9;
            this.Min.Text = "Уменьшить";
            this.Min.UseVisualStyleBackColor = true;
            this.Min.Click += new System.EventHandler(this.Min_Click);
            // 
            // buttonExcel
            // 
            this.buttonExcel.Location = new System.Drawing.Point(258, 36);
            this.buttonExcel.Name = "buttonExcel";
            this.buttonExcel.Size = new System.Drawing.Size(150, 33);
            this.buttonExcel.TabIndex = 16;
            this.buttonExcel.Text = "ВЫГРУЗИТЬ";
            this.buttonExcel.UseVisualStyleBackColor = true;
            this.buttonExcel.Click += new System.EventHandler(this.buttonExcel_Click);
            // 
            // Max
            // 
            this.Max.Location = new System.Drawing.Point(3, 36);
            this.Max.Name = "Max";
            this.Max.Size = new System.Drawing.Size(122, 33);
            this.Max.TabIndex = 8;
            this.Max.Text = "Увеличить";
            this.Max.UseVisualStyleBackColor = true;
            this.Max.Click += new System.EventHandler(this.Max_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle6;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(3, 75);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(357, 730);
            this.dataGridView1.TabIndex = 15;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(3, 3);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 27);
            this.dateTimePicker1.TabIndex = 13;
            this.dateTimePicker1.Value = new System.DateTime(2023, 9, 1, 0, 0, 0, 0);
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(208, 3);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(200, 27);
            this.dateTimePicker2.TabIndex = 14;
            this.dateTimePicker2.ValueChanged += new System.EventHandler(this.dateTimePicker2_ValueChanged);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.weather5);
            this.tabPage2.Controls.Add(this.weather4);
            this.tabPage2.Controls.Add(this.weather3);
            this.tabPage2.Controls.Add(this.weather2);
            this.tabPage2.Controls.Add(this.gMapControl1);
            this.tabPage2.Controls.Add(this.SMPcity);
            this.tabPage2.Controls.Add(this.weather1);
            this.tabPage2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tabPage2.Location = new System.Drawing.Point(4, 38);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1574, 811);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Погода";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // weather5
            // 
            this.weather5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.weather5.Controls.Add(this.time4);
            this.weather5.Controls.Add(this.pres4);
            this.weather5.Controls.Add(this.groupBox8);
            this.weather5.Controls.Add(this.hum4);
            this.weather5.Controls.Add(this.temp_4);
            this.weather5.Controls.Add(this.weatherDescription4);
            this.weather5.Controls.Add(this.weatherMain4);
            this.weather5.Controls.Add(this.image_4);
            this.weather5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.weather5.Location = new System.Drawing.Point(1232, 483);
            this.weather5.Name = "weather5";
            this.weather5.Size = new System.Drawing.Size(300, 333);
            this.weather5.TabIndex = 11;
            this.weather5.TabStop = false;
            this.weather5.Text = "Погода";
            // 
            // time4
            // 
            this.time4.AutoSize = true;
            this.time4.Location = new System.Drawing.Point(102, 26);
            this.time4.Name = "time4";
            this.time4.Size = new System.Drawing.Size(50, 20);
            this.time4.TabIndex = 9;
            this.time4.Text = "time4";
            // 
            // pres4
            // 
            this.pres4.AutoSize = true;
            this.pres4.Location = new System.Drawing.Point(6, 199);
            this.pres4.Name = "pres4";
            this.pres4.Size = new System.Drawing.Size(51, 20);
            this.pres4.TabIndex = 1;
            this.pres4.Text = "pres4";
            // 
            // groupBox8
            // 
            this.groupBox8.Controls.Add(this.deg_4);
            this.groupBox8.Controls.Add(this.speed_4);
            this.groupBox8.Location = new System.Drawing.Point(6, 222);
            this.groupBox8.Name = "groupBox8";
            this.groupBox8.Size = new System.Drawing.Size(241, 90);
            this.groupBox8.TabIndex = 6;
            this.groupBox8.TabStop = false;
            this.groupBox8.Text = "Ветер";
            // 
            // deg_4
            // 
            this.deg_4.AutoSize = true;
            this.deg_4.Location = new System.Drawing.Point(0, 38);
            this.deg_4.Name = "deg_4";
            this.deg_4.Size = new System.Drawing.Size(54, 20);
            this.deg_4.TabIndex = 5;
            this.deg_4.Text = "deg_4";
            // 
            // speed_4
            // 
            this.speed_4.AutoSize = true;
            this.speed_4.Location = new System.Drawing.Point(0, 18);
            this.speed_4.Name = "speed_4";
            this.speed_4.Size = new System.Drawing.Size(72, 20);
            this.speed_4.TabIndex = 4;
            this.speed_4.Text = "speed_4";
            // 
            // hum4
            // 
            this.hum4.AutoSize = true;
            this.hum4.Location = new System.Drawing.Point(6, 179);
            this.hum4.Name = "hum4";
            this.hum4.Size = new System.Drawing.Size(50, 20);
            this.hum4.TabIndex = 0;
            this.hum4.Text = "hum4";
            // 
            // temp_4
            // 
            this.temp_4.AutoSize = true;
            this.temp_4.Location = new System.Drawing.Point(6, 159);
            this.temp_4.Name = "temp_4";
            this.temp_4.Size = new System.Drawing.Size(64, 20);
            this.temp_4.TabIndex = 3;
            this.temp_4.Text = "temp_4";
            // 
            // weatherDescription4
            // 
            this.weatherDescription4.AutoSize = true;
            this.weatherDescription4.Location = new System.Drawing.Point(6, 139);
            this.weatherDescription4.Name = "weatherDescription4";
            this.weatherDescription4.Size = new System.Drawing.Size(163, 20);
            this.weatherDescription4.TabIndex = 2;
            this.weatherDescription4.Text = "weatherDescription4";
            // 
            // weatherMain4
            // 
            this.weatherMain4.AutoSize = true;
            this.weatherMain4.Location = new System.Drawing.Point(6, 119);
            this.weatherMain4.Name = "weatherMain4";
            this.weatherMain4.Size = new System.Drawing.Size(113, 20);
            this.weatherMain4.TabIndex = 1;
            this.weatherMain4.Text = "weatherMain4";
            // 
            // image_4
            // 
            this.image_4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.image_4.Location = new System.Drawing.Point(6, 26);
            this.image_4.Name = "image_4";
            this.image_4.Size = new System.Drawing.Size(90, 90);
            this.image_4.TabIndex = 0;
            // 
            // weather4
            // 
            this.weather4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.weather4.Controls.Add(this.time3);
            this.weather4.Controls.Add(this.pres3);
            this.weather4.Controls.Add(this.groupBox6);
            this.weather4.Controls.Add(this.hum3);
            this.weather4.Controls.Add(this.temp_3);
            this.weather4.Controls.Add(this.weatherDescription3);
            this.weather4.Controls.Add(this.weatherMain3);
            this.weather4.Controls.Add(this.image_3);
            this.weather4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.weather4.Location = new System.Drawing.Point(926, 483);
            this.weather4.Name = "weather4";
            this.weather4.Size = new System.Drawing.Size(300, 333);
            this.weather4.TabIndex = 10;
            this.weather4.TabStop = false;
            this.weather4.Text = "Погода";
            // 
            // time3
            // 
            this.time3.AutoSize = true;
            this.time3.Location = new System.Drawing.Point(102, 26);
            this.time3.Name = "time3";
            this.time3.Size = new System.Drawing.Size(50, 20);
            this.time3.TabIndex = 9;
            this.time3.Text = "time3";
            // 
            // pres3
            // 
            this.pres3.AutoSize = true;
            this.pres3.Location = new System.Drawing.Point(6, 199);
            this.pres3.Name = "pres3";
            this.pres3.Size = new System.Drawing.Size(51, 20);
            this.pres3.TabIndex = 1;
            this.pres3.Text = "pres3";
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.deg_3);
            this.groupBox6.Controls.Add(this.speed_3);
            this.groupBox6.Location = new System.Drawing.Point(6, 222);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(241, 90);
            this.groupBox6.TabIndex = 6;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Ветер";
            // 
            // deg_3
            // 
            this.deg_3.AutoSize = true;
            this.deg_3.Location = new System.Drawing.Point(0, 38);
            this.deg_3.Name = "deg_3";
            this.deg_3.Size = new System.Drawing.Size(54, 20);
            this.deg_3.TabIndex = 5;
            this.deg_3.Text = "deg_3";
            // 
            // speed_3
            // 
            this.speed_3.AutoSize = true;
            this.speed_3.Location = new System.Drawing.Point(0, 18);
            this.speed_3.Name = "speed_3";
            this.speed_3.Size = new System.Drawing.Size(72, 20);
            this.speed_3.TabIndex = 4;
            this.speed_3.Text = "speed_3";
            // 
            // hum3
            // 
            this.hum3.AutoSize = true;
            this.hum3.Location = new System.Drawing.Point(6, 179);
            this.hum3.Name = "hum3";
            this.hum3.Size = new System.Drawing.Size(50, 20);
            this.hum3.TabIndex = 0;
            this.hum3.Text = "hum3";
            // 
            // temp_3
            // 
            this.temp_3.AutoSize = true;
            this.temp_3.Location = new System.Drawing.Point(6, 159);
            this.temp_3.Name = "temp_3";
            this.temp_3.Size = new System.Drawing.Size(64, 20);
            this.temp_3.TabIndex = 3;
            this.temp_3.Text = "temp_3";
            // 
            // weatherDescription3
            // 
            this.weatherDescription3.AutoSize = true;
            this.weatherDescription3.Location = new System.Drawing.Point(6, 139);
            this.weatherDescription3.Name = "weatherDescription3";
            this.weatherDescription3.Size = new System.Drawing.Size(163, 20);
            this.weatherDescription3.TabIndex = 2;
            this.weatherDescription3.Text = "weatherDescription3";
            // 
            // weatherMain3
            // 
            this.weatherMain3.AutoSize = true;
            this.weatherMain3.Location = new System.Drawing.Point(6, 119);
            this.weatherMain3.Name = "weatherMain3";
            this.weatherMain3.Size = new System.Drawing.Size(113, 20);
            this.weatherMain3.TabIndex = 1;
            this.weatherMain3.Text = "weatherMain3";
            // 
            // image_3
            // 
            this.image_3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.image_3.Location = new System.Drawing.Point(6, 26);
            this.image_3.Name = "image_3";
            this.image_3.Size = new System.Drawing.Size(90, 90);
            this.image_3.TabIndex = 0;
            // 
            // weather3
            // 
            this.weather3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.weather3.Controls.Add(this.time2);
            this.weather3.Controls.Add(this.pres2);
            this.weather3.Controls.Add(this.groupBox4);
            this.weather3.Controls.Add(this.hum2);
            this.weather3.Controls.Add(this.temp_2);
            this.weather3.Controls.Add(this.weatherDescription2);
            this.weather3.Controls.Add(this.weatherMain2);
            this.weather3.Controls.Add(this.image_2);
            this.weather3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.weather3.Location = new System.Drawing.Point(620, 483);
            this.weather3.Name = "weather3";
            this.weather3.Size = new System.Drawing.Size(300, 333);
            this.weather3.TabIndex = 9;
            this.weather3.TabStop = false;
            this.weather3.Text = "Погода";
            // 
            // time2
            // 
            this.time2.AutoSize = true;
            this.time2.Location = new System.Drawing.Point(102, 26);
            this.time2.Name = "time2";
            this.time2.Size = new System.Drawing.Size(50, 20);
            this.time2.TabIndex = 9;
            this.time2.Text = "time2";
            // 
            // pres2
            // 
            this.pres2.AutoSize = true;
            this.pres2.Location = new System.Drawing.Point(6, 199);
            this.pres2.Name = "pres2";
            this.pres2.Size = new System.Drawing.Size(51, 20);
            this.pres2.TabIndex = 1;
            this.pres2.Text = "pres2";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.deg_2);
            this.groupBox4.Controls.Add(this.speed_2);
            this.groupBox4.Location = new System.Drawing.Point(6, 222);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(241, 90);
            this.groupBox4.TabIndex = 6;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Ветер";
            // 
            // deg_2
            // 
            this.deg_2.AutoSize = true;
            this.deg_2.Location = new System.Drawing.Point(0, 38);
            this.deg_2.Name = "deg_2";
            this.deg_2.Size = new System.Drawing.Size(54, 20);
            this.deg_2.TabIndex = 5;
            this.deg_2.Text = "deg_2";
            // 
            // speed_2
            // 
            this.speed_2.AutoSize = true;
            this.speed_2.Location = new System.Drawing.Point(0, 18);
            this.speed_2.Name = "speed_2";
            this.speed_2.Size = new System.Drawing.Size(72, 20);
            this.speed_2.TabIndex = 4;
            this.speed_2.Text = "speed_2";
            // 
            // hum2
            // 
            this.hum2.AutoSize = true;
            this.hum2.Location = new System.Drawing.Point(6, 179);
            this.hum2.Name = "hum2";
            this.hum2.Size = new System.Drawing.Size(50, 20);
            this.hum2.TabIndex = 0;
            this.hum2.Text = "hum2";
            // 
            // temp_2
            // 
            this.temp_2.AutoSize = true;
            this.temp_2.Location = new System.Drawing.Point(6, 159);
            this.temp_2.Name = "temp_2";
            this.temp_2.Size = new System.Drawing.Size(64, 20);
            this.temp_2.TabIndex = 3;
            this.temp_2.Text = "temp_2";
            // 
            // weatherDescription2
            // 
            this.weatherDescription2.AutoSize = true;
            this.weatherDescription2.Location = new System.Drawing.Point(6, 139);
            this.weatherDescription2.Name = "weatherDescription2";
            this.weatherDescription2.Size = new System.Drawing.Size(163, 20);
            this.weatherDescription2.TabIndex = 2;
            this.weatherDescription2.Text = "weatherDescription2";
            // 
            // weatherMain2
            // 
            this.weatherMain2.AutoSize = true;
            this.weatherMain2.Location = new System.Drawing.Point(6, 119);
            this.weatherMain2.Name = "weatherMain2";
            this.weatherMain2.Size = new System.Drawing.Size(113, 20);
            this.weatherMain2.TabIndex = 1;
            this.weatherMain2.Text = "weatherMain2";
            // 
            // image_2
            // 
            this.image_2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.image_2.Location = new System.Drawing.Point(6, 26);
            this.image_2.Name = "image_2";
            this.image_2.Size = new System.Drawing.Size(90, 90);
            this.image_2.TabIndex = 0;
            // 
            // weather2
            // 
            this.weather2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.weather2.Controls.Add(this.time1);
            this.weather2.Controls.Add(this.pres1);
            this.weather2.Controls.Add(this.groupBox2);
            this.weather2.Controls.Add(this.hum1);
            this.weather2.Controls.Add(this.temp_1);
            this.weather2.Controls.Add(this.weatherDescription1);
            this.weather2.Controls.Add(this.weatherMain1);
            this.weather2.Controls.Add(this.image_1);
            this.weather2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.weather2.Location = new System.Drawing.Point(314, 483);
            this.weather2.Name = "weather2";
            this.weather2.Size = new System.Drawing.Size(300, 333);
            this.weather2.TabIndex = 8;
            this.weather2.TabStop = false;
            this.weather2.Text = "Погода";
            // 
            // time1
            // 
            this.time1.AutoSize = true;
            this.time1.Location = new System.Drawing.Point(102, 26);
            this.time1.Name = "time1";
            this.time1.Size = new System.Drawing.Size(50, 20);
            this.time1.TabIndex = 8;
            this.time1.Text = "time1";
            // 
            // pres1
            // 
            this.pres1.AutoSize = true;
            this.pres1.Location = new System.Drawing.Point(6, 199);
            this.pres1.Name = "pres1";
            this.pres1.Size = new System.Drawing.Size(51, 20);
            this.pres1.TabIndex = 1;
            this.pres1.Text = "pres1";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.deg_1);
            this.groupBox2.Controls.Add(this.speed_1);
            this.groupBox2.Location = new System.Drawing.Point(6, 222);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(241, 90);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Ветер";
            // 
            // deg_1
            // 
            this.deg_1.AutoSize = true;
            this.deg_1.Location = new System.Drawing.Point(0, 38);
            this.deg_1.Name = "deg_1";
            this.deg_1.Size = new System.Drawing.Size(54, 20);
            this.deg_1.TabIndex = 5;
            this.deg_1.Text = "deg_1";
            // 
            // speed_1
            // 
            this.speed_1.AutoSize = true;
            this.speed_1.Location = new System.Drawing.Point(0, 18);
            this.speed_1.Name = "speed_1";
            this.speed_1.Size = new System.Drawing.Size(72, 20);
            this.speed_1.TabIndex = 4;
            this.speed_1.Text = "speed_1";
            // 
            // hum1
            // 
            this.hum1.AutoSize = true;
            this.hum1.Location = new System.Drawing.Point(6, 179);
            this.hum1.Name = "hum1";
            this.hum1.Size = new System.Drawing.Size(50, 20);
            this.hum1.TabIndex = 0;
            this.hum1.Text = "hum1";
            // 
            // temp_1
            // 
            this.temp_1.AutoSize = true;
            this.temp_1.Location = new System.Drawing.Point(6, 159);
            this.temp_1.Name = "temp_1";
            this.temp_1.Size = new System.Drawing.Size(64, 20);
            this.temp_1.TabIndex = 3;
            this.temp_1.Text = "temp_1";
            // 
            // weatherDescription1
            // 
            this.weatherDescription1.AutoSize = true;
            this.weatherDescription1.Location = new System.Drawing.Point(6, 139);
            this.weatherDescription1.Name = "weatherDescription1";
            this.weatherDescription1.Size = new System.Drawing.Size(163, 20);
            this.weatherDescription1.TabIndex = 2;
            this.weatherDescription1.Text = "weatherDescription1";
            // 
            // weatherMain1
            // 
            this.weatherMain1.AutoSize = true;
            this.weatherMain1.Location = new System.Drawing.Point(6, 119);
            this.weatherMain1.Name = "weatherMain1";
            this.weatherMain1.Size = new System.Drawing.Size(113, 20);
            this.weatherMain1.TabIndex = 1;
            this.weatherMain1.Text = "weatherMain1";
            // 
            // image_1
            // 
            this.image_1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.image_1.Location = new System.Drawing.Point(6, 26);
            this.image_1.Name = "image_1";
            this.image_1.Size = new System.Drawing.Size(90, 90);
            this.image_1.TabIndex = 0;
            // 
            // gMapControl1
            // 
            this.gMapControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gMapControl1.Bearing = 0F;
            this.gMapControl1.CanDragMap = true;
            this.gMapControl1.EmptyTileColor = System.Drawing.Color.Navy;
            this.gMapControl1.GrayScaleMode = false;
            this.gMapControl1.HelperLineOption = GMap.NET.WindowsForms.HelperLineOptions.DontShow;
            this.gMapControl1.LevelsKeepInMemory = 5;
            this.gMapControl1.Location = new System.Drawing.Point(314, 6);
            this.gMapControl1.MarkersEnabled = true;
            this.gMapControl1.MaxZoom = 2;
            this.gMapControl1.MinZoom = 2;
            this.gMapControl1.MouseWheelZoomEnabled = true;
            this.gMapControl1.MouseWheelZoomType = GMap.NET.MouseWheelZoomType.MousePositionAndCenter;
            this.gMapControl1.Name = "gMapControl1";
            this.gMapControl1.NegativeMode = false;
            this.gMapControl1.PolygonsEnabled = true;
            this.gMapControl1.RetryLoadTile = 0;
            this.gMapControl1.RoutesEnabled = true;
            this.gMapControl1.ScaleMode = GMap.NET.WindowsForms.ScaleModes.Integer;
            this.gMapControl1.SelectedAreaFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(65)))), ((int)(((byte)(105)))), ((int)(((byte)(225)))));
            this.gMapControl1.ShowTileGridLines = false;
            this.gMapControl1.Size = new System.Drawing.Size(1218, 479);
            this.gMapControl1.TabIndex = 3;
            this.gMapControl1.Zoom = 0D;
            // 
            // SMPcity
            // 
            this.SMPcity.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SMPcity.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SMPcity.FormattingEnabled = true;
            this.SMPcity.ItemHeight = 25;
            this.SMPcity.Location = new System.Drawing.Point(8, 6);
            this.SMPcity.Name = "SMPcity";
            this.SMPcity.ScrollAlwaysVisible = true;
            this.SMPcity.Size = new System.Drawing.Size(300, 479);
            this.SMPcity.TabIndex = 2;
            // 
            // weather1
            // 
            this.weather1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.weather1.Controls.Add(this.pres);
            this.weather1.Controls.Add(this.wind_);
            this.weather1.Controls.Add(this.hum);
            this.weather1.Controls.Add(this.temp_);
            this.weather1.Controls.Add(this.time);
            this.weather1.Controls.Add(this.weatherDescription);
            this.weather1.Controls.Add(this.weatherMain);
            this.weather1.Controls.Add(this.image_);
            this.weather1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.weather1.Location = new System.Drawing.Point(8, 483);
            this.weather1.Name = "weather1";
            this.weather1.Size = new System.Drawing.Size(300, 333);
            this.weather1.TabIndex = 1;
            this.weather1.TabStop = false;
            this.weather1.Text = "Погода";
            // 
            // pres
            // 
            this.pres.AutoSize = true;
            this.pres.Location = new System.Drawing.Point(6, 199);
            this.pres.Name = "pres";
            this.pres.Size = new System.Drawing.Size(42, 20);
            this.pres.TabIndex = 1;
            this.pres.Text = "pres";
            // 
            // wind_
            // 
            this.wind_.Controls.Add(this.deg_);
            this.wind_.Controls.Add(this.speed_);
            this.wind_.Location = new System.Drawing.Point(6, 222);
            this.wind_.Name = "wind_";
            this.wind_.Size = new System.Drawing.Size(241, 90);
            this.wind_.TabIndex = 6;
            this.wind_.TabStop = false;
            this.wind_.Text = "Ветер";
            // 
            // deg_
            // 
            this.deg_.AutoSize = true;
            this.deg_.Location = new System.Drawing.Point(0, 38);
            this.deg_.Name = "deg_";
            this.deg_.Size = new System.Drawing.Size(45, 20);
            this.deg_.TabIndex = 5;
            this.deg_.Text = "deg_";
            // 
            // speed_
            // 
            this.speed_.AutoSize = true;
            this.speed_.Location = new System.Drawing.Point(0, 18);
            this.speed_.Name = "speed_";
            this.speed_.Size = new System.Drawing.Size(63, 20);
            this.speed_.TabIndex = 4;
            this.speed_.Text = "speed_";
            // 
            // hum
            // 
            this.hum.AutoSize = true;
            this.hum.Location = new System.Drawing.Point(6, 179);
            this.hum.Name = "hum";
            this.hum.Size = new System.Drawing.Size(41, 20);
            this.hum.TabIndex = 0;
            this.hum.Text = "hum";
            // 
            // temp_
            // 
            this.temp_.AutoSize = true;
            this.temp_.Location = new System.Drawing.Point(6, 159);
            this.temp_.Name = "temp_";
            this.temp_.Size = new System.Drawing.Size(55, 20);
            this.temp_.TabIndex = 3;
            this.temp_.Text = "temp_";
            // 
            // time
            // 
            this.time.AutoSize = true;
            this.time.Location = new System.Drawing.Point(102, 26);
            this.time.Name = "time";
            this.time.Size = new System.Drawing.Size(41, 20);
            this.time.TabIndex = 7;
            this.time.Text = "time";
            // 
            // weatherDescription
            // 
            this.weatherDescription.AutoSize = true;
            this.weatherDescription.Location = new System.Drawing.Point(6, 139);
            this.weatherDescription.Name = "weatherDescription";
            this.weatherDescription.Size = new System.Drawing.Size(154, 20);
            this.weatherDescription.TabIndex = 2;
            this.weatherDescription.Text = "weatherDescription";
            // 
            // weatherMain
            // 
            this.weatherMain.AutoSize = true;
            this.weatherMain.Location = new System.Drawing.Point(6, 119);
            this.weatherMain.Name = "weatherMain";
            this.weatherMain.Size = new System.Drawing.Size(104, 20);
            this.weatherMain.TabIndex = 1;
            this.weatherMain.Text = "weatherMain";
            // 
            // image_
            // 
            this.image_.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.image_.Location = new System.Drawing.Point(6, 26);
            this.image_.Name = "image_";
            this.image_.Size = new System.Drawing.Size(90, 90);
            this.image_.TabIndex = 0;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.tech);
            this.tabPage3.Controls.Add(this.plan);
            this.tabPage3.Controls.Add(this.treeView1);
            this.tabPage3.Location = new System.Drawing.Point(4, 38);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(1574, 811);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Техническое";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // tech
            // 
            this.tech.BackColor = System.Drawing.Color.Gainsboro;
            this.tech.Controls.Add(this.label6);
            this.tech.Controls.Add(this.label5);
            this.tech.Controls.Add(this.label4);
            this.tech.Controls.Add(this.label3);
            this.tech.Controls.Add(this.label2);
            this.tech.Controls.Add(this.label1);
            this.tech.Controls.Add(this.to);
            this.tech.Dock = System.Windows.Forms.DockStyle.Left;
            this.tech.Location = new System.Drawing.Point(305, 3);
            this.tech.Name = "tech";
            this.tech.Size = new System.Drawing.Size(433, 805);
            this.tech.TabIndex = 15;
            this.tech.Visible = false;
            // 
            // to
            // 
            this.to.AutoSize = true;
            this.to.Location = new System.Drawing.Point(17, 15);
            this.to.Name = "to";
            this.to.Size = new System.Drawing.Size(48, 29);
            this.to.TabIndex = 0;
            this.to.Text = "ТО";
            // 
            // plan
            // 
            this.plan.Dock = System.Windows.Forms.DockStyle.Right;
            this.plan.Image = ((System.Drawing.Image)(resources.GetObject("plan.Image")));
            this.plan.Location = new System.Drawing.Point(744, 3);
            this.plan.Name = "plan";
            this.plan.Size = new System.Drawing.Size(827, 805);
            this.plan.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.plan.TabIndex = 14;
            this.plan.TabStop = false;
            // 
            // treeView1
            // 
            this.treeView1.Dock = System.Windows.Forms.DockStyle.Left;
            this.treeView1.Location = new System.Drawing.Point(3, 3);
            this.treeView1.Name = "treeView1";
            treeNode141.Name = "Узел8";
            treeNode141.Text = "1";
            treeNode142.Name = "Узел7";
            treeNode142.Text = "Холод";
            treeNode143.Name = "Узел11";
            treeNode143.Text = "1";
            treeNode144.Name = "Узел10";
            treeNode144.Text = "Тепло";
            treeNode145.Name = "Узел0";
            treeNode145.Text = "Терморегистраторы";
            treeNode146.Name = "Узел12";
            treeNode146.Text = "1";
            treeNode147.Name = "Узел6";
            treeNode147.Text = "Холод";
            treeNode148.Name = "Узел15";
            treeNode148.Text = "1";
            treeNode149.Name = "Узел14";
            treeNode149.Text = "Тепло";
            treeNode150.Name = "Узел1";
            treeNode150.Text = "Отопление";
            treeNode151.Name = "Узел18";
            treeNode151.Text = "1";
            treeNode152.Name = "Узел5";
            treeNode152.Text = "Холод";
            treeNode153.Name = "Узел17";
            treeNode153.Text = "1";
            treeNode154.Name = "Узел16";
            treeNode154.Text = "Тепло";
            treeNode155.Name = "Узел2";
            treeNode155.Text = "Кондиционер";
            treeNode156.Name = "Узел20";
            treeNode156.Text = "1";
            treeNode157.Name = "Узел4";
            treeNode157.Text = "Холод";
            treeNode158.Name = "Узел21";
            treeNode158.Text = "1";
            treeNode159.Name = "Узел19";
            treeNode159.Text = "Тепло";
            treeNode160.Name = "Узел3";
            treeNode160.Text = "Вентиляция";
            treeNode161.Name = "Узел23";
            treeNode161.Text = "Тёплые";
            treeNode162.Name = "Узел4";
            treeNode162.Text = "Выходы";
            treeNode163.Name = "Узел5";
            treeNode163.Text = "Запасные";
            treeNode164.Name = "Узел22";
            treeNode164.Text = "Двери";
            treeNode165.Name = "Узел0";
            treeNode165.Text = "Сигнализация";
            treeNode166.Name = "Узел1";
            treeNode166.Text = "Дым";
            treeNode167.Name = "Узел2";
            treeNode167.Text = "Генератор";
            treeNode168.Name = "Узел3";
            treeNode168.Text = "Техника";
            this.treeView1.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode145,
            treeNode150,
            treeNode155,
            treeNode160,
            treeNode164,
            treeNode165,
            treeNode166,
            treeNode167,
            treeNode168});
            this.treeView1.Size = new System.Drawing.Size(302, 805);
            this.treeView1.TabIndex = 13;
            this.treeView1.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeView1_AfterSelect);
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.userList);
            this.tabPage4.Controls.Add(this.account);
            this.tabPage4.Controls.Add(this.workers);
            this.tabPage4.Location = new System.Drawing.Point(4, 38);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(1574, 811);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Уч. запись";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // userList
            // 
            this.userList.BackColor = System.Drawing.Color.Silver;
            this.userList.Controls.Add(this.groupBox23);
            this.userList.Controls.Add(this.groupBox15);
            this.userList.Controls.Add(this.groupBox16);
            this.userList.Controls.Add(this.groupBox17);
            this.userList.Controls.Add(this.groupBox18);
            this.userList.Controls.Add(this.groupBox19);
            this.userList.Controls.Add(this.groupBox20);
            this.userList.Controls.Add(this.groupBox21);
            this.userList.Controls.Add(this.groupBox22);
            this.userList.Controls.Add(this.groupBox14);
            this.userList.Dock = System.Windows.Forms.DockStyle.Right;
            this.userList.Location = new System.Drawing.Point(1058, 0);
            this.userList.Name = "userList";
            this.userList.Size = new System.Drawing.Size(516, 811);
            this.userList.TabIndex = 2;
            this.userList.Visible = false;
            // 
            // groupBox23
            // 
            this.groupBox23.Controls.Add(this.lastEntry_);
            this.groupBox23.Location = new System.Drawing.Point(3, 731);
            this.groupBox23.Name = "groupBox23";
            this.groupBox23.Size = new System.Drawing.Size(273, 75);
            this.groupBox23.TabIndex = 42;
            this.groupBox23.TabStop = false;
            this.groupBox23.Text = "Последний вход";
            // 
            // lastEntry_
            // 
            this.lastEntry_.AutoSize = true;
            this.lastEntry_.Location = new System.Drawing.Point(6, 30);
            this.lastEntry_.Name = "lastEntry_";
            this.lastEntry_.Size = new System.Drawing.Size(196, 29);
            this.lastEntry_.TabIndex = 13;
            this.lastEntry_.Text = "Последний вход";
            // 
            // groupBox15
            // 
            this.groupBox15.Controls.Add(this.givenName_);
            this.groupBox15.Controls.Add(this.surname_);
            this.groupBox15.Controls.Add(this.patronymic_);
            this.groupBox15.Location = new System.Drawing.Point(3, 3);
            this.groupBox15.Name = "groupBox15";
            this.groupBox15.Size = new System.Drawing.Size(273, 155);
            this.groupBox15.TabIndex = 41;
            this.groupBox15.TabStop = false;
            this.groupBox15.Text = "ФИО";
            // 
            // givenName_
            // 
            this.givenName_.AutoSize = true;
            this.givenName_.Location = new System.Drawing.Point(6, 30);
            this.givenName_.Name = "givenName_";
            this.givenName_.Size = new System.Drawing.Size(64, 29);
            this.givenName_.TabIndex = 27;
            this.givenName_.Text = "Имя";
            // 
            // surname_
            // 
            this.surname_.AutoSize = true;
            this.surname_.Location = new System.Drawing.Point(6, 59);
            this.surname_.Name = "surname_";
            this.surname_.Size = new System.Drawing.Size(124, 29);
            this.surname_.TabIndex = 14;
            this.surname_.Text = "Фамилия";
            // 
            // patronymic_
            // 
            this.patronymic_.AutoSize = true;
            this.patronymic_.Location = new System.Drawing.Point(6, 88);
            this.patronymic_.Name = "patronymic_";
            this.patronymic_.Size = new System.Drawing.Size(122, 29);
            this.patronymic_.TabIndex = 15;
            this.patronymic_.Text = "Отчество";
            // 
            // groupBox16
            // 
            this.groupBox16.Controls.Add(this.birthdate_);
            this.groupBox16.Location = new System.Drawing.Point(3, 245);
            this.groupBox16.Name = "groupBox16";
            this.groupBox16.Size = new System.Drawing.Size(273, 75);
            this.groupBox16.TabIndex = 38;
            this.groupBox16.TabStop = false;
            this.groupBox16.Text = "Дата рождения";
            // 
            // birthdate_
            // 
            this.birthdate_.AutoSize = true;
            this.birthdate_.Location = new System.Drawing.Point(6, 30);
            this.birthdate_.Name = "birthdate_";
            this.birthdate_.Size = new System.Drawing.Size(193, 29);
            this.birthdate_.TabIndex = 17;
            this.birthdate_.Text = "Дата рождения";
            // 
            // groupBox17
            // 
            this.groupBox17.Controls.Add(this.city_);
            this.groupBox17.Location = new System.Drawing.Point(3, 569);
            this.groupBox17.Name = "groupBox17";
            this.groupBox17.Size = new System.Drawing.Size(273, 75);
            this.groupBox17.TabIndex = 35;
            this.groupBox17.TabStop = false;
            this.groupBox17.Text = "Город";
            // 
            // city_
            // 
            this.city_.AutoSize = true;
            this.city_.Location = new System.Drawing.Point(6, 30);
            this.city_.Name = "city_";
            this.city_.Size = new System.Drawing.Size(84, 29);
            this.city_.TabIndex = 31;
            this.city_.Text = "Город";
            // 
            // groupBox18
            // 
            this.groupBox18.Controls.Add(this.email_);
            this.groupBox18.Location = new System.Drawing.Point(3, 488);
            this.groupBox18.Name = "groupBox18";
            this.groupBox18.Size = new System.Drawing.Size(273, 75);
            this.groupBox18.TabIndex = 40;
            this.groupBox18.TabStop = false;
            this.groupBox18.Text = "Эл. почта";
            // 
            // email_
            // 
            this.email_.AutoSize = true;
            this.email_.Location = new System.Drawing.Point(6, 30);
            this.email_.Name = "email_";
            this.email_.Size = new System.Drawing.Size(121, 29);
            this.email_.TabIndex = 30;
            this.email_.Text = "Эл. почта";
            // 
            // groupBox19
            // 
            this.groupBox19.Controls.Add(this.gender_);
            this.groupBox19.Location = new System.Drawing.Point(3, 164);
            this.groupBox19.Name = "groupBox19";
            this.groupBox19.Size = new System.Drawing.Size(273, 75);
            this.groupBox19.TabIndex = 34;
            this.groupBox19.TabStop = false;
            this.groupBox19.Text = "Пол";
            // 
            // gender_
            // 
            this.gender_.AutoSize = true;
            this.gender_.Location = new System.Drawing.Point(6, 30);
            this.gender_.Name = "gender_";
            this.gender_.Size = new System.Drawing.Size(57, 29);
            this.gender_.TabIndex = 16;
            this.gender_.Text = "Пол";
            // 
            // groupBox20
            // 
            this.groupBox20.Controls.Add(this.phone_);
            this.groupBox20.Location = new System.Drawing.Point(3, 407);
            this.groupBox20.Name = "groupBox20";
            this.groupBox20.Size = new System.Drawing.Size(273, 75);
            this.groupBox20.TabIndex = 36;
            this.groupBox20.TabStop = false;
            this.groupBox20.Text = "Номер телефона";
            // 
            // phone_
            // 
            this.phone_.AutoSize = true;
            this.phone_.Location = new System.Drawing.Point(6, 30);
            this.phone_.Name = "phone_";
            this.phone_.Size = new System.Drawing.Size(213, 29);
            this.phone_.TabIndex = 29;
            this.phone_.Text = "Номер телефона";
            // 
            // groupBox21
            // 
            this.groupBox21.Controls.Add(this.post_);
            this.groupBox21.Location = new System.Drawing.Point(3, 650);
            this.groupBox21.Name = "groupBox21";
            this.groupBox21.Size = new System.Drawing.Size(273, 75);
            this.groupBox21.TabIndex = 37;
            this.groupBox21.TabStop = false;
            this.groupBox21.Text = "Должность";
            // 
            // post_
            // 
            this.post_.AutoSize = true;
            this.post_.Location = new System.Drawing.Point(6, 30);
            this.post_.Name = "post_";
            this.post_.Size = new System.Drawing.Size(143, 29);
            this.post_.TabIndex = 28;
            this.post_.Text = "Должность";
            // 
            // groupBox22
            // 
            this.groupBox22.Controls.Add(this.age_);
            this.groupBox22.Location = new System.Drawing.Point(3, 326);
            this.groupBox22.Name = "groupBox22";
            this.groupBox22.Size = new System.Drawing.Size(273, 75);
            this.groupBox22.TabIndex = 39;
            this.groupBox22.TabStop = false;
            this.groupBox22.Text = "Возраст";
            // 
            // age_
            // 
            this.age_.AutoSize = true;
            this.age_.Location = new System.Drawing.Point(6, 30);
            this.age_.Name = "age_";
            this.age_.Size = new System.Drawing.Size(106, 29);
            this.age_.TabIndex = 22;
            this.age_.Text = "Возраст";
            // 
            // groupBox14
            // 
            this.groupBox14.Controls.Add(this.photo_);
            this.groupBox14.Location = new System.Drawing.Point(282, 3);
            this.groupBox14.Name = "groupBox14";
            this.groupBox14.Size = new System.Drawing.Size(225, 236);
            this.groupBox14.TabIndex = 33;
            this.groupBox14.TabStop = false;
            this.groupBox14.Text = "Фото";
            // 
            // photo_
            // 
            this.photo_.Location = new System.Drawing.Point(6, 30);
            this.photo_.Name = "photo_";
            this.photo_.Size = new System.Drawing.Size(200, 200);
            this.photo_.TabIndex = 32;
            this.photo_.TabStop = false;
            // 
            // account
            // 
            this.account.BackColor = System.Drawing.Color.Silver;
            this.account.Controls.Add(this.quit);
            this.account.Controls.Add(this.textOFF);
            this.account.Controls.Add(this.groupBox1);
            this.account.Controls.Add(this.groupBox13);
            this.account.Controls.Add(this.groupBox5);
            this.account.Controls.Add(this.save);
            this.account.Controls.Add(this.texnON);
            this.account.Controls.Add(this.groupBox12);
            this.account.Controls.Add(this.groupBox11);
            this.account.Controls.Add(this.groupBox3);
            this.account.Controls.Add(this.groupBox9);
            this.account.Controls.Add(this.groupBox7);
            this.account.Controls.Add(this.groupBox10);
            this.account.Dock = System.Windows.Forms.DockStyle.Left;
            this.account.Location = new System.Drawing.Point(0, 0);
            this.account.Name = "account";
            this.account.Size = new System.Drawing.Size(531, 811);
            this.account.TabIndex = 0;
            // 
            // textOFF
            // 
            this.textOFF.Location = new System.Drawing.Point(15, 772);
            this.textOFF.Name = "textOFF";
            this.textOFF.Size = new System.Drawing.Size(273, 36);
            this.textOFF.TabIndex = 29;
            this.textOFF.Text = "Редактировать ВЫКЛ";
            this.textOFF.UseVisualStyleBackColor = true;
            this.textOFF.Click += new System.EventHandler(this.textOFF_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.givenName);
            this.groupBox1.Controls.Add(this.surname);
            this.groupBox1.Controls.Add(this.patronymic);
            this.groupBox1.Location = new System.Drawing.Point(15, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(273, 155);
            this.groupBox1.TabIndex = 28;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "ФИО";
            // 
            // givenName
            // 
            this.givenName.Enabled = false;
            this.givenName.HideSelection = false;
            this.givenName.Location = new System.Drawing.Point(6, 33);
            this.givenName.Name = "givenName";
            this.givenName.Size = new System.Drawing.Size(261, 34);
            this.givenName.TabIndex = 14;
            // 
            // surname
            // 
            this.surname.Enabled = false;
            this.surname.Location = new System.Drawing.Point(6, 73);
            this.surname.Name = "surname";
            this.surname.Size = new System.Drawing.Size(261, 34);
            this.surname.TabIndex = 15;
            // 
            // patronymic
            // 
            this.patronymic.Enabled = false;
            this.patronymic.Location = new System.Drawing.Point(6, 113);
            this.patronymic.Name = "patronymic";
            this.patronymic.Size = new System.Drawing.Size(261, 34);
            this.patronymic.TabIndex = 16;
            // 
            // groupBox13
            // 
            this.groupBox13.Controls.Add(this.photo);
            this.groupBox13.Location = new System.Drawing.Point(294, 3);
            this.groupBox13.Name = "groupBox13";
            this.groupBox13.Size = new System.Drawing.Size(225, 236);
            this.groupBox13.TabIndex = 4;
            this.groupBox13.TabStop = false;
            this.groupBox13.Text = "Фото";
            // 
            // photo
            // 
            this.photo.Enabled = false;
            this.photo.Location = new System.Drawing.Point(6, 28);
            this.photo.Name = "photo";
            this.photo.Size = new System.Drawing.Size(200, 200);
            this.photo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.photo.TabIndex = 30;
            this.photo.TabStop = false;
            this.photo.Click += new System.EventHandler(this.photo_Click);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.birthdate);
            this.groupBox5.Location = new System.Drawing.Point(15, 245);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(273, 75);
            this.groupBox5.TabIndex = 18;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Дата рождения";
            // 
            // birthdate
            // 
            this.birthdate.Enabled = false;
            this.birthdate.Location = new System.Drawing.Point(7, 33);
            this.birthdate.Name = "birthdate";
            this.birthdate.Size = new System.Drawing.Size(260, 34);
            this.birthdate.TabIndex = 31;
            // 
            // save
            // 
            this.save.Location = new System.Drawing.Point(294, 731);
            this.save.Name = "save";
            this.save.Size = new System.Drawing.Size(145, 36);
            this.save.TabIndex = 13;
            this.save.Text = "Сохранить";
            this.save.UseVisualStyleBackColor = true;
            this.save.Click += new System.EventHandler(this.save_Click);
            // 
            // texnON
            // 
            this.texnON.Location = new System.Drawing.Point(15, 731);
            this.texnON.Name = "texnON";
            this.texnON.Size = new System.Drawing.Size(273, 36);
            this.texnON.TabIndex = 26;
            this.texnON.Text = "Редактировать ВКЛ";
            this.texnON.UseVisualStyleBackColor = true;
            this.texnON.Click += new System.EventHandler(this.texnON_Click);
            // 
            // groupBox12
            // 
            this.groupBox12.Controls.Add(this.city);
            this.groupBox12.Location = new System.Drawing.Point(15, 569);
            this.groupBox12.Name = "groupBox12";
            this.groupBox12.Size = new System.Drawing.Size(273, 75);
            this.groupBox12.TabIndex = 4;
            this.groupBox12.TabStop = false;
            this.groupBox12.Text = "Город";
            // 
            // city
            // 
            this.city.Enabled = false;
            this.city.Location = new System.Drawing.Point(6, 33);
            this.city.Name = "city";
            this.city.ReadOnly = true;
            this.city.Size = new System.Drawing.Size(261, 34);
            this.city.TabIndex = 30;
            this.city.Text = "Города";
            // 
            // groupBox11
            // 
            this.groupBox11.Controls.Add(this.email);
            this.groupBox11.Location = new System.Drawing.Point(15, 488);
            this.groupBox11.Name = "groupBox11";
            this.groupBox11.Size = new System.Drawing.Size(273, 75);
            this.groupBox11.TabIndex = 20;
            this.groupBox11.TabStop = false;
            this.groupBox11.Text = "Эл. почта";
            // 
            // email
            // 
            this.email.Enabled = false;
            this.email.Location = new System.Drawing.Point(6, 33);
            this.email.Name = "email";
            this.email.Size = new System.Drawing.Size(261, 34);
            this.email.TabIndex = 22;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.gender);
            this.groupBox3.Location = new System.Drawing.Point(15, 164);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(273, 75);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Пол";
            // 
            // gender
            // 
            this.gender.Enabled = false;
            this.gender.Location = new System.Drawing.Point(6, 33);
            this.gender.Name = "gender";
            this.gender.Size = new System.Drawing.Size(261, 34);
            this.gender.TabIndex = 17;
            // 
            // groupBox9
            // 
            this.groupBox9.Controls.Add(this.phone);
            this.groupBox9.Location = new System.Drawing.Point(15, 407);
            this.groupBox9.Name = "groupBox9";
            this.groupBox9.Size = new System.Drawing.Size(273, 75);
            this.groupBox9.TabIndex = 4;
            this.groupBox9.TabStop = false;
            this.groupBox9.Text = "Номер телефона";
            // 
            // phone
            // 
            this.phone.Enabled = false;
            this.phone.Location = new System.Drawing.Point(6, 33);
            this.phone.Name = "phone";
            this.phone.Size = new System.Drawing.Size(261, 34);
            this.phone.TabIndex = 21;
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.post);
            this.groupBox7.Location = new System.Drawing.Point(15, 650);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(273, 75);
            this.groupBox7.TabIndex = 4;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "Должность";
            // 
            // post
            // 
            this.post.Enabled = false;
            this.post.Location = new System.Drawing.Point(6, 33);
            this.post.Name = "post";
            this.post.Size = new System.Drawing.Size(261, 34);
            this.post.TabIndex = 20;
            // 
            // groupBox10
            // 
            this.groupBox10.Controls.Add(this.age);
            this.groupBox10.Location = new System.Drawing.Point(15, 326);
            this.groupBox10.Name = "groupBox10";
            this.groupBox10.Size = new System.Drawing.Size(273, 75);
            this.groupBox10.TabIndex = 19;
            this.groupBox10.TabStop = false;
            this.groupBox10.Text = "Возраст";
            // 
            // age
            // 
            this.age.Enabled = false;
            this.age.Location = new System.Drawing.Point(6, 33);
            this.age.Name = "age";
            this.age.Size = new System.Drawing.Size(261, 34);
            this.age.TabIndex = 19;
            // 
            // workers
            // 
            this.workers.FormattingEnabled = true;
            this.workers.ItemHeight = 29;
            this.workers.Location = new System.Drawing.Point(537, 16);
            this.workers.Name = "workers";
            this.workers.Size = new System.Drawing.Size(515, 207);
            this.workers.TabIndex = 1;
            this.workers.SelectedIndexChanged += new System.EventHandler(this.workers_SelectedIndexChanged);
            // 
            // database1DataSet
            // 
            this.database1DataSet.DataSetName = "Database1DataSet";
            this.database1DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tableColdBindingSource
            // 
            this.tableColdBindingSource.DataMember = "tableCold";
            this.tableColdBindingSource.DataSource = this.database1DataSet;
            // 
            // tableColdTableAdapter
            // 
            this.tableColdTableAdapter.ClearBeforeFill = true;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // quit
            // 
            this.quit.Location = new System.Drawing.Point(294, 772);
            this.quit.Name = "quit";
            this.quit.Size = new System.Drawing.Size(145, 36);
            this.quit.TabIndex = 3;
            this.quit.Text = "Выйти";
            this.quit.UseVisualStyleBackColor = true;
            this.quit.Click += new System.EventHandler(this.quit_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(70, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 29);
            this.label1.TabIndex = 1;
            this.label1.Text = "label1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(70, 117);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 29);
            this.label2.TabIndex = 2;
            this.label2.Text = "label2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(70, 163);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 29);
            this.label3.TabIndex = 3;
            this.label3.Text = "label3";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(70, 212);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 29);
            this.label4.TabIndex = 4;
            this.label4.Text = "label4";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(70, 261);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 29);
            this.label5.TabIndex = 5;
            this.label5.Text = "label5";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(70, 310);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(79, 29);
            this.label6.TabIndex = 6;
            this.label6.Text = "label6";
            // 
            // Climate
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1582, 853);
            this.Controls.Add(this.tabControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(1600, 900);
            this.Name = "Climate";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Aurora";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.splitContainer5.Panel1.ResumeLayout(false);
            this.splitContainer5.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer5)).EndInit();
            this.splitContainer5.ResumeLayout(false);
            this.panelWarning.ResumeLayout(false);
            this.panelWarning.PerformLayout();
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.splitContainer4.Panel1.ResumeLayout(false);
            this.splitContainer4.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer4)).EndInit();
            this.splitContainer4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.weather5.ResumeLayout(false);
            this.weather5.PerformLayout();
            this.groupBox8.ResumeLayout(false);
            this.groupBox8.PerformLayout();
            this.weather4.ResumeLayout(false);
            this.weather4.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.weather3.ResumeLayout(false);
            this.weather3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.weather2.ResumeLayout(false);
            this.weather2.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.weather1.ResumeLayout(false);
            this.weather1.PerformLayout();
            this.wind_.ResumeLayout(false);
            this.wind_.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tech.ResumeLayout(false);
            this.tech.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.plan)).EndInit();
            this.tabPage4.ResumeLayout(false);
            this.userList.ResumeLayout(false);
            this.groupBox23.ResumeLayout(false);
            this.groupBox23.PerformLayout();
            this.groupBox15.ResumeLayout(false);
            this.groupBox15.PerformLayout();
            this.groupBox16.ResumeLayout(false);
            this.groupBox16.PerformLayout();
            this.groupBox17.ResumeLayout(false);
            this.groupBox17.PerformLayout();
            this.groupBox18.ResumeLayout(false);
            this.groupBox18.PerformLayout();
            this.groupBox19.ResumeLayout(false);
            this.groupBox19.PerformLayout();
            this.groupBox20.ResumeLayout(false);
            this.groupBox20.PerformLayout();
            this.groupBox21.ResumeLayout(false);
            this.groupBox21.PerformLayout();
            this.groupBox22.ResumeLayout(false);
            this.groupBox22.PerformLayout();
            this.groupBox14.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.photo_)).EndInit();
            this.account.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox13.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.photo)).EndInit();
            this.groupBox5.ResumeLayout(false);
            this.groupBox12.ResumeLayout(false);
            this.groupBox11.ResumeLayout(false);
            this.groupBox11.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox9.ResumeLayout(false);
            this.groupBox9.PerformLayout();
            this.groupBox7.ResumeLayout(false);
            this.groupBox7.PerformLayout();
            this.groupBox10.ResumeLayout(false);
            this.groupBox10.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableColdBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private LiveCharts.WinForms.CartesianChart chartMoisture;
        private LiveCharts.WinForms.CartesianChart chartTemp;
        private System.Windows.Forms.TabPage tabPage2;
        private GMap.NET.WindowsForms.GMapControl gMapControl1;
        private System.Windows.Forms.ListBox SMPcity;
        private System.Windows.Forms.Button buttonCold;
        private System.Windows.Forms.Panel panelWarning;
        private System.Windows.Forms.Label normMoist;
        private System.Windows.Forms.Label Warning2;
        private System.Windows.Forms.Label Warning1;
        private System.Windows.Forms.Label normTemp;
        private System.Windows.Forms.Label warning;
        private System.Windows.Forms.Button buttonWarm;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.SplitContainer splitContainer4;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private Database1DataSet database1DataSet;
        private System.Windows.Forms.BindingSource tableColdBindingSource;
        private Database1DataSetTableAdapters.tableColdTableAdapter tableColdTableAdapter;
        private System.Windows.Forms.Button buttonExcel;
        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.Label time;
        private System.Windows.Forms.GroupBox weather5;
        private System.Windows.Forms.Label pres4;
        private System.Windows.Forms.GroupBox groupBox8;
        private System.Windows.Forms.Label deg_4;
        private System.Windows.Forms.Label speed_4;
        private System.Windows.Forms.Label hum4;
        private System.Windows.Forms.Label temp_4;
        private System.Windows.Forms.Label weatherDescription4;
        private System.Windows.Forms.Label weatherMain4;
        private System.Windows.Forms.Panel image_4;
        private System.Windows.Forms.GroupBox weather4;
        private System.Windows.Forms.Label pres3;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Label deg_3;
        private System.Windows.Forms.Label speed_3;
        private System.Windows.Forms.Label hum3;
        private System.Windows.Forms.Label temp_3;
        private System.Windows.Forms.Label weatherDescription3;
        private System.Windows.Forms.Label weatherMain3;
        private System.Windows.Forms.Panel image_3;
        private System.Windows.Forms.GroupBox weather3;
        private System.Windows.Forms.Label pres2;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label deg_2;
        private System.Windows.Forms.Label speed_2;
        private System.Windows.Forms.Label hum2;
        private System.Windows.Forms.Label temp_2;
        private System.Windows.Forms.Label weatherDescription2;
        private System.Windows.Forms.Label weatherMain2;
        private System.Windows.Forms.Panel image_2;
        private System.Windows.Forms.GroupBox weather2;
        private System.Windows.Forms.Label pres1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label deg_1;
        private System.Windows.Forms.Label speed_1;
        private System.Windows.Forms.Label hum1;
        private System.Windows.Forms.Label temp_1;
        private System.Windows.Forms.Label weatherDescription1;
        private System.Windows.Forms.Label weatherMain1;
        private System.Windows.Forms.Panel image_1;
        private System.Windows.Forms.GroupBox weather1;
        private System.Windows.Forms.Label pres;
        private System.Windows.Forms.GroupBox wind_;
        private System.Windows.Forms.Label deg_;
        private System.Windows.Forms.Label speed_;
        private System.Windows.Forms.Label hum;
        private System.Windows.Forms.Label temp_;
        private System.Windows.Forms.Label weatherDescription;
        private System.Windows.Forms.Label weatherMain;
        private System.Windows.Forms.Panel image_;
        private System.Windows.Forms.Label time1;
        private System.Windows.Forms.Label time4;
        private System.Windows.Forms.Label time3;
        private System.Windows.Forms.Label time2;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.SplitContainer splitContainer5;
        private System.Windows.Forms.MonthCalendar monthCalendar;
        private System.Windows.Forms.PictureBox plan;
        private System.Windows.Forms.Label WarningMoist;
        private System.Windows.Forms.Label WarningTemp;
        private System.Windows.Forms.Button Min;
        private System.Windows.Forms.Button Max;
        private System.Windows.Forms.Panel tech;
        private System.Windows.Forms.Label to;
        private System.Windows.Forms.Panel account;
        private System.Windows.Forms.ListBox workers;
        private System.Windows.Forms.Label lastEntry_;
        private System.Windows.Forms.Panel userList;
        private System.Windows.Forms.TextBox givenName;
        private System.Windows.Forms.Button save;
        private System.Windows.Forms.TextBox email;
        private System.Windows.Forms.TextBox phone;
        private System.Windows.Forms.TextBox age;
        private System.Windows.Forms.TextBox gender;
        private System.Windows.Forms.TextBox patronymic;
        private System.Windows.Forms.TextBox surname;
        private System.Windows.Forms.TextBox post;
        private System.Windows.Forms.Label givenName_;
        private System.Windows.Forms.Button texnON;
        private System.Windows.Forms.Label birthdate_;
        private System.Windows.Forms.Label gender_;
        private System.Windows.Forms.Label patronymic_;
        private System.Windows.Forms.Label surname_;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button textOFF;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox10;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.GroupBox groupBox9;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.GroupBox groupBox12;
        private System.Windows.Forms.GroupBox groupBox13;
        private System.Windows.Forms.GroupBox groupBox11;
        private System.Windows.Forms.DateTimePicker birthdate;
        private System.Windows.Forms.PictureBox photo;
        private System.Windows.Forms.DomainUpDown city;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Label city_;
        private System.Windows.Forms.Label email_;
        private System.Windows.Forms.Label phone_;
        private System.Windows.Forms.Label post_;
        private System.Windows.Forms.Label age_;
        private System.Windows.Forms.PictureBox photo_;
        private System.Windows.Forms.GroupBox groupBox23;
        private System.Windows.Forms.GroupBox groupBox15;
        private System.Windows.Forms.GroupBox groupBox16;
        private System.Windows.Forms.GroupBox groupBox17;
        private System.Windows.Forms.GroupBox groupBox18;
        private System.Windows.Forms.GroupBox groupBox19;
        private System.Windows.Forms.GroupBox groupBox20;
        private System.Windows.Forms.GroupBox groupBox21;
        private System.Windows.Forms.GroupBox groupBox22;
        private System.Windows.Forms.GroupBox groupBox14;
        private System.Windows.Forms.Button quit;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}

