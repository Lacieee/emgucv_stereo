namespace disparity_gui_2
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.pSettings = new System.Windows.Forms.Panel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.label20 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lVminDisparity = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tBminDisparity = new System.Windows.Forms.TrackBar();
            this.tBspecleRange = new System.Windows.Forms.TrackBar();
            this.tBspecleWindowSize = new System.Windows.Forms.TrackBar();
            this.tBuniquenessRatio = new System.Windows.Forms.TrackBar();
            this.tBpreFilterCap = new System.Windows.Forms.TrackBar();
            this.tBdisp12MaxDiff = new System.Windows.Forms.TrackBar();
            this.tBP2 = new System.Windows.Forms.TrackBar();
            this.tBP1 = new System.Windows.Forms.TrackBar();
            this.tBblockSize = new System.Windows.Forms.TrackBar();
            this.tBnumDisparities = new System.Windows.Forms.TrackBar();
            this.lVspecleRange = new System.Windows.Forms.Label();
            this.lVspecleWindowSize = new System.Windows.Forms.Label();
            this.lVuniquenessRatio = new System.Windows.Forms.Label();
            this.lVpreFilterCap = new System.Windows.Forms.Label();
            this.lVdisp12MaxDiff = new System.Windows.Forms.Label();
            this.lVP2 = new System.Windows.Forms.Label();
            this.lVP1 = new System.Windows.Forms.Label();
            this.lVblockSize = new System.Windows.Forms.Label();
            this.lVnumDisparites = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pImages = new System.Windows.Forms.Panel();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.lLog = new System.Windows.Forms.Label();
            this.iBleft = new Emgu.CV.UI.ImageBox();
            this.iBright = new Emgu.CV.UI.ImageBox();
            this.iBdisparity = new Emgu.CV.UI.ImageBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.rBSBGM = new System.Windows.Forms.RadioButton();
            this.rBHH = new System.Windows.Forms.RadioButton();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fájlToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.újBalOldaliKépToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.újJobbOldaliKépToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tableLayoutPanel1.SuspendLayout();
            this.pSettings.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tBminDisparity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBspecleRange)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBspecleWindowSize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBuniquenessRatio)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBpreFilterCap)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBdisp12MaxDiff)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBP2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBP1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBblockSize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBnumDisparities)).BeginInit();
            this.pImages.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iBleft)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iBright)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iBdisparity)).BeginInit();
            this.tableLayoutPanel4.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.pSettings, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.pImages, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 28);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 586F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1110, 558);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // pSettings
            // 
            this.pSettings.Controls.Add(this.tableLayoutPanel2);
            this.pSettings.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pSettings.Location = new System.Drawing.Point(3, 3);
            this.pSettings.Name = "pSettings";
            this.pSettings.Size = new System.Drawing.Size(549, 552);
            this.pSettings.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 3;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.tableLayoutPanel2.Controls.Add(this.label9, 0, 10);
            this.tableLayoutPanel2.Controls.Add(this.label7, 0, 10);
            this.tableLayoutPanel2.Controls.Add(this.label20, 0, 9);
            this.tableLayoutPanel2.Controls.Add(this.label18, 0, 8);
            this.tableLayoutPanel2.Controls.Add(this.label16, 0, 7);
            this.tableLayoutPanel2.Controls.Add(this.label14, 0, 6);
            this.tableLayoutPanel2.Controls.Add(this.label12, 0, 5);
            this.tableLayoutPanel2.Controls.Add(this.label10, 0, 4);
            this.tableLayoutPanel2.Controls.Add(this.label8, 0, 3);
            this.tableLayoutPanel2.Controls.Add(this.label6, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.lVminDisparity, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.tBminDisparity, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.tBspecleRange, 2, 9);
            this.tableLayoutPanel2.Controls.Add(this.tBspecleWindowSize, 2, 8);
            this.tableLayoutPanel2.Controls.Add(this.tBuniquenessRatio, 2, 7);
            this.tableLayoutPanel2.Controls.Add(this.tBpreFilterCap, 2, 6);
            this.tableLayoutPanel2.Controls.Add(this.tBdisp12MaxDiff, 2, 5);
            this.tableLayoutPanel2.Controls.Add(this.tBP2, 2, 4);
            this.tableLayoutPanel2.Controls.Add(this.tBP1, 2, 3);
            this.tableLayoutPanel2.Controls.Add(this.tBblockSize, 2, 2);
            this.tableLayoutPanel2.Controls.Add(this.tBnumDisparities, 2, 1);
            this.tableLayoutPanel2.Controls.Add(this.lVspecleRange, 1, 9);
            this.tableLayoutPanel2.Controls.Add(this.lVspecleWindowSize, 1, 8);
            this.tableLayoutPanel2.Controls.Add(this.lVuniquenessRatio, 1, 7);
            this.tableLayoutPanel2.Controls.Add(this.lVpreFilterCap, 1, 6);
            this.tableLayoutPanel2.Controls.Add(this.lVdisp12MaxDiff, 1, 5);
            this.tableLayoutPanel2.Controls.Add(this.lVP2, 1, 4);
            this.tableLayoutPanel2.Controls.Add(this.lVP1, 1, 3);
            this.tableLayoutPanel2.Controls.Add(this.lVblockSize, 1, 2);
            this.tableLayoutPanel2.Controls.Add(this.lVnumDisparites, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.label2, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel4, 2, 10);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 11;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.090909F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.090909F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.090909F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.090909F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.090909F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.090909F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.090909F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.090909F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.090909F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.090909F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.090909F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(549, 552);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // label20
            // 
            this.label20.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label20.Location = new System.Drawing.Point(3, 450);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(103, 50);
            this.label20.TabIndex = 42;
            this.label20.Text = "specleRange";
            this.label20.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label18
            // 
            this.label18.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label18.Location = new System.Drawing.Point(3, 400);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(103, 50);
            this.label18.TabIndex = 41;
            this.label18.Text = "specleWindowSize";
            this.label18.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label16
            // 
            this.label16.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label16.Location = new System.Drawing.Point(3, 350);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(103, 50);
            this.label16.TabIndex = 40;
            this.label16.Text = "uniquenessRatio";
            this.label16.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label14
            // 
            this.label14.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label14.Location = new System.Drawing.Point(3, 300);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(103, 50);
            this.label14.TabIndex = 39;
            this.label14.Text = "preFilterCap";
            this.label14.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label12
            // 
            this.label12.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label12.Location = new System.Drawing.Point(3, 250);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(103, 50);
            this.label12.TabIndex = 38;
            this.label12.Text = "disp12MaxDiff";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label10
            // 
            this.label10.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label10.Location = new System.Drawing.Point(3, 200);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(103, 50);
            this.label10.TabIndex = 37;
            this.label10.Text = "P2";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label8
            // 
            this.label8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label8.Location = new System.Drawing.Point(3, 150);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(103, 50);
            this.label8.TabIndex = 36;
            this.label8.Text = "P1";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label6.Location = new System.Drawing.Point(3, 100);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(103, 50);
            this.label6.TabIndex = 35;
            this.label6.Text = "blockSize";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lVminDisparity
            // 
            this.lVminDisparity.AutoSize = true;
            this.lVminDisparity.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lVminDisparity.Location = new System.Drawing.Point(112, 0);
            this.lVminDisparity.Name = "lVminDisparity";
            this.lVminDisparity.Size = new System.Drawing.Size(48, 50);
            this.lVminDisparity.TabIndex = 34;
            this.lVminDisparity.Text = "0";
            this.lVminDisparity.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 50);
            this.label1.TabIndex = 32;
            this.label1.Text = "minDisparity";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tBminDisparity
            // 
            this.tBminDisparity.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tBminDisparity.Location = new System.Drawing.Point(166, 3);
            this.tBminDisparity.Maximum = 20;
            this.tBminDisparity.Name = "tBminDisparity";
            this.tBminDisparity.Size = new System.Drawing.Size(380, 44);
            this.tBminDisparity.TabIndex = 1;
            this.tBminDisparity.Scroll += new System.EventHandler(this.tBminDisparity_Scroll);
            this.tBminDisparity.ValueChanged += new System.EventHandler(this.Any_ValueChanged);
            // 
            // tBspecleRange
            // 
            this.tBspecleRange.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tBspecleRange.Location = new System.Drawing.Point(166, 453);
            this.tBspecleRange.Maximum = 100;
            this.tBspecleRange.Name = "tBspecleRange";
            this.tBspecleRange.Size = new System.Drawing.Size(380, 44);
            this.tBspecleRange.TabIndex = 10;
            this.tBspecleRange.Scroll += new System.EventHandler(this.tBspecleRange_Scroll);
            this.tBspecleRange.ValueChanged += new System.EventHandler(this.Any_ValueChanged);
            // 
            // tBspecleWindowSize
            // 
            this.tBspecleWindowSize.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tBspecleWindowSize.Location = new System.Drawing.Point(166, 403);
            this.tBspecleWindowSize.Maximum = 100;
            this.tBspecleWindowSize.Name = "tBspecleWindowSize";
            this.tBspecleWindowSize.Size = new System.Drawing.Size(380, 44);
            this.tBspecleWindowSize.TabIndex = 9;
            this.tBspecleWindowSize.Scroll += new System.EventHandler(this.tBspecleWindowSize_Scroll);
            this.tBspecleWindowSize.ValueChanged += new System.EventHandler(this.Any_ValueChanged);
            // 
            // tBuniquenessRatio
            // 
            this.tBuniquenessRatio.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tBuniquenessRatio.Location = new System.Drawing.Point(166, 353);
            this.tBuniquenessRatio.Maximum = 100;
            this.tBuniquenessRatio.Name = "tBuniquenessRatio";
            this.tBuniquenessRatio.Size = new System.Drawing.Size(380, 44);
            this.tBuniquenessRatio.TabIndex = 8;
            this.tBuniquenessRatio.Scroll += new System.EventHandler(this.tBuniquenessRatio_Scroll);
            this.tBuniquenessRatio.ValueChanged += new System.EventHandler(this.Any_ValueChanged);
            // 
            // tBpreFilterCap
            // 
            this.tBpreFilterCap.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tBpreFilterCap.Location = new System.Drawing.Point(166, 303);
            this.tBpreFilterCap.Maximum = 100;
            this.tBpreFilterCap.Name = "tBpreFilterCap";
            this.tBpreFilterCap.Size = new System.Drawing.Size(380, 44);
            this.tBpreFilterCap.TabIndex = 7;
            this.tBpreFilterCap.Scroll += new System.EventHandler(this.tBpreFilterCap_Scroll);
            this.tBpreFilterCap.ValueChanged += new System.EventHandler(this.Any_ValueChanged);
            // 
            // tBdisp12MaxDiff
            // 
            this.tBdisp12MaxDiff.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tBdisp12MaxDiff.Location = new System.Drawing.Point(166, 253);
            this.tBdisp12MaxDiff.Maximum = 100;
            this.tBdisp12MaxDiff.Name = "tBdisp12MaxDiff";
            this.tBdisp12MaxDiff.Size = new System.Drawing.Size(380, 44);
            this.tBdisp12MaxDiff.TabIndex = 6;
            this.tBdisp12MaxDiff.Scroll += new System.EventHandler(this.tBdisp12MaxDiff_Scroll);
            this.tBdisp12MaxDiff.ValueChanged += new System.EventHandler(this.Any_ValueChanged);
            // 
            // tBP2
            // 
            this.tBP2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tBP2.Location = new System.Drawing.Point(166, 203);
            this.tBP2.Maximum = 100;
            this.tBP2.Name = "tBP2";
            this.tBP2.Size = new System.Drawing.Size(380, 44);
            this.tBP2.TabIndex = 5;
            this.tBP2.Scroll += new System.EventHandler(this.tBP2_Scroll);
            this.tBP2.ValueChanged += new System.EventHandler(this.Any_ValueChanged);
            // 
            // tBP1
            // 
            this.tBP1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tBP1.Location = new System.Drawing.Point(166, 153);
            this.tBP1.Maximum = 100;
            this.tBP1.Name = "tBP1";
            this.tBP1.Size = new System.Drawing.Size(380, 44);
            this.tBP1.TabIndex = 4;
            this.tBP1.Scroll += new System.EventHandler(this.tBP1_Scroll);
            this.tBP1.ValueChanged += new System.EventHandler(this.Any_ValueChanged);
            // 
            // tBblockSize
            // 
            this.tBblockSize.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tBblockSize.Location = new System.Drawing.Point(166, 103);
            this.tBblockSize.Maximum = 100;
            this.tBblockSize.Minimum = 1;
            this.tBblockSize.Name = "tBblockSize";
            this.tBblockSize.Size = new System.Drawing.Size(380, 44);
            this.tBblockSize.TabIndex = 3;
            this.tBblockSize.TickFrequency = 2;
            this.tBblockSize.Value = 2;
            this.tBblockSize.Scroll += new System.EventHandler(this.tBblockSize_Scroll);
            this.tBblockSize.ValueChanged += new System.EventHandler(this.Any_ValueChanged);
            // 
            // tBnumDisparities
            // 
            this.tBnumDisparities.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tBnumDisparities.Location = new System.Drawing.Point(166, 53);
            this.tBnumDisparities.Maximum = 64;
            this.tBnumDisparities.Name = "tBnumDisparities";
            this.tBnumDisparities.Size = new System.Drawing.Size(380, 44);
            this.tBnumDisparities.TabIndex = 2;
            this.tBnumDisparities.Scroll += new System.EventHandler(this.tBnumDisparities_Scroll);
            this.tBnumDisparities.ValueChanged += new System.EventHandler(this.Any_ValueChanged);
            // 
            // lVspecleRange
            // 
            this.lVspecleRange.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lVspecleRange.Location = new System.Drawing.Point(112, 450);
            this.lVspecleRange.Name = "lVspecleRange";
            this.lVspecleRange.Size = new System.Drawing.Size(48, 50);
            this.lVspecleRange.TabIndex = 18;
            this.lVspecleRange.Text = "0";
            this.lVspecleRange.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lVspecleWindowSize
            // 
            this.lVspecleWindowSize.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lVspecleWindowSize.Location = new System.Drawing.Point(112, 400);
            this.lVspecleWindowSize.Name = "lVspecleWindowSize";
            this.lVspecleWindowSize.Size = new System.Drawing.Size(48, 50);
            this.lVspecleWindowSize.TabIndex = 16;
            this.lVspecleWindowSize.Text = "0";
            this.lVspecleWindowSize.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lVuniquenessRatio
            // 
            this.lVuniquenessRatio.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lVuniquenessRatio.Location = new System.Drawing.Point(112, 350);
            this.lVuniquenessRatio.Name = "lVuniquenessRatio";
            this.lVuniquenessRatio.Size = new System.Drawing.Size(48, 50);
            this.lVuniquenessRatio.TabIndex = 14;
            this.lVuniquenessRatio.Text = "0";
            this.lVuniquenessRatio.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lVpreFilterCap
            // 
            this.lVpreFilterCap.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lVpreFilterCap.Location = new System.Drawing.Point(112, 300);
            this.lVpreFilterCap.Name = "lVpreFilterCap";
            this.lVpreFilterCap.Size = new System.Drawing.Size(48, 50);
            this.lVpreFilterCap.TabIndex = 12;
            this.lVpreFilterCap.Text = "0";
            this.lVpreFilterCap.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lVdisp12MaxDiff
            // 
            this.lVdisp12MaxDiff.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lVdisp12MaxDiff.Location = new System.Drawing.Point(112, 250);
            this.lVdisp12MaxDiff.Name = "lVdisp12MaxDiff";
            this.lVdisp12MaxDiff.Size = new System.Drawing.Size(48, 50);
            this.lVdisp12MaxDiff.TabIndex = 10;
            this.lVdisp12MaxDiff.Text = "0";
            this.lVdisp12MaxDiff.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lVP2
            // 
            this.lVP2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lVP2.Location = new System.Drawing.Point(112, 200);
            this.lVP2.Name = "lVP2";
            this.lVP2.Size = new System.Drawing.Size(48, 50);
            this.lVP2.TabIndex = 8;
            this.lVP2.Text = "0";
            this.lVP2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lVP1
            // 
            this.lVP1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lVP1.Location = new System.Drawing.Point(112, 150);
            this.lVP1.Name = "lVP1";
            this.lVP1.Size = new System.Drawing.Size(48, 50);
            this.lVP1.TabIndex = 6;
            this.lVP1.Text = "0";
            this.lVP1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lVblockSize
            // 
            this.lVblockSize.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lVblockSize.Location = new System.Drawing.Point(112, 100);
            this.lVblockSize.Name = "lVblockSize";
            this.lVblockSize.Size = new System.Drawing.Size(48, 50);
            this.lVblockSize.TabIndex = 4;
            this.lVblockSize.Text = "3";
            this.lVblockSize.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lVnumDisparites
            // 
            this.lVnumDisparites.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lVnumDisparites.Location = new System.Drawing.Point(112, 50);
            this.lVnumDisparites.Name = "lVnumDisparites";
            this.lVnumDisparites.Size = new System.Drawing.Size(48, 50);
            this.lVnumDisparites.TabIndex = 2;
            this.lVnumDisparites.Text = "0";
            this.lVnumDisparites.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Location = new System.Drawing.Point(3, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 50);
            this.label2.TabIndex = 33;
            this.label2.Text = "numDisparities";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pImages
            // 
            this.pImages.Controls.Add(this.tableLayoutPanel3);
            this.pImages.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pImages.Location = new System.Drawing.Point(558, 3);
            this.pImages.Name = "pImages";
            this.pImages.Size = new System.Drawing.Size(549, 552);
            this.pImages.TabIndex = 1;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Controls.Add(this.iBright, 1, 1);
            this.tableLayoutPanel3.Controls.Add(this.label4, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.label3, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.panel1, 0, 3);
            this.tableLayoutPanel3.Controls.Add(this.panel2, 0, 2);
            this.tableLayoutPanel3.Controls.Add(this.btnSave, 1, 4);
            this.tableLayoutPanel3.Controls.Add(this.lLog, 0, 4);
            this.tableLayoutPanel3.Controls.Add(this.iBleft, 0, 1);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 5;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 65F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(549, 552);
            this.tableLayoutPanel3.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label4.Location = new System.Drawing.Point(277, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(269, 27);
            this.label4.TabIndex = 1;
            this.label4.Text = "Jobb oldali kép";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Location = new System.Drawing.Point(3, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(268, 27);
            this.label3.TabIndex = 0;
            this.label3.Text = "Bal oldali kép";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.tableLayoutPanel3.SetColumnSpan(this.panel1, 2);
            this.panel1.Controls.Add(this.iBdisparity);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 167);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(543, 352);
            this.panel1.TabIndex = 4;
            // 
            // panel2
            // 
            this.tableLayoutPanel3.SetColumnSpan(this.panel2, 2);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(3, 140);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(543, 21);
            this.panel2.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label5.Location = new System.Drawing.Point(0, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(543, 21);
            this.label5.TabIndex = 0;
            this.label5.Text = "Mélység kép";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnSave
            // 
            this.btnSave.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnSave.Location = new System.Drawing.Point(277, 525);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(269, 24);
            this.btnSave.TabIndex = 6;
            this.btnSave.Text = "Kép mentése";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // lLog
            // 
            this.lLog.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lLog.Location = new System.Drawing.Point(3, 522);
            this.lLog.Name = "lLog";
            this.lLog.Size = new System.Drawing.Size(268, 30);
            this.lLog.TabIndex = 7;
            this.lLog.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // iBleft
            // 
            this.iBleft.Dock = System.Windows.Forms.DockStyle.Fill;
            this.iBleft.Location = new System.Drawing.Point(3, 30);
            this.iBleft.Name = "iBleft";
            this.iBleft.Size = new System.Drawing.Size(268, 104);
            this.iBleft.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.iBleft.TabIndex = 2;
            this.iBleft.TabStop = false;
            // 
            // iBright
            // 
            this.iBright.Dock = System.Windows.Forms.DockStyle.Fill;
            this.iBright.Location = new System.Drawing.Point(277, 30);
            this.iBright.Name = "iBright";
            this.iBright.Size = new System.Drawing.Size(269, 104);
            this.iBright.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.iBright.TabIndex = 8;
            this.iBright.TabStop = false;
            // 
            // iBdisparity
            // 
            this.iBdisparity.Dock = System.Windows.Forms.DockStyle.Fill;
            this.iBdisparity.Location = new System.Drawing.Point(0, 0);
            this.iBdisparity.Name = "iBdisparity";
            this.iBdisparity.Size = new System.Drawing.Size(543, 352);
            this.iBdisparity.TabIndex = 2;
            this.iBdisparity.TabStop = false;
            // 
            // label7
            // 
            this.label7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label7.Location = new System.Drawing.Point(3, 500);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(103, 52);
            this.label7.TabIndex = 43;
            this.label7.Text = "Stereo Mode";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label9
            // 
            this.label9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label9.Location = new System.Drawing.Point(112, 500);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(48, 52);
            this.label9.TabIndex = 44;
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 2;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.Controls.Add(this.rBHH, 1, 0);
            this.tableLayoutPanel4.Controls.Add(this.rBSBGM, 0, 0);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(166, 503);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 1;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(380, 46);
            this.tableLayoutPanel4.TabIndex = 45;
            // 
            // rBSBGM
            // 
            this.rBSBGM.Checked = true;
            this.rBSBGM.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rBSBGM.Location = new System.Drawing.Point(3, 3);
            this.rBSBGM.Name = "rBSBGM";
            this.rBSBGM.Size = new System.Drawing.Size(184, 40);
            this.rBSBGM.TabIndex = 0;
            this.rBSBGM.TabStop = true;
            this.rBSBGM.Text = "SGBM";
            this.rBSBGM.UseVisualStyleBackColor = true;
            this.rBSBGM.CheckedChanged += new System.EventHandler(this.Any_ValueChanged);
            // 
            // rBHH
            // 
            this.rBHH.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rBHH.Location = new System.Drawing.Point(193, 3);
            this.rBHH.Name = "rBHH";
            this.rBHH.Size = new System.Drawing.Size(184, 40);
            this.rBHH.TabIndex = 1;
            this.rBHH.Text = "HH";
            this.rBHH.UseVisualStyleBackColor = true;
            this.rBHH.CheckedChanged += new System.EventHandler(this.Any_ValueChanged);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fájlToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1110, 28);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fájlToolStripMenuItem
            // 
            this.fájlToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.újBalOldaliKépToolStripMenuItem,
            this.újJobbOldaliKépToolStripMenuItem});
            this.fájlToolStripMenuItem.Name = "fájlToolStripMenuItem";
            this.fájlToolStripMenuItem.Size = new System.Drawing.Size(45, 24);
            this.fájlToolStripMenuItem.Text = "Fájl";
            // 
            // újBalOldaliKépToolStripMenuItem
            // 
            this.újBalOldaliKépToolStripMenuItem.Name = "újBalOldaliKépToolStripMenuItem";
            this.újBalOldaliKépToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.újBalOldaliKépToolStripMenuItem.Text = "Új bal oldali kép";
            this.újBalOldaliKépToolStripMenuItem.Click += new System.EventHandler(this.újBalOldaliKépToolStripMenuItem_Click);
            // 
            // újJobbOldaliKépToolStripMenuItem
            // 
            this.újJobbOldaliKépToolStripMenuItem.Name = "újJobbOldaliKépToolStripMenuItem";
            this.újJobbOldaliKépToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.újJobbOldaliKépToolStripMenuItem.Text = "Új jobb oldali kép";
            this.újJobbOldaliKépToolStripMenuItem.Click += new System.EventHandler(this.újJobbOldaliKépToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1110, 586);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Gadugi", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Mélység kép";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.tableLayoutPanel1.ResumeLayout(false);
            this.pSettings.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tBminDisparity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBspecleRange)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBspecleWindowSize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBuniquenessRatio)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBpreFilterCap)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBdisp12MaxDiff)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBP2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBP1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBblockSize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBnumDisparities)).EndInit();
            this.pImages.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.iBleft)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iBright)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iBdisparity)).EndInit();
            this.tableLayoutPanel4.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel pSettings;
        private System.Windows.Forms.Panel pImages;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label lVspecleRange;
        private System.Windows.Forms.Label lVspecleWindowSize;
        private System.Windows.Forms.Label lVuniquenessRatio;
        private System.Windows.Forms.Label lVpreFilterCap;
        private System.Windows.Forms.Label lVdisp12MaxDiff;
        private System.Windows.Forms.Label lVP2;
        private System.Windows.Forms.TrackBar tBspecleRange;
        private System.Windows.Forms.TrackBar tBspecleWindowSize;
        private System.Windows.Forms.TrackBar tBuniquenessRatio;
        private System.Windows.Forms.TrackBar tBpreFilterCap;
        private System.Windows.Forms.TrackBar tBdisp12MaxDiff;
        private System.Windows.Forms.TrackBar tBP2;
        private System.Windows.Forms.TrackBar tBP1;
        private System.Windows.Forms.TrackBar tBblockSize;
        private System.Windows.Forms.TrackBar tBnumDisparities;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lVminDisparity;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TrackBar tBminDisparity;
        private System.Windows.Forms.Label lVP1;
        private System.Windows.Forms.Label lVblockSize;
        private System.Windows.Forms.Label lVnumDisparites;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label lLog;
        private Emgu.CV.UI.ImageBox iBleft;
        private Emgu.CV.UI.ImageBox iBright;
        private Emgu.CV.UI.ImageBox iBdisparity;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.RadioButton rBSBGM;
        private System.Windows.Forms.RadioButton rBHH;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fájlToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem újBalOldaliKépToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem újJobbOldaliKépToolStripMenuItem;
    }
}

