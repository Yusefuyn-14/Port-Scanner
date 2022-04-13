namespace YK_47_Port_Scanner
{
    partial class homeForm
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
            this.pnlSettings = new System.Windows.Forms.Panel();
            this.btnVictimInport = new System.Windows.Forms.Button();
            this.btnVictimExport = new System.Windows.Forms.Button();
            this.btnSelectedVictimRemove = new System.Windows.Forms.Button();
            this.listVictims = new System.Windows.Forms.ListBox();
            this.btnVictimAdd = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtVictim = new System.Windows.Forms.TextBox();
            this.panel6 = new System.Windows.Forms.Panel();
            this.radioList = new System.Windows.Forms.RadioButton();
            this.radioInterval = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.radioUdp = new System.Windows.Forms.RadioButton();
            this.radioTcp = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.pnlInterval = new System.Windows.Forms.Panel();
            this.numericIntervalMax = new System.Windows.Forms.NumericUpDown();
            this.numericIntervalMin = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.pnlList = new System.Windows.Forms.Panel();
            this.numericPortAdd = new System.Windows.Forms.NumericUpDown();
            this.btnPortInport = new System.Windows.Forms.Button();
            this.btnPortExport = new System.Windows.Forms.Button();
            this.btnSelectedPortRemove = new System.Windows.Forms.Button();
            this.listPort = new System.Windows.Forms.ListBox();
            this.btnPortAdd = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.btnStartStop = new System.Windows.Forms.Button();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.pnlResult = new System.Windows.Forms.Panel();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnResultExport = new System.Windows.Forms.Button();
            this.pnlSettings.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel5.SuspendLayout();
            this.pnlInterval.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericIntervalMax)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericIntervalMin)).BeginInit();
            this.pnlList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericPortAdd)).BeginInit();
            this.pnlResult.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlSettings
            // 
            this.pnlSettings.Controls.Add(this.btnVictimInport);
            this.pnlSettings.Controls.Add(this.btnVictimExport);
            this.pnlSettings.Controls.Add(this.btnSelectedVictimRemove);
            this.pnlSettings.Controls.Add(this.listVictims);
            this.pnlSettings.Controls.Add(this.btnVictimAdd);
            this.pnlSettings.Controls.Add(this.label3);
            this.pnlSettings.Controls.Add(this.txtVictim);
            this.pnlSettings.Controls.Add(this.panel6);
            this.pnlSettings.Controls.Add(this.label2);
            this.pnlSettings.Controls.Add(this.panel5);
            this.pnlSettings.Controls.Add(this.label1);
            this.pnlSettings.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlSettings.Location = new System.Drawing.Point(0, 0);
            this.pnlSettings.Name = "pnlSettings";
            this.pnlSettings.Size = new System.Drawing.Size(675, 133);
            this.pnlSettings.TabIndex = 0;
            // 
            // btnVictimInport
            // 
            this.btnVictimInport.Location = new System.Drawing.Point(552, 81);
            this.btnVictimInport.Name = "btnVictimInport";
            this.btnVictimInport.Size = new System.Drawing.Size(111, 23);
            this.btnVictimInport.TabIndex = 10;
            this.btnVictimInport.Text = "İçe Aktar";
            this.btnVictimInport.UseVisualStyleBackColor = true;
            this.btnVictimInport.Click += new System.EventHandler(this.btnVictimInport_Click);
            // 
            // btnVictimExport
            // 
            this.btnVictimExport.Location = new System.Drawing.Point(552, 106);
            this.btnVictimExport.Name = "btnVictimExport";
            this.btnVictimExport.Size = new System.Drawing.Size(111, 23);
            this.btnVictimExport.TabIndex = 9;
            this.btnVictimExport.Text = "Dışa Aktar";
            this.btnVictimExport.UseVisualStyleBackColor = true;
            this.btnVictimExport.Click += new System.EventHandler(this.btnVictimExport_Click);
            // 
            // btnSelectedVictimRemove
            // 
            this.btnSelectedVictimRemove.Location = new System.Drawing.Point(552, 34);
            this.btnSelectedVictimRemove.Name = "btnSelectedVictimRemove";
            this.btnSelectedVictimRemove.Size = new System.Drawing.Size(111, 23);
            this.btnSelectedVictimRemove.TabIndex = 8;
            this.btnSelectedVictimRemove.Text = "Seçileni Sil";
            this.btnSelectedVictimRemove.UseVisualStyleBackColor = true;
            this.btnSelectedVictimRemove.Click += new System.EventHandler(this.btnSelectedVictimRemove_Click);
            // 
            // listVictims
            // 
            this.listVictims.FormattingEnabled = true;
            this.listVictims.Location = new System.Drawing.Point(387, 34);
            this.listVictims.Name = "listVictims";
            this.listVictims.Size = new System.Drawing.Size(159, 95);
            this.listVictims.TabIndex = 7;
            // 
            // btnVictimAdd
            // 
            this.btnVictimAdd.Location = new System.Drawing.Point(552, 9);
            this.btnVictimAdd.Name = "btnVictimAdd";
            this.btnVictimAdd.Size = new System.Drawing.Size(111, 23);
            this.btnVictimAdd.TabIndex = 6;
            this.btnVictimAdd.Text = "Ekle";
            this.btnVictimAdd.UseVisualStyleBackColor = true;
            this.btnVictimAdd.Click += new System.EventHandler(this.btnVictimAdd_Click);
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(281, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 23);
            this.label3.TabIndex = 5;
            this.label3.Text = "Hedef :";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtVictim
            // 
            this.txtVictim.Location = new System.Drawing.Point(387, 11);
            this.txtVictim.Name = "txtVictim";
            this.txtVictim.Size = new System.Drawing.Size(159, 20);
            this.txtVictim.TabIndex = 4;
            this.txtVictim.Text = "192.168.1.1";
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.radioList);
            this.panel6.Controls.Add(this.radioInterval);
            this.panel6.Location = new System.Drawing.Point(118, 34);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(157, 23);
            this.panel6.TabIndex = 3;
            // 
            // radioList
            // 
            this.radioList.AutoSize = true;
            this.radioList.Location = new System.Drawing.Point(94, 3);
            this.radioList.Name = "radioList";
            this.radioList.Size = new System.Drawing.Size(47, 17);
            this.radioList.TabIndex = 3;
            this.radioList.Text = "Liste";
            this.radioList.UseVisualStyleBackColor = true;
            // 
            // radioInterval
            // 
            this.radioInterval.AutoSize = true;
            this.radioInterval.Checked = true;
            this.radioInterval.Location = new System.Drawing.Point(3, 3);
            this.radioInterval.Name = "radioInterval";
            this.radioInterval.Size = new System.Drawing.Size(51, 17);
            this.radioInterval.TabIndex = 2;
            this.radioInterval.TabStop = true;
            this.radioInterval.Text = "Aralık";
            this.radioInterval.UseVisualStyleBackColor = true;
            this.radioInterval.CheckedChanged += new System.EventHandler(this.radioInterval_CheckedChanged);
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(12, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 23);
            this.label2.TabIndex = 2;
            this.label2.Text = "Taranacak Port :";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.radioUdp);
            this.panel5.Controls.Add(this.radioTcp);
            this.panel5.Location = new System.Drawing.Point(118, 9);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(157, 23);
            this.panel5.TabIndex = 1;
            // 
            // radioUdp
            // 
            this.radioUdp.AutoSize = true;
            this.radioUdp.Enabled = false;
            this.radioUdp.Location = new System.Drawing.Point(94, 3);
            this.radioUdp.Name = "radioUdp";
            this.radioUdp.Size = new System.Drawing.Size(48, 17);
            this.radioUdp.TabIndex = 3;
            this.radioUdp.Text = "UDP";
            this.radioUdp.UseVisualStyleBackColor = true;
            // 
            // radioTcp
            // 
            this.radioTcp.AutoSize = true;
            this.radioTcp.Checked = true;
            this.radioTcp.Location = new System.Drawing.Point(3, 3);
            this.radioTcp.Name = "radioTcp";
            this.radioTcp.Size = new System.Drawing.Size(46, 17);
            this.radioTcp.TabIndex = 2;
            this.radioTcp.TabStop = true;
            this.radioTcp.Text = "TCP";
            this.radioTcp.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Port Tipi :";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // pnlInterval
            // 
            this.pnlInterval.Controls.Add(this.numericIntervalMax);
            this.pnlInterval.Controls.Add(this.numericIntervalMin);
            this.pnlInterval.Controls.Add(this.label4);
            this.pnlInterval.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlInterval.Location = new System.Drawing.Point(0, 133);
            this.pnlInterval.Name = "pnlInterval";
            this.pnlInterval.Size = new System.Drawing.Size(675, 27);
            this.pnlInterval.TabIndex = 1;
            // 
            // numericIntervalMax
            // 
            this.numericIntervalMax.Location = new System.Drawing.Point(240, 4);
            this.numericIntervalMax.Maximum = new decimal(new int[] {
            65535,
            0,
            0,
            0});
            this.numericIntervalMax.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.numericIntervalMax.Name = "numericIntervalMax";
            this.numericIntervalMax.Size = new System.Drawing.Size(99, 20);
            this.numericIntervalMax.TabIndex = 2;
            this.numericIntervalMax.Value = new decimal(new int[] {
            65535,
            0,
            0,
            0});
            // 
            // numericIntervalMin
            // 
            this.numericIntervalMin.Location = new System.Drawing.Point(121, 4);
            this.numericIntervalMin.Maximum = new decimal(new int[] {
            65534,
            0,
            0,
            0});
            this.numericIntervalMin.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericIntervalMin.Name = "numericIntervalMin";
            this.numericIntervalMin.Size = new System.Drawing.Size(99, 20);
            this.numericIntervalMin.TabIndex = 0;
            this.numericIntervalMin.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(12, 1);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 23);
            this.label4.TabIndex = 1;
            this.label4.Text = "Aralık :";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // pnlList
            // 
            this.pnlList.Controls.Add(this.numericPortAdd);
            this.pnlList.Controls.Add(this.btnPortInport);
            this.pnlList.Controls.Add(this.btnPortExport);
            this.pnlList.Controls.Add(this.btnSelectedPortRemove);
            this.pnlList.Controls.Add(this.listPort);
            this.pnlList.Controls.Add(this.btnPortAdd);
            this.pnlList.Controls.Add(this.label5);
            this.pnlList.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlList.Location = new System.Drawing.Point(0, 160);
            this.pnlList.Name = "pnlList";
            this.pnlList.Size = new System.Drawing.Size(675, 131);
            this.pnlList.TabIndex = 2;
            // 
            // numericPortAdd
            // 
            this.numericPortAdd.Location = new System.Drawing.Point(117, 5);
            this.numericPortAdd.Maximum = new decimal(new int[] {
            65535,
            0,
            0,
            0});
            this.numericPortAdd.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericPortAdd.Name = "numericPortAdd";
            this.numericPortAdd.Size = new System.Drawing.Size(159, 20);
            this.numericPortAdd.TabIndex = 17;
            this.numericPortAdd.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // btnPortInport
            // 
            this.btnPortInport.Location = new System.Drawing.Point(282, 74);
            this.btnPortInport.Name = "btnPortInport";
            this.btnPortInport.Size = new System.Drawing.Size(111, 23);
            this.btnPortInport.TabIndex = 16;
            this.btnPortInport.Text = "İçe Aktar";
            this.btnPortInport.UseVisualStyleBackColor = true;
            this.btnPortInport.Click += new System.EventHandler(this.btnPortInport_Click);
            // 
            // btnPortExport
            // 
            this.btnPortExport.Location = new System.Drawing.Point(282, 99);
            this.btnPortExport.Name = "btnPortExport";
            this.btnPortExport.Size = new System.Drawing.Size(111, 23);
            this.btnPortExport.TabIndex = 15;
            this.btnPortExport.Text = "Dışa Aktar";
            this.btnPortExport.UseVisualStyleBackColor = true;
            this.btnPortExport.Click += new System.EventHandler(this.btnPortExport_Click);
            // 
            // btnSelectedPortRemove
            // 
            this.btnSelectedPortRemove.Location = new System.Drawing.Point(282, 27);
            this.btnSelectedPortRemove.Name = "btnSelectedPortRemove";
            this.btnSelectedPortRemove.Size = new System.Drawing.Size(111, 23);
            this.btnSelectedPortRemove.TabIndex = 14;
            this.btnSelectedPortRemove.Text = "Seçileni Sil";
            this.btnSelectedPortRemove.UseVisualStyleBackColor = true;
            this.btnSelectedPortRemove.Click += new System.EventHandler(this.btnSelectedPortRemove_Click);
            // 
            // listPort
            // 
            this.listPort.FormattingEnabled = true;
            this.listPort.Location = new System.Drawing.Point(117, 27);
            this.listPort.Name = "listPort";
            this.listPort.Size = new System.Drawing.Size(159, 95);
            this.listPort.TabIndex = 13;
            // 
            // btnPortAdd
            // 
            this.btnPortAdd.Location = new System.Drawing.Point(282, 2);
            this.btnPortAdd.Name = "btnPortAdd";
            this.btnPortAdd.Size = new System.Drawing.Size(111, 23);
            this.btnPortAdd.TabIndex = 12;
            this.btnPortAdd.Text = "Ekle";
            this.btnPortAdd.UseVisualStyleBackColor = true;
            this.btnPortAdd.Click += new System.EventHandler(this.btnPortAdd_Click);
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(11, 2);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 23);
            this.label5.TabIndex = 11;
            this.label5.Text = "Hedef :";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnStartStop
            // 
            this.btnStartStop.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnStartStop.Location = new System.Drawing.Point(0, 291);
            this.btnStartStop.Name = "btnStartStop";
            this.btnStartStop.Size = new System.Drawing.Size(675, 23);
            this.btnStartStop.TabIndex = 3;
            this.btnStartStop.Text = "Başlat";
            this.btnStartStop.UseVisualStyleBackColor = true;
            this.btnStartStop.Click += new System.EventHandler(this.btnStartStop_Click);
            // 
            // progressBar1
            // 
            this.progressBar1.Dock = System.Windows.Forms.DockStyle.Top;
            this.progressBar1.Location = new System.Drawing.Point(0, 314);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(675, 23);
            this.progressBar1.TabIndex = 4;
            // 
            // pnlResult
            // 
            this.pnlResult.Controls.Add(this.listBox1);
            this.pnlResult.Controls.Add(this.label7);
            this.pnlResult.Controls.Add(this.label6);
            this.pnlResult.Controls.Add(this.btnResultExport);
            this.pnlResult.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlResult.Location = new System.Drawing.Point(0, 337);
            this.pnlResult.Name = "pnlResult";
            this.pnlResult.Size = new System.Drawing.Size(675, 194);
            this.pnlResult.TabIndex = 5;
            // 
            // listBox1
            // 
            this.listBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(117, 3);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(555, 160);
            this.listBox1.TabIndex = 14;
            // 
            // label7
            // 
            this.label7.Location = new System.Drawing.Point(12, 26);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(100, 23);
            this.label7.TabIndex = 13;
            this.label7.Text = "Hedef";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(12, 3);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(100, 23);
            this.label6.TabIndex = 12;
            this.label6.Text = "Sonuç :";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnResultExport
            // 
            this.btnResultExport.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnResultExport.Location = new System.Drawing.Point(0, 168);
            this.btnResultExport.Name = "btnResultExport";
            this.btnResultExport.Size = new System.Drawing.Size(675, 23);
            this.btnResultExport.TabIndex = 4;
            this.btnResultExport.Text = "Sonuçu Dışa Aktar";
            this.btnResultExport.UseVisualStyleBackColor = true;
            this.btnResultExport.Click += new System.EventHandler(this.btnResultExport_Click);
            // 
            // homeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(675, 531);
            this.Controls.Add(this.pnlResult);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.btnStartStop);
            this.Controls.Add(this.pnlList);
            this.Controls.Add(this.pnlInterval);
            this.Controls.Add(this.pnlSettings);
            this.Name = "homeForm";
            this.Text = "YK-47 Tarafından Port Scanner";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.pnlSettings.ResumeLayout(false);
            this.pnlSettings.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.pnlInterval.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numericIntervalMax)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericIntervalMin)).EndInit();
            this.pnlList.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numericPortAdd)).EndInit();
            this.pnlResult.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlSettings;
        private System.Windows.Forms.Panel pnlInterval;
        private System.Windows.Forms.Panel pnlList;
        private System.Windows.Forms.Button btnStartStop;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Panel pnlResult;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.RadioButton radioUdp;
        private System.Windows.Forms.RadioButton radioTcp;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnVictimInport;
        private System.Windows.Forms.Button btnVictimExport;
        private System.Windows.Forms.Button btnSelectedVictimRemove;
        private System.Windows.Forms.ListBox listVictims;
        private System.Windows.Forms.Button btnVictimAdd;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtVictim;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.RadioButton radioList;
        private System.Windows.Forms.RadioButton radioInterval;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown numericIntervalMax;
        private System.Windows.Forms.NumericUpDown numericIntervalMin;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown numericPortAdd;
        private System.Windows.Forms.Button btnPortInport;
        private System.Windows.Forms.Button btnPortExport;
        private System.Windows.Forms.Button btnSelectedPortRemove;
        private System.Windows.Forms.ListBox listPort;
        private System.Windows.Forms.Button btnPortAdd;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnResultExport;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ListBox listBox1;
    }
}

