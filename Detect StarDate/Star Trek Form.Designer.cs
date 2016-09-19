namespace Detect_StarDate
{
    partial class Star_Trek_Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Star_Trek_Form));
            this.CurrentDate = new System.Windows.Forms.DateTimePicker();
            this.TNG_StarDate = new System.Windows.Forms.TextBox();
            this.STO_StarDate = new System.Windows.Forms.TextBox();
            this.Get_StarDate = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.IsUTC = new System.Windows.Forms.CheckBox();
            this.CopyToClipBoard = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // CurrentDate
            // 
            this.CurrentDate.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.CurrentDate.CalendarFont = new System.Drawing.Font("Montalban Condensed", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CurrentDate.CalendarMonthBackground = System.Drawing.Color.WhiteSmoke;
            this.CurrentDate.CustomFormat = "dd.MM.yyyy HH:mm:ss";
            this.CurrentDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.CurrentDate.Location = new System.Drawing.Point(168, 30);
            this.CurrentDate.MinDate = new System.DateTime(1961, 1, 1, 0, 0, 0, 0);
            this.CurrentDate.Name = "CurrentDate";
            this.CurrentDate.Size = new System.Drawing.Size(180, 22);
            this.CurrentDate.TabIndex = 0;
            // 
            // TNG_StarDate
            // 
            this.TNG_StarDate.BackColor = System.Drawing.SystemColors.Desktop;
            this.TNG_StarDate.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TNG_StarDate.Font = new System.Drawing.Font("Montalban Condensed", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TNG_StarDate.ForeColor = System.Drawing.Color.LimeGreen;
            this.TNG_StarDate.Location = new System.Drawing.Point(168, 59);
            this.TNG_StarDate.Name = "TNG_StarDate";
            this.TNG_StarDate.ReadOnly = true;
            this.TNG_StarDate.Size = new System.Drawing.Size(180, 15);
            this.TNG_StarDate.TabIndex = 1;
            this.TNG_StarDate.Text = "00000.00";
            this.TNG_StarDate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // STO_StarDate
            // 
            this.STO_StarDate.BackColor = System.Drawing.SystemColors.Desktop;
            this.STO_StarDate.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.STO_StarDate.Font = new System.Drawing.Font("Montalban Condensed", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.STO_StarDate.ForeColor = System.Drawing.Color.LimeGreen;
            this.STO_StarDate.Location = new System.Drawing.Point(168, 87);
            this.STO_StarDate.Name = "STO_StarDate";
            this.STO_StarDate.ReadOnly = true;
            this.STO_StarDate.Size = new System.Drawing.Size(180, 15);
            this.STO_StarDate.TabIndex = 2;
            this.STO_StarDate.Text = "00000.00";
            this.STO_StarDate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Get_StarDate
            // 
            this.Get_StarDate.BackColor = System.Drawing.Color.Transparent;
            this.Get_StarDate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Get_StarDate.ForeColor = System.Drawing.Color.LimeGreen;
            this.Get_StarDate.Location = new System.Drawing.Point(74, 136);
            this.Get_StarDate.Name = "Get_StarDate";
            this.Get_StarDate.Size = new System.Drawing.Size(274, 25);
            this.Get_StarDate.TabIndex = 3;
            this.Get_StarDate.Text = "Get star date";
            this.Get_StarDate.UseVisualStyleBackColor = false;
            this.Get_StarDate.Click += new System.EventHandler(this.Get_StarDate_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Montalban Condensed", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.LimeGreen;
            this.label1.Location = new System.Drawing.Point(71, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 14);
            this.label1.TabIndex = 4;
            this.label1.Text = "Current date:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Montalban Condensed", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.LimeGreen;
            this.label2.Location = new System.Drawing.Point(71, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 14);
            this.label2.TabIndex = 5;
            this.label2.Text = "TNG star date:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Montalban Condensed", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.LimeGreen;
            this.label3.Location = new System.Drawing.Point(71, 88);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 14);
            this.label3.TabIndex = 6;
            this.label3.Text = "STO star date:";
            // 
            // IsUTC
            // 
            this.IsUTC.BackColor = System.Drawing.Color.Transparent;
            this.IsUTC.ForeColor = System.Drawing.Color.LimeGreen;
            this.IsUTC.Location = new System.Drawing.Point(74, 108);
            this.IsUTC.Name = "IsUTC";
            this.IsUTC.Size = new System.Drawing.Size(274, 22);
            this.IsUTC.TabIndex = 7;
            this.IsUTC.Text = "Use UTC time?";
            this.IsUTC.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.IsUTC.UseVisualStyleBackColor = false;
            // 
            // CopyToClipBoard
            // 
            this.CopyToClipBoard.BackColor = System.Drawing.Color.Transparent;
            this.CopyToClipBoard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CopyToClipBoard.ForeColor = System.Drawing.Color.LimeGreen;
            this.CopyToClipBoard.Location = new System.Drawing.Point(74, 167);
            this.CopyToClipBoard.Name = "CopyToClipBoard";
            this.CopyToClipBoard.Size = new System.Drawing.Size(274, 25);
            this.CopyToClipBoard.TabIndex = 8;
            this.CopyToClipBoard.Text = "Copy to clip board";
            this.CopyToClipBoard.UseVisualStyleBackColor = false;
            this.CopyToClipBoard.Click += new System.EventHandler(this.CopyToClipBoard_Click);
            // 
            // Star_Trek_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BackgroundImage = global::Detect_StarDate.Properties.Resources.pattern1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(350, 193);
            this.Controls.Add(this.CopyToClipBoard);
            this.Controls.Add(this.IsUTC);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Get_StarDate);
            this.Controls.Add(this.STO_StarDate);
            this.Controls.Add(this.TNG_StarDate);
            this.Controls.Add(this.CurrentDate);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Montalban Condensed", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Star_Trek_Form";
            this.Text = "Wich star date now?";
            this.Load += new System.EventHandler(this.Star_Trek_Form_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker CurrentDate;
        private System.Windows.Forms.TextBox TNG_StarDate;
        private System.Windows.Forms.TextBox STO_StarDate;
        private System.Windows.Forms.Button Get_StarDate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox IsUTC;
        private System.Windows.Forms.Button CopyToClipBoard;
    }
}