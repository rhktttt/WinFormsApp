namespace WinFormsApp1
{
    partial class Form1
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
            tabCtrl2 = new TabControl();
            tabPage1 = new TabPage();
            dgvActLog = new DataGridView();
            tabPage2 = new TabPage();
            dgvCommLog = new DataGridView();
            txtLog = new TextBox();
            btnTx = new Button();
            btnRx = new Button();
            btnAct = new Button();
            CommNo = new DataGridViewTextBoxColumn();
            DgvCommTime = new DataGridViewTextBoxColumn();
            DgvCommType = new DataGridViewTextBoxColumn();
            DgvCommSrcAddr = new DataGridViewTextBoxColumn();
            DgvCommSrcPort = new DataGridViewTextBoxColumn();
            DgvCommDstAddr = new DataGridViewTextBoxColumn();
            DgvCommDstPort = new DataGridViewTextBoxColumn();
            DgvCommData = new DataGridViewTextBoxColumn();
            ActNo = new DataGridViewTextBoxColumn();
            ActTime = new DataGridViewTextBoxColumn();
            ActMessage = new DataGridViewTextBoxColumn();
            tabCtrl2.SuspendLayout();
            tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvActLog).BeginInit();
            tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvCommLog).BeginInit();
            SuspendLayout();
            // 
            // tabCtrl2
            // 
            tabCtrl2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tabCtrl2.Controls.Add(tabPage1);
            tabCtrl2.Controls.Add(tabPage2);
            tabCtrl2.Location = new Point(12, 204);
            tabCtrl2.Name = "tabCtrl2";
            tabCtrl2.SelectedIndex = 0;
            tabCtrl2.Size = new Size(1028, 388);
            tabCtrl2.TabIndex = 0;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(dgvActLog);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(1020, 360);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "動作ログ";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // dgvActLog
            // 
            dgvActLog.AllowUserToAddRows = false;
            dgvActLog.AllowUserToDeleteRows = false;
            dgvActLog.AllowUserToResizeRows = false;
            dgvActLog.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvActLog.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvActLog.Columns.AddRange(new DataGridViewColumn[] { ActNo, ActTime, ActMessage });
            dgvActLog.Location = new Point(6, 3);
            dgvActLog.Name = "dgvActLog";
            dgvActLog.ReadOnly = true;
            dgvActLog.Size = new Size(1011, 351);
            dgvActLog.TabIndex = 0;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(dgvCommLog);
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(1020, 360);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "通信ログ";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // dgvCommLog
            // 
            dgvCommLog.AllowUserToAddRows = false;
            dgvCommLog.AllowUserToDeleteRows = false;
            dgvCommLog.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvCommLog.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCommLog.Columns.AddRange(new DataGridViewColumn[] { CommNo, DgvCommTime, DgvCommType, DgvCommSrcAddr, DgvCommSrcPort, DgvCommDstAddr, DgvCommDstPort, DgvCommData });
            dgvCommLog.Location = new Point(6, 6);
            dgvCommLog.Name = "dgvCommLog";
            dgvCommLog.ReadOnly = true;
            dgvCommLog.Size = new Size(1008, 348);
            dgvCommLog.TabIndex = 0;
            // 
            // txtLog
            // 
            txtLog.BackColor = Color.White;
            txtLog.Location = new Point(16, 12);
            txtLog.Multiline = true;
            txtLog.Name = "txtLog";
            txtLog.Size = new Size(253, 91);
            txtLog.TabIndex = 2;
            // 
            // btnTx
            // 
            btnTx.Location = new Point(452, 31);
            btnTx.Name = "btnTx";
            btnTx.Size = new Size(75, 43);
            btnTx.TabIndex = 4;
            btnTx.Text = "tx";
            btnTx.UseVisualStyleBackColor = true;
            btnTx.Click += btnTx_Click;
            // 
            // btnRx
            // 
            btnRx.Location = new Point(452, 80);
            btnRx.Name = "btnRx";
            btnRx.Size = new Size(75, 42);
            btnRx.TabIndex = 5;
            btnRx.Text = "rx";
            btnRx.UseVisualStyleBackColor = true;
            btnRx.Click += btnRx_Click;
            // 
            // btnAct
            // 
            btnAct.Location = new Point(371, 31);
            btnAct.Name = "btnAct";
            btnAct.Size = new Size(75, 43);
            btnAct.TabIndex = 4;
            btnAct.Text = "act";
            btnAct.UseVisualStyleBackColor = true;
            btnAct.Click += btnAct_Click;
            // 
            // CommNo
            // 
            CommNo.HeaderText = "NO";
            CommNo.MinimumWidth = 30;
            CommNo.Name = "CommNo";
            CommNo.ReadOnly = true;
            CommNo.Width = 30;
            // 
            // DgvCommTime
            // 
            DgvCommTime.HeaderText = "DATETIME";
            DgvCommTime.MinimumWidth = 140;
            DgvCommTime.Name = "DgvCommTime";
            DgvCommTime.ReadOnly = true;
            DgvCommTime.Resizable = DataGridViewTriState.False;
            DgvCommTime.Width = 140;
            // 
            // DgvCommType
            // 
            DgvCommType.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            DgvCommType.HeaderText = "TX/RX";
            DgvCommType.MaxInputLength = 10;
            DgvCommType.MinimumWidth = 70;
            DgvCommType.Name = "DgvCommType";
            DgvCommType.ReadOnly = true;
            DgvCommType.Resizable = DataGridViewTriState.False;
            DgvCommType.Width = 70;
            // 
            // DgvCommSrcAddr
            // 
            DgvCommSrcAddr.HeaderText = "SOURCE";
            DgvCommSrcAddr.MaxInputLength = 40;
            DgvCommSrcAddr.MinimumWidth = 240;
            DgvCommSrcAddr.Name = "DgvCommSrcAddr";
            DgvCommSrcAddr.ReadOnly = true;
            DgvCommSrcAddr.Resizable = DataGridViewTriState.False;
            DgvCommSrcAddr.Width = 240;
            // 
            // DgvCommSrcPort
            // 
            DgvCommSrcPort.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            DgvCommSrcPort.HeaderText = "";
            DgvCommSrcPort.MaxInputLength = 5;
            DgvCommSrcPort.MinimumWidth = 50;
            DgvCommSrcPort.Name = "DgvCommSrcPort";
            DgvCommSrcPort.ReadOnly = true;
            DgvCommSrcPort.SortMode = DataGridViewColumnSortMode.NotSortable;
            DgvCommSrcPort.Width = 50;
            // 
            // DgvCommDstAddr
            // 
            DgvCommDstAddr.HeaderText = "DESTINATION";
            DgvCommDstAddr.MaxInputLength = 40;
            DgvCommDstAddr.MinimumWidth = 260;
            DgvCommDstAddr.Name = "DgvCommDstAddr";
            DgvCommDstAddr.ReadOnly = true;
            DgvCommDstAddr.Width = 260;
            // 
            // DgvCommDstPort
            // 
            DgvCommDstPort.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            DgvCommDstPort.HeaderText = "";
            DgvCommDstPort.MaxInputLength = 5;
            DgvCommDstPort.MinimumWidth = 40;
            DgvCommDstPort.Name = "DgvCommDstPort";
            DgvCommDstPort.ReadOnly = true;
            DgvCommDstPort.Width = 40;
            // 
            // DgvCommData
            // 
            DgvCommData.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            DgvCommData.HeaderText = "DATA";
            DgvCommData.MinimumWidth = 150;
            DgvCommData.Name = "DgvCommData";
            DgvCommData.ReadOnly = true;
            DgvCommData.SortMode = DataGridViewColumnSortMode.NotSortable;
            // 
            // ActNo
            // 
            ActNo.HeaderText = "NO";
            ActNo.MinimumWidth = 30;
            ActNo.Name = "ActNo";
            ActNo.ReadOnly = true;
            ActNo.Width = 30;
            // 
            // ActTime
            // 
            ActTime.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            ActTime.HeaderText = "DATETIME";
            ActTime.MaxInputLength = 20;
            ActTime.MinimumWidth = 140;
            ActTime.Name = "ActTime";
            ActTime.ReadOnly = true;
            ActTime.Resizable = DataGridViewTriState.False;
            ActTime.Width = 140;
            // 
            // ActMessage
            // 
            ActMessage.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            ActMessage.HeaderText = "MESSAGE";
            ActMessage.MinimumWidth = 200;
            ActMessage.Name = "ActMessage";
            ActMessage.ReadOnly = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1045, 604);
            Controls.Add(btnRx);
            Controls.Add(btnAct);
            Controls.Add(btnTx);
            Controls.Add(txtLog);
            Controls.Add(tabCtrl2);
            Name = "Form1";
            Text = "Form1";
            FormClosing += Form1_FormClosing;
            Load += Form1_Load;
            tabCtrl2.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvActLog).EndInit();
            tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvCommLog).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TabControl tabCtrl2;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private DataGridView dgvActLog;
        private DataGridView dgvCommLog;
        private TextBox txt1;
        private TextBox txt2;
        private TextBox txtLog;
        private Button btnTx;
        private Button btnRx;
        private Button btnAct;
        private DataGridViewTextBoxColumn ActNo;
        private DataGridViewTextBoxColumn ActTime;
        private DataGridViewTextBoxColumn ActMessage;
        private DataGridViewTextBoxColumn CommNo;
        private DataGridViewTextBoxColumn DgvCommTime;
        private DataGridViewTextBoxColumn DgvCommType;
        private DataGridViewTextBoxColumn DgvCommSrcAddr;
        private DataGridViewTextBoxColumn DgvCommSrcPort;
        private DataGridViewTextBoxColumn DgvCommDstAddr;
        private DataGridViewTextBoxColumn DgvCommDstPort;
        private DataGridViewTextBoxColumn DgvCommData;
    }
}
