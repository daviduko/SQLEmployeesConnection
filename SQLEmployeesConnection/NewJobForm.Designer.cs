namespace SQLEmployeesConnection
{
    partial class NewJobForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnCreate = new System.Windows.Forms.Button();
            this.numMinSalary = new System.Windows.Forms.NumericUpDown();
            this.numMaxSalary = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.numMinSalary)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMaxSalary)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 50F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(315, 78);
            this.label1.TabIndex = 0;
            this.label1.Text = "New Job";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtTitle
            // 
            this.txtTitle.Location = new System.Drawing.Point(107, 134);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(100, 20);
            this.txtTitle.TabIndex = 1;
            this.txtTitle.TextChanged += new System.EventHandler(this.txtTitle_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(107, 115);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(27, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Title";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(107, 190);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Min Salary";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(107, 266);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Max Salary";
            // 
            // btnCreate
            // 
            this.btnCreate.BackColor = System.Drawing.SystemColors.Control;
            this.btnCreate.Enabled = false;
            this.btnCreate.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreate.Location = new System.Drawing.Point(221, 319);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(82, 25);
            this.btnCreate.TabIndex = 7;
            this.btnCreate.Text = "Create";
            this.btnCreate.UseVisualStyleBackColor = false;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // numMinSalary
            // 
            this.numMinSalary.DecimalPlaces = 2;
            this.numMinSalary.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.numMinSalary.Location = new System.Drawing.Point(107, 206);
            this.numMinSalary.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.numMinSalary.Name = "numMinSalary";
            this.numMinSalary.Size = new System.Drawing.Size(120, 20);
            this.numMinSalary.TabIndex = 8;
            // 
            // numMaxSalary
            // 
            this.numMaxSalary.DecimalPlaces = 2;
            this.numMaxSalary.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.numMaxSalary.Location = new System.Drawing.Point(107, 283);
            this.numMaxSalary.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.numMaxSalary.Name = "numMaxSalary";
            this.numMaxSalary.Size = new System.Drawing.Size(120, 20);
            this.numMaxSalary.TabIndex = 9;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(315, 356);
            this.Controls.Add(this.numMaxSalary);
            this.Controls.Add(this.numMinSalary);
            this.Controls.Add(this.btnCreate);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtTitle);
            this.Controls.Add(this.label1);
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)(this.numMinSalary)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMaxSalary)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTitle;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.NumericUpDown numMinSalary;
        private System.Windows.Forms.NumericUpDown numMaxSalary;
    }
}