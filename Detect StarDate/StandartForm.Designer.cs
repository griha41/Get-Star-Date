namespace Detect_StarDate
{
    partial class StandartForm
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
            this.CurrentDate = new System.Windows.Forms.TextBox();
            this.CurrentDate_Lbl = new System.Windows.Forms.Label();
            this.StarDate_Lbl = new System.Windows.Forms.Label();
            this.Star_Date = new System.Windows.Forms.TextBox();
            this.Conv = new System.Windows.Forms.Button();
            this.STO_Date_Lbl = new System.Windows.Forms.Label();
            this.STO_StarDate = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // CurrentDate
            // 
            this.CurrentDate.Location = new System.Drawing.Point(82, 6);
            this.CurrentDate.Name = "CurrentDate";
            this.CurrentDate.Size = new System.Drawing.Size(178, 20);
            this.CurrentDate.TabIndex = 0;
            this.CurrentDate.Text = "15/09/2016 17:15:44";
            this.CurrentDate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // CurrentDate_Lbl
            // 
            this.CurrentDate_Lbl.AutoSize = true;
            this.CurrentDate_Lbl.Location = new System.Drawing.Point(3, 9);
            this.CurrentDate_Lbl.Name = "CurrentDate_Lbl";
            this.CurrentDate_Lbl.Size = new System.Drawing.Size(73, 13);
            this.CurrentDate_Lbl.TabIndex = 1;
            this.CurrentDate_Lbl.Text = "Current Date: ";
            this.CurrentDate_Lbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // StarDate_Lbl
            // 
            this.StarDate_Lbl.AutoSize = true;
            this.StarDate_Lbl.Location = new System.Drawing.Point(22, 29);
            this.StarDate_Lbl.Name = "StarDate_Lbl";
            this.StarDate_Lbl.Size = new System.Drawing.Size(81, 13);
            this.StarDate_Lbl.TabIndex = 2;
            this.StarDate_Lbl.Text = "TNG Star Date:";
            // 
            // Star_Date
            // 
            this.Star_Date.Location = new System.Drawing.Point(6, 45);
            this.Star_Date.Name = "Star_Date";
            this.Star_Date.ReadOnly = true;
            this.Star_Date.Size = new System.Drawing.Size(121, 20);
            this.Star_Date.TabIndex = 3;
            this.Star_Date.Text = "00000.00";
            this.Star_Date.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Conv
            // 
            this.Conv.Location = new System.Drawing.Point(6, 71);
            this.Conv.Name = "Conv";
            this.Conv.Size = new System.Drawing.Size(254, 23);
            this.Conv.TabIndex = 4;
            this.Conv.Text = "Date to Star Date";
            this.Conv.UseVisualStyleBackColor = true;
            this.Conv.Click += new System.EventHandler(this.Conv_Click);
            // 
            // STO_Date_Lbl
            // 
            this.STO_Date_Lbl.AutoSize = true;
            this.STO_Date_Lbl.Location = new System.Drawing.Point(151, 29);
            this.STO_Date_Lbl.Name = "STO_Date_Lbl";
            this.STO_Date_Lbl.Size = new System.Drawing.Size(80, 13);
            this.STO_Date_Lbl.TabIndex = 6;
            this.STO_Date_Lbl.Text = "STO Star Date:";
            // 
            // STO_StarDate
            // 
            this.STO_StarDate.Location = new System.Drawing.Point(133, 45);
            this.STO_StarDate.Name = "STO_StarDate";
            this.STO_StarDate.ReadOnly = true;
            this.STO_StarDate.Size = new System.Drawing.Size(121, 20);
            this.STO_StarDate.TabIndex = 7;
            this.STO_StarDate.Text = "00000.00";
            this.STO_StarDate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(266, 101);
            this.Controls.Add(this.STO_StarDate);
            this.Controls.Add(this.STO_Date_Lbl);
            this.Controls.Add(this.Conv);
            this.Controls.Add(this.Star_Date);
            this.Controls.Add(this.StarDate_Lbl);
            this.Controls.Add(this.CurrentDate_Lbl);
            this.Controls.Add(this.CurrentDate);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox CurrentDate;
        private System.Windows.Forms.Label CurrentDate_Lbl;
        private System.Windows.Forms.Label StarDate_Lbl;
        private System.Windows.Forms.TextBox Star_Date;
        private System.Windows.Forms.Button Conv;
        private System.Windows.Forms.Label STO_Date_Lbl;
        private System.Windows.Forms.TextBox STO_StarDate;
    }
}

