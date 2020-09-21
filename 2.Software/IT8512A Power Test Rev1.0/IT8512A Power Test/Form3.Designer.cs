namespace IT8512A_Power_Test
{
    partial class Form3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form3));
            this.pnOption = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.btOptionClose = new System.Windows.Forms.Button();
            this.btloadToday = new System.Windows.Forms.Button();
            this.btClearNG = new System.Windows.Forms.Button();
            this.gbStatisc = new System.Windows.Forms.GroupBox();
            this.lbStaNGnum = new System.Windows.Forms.Label();
            this.lbStaNG = new System.Windows.Forms.Label();
            this.lbStaOKnum = new System.Windows.Forms.Label();
            this.lbStaOK = new System.Windows.Forms.Label();
            this.lbStaTTnum = new System.Windows.Forms.Label();
            this.lbStaTT = new System.Windows.Forms.Label();
            this.gbReport = new System.Windows.Forms.GroupBox();
            this.dgReport = new System.Windows.Forms.DataGridView();
            this.dgwReportSTT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgwReportResult = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgwReportModel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgwReportTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgwReportCnA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgwReportResultA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgwReportCnBVol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgwReportCnBResult = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gbFillter = new System.Windows.Forms.GroupBox();
            this.lbTimerFillter = new System.Windows.Forms.Label();
            this.nbYearTo = new System.Windows.Forms.NumericUpDown();
            this.nbYearFrom = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cbDayTo = new System.Windows.Forms.ComboBox();
            this.cbMonthTo = new System.Windows.Forms.ComboBox();
            this.btFillter = new System.Windows.Forms.Button();
            this.cbModel = new System.Windows.Forms.ComboBox();
            this.cbDay = new System.Windows.Forms.ComboBox();
            this.cbMonth = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.pnOption.SuspendLayout();
            this.gbStatisc.SuspendLayout();
            this.gbReport.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgReport)).BeginInit();
            this.gbFillter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nbYearTo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nbYearFrom)).BeginInit();
            this.SuspendLayout();
            // 
            // pnOption
            // 
            this.pnOption.Controls.Add(this.label6);
            this.pnOption.Controls.Add(this.btOptionClose);
            this.pnOption.Controls.Add(this.btloadToday);
            this.pnOption.Controls.Add(this.btClearNG);
            this.pnOption.Controls.Add(this.gbStatisc);
            this.pnOption.Controls.Add(this.gbReport);
            this.pnOption.Controls.Add(this.gbFillter);
            this.pnOption.Location = new System.Drawing.Point(12, 12);
            this.pnOption.Name = "pnOption";
            this.pnOption.Size = new System.Drawing.Size(858, 677);
            this.pnOption.TabIndex = 7;
            // 
            // label6
            // 
            this.label6.Dock = System.Windows.Forms.DockStyle.Top;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(0, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(858, 37);
            this.label6.TabIndex = 6;
            this.label6.Text = "Management reports";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label6.MouseDown += new System.Windows.Forms.MouseEventHandler(this.label6_MouseDown);
            // 
            // btOptionClose
            // 
            this.btOptionClose.Location = new System.Drawing.Point(757, 640);
            this.btOptionClose.Name = "btOptionClose";
            this.btOptionClose.Size = new System.Drawing.Size(94, 31);
            this.btOptionClose.TabIndex = 5;
            this.btOptionClose.Text = "Close";
            this.btOptionClose.UseVisualStyleBackColor = true;
            this.btOptionClose.Click += new System.EventHandler(this.btOptionClose_Click);
            // 
            // btloadToday
            // 
            this.btloadToday.Location = new System.Drawing.Point(628, 640);
            this.btloadToday.Name = "btloadToday";
            this.btloadToday.Size = new System.Drawing.Size(74, 31);
            this.btloadToday.TabIndex = 4;
            this.btloadToday.Text = "Today";
            this.btloadToday.UseVisualStyleBackColor = true;
            this.btloadToday.Click += new System.EventHandler(this.btloadToday_Click);
            // 
            // btClearNG
            // 
            this.btClearNG.Location = new System.Drawing.Point(522, 640);
            this.btClearNG.Name = "btClearNG";
            this.btClearNG.Size = new System.Drawing.Size(100, 31);
            this.btClearNG.TabIndex = 3;
            this.btClearNG.Text = "Clear NG";
            this.btClearNG.UseVisualStyleBackColor = true;
            this.btClearNG.Click += new System.EventHandler(this.btClearNG_Click);
            // 
            // gbStatisc
            // 
            this.gbStatisc.Controls.Add(this.lbStaNGnum);
            this.gbStatisc.Controls.Add(this.lbStaNG);
            this.gbStatisc.Controls.Add(this.lbStaOKnum);
            this.gbStatisc.Controls.Add(this.lbStaOK);
            this.gbStatisc.Controls.Add(this.lbStaTTnum);
            this.gbStatisc.Controls.Add(this.lbStaTT);
            this.gbStatisc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.gbStatisc.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.gbStatisc.Location = new System.Drawing.Point(3, 633);
            this.gbStatisc.Name = "gbStatisc";
            this.gbStatisc.Size = new System.Drawing.Size(304, 40);
            this.gbStatisc.TabIndex = 2;
            this.gbStatisc.TabStop = false;
            this.gbStatisc.Text = "Statistisc";
            // 
            // lbStaNGnum
            // 
            this.lbStaNGnum.AutoSize = true;
            this.lbStaNGnum.Location = new System.Drawing.Point(257, 16);
            this.lbStaNGnum.Name = "lbStaNGnum";
            this.lbStaNGnum.Size = new System.Drawing.Size(13, 13);
            this.lbStaNGnum.TabIndex = 5;
            this.lbStaNGnum.Text = "0";
            // 
            // lbStaNG
            // 
            this.lbStaNG.AutoSize = true;
            this.lbStaNG.Location = new System.Drawing.Point(210, 16);
            this.lbStaNG.Name = "lbStaNG";
            this.lbStaNG.Size = new System.Drawing.Size(29, 13);
            this.lbStaNG.TabIndex = 4;
            this.lbStaNG.Text = "NG :";
            // 
            // lbStaOKnum
            // 
            this.lbStaOKnum.AutoSize = true;
            this.lbStaOKnum.Location = new System.Drawing.Point(156, 16);
            this.lbStaOKnum.Name = "lbStaOKnum";
            this.lbStaOKnum.Size = new System.Drawing.Size(13, 13);
            this.lbStaOKnum.TabIndex = 3;
            this.lbStaOKnum.Text = "0";
            // 
            // lbStaOK
            // 
            this.lbStaOK.AutoSize = true;
            this.lbStaOK.Location = new System.Drawing.Point(115, 16);
            this.lbStaOK.Name = "lbStaOK";
            this.lbStaOK.Size = new System.Drawing.Size(28, 13);
            this.lbStaOK.TabIndex = 2;
            this.lbStaOK.Text = "OK :";
            // 
            // lbStaTTnum
            // 
            this.lbStaTTnum.AutoSize = true;
            this.lbStaTTnum.Location = new System.Drawing.Point(61, 16);
            this.lbStaTTnum.Name = "lbStaTTnum";
            this.lbStaTTnum.Size = new System.Drawing.Size(13, 13);
            this.lbStaTTnum.TabIndex = 1;
            this.lbStaTTnum.Text = "0";
            // 
            // lbStaTT
            // 
            this.lbStaTT.AutoSize = true;
            this.lbStaTT.Location = new System.Drawing.Point(20, 16);
            this.lbStaTT.Name = "lbStaTT";
            this.lbStaTT.Size = new System.Drawing.Size(37, 13);
            this.lbStaTT.TabIndex = 0;
            this.lbStaTT.Text = "Total :";
            // 
            // gbReport
            // 
            this.gbReport.Controls.Add(this.dgReport);
            this.gbReport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.gbReport.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.gbReport.Location = new System.Drawing.Point(3, 135);
            this.gbReport.Name = "gbReport";
            this.gbReport.Size = new System.Drawing.Size(851, 492);
            this.gbReport.TabIndex = 1;
            this.gbReport.TabStop = false;
            this.gbReport.Text = "Report";
            // 
            // dgReport
            // 
            this.dgReport.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgReport.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgReport.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgwReportSTT,
            this.dgwReportResult,
            this.dgwReportModel,
            this.dgwReportTime,
            this.dgwReportCnA,
            this.dgwReportResultA,
            this.dgwReportCnBVol,
            this.dgwReportCnBResult});
            this.dgReport.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgReport.Location = new System.Drawing.Point(3, 16);
            this.dgReport.Name = "dgReport";
            this.dgReport.Size = new System.Drawing.Size(845, 473);
            this.dgReport.TabIndex = 0;
            // 
            // dgwReportSTT
            // 
            this.dgwReportSTT.FillWeight = 30F;
            this.dgwReportSTT.HeaderText = "STT";
            this.dgwReportSTT.Name = "dgwReportSTT";
            this.dgwReportSTT.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // dgwReportResult
            // 
            this.dgwReportResult.FillWeight = 50F;
            this.dgwReportResult.HeaderText = "Result";
            this.dgwReportResult.Name = "dgwReportResult";
            // 
            // dgwReportModel
            // 
            this.dgwReportModel.HeaderText = "Model";
            this.dgwReportModel.Name = "dgwReportModel";
            // 
            // dgwReportTime
            // 
            this.dgwReportTime.FillWeight = 50F;
            this.dgwReportTime.HeaderText = "Time";
            this.dgwReportTime.Name = "dgwReportTime";
            // 
            // dgwReportCnA
            // 
            this.dgwReportCnA.FillWeight = 70F;
            this.dgwReportCnA.HeaderText = "Chanel A Vol";
            this.dgwReportCnA.Name = "dgwReportCnA";
            // 
            // dgwReportResultA
            // 
            this.dgwReportResultA.FillWeight = 30F;
            this.dgwReportResultA.HeaderText = "Chanel A Result";
            this.dgwReportResultA.Name = "dgwReportResultA";
            // 
            // dgwReportCnBVol
            // 
            this.dgwReportCnBVol.FillWeight = 70F;
            this.dgwReportCnBVol.HeaderText = "Chanel B Vol";
            this.dgwReportCnBVol.Name = "dgwReportCnBVol";
            // 
            // dgwReportCnBResult
            // 
            this.dgwReportCnBResult.FillWeight = 30F;
            this.dgwReportCnBResult.HeaderText = "Chanel B Result";
            this.dgwReportCnBResult.Name = "dgwReportCnBResult";
            // 
            // gbFillter
            // 
            this.gbFillter.Controls.Add(this.label7);
            this.gbFillter.Controls.Add(this.label3);
            this.gbFillter.Controls.Add(this.label2);
            this.gbFillter.Controls.Add(this.label1);
            this.gbFillter.Controls.Add(this.lbTimerFillter);
            this.gbFillter.Controls.Add(this.nbYearTo);
            this.gbFillter.Controls.Add(this.nbYearFrom);
            this.gbFillter.Controls.Add(this.label5);
            this.gbFillter.Controls.Add(this.label4);
            this.gbFillter.Controls.Add(this.cbDayTo);
            this.gbFillter.Controls.Add(this.cbMonthTo);
            this.gbFillter.Controls.Add(this.btFillter);
            this.gbFillter.Controls.Add(this.cbModel);
            this.gbFillter.Controls.Add(this.cbDay);
            this.gbFillter.Controls.Add(this.cbMonth);
            this.gbFillter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.gbFillter.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.gbFillter.Location = new System.Drawing.Point(3, 40);
            this.gbFillter.Name = "gbFillter";
            this.gbFillter.Size = new System.Drawing.Size(854, 89);
            this.gbFillter.TabIndex = 0;
            this.gbFillter.TabStop = false;
            this.gbFillter.Text = "Fillter";
            // 
            // lbTimerFillter
            // 
            this.lbTimerFillter.Location = new System.Drawing.Point(486, 64);
            this.lbTimerFillter.Name = "lbTimerFillter";
            this.lbTimerFillter.Size = new System.Drawing.Size(262, 21);
            this.lbTimerFillter.TabIndex = 13;
            this.lbTimerFillter.Text = "Date time fillter";
            this.lbTimerFillter.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // nbYearTo
            // 
            this.nbYearTo.Increment = new decimal(new int[] {
            2020,
            0,
            0,
            0});
            this.nbYearTo.Location = new System.Drawing.Point(73, 58);
            this.nbYearTo.Maximum = new decimal(new int[] {
            5000,
            0,
            0,
            0});
            this.nbYearTo.Name = "nbYearTo";
            this.nbYearTo.Size = new System.Drawing.Size(120, 20);
            this.nbYearTo.TabIndex = 12;
            this.nbYearTo.Value = new decimal(new int[] {
            2020,
            0,
            0,
            0});
            // 
            // nbYearFrom
            // 
            this.nbYearFrom.Location = new System.Drawing.Point(73, 32);
            this.nbYearFrom.Maximum = new decimal(new int[] {
            5000,
            0,
            0,
            0});
            this.nbYearFrom.Name = "nbYearFrom";
            this.nbYearFrom.Size = new System.Drawing.Size(120, 20);
            this.nbYearFrom.TabIndex = 11;
            this.nbYearFrom.Value = new decimal(new int[] {
            2020,
            0,
            0,
            0});
            this.nbYearFrom.ValueChanged += new System.EventHandler(this.nbYearFrom_ValueChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 62);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(20, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "To";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 34);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(30, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "From";
            // 
            // cbDayTo
            // 
            this.cbDayTo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbDayTo.FormattingEnabled = true;
            this.cbDayTo.Location = new System.Drawing.Point(326, 59);
            this.cbDayTo.Name = "cbDayTo";
            this.cbDayTo.Size = new System.Drawing.Size(121, 21);
            this.cbDayTo.TabIndex = 7;
            // 
            // cbMonthTo
            // 
            this.cbMonthTo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbMonthTo.FormattingEnabled = true;
            this.cbMonthTo.Location = new System.Drawing.Point(199, 59);
            this.cbMonthTo.Name = "cbMonthTo";
            this.cbMonthTo.Size = new System.Drawing.Size(121, 21);
            this.cbMonthTo.TabIndex = 6;
            // 
            // btFillter
            // 
            this.btFillter.Location = new System.Drawing.Point(754, 64);
            this.btFillter.Name = "btFillter";
            this.btFillter.Size = new System.Drawing.Size(86, 21);
            this.btFillter.TabIndex = 4;
            this.btFillter.Text = "Filter";
            this.btFillter.UseVisualStyleBackColor = true;
            this.btFillter.Click += new System.EventHandler(this.btFillter_Click);
            // 
            // cbModel
            // 
            this.cbModel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbModel.FormattingEnabled = true;
            this.cbModel.Location = new System.Drawing.Point(554, 32);
            this.cbModel.Name = "cbModel";
            this.cbModel.Size = new System.Drawing.Size(294, 21);
            this.cbModel.TabIndex = 2;
            // 
            // cbDay
            // 
            this.cbDay.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbDay.FormattingEnabled = true;
            this.cbDay.Location = new System.Drawing.Point(326, 32);
            this.cbDay.Name = "cbDay";
            this.cbDay.Size = new System.Drawing.Size(121, 21);
            this.cbDay.TabIndex = 1;
            // 
            // cbMonth
            // 
            this.cbMonth.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbMonth.FormattingEnabled = true;
            this.cbMonth.Location = new System.Drawing.Point(199, 32);
            this.cbMonth.Name = "cbMonth";
            this.cbMonth.Size = new System.Drawing.Size(121, 21);
            this.cbMonth.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(70, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 21);
            this.label1.TabIndex = 14;
            this.label1.Text = "Year";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(199, 8);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(121, 21);
            this.label2.TabIndex = 15;
            this.label2.Text = "Month";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(326, 8);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(121, 21);
            this.label3.TabIndex = 16;
            this.label3.Text = "Day";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            this.label7.Location = new System.Drawing.Point(551, 8);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(123, 21);
            this.label7.TabIndex = 17;
            this.label7.Text = "Model";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(882, 693);
            this.ControlBox = false;
            this.Controls.Add(this.pnOption);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form3";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form3_FormClosed);
            this.Load += new System.EventHandler(this.Form3_Load);
            this.pnOption.ResumeLayout(false);
            this.gbStatisc.ResumeLayout(false);
            this.gbStatisc.PerformLayout();
            this.gbReport.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgReport)).EndInit();
            this.gbFillter.ResumeLayout(false);
            this.gbFillter.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nbYearTo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nbYearFrom)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel pnOption;
        private System.Windows.Forms.GroupBox gbFillter;
        private System.Windows.Forms.Button btOptionClose;
        private System.Windows.Forms.Button btloadToday;
        private System.Windows.Forms.Button btClearNG;
        private System.Windows.Forms.GroupBox gbStatisc;
        private System.Windows.Forms.GroupBox gbReport;
        private System.Windows.Forms.Button btFillter;
        private System.Windows.Forms.ComboBox cbModel;
        private System.Windows.Forms.ComboBox cbDay;
        private System.Windows.Forms.ComboBox cbMonth;
        private System.Windows.Forms.DataGridView dgReport;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbDayTo;
        private System.Windows.Forms.ComboBox cbMonthTo;
        private System.Windows.Forms.NumericUpDown nbYearTo;
        private System.Windows.Forms.NumericUpDown nbYearFrom;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgwReportSTT;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgwReportResult;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgwReportModel;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgwReportTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgwReportCnA;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgwReportResultA;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgwReportCnBVol;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgwReportCnBResult;
        private System.Windows.Forms.Label lbTimerFillter;
        private System.Windows.Forms.Label lbStaNGnum;
        private System.Windows.Forms.Label lbStaNG;
        private System.Windows.Forms.Label lbStaOKnum;
        private System.Windows.Forms.Label lbStaOK;
        private System.Windows.Forms.Label lbStaTTnum;
        private System.Windows.Forms.Label lbStaTT;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}