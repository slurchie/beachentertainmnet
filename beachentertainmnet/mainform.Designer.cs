
namespace beachentertainmnet
{
    partial class mainform
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mainform));
            this.menu = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.splitContainer4 = new System.Windows.Forms.SplitContainer();
            this.splitContainerAttrMenu = new System.Windows.Forms.SplitContainer();
            this.listBoxAttractions = new System.Windows.Forms.ListBox();
            this.listBoxStatus = new System.Windows.Forms.ListBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.pictures1 = new beachentertainmnet.pictures();
            this.pictures2 = new beachentertainmnet.pictures();
            this.pictures3 = new beachentertainmnet.pictures();
            this.pictures4 = new beachentertainmnet.pictures();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.buttonBack = new System.Windows.Forms.Button();
            this.buttonNext = new System.Windows.Forms.Button();
            this.richTextBoxDate = new System.Windows.Forms.RichTextBox();
            this.listchildcalendar = new beachentertainmnet.listchild();
            this.attractionsdisplayinfo = new beachentertainmnet.displayinfo();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.splitContainer3 = new System.Windows.Forms.SplitContainer();
            this.listchildworkers = new beachentertainmnet.listchild();
            this.displayinfoworkers = new beachentertainmnet.displayinfo();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.richTextBoxStatistics = new System.Windows.Forms.RichTextBox();
            this.menu.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer4)).BeginInit();
            this.splitContainer4.Panel1.SuspendLayout();
            this.splitContainer4.Panel2.SuspendLayout();
            this.splitContainer4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerAttrMenu)).BeginInit();
            this.splitContainerAttrMenu.Panel1.SuspendLayout();
            this.splitContainerAttrMenu.Panel2.SuspendLayout();
            this.splitContainerAttrMenu.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictures1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictures2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictures3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictures4)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.attractionsdisplayinfo)).BeginInit();
            this.attractionsdisplayinfo.SuspendLayout();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).BeginInit();
            this.splitContainer3.Panel1.SuspendLayout();
            this.splitContainer3.Panel2.SuspendLayout();
            this.splitContainer3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.displayinfoworkers)).BeginInit();
            this.displayinfoworkers.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.SuspendLayout();
            // 
            // menu
            // 
            this.menu.Appearance = System.Windows.Forms.TabAppearance.Buttons;
            this.menu.Controls.Add(this.tabPage1);
            this.menu.Controls.Add(this.tabPage2);
            this.menu.Controls.Add(this.tabPage3);
            this.menu.Controls.Add(this.tabPage4);
            this.menu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.menu.Location = new System.Drawing.Point(0, 0);
            this.menu.Name = "menu";
            this.menu.SelectedIndex = 0;
            this.menu.Size = new System.Drawing.Size(800, 450);
            this.menu.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.PaleTurquoise;
            this.tabPage1.BackgroundImage = global::beachentertainmnet.Properties.Resources.tropical_beach_background_dstephens;
            this.tabPage1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tabPage1.Controls.Add(this.splitContainer4);
            this.tabPage1.Location = new System.Drawing.Point(4, 28);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(792, 418);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Аттракционы";
            // 
            // splitContainer4
            // 
            this.splitContainer4.BackColor = System.Drawing.Color.AntiqueWhite;
            this.splitContainer4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer4.Location = new System.Drawing.Point(3, 3);
            this.splitContainer4.Name = "splitContainer4";
            // 
            // splitContainer4.Panel1
            // 
            this.splitContainer4.Panel1.Controls.Add(this.splitContainerAttrMenu);
            // 
            // splitContainer4.Panel2
            // 
            this.splitContainer4.Panel2.BackColor = System.Drawing.Color.PapayaWhip;
            this.splitContainer4.Panel2.Controls.Add(this.tableLayoutPanel2);
            this.splitContainer4.Size = new System.Drawing.Size(786, 412);
            this.splitContainer4.SplitterDistance = 262;
            this.splitContainer4.TabIndex = 0;
            // 
            // splitContainerAttrMenu
            // 
            this.splitContainerAttrMenu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerAttrMenu.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainerAttrMenu.Font = new System.Drawing.Font("MS Reference Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.splitContainerAttrMenu.Location = new System.Drawing.Point(0, 0);
            this.splitContainerAttrMenu.Name = "splitContainerAttrMenu";
            this.splitContainerAttrMenu.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainerAttrMenu.Panel1
            // 
            this.splitContainerAttrMenu.Panel1.Controls.Add(this.listBoxAttractions);
            this.splitContainerAttrMenu.Panel1.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            // 
            // splitContainerAttrMenu.Panel2
            // 
            this.splitContainerAttrMenu.Panel2.BackColor = System.Drawing.Color.AntiqueWhite;
            this.splitContainerAttrMenu.Panel2.Controls.Add(this.listBoxStatus);
            this.splitContainerAttrMenu.Panel2MinSize = 50;
            this.splitContainerAttrMenu.Size = new System.Drawing.Size(262, 412);
            this.splitContainerAttrMenu.SplitterDistance = 200;
            this.splitContainerAttrMenu.TabIndex = 0;
            // 
            // listBoxAttractions
            // 
            this.listBoxAttractions.BackColor = System.Drawing.SystemColors.Info;
            this.listBoxAttractions.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBoxAttractions.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxAttractions.ForeColor = System.Drawing.Color.SaddleBrown;
            this.listBoxAttractions.FormattingEnabled = true;
            this.listBoxAttractions.ItemHeight = 26;
            this.listBoxAttractions.Items.AddRange(new object[] {
            "Все",
            "банан",
            "катамаран",
            "водная горка",
            "гидроцикл"});
            this.listBoxAttractions.Location = new System.Drawing.Point(0, 0);
            this.listBoxAttractions.Name = "listBoxAttractions";
            this.listBoxAttractions.Size = new System.Drawing.Size(262, 200);
            this.listBoxAttractions.TabIndex = 0;
            this.listBoxAttractions.SelectedIndexChanged += new System.EventHandler(this.listBox3_SelectedIndexChanged);
            // 
            // listBoxStatus
            // 
            this.listBoxStatus.BackColor = System.Drawing.SystemColors.Info;
            this.listBoxStatus.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBoxStatus.Font = new System.Drawing.Font("MS Reference Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.listBoxStatus.ForeColor = System.Drawing.Color.SaddleBrown;
            this.listBoxStatus.FormattingEnabled = true;
            this.listBoxStatus.ItemHeight = 23;
            this.listBoxStatus.Items.AddRange(new object[] {
            "Все",
            "Занят",
            "Свободен",
            "На ремонте",
            "Неизвестно"});
            this.listBoxStatus.Location = new System.Drawing.Point(0, 0);
            this.listBoxStatus.Name = "listBoxStatus";
            this.listBoxStatus.Size = new System.Drawing.Size(262, 208);
            this.listBoxStatus.TabIndex = 0;
            this.listBoxStatus.SelectedIndexChanged += new System.EventHandler(this.listBox4_SelectedIndexChanged);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.pictures1, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.pictures2, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.pictures3, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.pictures4, 1, 1);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(520, 412);
            this.tableLayoutPanel2.TabIndex = 2;
            // 
            // pictures1
            // 
            this.pictures1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictures1.Location = new System.Drawing.Point(3, 3);
            this.pictures1.Name = "pictures1";
            this.pictures1.Size = new System.Drawing.Size(254, 200);
            this.pictures1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictures1.TabIndex = 0;
            this.pictures1.TabStop = false;
            // 
            // pictures2
            // 
            this.pictures2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictures2.Location = new System.Drawing.Point(3, 209);
            this.pictures2.Name = "pictures2";
            this.pictures2.Size = new System.Drawing.Size(254, 200);
            this.pictures2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictures2.TabIndex = 1;
            this.pictures2.TabStop = false;
            // 
            // pictures3
            // 
            this.pictures3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictures3.Location = new System.Drawing.Point(263, 3);
            this.pictures3.Name = "pictures3";
            this.pictures3.Size = new System.Drawing.Size(254, 200);
            this.pictures3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictures3.TabIndex = 2;
            this.pictures3.TabStop = false;
            // 
            // pictures4
            // 
            this.pictures4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictures4.Location = new System.Drawing.Point(263, 209);
            this.pictures4.Name = "pictures4";
            this.pictures4.Size = new System.Drawing.Size(254, 200);
            this.pictures4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictures4.TabIndex = 3;
            this.pictures4.TabStop = false;
            // 
            // tabPage2
            // 
            this.tabPage2.BackgroundImage = global::beachentertainmnet.Properties.Resources.tropical_beach_background_dstephens;
            this.tabPage2.Controls.Add(this.splitContainer1);
            this.tabPage2.Location = new System.Drawing.Point(4, 28);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(792, 418);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Календарь";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // splitContainer1
            // 
            this.splitContainer1.BackColor = System.Drawing.Color.AntiqueWhite;
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(3, 3);
            this.splitContainer1.Margin = new System.Windows.Forms.Padding(0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.splitContainer2);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.attractionsdisplayinfo);
            this.splitContainer1.Size = new System.Drawing.Size(786, 412);
            this.splitContainer1.SplitterDistance = 262;
            this.splitContainer1.TabIndex = 0;
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Margin = new System.Windows.Forms.Padding(0);
            this.splitContainer2.Name = "splitContainer2";
            this.splitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.tableLayoutPanel1);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.listchildcalendar);
            this.splitContainer2.Size = new System.Drawing.Size(262, 412);
            this.splitContainer2.SplitterDistance = 87;
            this.splitContainer2.TabIndex = 0;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel1.Controls.Add(this.buttonBack, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.buttonNext, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.richTextBoxDate, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(262, 87);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // buttonBack
            // 
            this.buttonBack.BackColor = System.Drawing.Color.Bisque;
            this.buttonBack.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonBack.Font = new System.Drawing.Font("MS Reference Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonBack.Location = new System.Drawing.Point(3, 3);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(34, 81);
            this.buttonBack.TabIndex = 0;
            this.buttonBack.Text = "<";
            this.buttonBack.UseVisualStyleBackColor = false;
            this.buttonBack.Click += new System.EventHandler(this.buttonBack_Click);
            // 
            // buttonNext
            // 
            this.buttonNext.BackColor = System.Drawing.Color.Bisque;
            this.buttonNext.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonNext.Font = new System.Drawing.Font("MS Reference Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonNext.Location = new System.Drawing.Point(225, 3);
            this.buttonNext.Name = "buttonNext";
            this.buttonNext.Size = new System.Drawing.Size(34, 81);
            this.buttonNext.TabIndex = 1;
            this.buttonNext.Text = ">";
            this.buttonNext.UseVisualStyleBackColor = false;
            this.buttonNext.Click += new System.EventHandler(this.buttonNext_Click);
            // 
            // richTextBoxDate
            // 
            this.richTextBoxDate.BackColor = System.Drawing.SystemColors.Info;
            this.richTextBoxDate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richTextBoxDate.Font = new System.Drawing.Font("MS PGothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.richTextBoxDate.ForeColor = System.Drawing.Color.SaddleBrown;
            this.richTextBoxDate.Location = new System.Drawing.Point(43, 3);
            this.richTextBoxDate.Name = "richTextBoxDate";
            this.richTextBoxDate.ReadOnly = true;
            this.richTextBoxDate.Size = new System.Drawing.Size(176, 81);
            this.richTextBoxDate.TabIndex = 2;
            this.richTextBoxDate.Text = "";
            this.richTextBoxDate.TextChanged += new System.EventHandler(this.richTextBoxDate_TextChanged);
            // 
            // listchildcalendar
            // 
            this.listchildcalendar.BackColor = System.Drawing.Color.AntiqueWhite;
            this.listchildcalendar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listchildcalendar.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.listchildcalendar.ForeColor = System.Drawing.Color.SaddleBrown;
            this.listchildcalendar.FormattingEnabled = true;
            this.listchildcalendar.ItemHeight = 27;
            this.listchildcalendar.Location = new System.Drawing.Point(0, 0);
            this.listchildcalendar.Name = "listchildcalendar";
            this.listchildcalendar.Size = new System.Drawing.Size(262, 321);
            this.listchildcalendar.TabIndex = 0;
            this.listchildcalendar.SelectedIndexChanged += new System.EventHandler(this.listchildcalendar_SelectedIndexChanged);
            // 
            // attractionsdisplayinfo
            // 
            this.attractionsdisplayinfo.BackColor = System.Drawing.Color.NavajoWhite;
            this.attractionsdisplayinfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.attractionsdisplayinfo.ForeColor = System.Drawing.Color.SaddleBrown;
            this.attractionsdisplayinfo.Location = new System.Drawing.Point(0, 0);
            this.attractionsdisplayinfo.Name = "attractionsdisplayinfo";
            this.attractionsdisplayinfo.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // attractionsdisplayinfo.Panel1
            // 
            this.attractionsdisplayinfo.Panel1.BackColor = System.Drawing.Color.AntiqueWhite;
            // 
            // attractionsdisplayinfo.Panel2
            // 
            this.attractionsdisplayinfo.Panel2.BackColor = System.Drawing.Color.AntiqueWhite;
            this.attractionsdisplayinfo.Panel2.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.attractionsdisplayinfo.Size = new System.Drawing.Size(520, 412);
            this.attractionsdisplayinfo.SplitterDistance = 206;
            this.attractionsdisplayinfo.TabIndex = 0;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.splitContainer3);
            this.tabPage3.Location = new System.Drawing.Point(4, 28);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(792, 418);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Сотрудники";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // splitContainer3
            // 
            this.splitContainer3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer3.Location = new System.Drawing.Point(3, 3);
            this.splitContainer3.Name = "splitContainer3";
            // 
            // splitContainer3.Panel1
            // 
            this.splitContainer3.Panel1.Controls.Add(this.listchildworkers);
            // 
            // splitContainer3.Panel2
            // 
            this.splitContainer3.Panel2.Controls.Add(this.displayinfoworkers);
            this.splitContainer3.Size = new System.Drawing.Size(786, 412);
            this.splitContainer3.SplitterDistance = 262;
            this.splitContainer3.TabIndex = 0;
            // 
            // listchildworkers
            // 
            this.listchildworkers.BackColor = System.Drawing.Color.AntiqueWhite;
            this.listchildworkers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listchildworkers.Font = new System.Drawing.Font("MS Reference Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listchildworkers.ForeColor = System.Drawing.Color.SaddleBrown;
            this.listchildworkers.FormattingEnabled = true;
            this.listchildworkers.ItemHeight = 28;
            this.listchildworkers.Location = new System.Drawing.Point(0, 0);
            this.listchildworkers.Name = "listchildworkers";
            this.listchildworkers.Size = new System.Drawing.Size(262, 412);
            this.listchildworkers.TabIndex = 0;
            // 
            // displayinfoworkers
            // 
            this.displayinfoworkers.BackColor = System.Drawing.Color.LightBlue;
            this.displayinfoworkers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.displayinfoworkers.Location = new System.Drawing.Point(0, 0);
            this.displayinfoworkers.Name = "displayinfoworkers";
            this.displayinfoworkers.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // displayinfoworkers.Panel1
            // 
            this.displayinfoworkers.Panel1.BackColor = System.Drawing.Color.AntiqueWhite;
            // 
            // displayinfoworkers.Panel2
            // 
            this.displayinfoworkers.Panel2.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.displayinfoworkers.Size = new System.Drawing.Size(520, 412);
            this.displayinfoworkers.SplitterDistance = 206;
            this.displayinfoworkers.TabIndex = 0;
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.richTextBoxStatistics);
            this.tabPage4.Location = new System.Drawing.Point(4, 28);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(792, 418);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Статистика";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // richTextBoxStatistics
            // 
            this.richTextBoxStatistics.BackColor = System.Drawing.Color.AntiqueWhite;
            this.richTextBoxStatistics.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richTextBoxStatistics.Font = new System.Drawing.Font("MS Reference Sans Serif", 10.15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.richTextBoxStatistics.ForeColor = System.Drawing.Color.SaddleBrown;
            this.richTextBoxStatistics.Location = new System.Drawing.Point(3, 3);
            this.richTextBoxStatistics.Name = "richTextBoxStatistics";
            this.richTextBoxStatistics.ReadOnly = true;
            this.richTextBoxStatistics.Size = new System.Drawing.Size(786, 412);
            this.richTextBoxStatistics.TabIndex = 0;
            this.richTextBoxStatistics.Text = "Аттракцион: Рабочие дни * Цена = Прибыль";
            // 
            // mainform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menu);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "mainform";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.mainform_FormClosed);
            this.Load += new System.EventHandler(this.mainform_Load);
            this.menu.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.splitContainer4.Panel1.ResumeLayout(false);
            this.splitContainer4.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer4)).EndInit();
            this.splitContainer4.ResumeLayout(false);
            this.splitContainerAttrMenu.Panel1.ResumeLayout(false);
            this.splitContainerAttrMenu.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerAttrMenu)).EndInit();
            this.splitContainerAttrMenu.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictures1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictures2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictures3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictures4)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.attractionsdisplayinfo)).EndInit();
            this.attractionsdisplayinfo.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.splitContainer3.Panel1.ResumeLayout(false);
            this.splitContainer3.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).EndInit();
            this.splitContainer3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.displayinfoworkers)).EndInit();
            this.displayinfoworkers.ResumeLayout(false);
            this.tabPage4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl menu;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private displayinfo attractionsdisplayinfo;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button buttonBack;
        private System.Windows.Forms.Button buttonNext;
        private System.Windows.Forms.RichTextBox richTextBoxDate;
        private System.Windows.Forms.SplitContainer splitContainer3;
        private displayinfo displayinfoworkers;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.SplitContainer splitContainer4;
        private System.Windows.Forms.SplitContainer splitContainerAttrMenu;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private pictures pictures1;
        private pictures pictures2;
        private pictures pictures3;
        private pictures pictures4;
        private System.Windows.Forms.ListBox listBoxAttractions;
        private System.Windows.Forms.ListBox listBoxStatus;
        private listchild listchildcalendar;
        private listchild listchildworkers;
        private System.Windows.Forms.RichTextBox richTextBoxStatistics;
    }
}

