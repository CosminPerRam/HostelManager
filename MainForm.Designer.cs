namespace HotelMan
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            splitContainer1 = new SplitContainer();
            tableLayoutPanel1 = new TableLayoutPanel();
            hotelView = new TreeView();
            ratesList = new ListView();
            luxuryRate = new ColumnHeader();
            perNight = new ColumnHeader();
            currentOccupants = new ColumnHeader();
            tableLayoutPanel2 = new TableLayoutPanel();
            tableLayoutPanel3 = new TableLayoutPanel();
            ratesAdd = new Button();
            ratesRemove = new Button();
            tableLayoutPanel4 = new TableLayoutPanel();
            tableLayoutPanel5 = new TableLayoutPanel();
            occupantsAdd = new Button();
            occupantsRemove = new Button();
            tableLayoutPanel6 = new TableLayoutPanel();
            stats = new Label();
            exportStats = new Button();
            toolStrip1 = new ToolStrip();
            toolStripLoad = new ToolStripButton();
            toolStripSave = new ToolStripButton();
            toolStripClear = new ToolStripButton();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            tableLayoutPanel3.SuspendLayout();
            tableLayoutPanel4.SuspendLayout();
            tableLayoutPanel5.SuspendLayout();
            tableLayoutPanel6.SuspendLayout();
            toolStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // splitContainer1
            // 
            splitContainer1.Dock = DockStyle.Fill;
            splitContainer1.Location = new Point(0, 0);
            splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(tableLayoutPanel1);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(tableLayoutPanel2);
            splitContainer1.Panel2.Controls.Add(toolStrip1);
            splitContainer1.Size = new Size(465, 450);
            splitContainer1.SplitterDistance = 266;
            splitContainer1.TabIndex = 0;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(hotelView, 0, 0);
            tableLayoutPanel1.Controls.Add(ratesList, 0, 1);
            tableLayoutPanel1.Location = new Point(3, 3);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 74.0991F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 25.9009018F));
            tableLayoutPanel1.Size = new Size(260, 444);
            tableLayoutPanel1.TabIndex = 1;
            // 
            // hotelView
            // 
            hotelView.Dock = DockStyle.Fill;
            hotelView.Location = new Point(3, 3);
            hotelView.Name = "hotelView";
            hotelView.Size = new Size(254, 323);
            hotelView.TabIndex = 0;
            hotelView.AfterSelect += hotelView_AfterSelect;
            // 
            // ratesList
            // 
            ratesList.Activation = ItemActivation.OneClick;
            ratesList.AllowColumnReorder = true;
            ratesList.Columns.AddRange(new ColumnHeader[] { luxuryRate, perNight, currentOccupants });
            ratesList.Dock = DockStyle.Fill;
            ratesList.HotTracking = true;
            ratesList.HoverSelection = true;
            ratesList.Location = new Point(3, 332);
            ratesList.MultiSelect = false;
            ratesList.Name = "ratesList";
            ratesList.Size = new Size(254, 109);
            ratesList.TabIndex = 1;
            ratesList.UseCompatibleStateImageBehavior = false;
            ratesList.View = View.Details;
            ratesList.ItemSelectionChanged += ratesList_ItemSelectionChanged;
            // 
            // luxuryRate
            // 
            luxuryRate.Text = "Luxury";
            // 
            // perNight
            // 
            perNight.Text = "Price/Night";
            perNight.Width = 80;
            // 
            // currentOccupants
            // 
            currentOccupants.Text = "Current Occupants";
            currentOccupants.Width = 110;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 1;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.Controls.Add(tableLayoutPanel3, 0, 1);
            tableLayoutPanel2.Controls.Add(tableLayoutPanel4, 0, 0);
            tableLayoutPanel2.Location = new Point(3, 28);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 2;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 72.5536957F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 27.4463F));
            tableLayoutPanel2.Size = new Size(190, 419);
            tableLayoutPanel2.TabIndex = 1;
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.ColumnCount = 1;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel3.Controls.Add(ratesAdd, 0, 0);
            tableLayoutPanel3.Controls.Add(ratesRemove, 0, 1);
            tableLayoutPanel3.Location = new Point(3, 306);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 2;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel3.Size = new Size(184, 110);
            tableLayoutPanel3.TabIndex = 0;
            // 
            // ratesAdd
            // 
            ratesAdd.Location = new Point(3, 3);
            ratesAdd.Name = "ratesAdd";
            ratesAdd.Size = new Size(178, 49);
            ratesAdd.TabIndex = 0;
            ratesAdd.Text = "Add";
            ratesAdd.UseVisualStyleBackColor = true;
            ratesAdd.Click += ratesAdd_Click;
            // 
            // ratesRemove
            // 
            ratesRemove.Enabled = false;
            ratesRemove.Location = new Point(3, 58);
            ratesRemove.Name = "ratesRemove";
            ratesRemove.Size = new Size(178, 49);
            ratesRemove.TabIndex = 1;
            ratesRemove.Text = "Remove";
            ratesRemove.UseVisualStyleBackColor = true;
            ratesRemove.Click += ratesRemove_Click;
            // 
            // tableLayoutPanel4
            // 
            tableLayoutPanel4.ColumnCount = 1;
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel4.Controls.Add(tableLayoutPanel5, 0, 0);
            tableLayoutPanel4.Controls.Add(tableLayoutPanel6, 0, 1);
            tableLayoutPanel4.Location = new Point(3, 3);
            tableLayoutPanel4.Name = "tableLayoutPanel4";
            tableLayoutPanel4.RowCount = 2;
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel4.Size = new Size(184, 297);
            tableLayoutPanel4.TabIndex = 1;
            // 
            // tableLayoutPanel5
            // 
            tableLayoutPanel5.ColumnCount = 1;
            tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel5.Controls.Add(occupantsAdd, 0, 0);
            tableLayoutPanel5.Controls.Add(occupantsRemove, 0, 1);
            tableLayoutPanel5.Location = new Point(3, 3);
            tableLayoutPanel5.Name = "tableLayoutPanel5";
            tableLayoutPanel5.RowCount = 2;
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel5.Size = new Size(178, 142);
            tableLayoutPanel5.TabIndex = 0;
            // 
            // occupantsAdd
            // 
            occupantsAdd.Location = new Point(3, 3);
            occupantsAdd.Name = "occupantsAdd";
            occupantsAdd.Size = new Size(172, 65);
            occupantsAdd.TabIndex = 0;
            occupantsAdd.Text = "Add";
            occupantsAdd.UseVisualStyleBackColor = true;
            occupantsAdd.Click += occupantsAdd_Click;
            // 
            // occupantsRemove
            // 
            occupantsRemove.Enabled = false;
            occupantsRemove.Location = new Point(3, 74);
            occupantsRemove.Name = "occupantsRemove";
            occupantsRemove.Size = new Size(172, 65);
            occupantsRemove.TabIndex = 1;
            occupantsRemove.Text = "Remove";
            occupantsRemove.UseVisualStyleBackColor = true;
            occupantsRemove.Click += occupantsRemove_Click;
            // 
            // tableLayoutPanel6
            // 
            tableLayoutPanel6.ColumnCount = 1;
            tableLayoutPanel6.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel6.Controls.Add(stats, 0, 0);
            tableLayoutPanel6.Controls.Add(exportStats, 0, 1);
            tableLayoutPanel6.Location = new Point(3, 151);
            tableLayoutPanel6.Name = "tableLayoutPanel6";
            tableLayoutPanel6.RowCount = 2;
            tableLayoutPanel6.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel6.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel6.Size = new Size(178, 143);
            tableLayoutPanel6.TabIndex = 1;
            // 
            // stats
            // 
            stats.Anchor = AnchorStyles.None;
            stats.AutoSize = true;
            stats.Location = new Point(62, 28);
            stats.Name = "stats";
            stats.Size = new Size(53, 15);
            stats.TabIndex = 2;
            stats.Text = "< stats >";
            stats.TextAlign = ContentAlignment.TopCenter;
            // 
            // exportStats
            // 
            exportStats.Enabled = false;
            exportStats.Location = new Point(3, 74);
            exportStats.Name = "exportStats";
            exportStats.Size = new Size(172, 66);
            exportStats.TabIndex = 3;
            exportStats.Text = "Export stats";
            exportStats.UseVisualStyleBackColor = true;
            exportStats.Click += exportStats_Click;
            // 
            // toolStrip1
            // 
            toolStrip1.Items.AddRange(new ToolStripItem[] { toolStripLoad, toolStripSave, toolStripClear });
            toolStrip1.Location = new Point(0, 0);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(195, 25);
            toolStrip1.TabIndex = 0;
            toolStrip1.Text = "toolStrip1";
            // 
            // toolStripLoad
            // 
            toolStripLoad.DisplayStyle = ToolStripItemDisplayStyle.Text;
            toolStripLoad.Image = (Image)resources.GetObject("toolStripLoad.Image");
            toolStripLoad.ImageTransparentColor = Color.Magenta;
            toolStripLoad.Name = "toolStripLoad";
            toolStripLoad.Size = new Size(37, 22);
            toolStripLoad.Text = "Load";
            toolStripLoad.Click += toolStripLoad_Click;
            // 
            // toolStripSave
            // 
            toolStripSave.DisplayStyle = ToolStripItemDisplayStyle.Text;
            toolStripSave.Image = (Image)resources.GetObject("toolStripSave.Image");
            toolStripSave.ImageTransparentColor = Color.Magenta;
            toolStripSave.Name = "toolStripSave";
            toolStripSave.Size = new Size(35, 22);
            toolStripSave.Text = "Save";
            toolStripSave.Click += toolStripSave_Click;
            // 
            // toolStripClear
            // 
            toolStripClear.DisplayStyle = ToolStripItemDisplayStyle.Text;
            toolStripClear.Image = (Image)resources.GetObject("toolStripClear.Image");
            toolStripClear.ImageTransparentColor = Color.Magenta;
            toolStripClear.Name = "toolStripClear";
            toolStripClear.Size = new Size(38, 22);
            toolStripClear.Text = "Clear";
            toolStripClear.Click += toolStripClear_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(465, 450);
            Controls.Add(splitContainer1);
            Name = "MainForm";
            Text = "HotelMan";
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel2.ResumeLayout(false);
            splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel3.ResumeLayout(false);
            tableLayoutPanel4.ResumeLayout(false);
            tableLayoutPanel5.ResumeLayout(false);
            tableLayoutPanel6.ResumeLayout(false);
            tableLayoutPanel6.PerformLayout();
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private SplitContainer splitContainer1;
        private TreeView hotelView;
        private TableLayoutPanel tableLayoutPanel1;
        private ListView ratesList;
        private ColumnHeader perNight;
        private ColumnHeader luxuryRate;
        private ColumnHeader currentOccupants;
        private ToolStrip toolStrip1;
        private ToolStripButton toolStripLoad;
        private ToolStripButton toolStripSave;
        private ToolStripButton toolStripClear;
        private TableLayoutPanel tableLayoutPanel2;
        private TableLayoutPanel tableLayoutPanel3;
        private Button ratesAdd;
        private Button ratesRemove;
        private TableLayoutPanel tableLayoutPanel4;
        private TableLayoutPanel tableLayoutPanel5;
        private Button occupantsAdd;
        private Button occupantsRemove;
        private TableLayoutPanel tableLayoutPanel6;
        private Label stats;
        private Button exportStats;
    }
}
