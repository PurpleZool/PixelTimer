
using MainForm;

namespace WinFormsApp1
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
            this.lblDateSplash = new System.Windows.Forms.Label();
            this.btnStartStop = new System.Windows.Forms.Button();
            this.lblGameLongDate = new System.Windows.Forms.Label();
            this.lblTimeLapsed = new System.Windows.Forms.Label();
            this.grpBxSettings = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblInfo1 = new System.Windows.Forms.Label();
            this.txtBoxYearLapse = new NumericTextBox();
            this.txtBoxMonthLapse = new NumericTextBox();
            this.txtBoxDayLapse = new NumericTextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblLumberMill = new System.Windows.Forms.Label();
            this.lblCourt = new System.Windows.Forms.Label();
            this.lblThief = new System.Windows.Forms.Label();
            this.grpBxSettings.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblDateSplash
            // 
            this.lblDateSplash.AutoSize = true;
            this.lblDateSplash.Location = new System.Drawing.Point(12, 264);
            this.lblDateSplash.Name = "lblDateSplash";
            this.lblDateSplash.Size = new System.Drawing.Size(78, 15);
            this.lblDateSplash.TabIndex = 0;
            this.lblDateSplash.Text = "lblDateSplash";
            // 
            // btnStartStop
            // 
            this.btnStartStop.Location = new System.Drawing.Point(14, 137);
            this.btnStartStop.Name = "btnStartStop";
            this.btnStartStop.Size = new System.Drawing.Size(110, 48);
            this.btnStartStop.TabIndex = 1;
            this.btnStartStop.Text = "btnStartStop";
            this.btnStartStop.UseVisualStyleBackColor = true;
            this.btnStartStop.Click += new System.EventHandler(this.btnStartStop_Click);
            // 
            // lblGameLongDate
            // 
            this.lblGameLongDate.AutoSize = true;
            this.lblGameLongDate.Location = new System.Drawing.Point(12, 233);
            this.lblGameLongDate.Name = "lblGameLongDate";
            this.lblGameLongDate.Size = new System.Drawing.Size(102, 15);
            this.lblGameLongDate.TabIndex = 0;
            this.lblGameLongDate.Text = "lblGameLongDate";
            // 
            // lblTimeLapsed
            // 
            this.lblTimeLapsed.AutoSize = true;
            this.lblTimeLapsed.Location = new System.Drawing.Point(12, 205);
            this.lblTimeLapsed.Name = "lblTimeLapsed";
            this.lblTimeLapsed.Size = new System.Drawing.Size(83, 15);
            this.lblTimeLapsed.TabIndex = 0;
            this.lblTimeLapsed.Text = "lblTimeLapsed";
            // 
            // grpBxSettings
            // 
            this.grpBxSettings.Controls.Add(this.label2);
            this.grpBxSettings.Controls.Add(this.label1);
            this.grpBxSettings.Controls.Add(this.lblInfo1);
            this.grpBxSettings.Controls.Add(this.txtBoxYearLapse);
            this.grpBxSettings.Controls.Add(this.txtBoxMonthLapse);
            this.grpBxSettings.Controls.Add(this.txtBoxDayLapse);
            this.grpBxSettings.Location = new System.Drawing.Point(12, 14);
            this.grpBxSettings.Name = "grpBxSettings";
            this.grpBxSettings.Size = new System.Drawing.Size(216, 117);
            this.grpBxSettings.TabIndex = 2;
            this.grpBxSettings.TabStop = false;
            this.grpBxSettings.Text = "Settings";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(128, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "Year Lapse in Months : ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "Month lapse in Days :";
            // 
            // lblInfo1
            // 
            this.lblInfo1.AutoSize = true;
            this.lblInfo1.Location = new System.Drawing.Point(10, 23);
            this.lblInfo1.Name = "lblInfo1";
            this.lblInfo1.Size = new System.Drawing.Size(122, 15);
            this.lblInfo1.TabIndex = 3;
            this.lblInfo1.Text = "Day lapse in seconds :";
            // 
            // txtBoxYearLapse
            // 
            this.txtBoxYearLapse.Location = new System.Drawing.Point(138, 78);
            this.txtBoxYearLapse.Name = "txtBoxYearLapse";
            this.txtBoxYearLapse.Size = new System.Drawing.Size(54, 23);
            this.txtBoxYearLapse.TabIndex = 2;
            this.txtBoxYearLapse.Text = "4";
            // 
            // txtBoxMonthLapse
            // 
            this.txtBoxMonthLapse.Location = new System.Drawing.Point(138, 49);
            this.txtBoxMonthLapse.Name = "txtBoxMonthLapse";
            this.txtBoxMonthLapse.Size = new System.Drawing.Size(54, 23);
            this.txtBoxMonthLapse.TabIndex = 2;
            this.txtBoxMonthLapse.Text = "7";
            // 
            // txtBoxDayLapse
            // 
            this.txtBoxDayLapse.Location = new System.Drawing.Point(138, 20);
            this.txtBoxDayLapse.Name = "txtBoxDayLapse";
            this.txtBoxDayLapse.Size = new System.Drawing.Size(54, 23);
            this.txtBoxDayLapse.TabIndex = 2;
            this.txtBoxDayLapse.Text = "24";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::MainForm.Properties.Resources.TownPixel;
            this.pictureBox1.Location = new System.Drawing.Point(354, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(375, 317);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // lblLumberMill
            // 
            this.lblLumberMill.AutoSize = true;
            this.lblLumberMill.Location = new System.Drawing.Point(397, 273);
            this.lblLumberMill.Name = "lblLumberMill";
            this.lblLumberMill.Size = new System.Drawing.Size(68, 15);
            this.lblLumberMill.TabIndex = 4;
            this.lblLumberMill.Text = "LumberMill";
            // 
            // lblCourt
            // 
            this.lblCourt.AutoSize = true;
            this.lblCourt.Location = new System.Drawing.Point(384, 137);
            this.lblCourt.Name = "lblCourt";
            this.lblCourt.Size = new System.Drawing.Size(56, 15);
            this.lblCourt.TabIndex = 4;
            this.lblCourt.Text = "Courthall";
            // 
            // lblThief
            // 
            this.lblThief.AutoSize = true;
            this.lblThief.Location = new System.Drawing.Point(646, 92);
            this.lblThief.Name = "lblThief";
            this.lblThief.Size = new System.Drawing.Size(54, 15);
            this.lblThief.TabIndex = 4;
            this.lblThief.Text = "ThiefDen";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(741, 351);
            this.Controls.Add(this.lblThief);
            this.Controls.Add(this.lblCourt);
            this.Controls.Add(this.lblLumberMill);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.grpBxSettings);
            this.Controls.Add(this.lblTimeLapsed);
            this.Controls.Add(this.lblGameLongDate);
            this.Controls.Add(this.lblDateSplash);
            this.Controls.Add(this.btnStartStop);
            this.Name = "MainForm";
            this.Text = "Form1";
            this.grpBxSettings.ResumeLayout(false);
            this.grpBxSettings.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDateSplash;
        private System.Windows.Forms.Button btnStartStop;
        private System.Windows.Forms.Label lblGameLongDate;
        private System.Windows.Forms.Label lblTimeLapsed;
        private System.Windows.Forms.GroupBox grpBxSettings;
        private NumericTextBox txtBoxDayLapse;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblInfo1;
        private NumericTextBox txtBoxYearLapse;
        private NumericTextBox txtBoxMonthLapse;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblLumberMill;
        private System.Windows.Forms.Label lblCourt;
        private System.Windows.Forms.Label lblThief;
    }
}

