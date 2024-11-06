namespace SQLEmployeesConnection
{
    partial class MainForm
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
            this.btnConnect = new System.Windows.Forms.Button();
            this.btnDisconnect = new System.Windows.Forms.Button();
            this.labelConnection = new System.Windows.Forms.Label();
            this.btnNewJob = new System.Windows.Forms.Button();
            this.dataGridViewJobs = new System.Windows.Forms.DataGridView();
            this.btnRefresh = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewJobs)).BeginInit();
            this.SuspendLayout();
            // 
            // btnConnect
            // 
            this.btnConnect.Enabled = false;
            this.btnConnect.Location = new System.Drawing.Point(43, 117);
            this.btnConnect.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(191, 50);
            this.btnConnect.TabIndex = 0;
            this.btnConnect.Text = "Connect";
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // btnDisconnect
            // 
            this.btnDisconnect.Location = new System.Drawing.Point(468, 117);
            this.btnDisconnect.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnDisconnect.Name = "btnDisconnect";
            this.btnDisconnect.Size = new System.Drawing.Size(191, 50);
            this.btnDisconnect.TabIndex = 1;
            this.btnDisconnect.Text = "Disconnect";
            this.btnDisconnect.UseVisualStyleBackColor = true;
            this.btnDisconnect.Click += new System.EventHandler(this.btnDisconnect_Click);
            // 
            // labelConnection
            // 
            this.labelConnection.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.labelConnection.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelConnection.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelConnection.Location = new System.Drawing.Point(0, 0);
            this.labelConnection.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelConnection.Name = "labelConnection";
            this.labelConnection.Size = new System.Drawing.Size(705, 97);
            this.labelConnection.TabIndex = 2;
            this.labelConnection.Text = "Opened";
            this.labelConnection.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnNewJob
            // 
            this.btnNewJob.Location = new System.Drawing.Point(559, 513);
            this.btnNewJob.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnNewJob.Name = "btnNewJob";
            this.btnNewJob.Size = new System.Drawing.Size(100, 28);
            this.btnNewJob.TabIndex = 3;
            this.btnNewJob.Text = "New Job";
            this.btnNewJob.UseVisualStyleBackColor = true;
            this.btnNewJob.Click += new System.EventHandler(this.btnNewJob_Click);
            // 
            // dataGridViewJobs
            // 
            this.dataGridViewJobs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewJobs.Location = new System.Drawing.Point(43, 224);
            this.dataGridViewJobs.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataGridViewJobs.Name = "dataGridViewJobs";
            this.dataGridViewJobs.RowHeadersWidth = 51;
            this.dataGridViewJobs.Size = new System.Drawing.Size(616, 260);
            this.dataGridViewJobs.TabIndex = 4;
            this.dataGridViewJobs.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewJobs_CellValueChanged);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(43, 492);
            this.btnRefresh.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(100, 28);
            this.btnRefresh.TabIndex = 5;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(705, 554);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.dataGridViewJobs);
            this.Controls.Add(this.btnNewJob);
            this.Controls.Add(this.labelConnection);
            this.Controls.Add(this.btnDisconnect);
            this.Controls.Add(this.btnConnect);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewJobs)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.Button btnDisconnect;
        private System.Windows.Forms.Label labelConnection;
        private System.Windows.Forms.Button btnNewJob;
        private System.Windows.Forms.DataGridView dataGridViewJobs;
        private System.Windows.Forms.Button btnRefresh;
    }
}

