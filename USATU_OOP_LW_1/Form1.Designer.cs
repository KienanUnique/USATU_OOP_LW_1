namespace USATU_OOP_LW_1
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
            this.labelMousePositionInfo = new System.Windows.Forms.Label();
            this.labelKeyPressInfo = new System.Windows.Forms.Label();
            this.labelMouseClickInfo = new System.Windows.Forms.Label();
            this.groupBoxColorText = new System.Windows.Forms.GroupBox();
            this.labelToColor = new System.Windows.Forms.Label();
            this.radioButtonBlue = new System.Windows.Forms.RadioButton();
            this.radioButtonGreen = new System.Windows.Forms.RadioButton();
            this.radioButtonRed = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.groupBoxPressKeyCheck = new System.Windows.Forms.GroupBox();
            this.textBoxKeyPressChecker = new System.Windows.Forms.TextBox();
            this.timerSecondsFromStart = new System.Timers.Timer();
            this.labelCountOfTicks = new System.Windows.Forms.Label();
            this.groupBoxColorText.SuspendLayout();
            this.groupBoxPressKeyCheck.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize) (this.timerSecondsFromStart)).BeginInit();
            this.SuspendLayout();
            // 
            // labelMousePositionInfo
            // 
            this.labelMousePositionInfo.Location = new System.Drawing.Point(12, 9);
            this.labelMousePositionInfo.Name = "labelMousePositionInfo";
            this.labelMousePositionInfo.Size = new System.Drawing.Size(157, 23);
            this.labelMousePositionInfo.TabIndex = 1;
            this.labelMousePositionInfo.Text = "Wating for mouse position";
            // 
            // labelKeyPressInfo
            // 
            this.labelKeyPressInfo.Location = new System.Drawing.Point(6, 42);
            this.labelKeyPressInfo.Name = "labelKeyPressInfo";
            this.labelKeyPressInfo.Size = new System.Drawing.Size(180, 23);
            this.labelKeyPressInfo.TabIndex = 1;
            this.labelKeyPressInfo.Text = "Wating for key press";
            this.labelKeyPressInfo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelMouseClickInfo
            // 
            this.labelMouseClickInfo.Location = new System.Drawing.Point(12, 32);
            this.labelMouseClickInfo.Name = "labelMouseClickInfo";
            this.labelMouseClickInfo.Size = new System.Drawing.Size(157, 23);
            this.labelMouseClickInfo.TabIndex = 1;
            this.labelMouseClickInfo.Text = "Wating for mouse clicks";
            // 
            // groupBoxColorText
            // 
            this.groupBoxColorText.Controls.Add(this.labelToColor);
            this.groupBoxColorText.Controls.Add(this.radioButtonBlue);
            this.groupBoxColorText.Controls.Add(this.radioButtonGreen);
            this.groupBoxColorText.Controls.Add(this.radioButtonRed);
            this.groupBoxColorText.Location = new System.Drawing.Point(348, 99);
            this.groupBoxColorText.Name = "groupBoxColorText";
            this.groupBoxColorText.Size = new System.Drawing.Size(157, 114);
            this.groupBoxColorText.TabIndex = 2;
            this.groupBoxColorText.TabStop = false;
            this.groupBoxColorText.Text = "Select color";
            // 
            // labelToColor
            // 
            this.labelToColor.Location = new System.Drawing.Point(77, 18);
            this.labelToColor.Name = "labelToColor";
            this.labelToColor.Size = new System.Drawing.Size(66, 87);
            this.labelToColor.TabIndex = 1;
            this.labelToColor.Text = "Hello";
            this.labelToColor.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // radioButtonBlue
            // 
            this.radioButtonBlue.ForeColor = System.Drawing.Color.Blue;
            this.radioButtonBlue.Location = new System.Drawing.Point(6, 79);
            this.radioButtonBlue.Name = "radioButtonBlue";
            this.radioButtonBlue.Size = new System.Drawing.Size(65, 24);
            this.radioButtonBlue.TabIndex = 0;
            this.radioButtonBlue.TabStop = true;
            this.radioButtonBlue.Text = "Blue";
            this.radioButtonBlue.UseVisualStyleBackColor = true;
            this.radioButtonBlue.CheckedChanged += new System.EventHandler(this.radioButtonBlue_CheckedChanged);
            // 
            // radioButtonGreen
            // 
            this.radioButtonGreen.ForeColor = System.Drawing.Color.Lime;
            this.radioButtonGreen.Location = new System.Drawing.Point(6, 49);
            this.radioButtonGreen.Name = "radioButtonGreen";
            this.radioButtonGreen.Size = new System.Drawing.Size(65, 24);
            this.radioButtonGreen.TabIndex = 0;
            this.radioButtonGreen.TabStop = true;
            this.radioButtonGreen.Text = "Green";
            this.radioButtonGreen.UseVisualStyleBackColor = true;
            this.radioButtonGreen.CheckedChanged += new System.EventHandler(this.radioButtonGreen_CheckedChanged);
            // 
            // radioButtonRed
            // 
            this.radioButtonRed.ForeColor = System.Drawing.Color.Red;
            this.radioButtonRed.Location = new System.Drawing.Point(6, 19);
            this.radioButtonRed.Name = "radioButtonRed";
            this.radioButtonRed.Size = new System.Drawing.Size(65, 24);
            this.radioButtonRed.TabIndex = 0;
            this.radioButtonRed.TabStop = true;
            this.radioButtonRed.Text = "Red";
            this.radioButtonRed.UseVisualStyleBackColor = true;
            this.radioButtonRed.CheckedChanged += new System.EventHandler(this.radioButtonRed_CheckedChanged);
            // 
            // radioButton2
            // 
            this.radioButton2.Location = new System.Drawing.Point(0, 0);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(104, 24);
            this.radioButton2.TabIndex = 0;
            // 
            // radioButton3
            // 
            this.radioButton3.Location = new System.Drawing.Point(0, 0);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(104, 24);
            this.radioButton3.TabIndex = 0;
            // 
            // groupBoxPressKeyCheck
            // 
            this.groupBoxPressKeyCheck.Controls.Add(this.textBoxKeyPressChecker);
            this.groupBoxPressKeyCheck.Controls.Add(this.labelKeyPressInfo);
            this.groupBoxPressKeyCheck.Location = new System.Drawing.Point(313, 12);
            this.groupBoxPressKeyCheck.Name = "groupBoxPressKeyCheck";
            this.groupBoxPressKeyCheck.Size = new System.Drawing.Size(192, 81);
            this.groupBoxPressKeyCheck.TabIndex = 3;
            this.groupBoxPressKeyCheck.TabStop = false;
            this.groupBoxPressKeyCheck.Text = "Press Key Check";
            // 
            // textBoxKeyPressChecker
            // 
            this.textBoxKeyPressChecker.Location = new System.Drawing.Point(6, 19);
            this.textBoxKeyPressChecker.Name = "textBoxKeyPressChecker";
            this.textBoxKeyPressChecker.Size = new System.Drawing.Size(180, 20);
            this.textBoxKeyPressChecker.TabIndex = 2;
            this.textBoxKeyPressChecker.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Form1_KeyPress);
            // 
            // timerSecondsFromStart
            // 
            this.timerSecondsFromStart.Enabled = true;
            this.timerSecondsFromStart.Interval = 1000D;
            this.timerSecondsFromStart.SynchronizingObject = this;
            this.timerSecondsFromStart.Elapsed += new System.Timers.ElapsedEventHandler(this.timerSecondsFromStart_Elapsed);
            // 
            // labelCountOfTicks
            // 
            this.labelCountOfTicks.Location = new System.Drawing.Point(12, 54);
            this.labelCountOfTicks.Name = "labelCountOfTicks";
            this.labelCountOfTicks.Size = new System.Drawing.Size(157, 23);
            this.labelCountOfTicks.TabIndex = 1;
            this.labelCountOfTicks.Text = "Count of ticks: 0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(517, 450);
            this.Controls.Add(this.groupBoxPressKeyCheck);
            this.Controls.Add(this.groupBoxColorText);
            this.Controls.Add(this.labelCountOfTicks);
            this.Controls.Add(this.labelMouseClickInfo);
            this.Controls.Add(this.labelMousePositionInfo);
            this.Location = new System.Drawing.Point(15, 15);
            this.Name = "Form1";
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseClick);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseMove);
            this.groupBoxColorText.ResumeLayout(false);
            this.groupBoxPressKeyCheck.ResumeLayout(false);
            this.groupBoxPressKeyCheck.PerformLayout();
            ((System.ComponentModel.ISupportInitialize) (this.timerSecondsFromStart)).EndInit();
            this.ResumeLayout(false);
        }

        private System.Timers.Timer timerSecondsFromStart;
        private System.Windows.Forms.Label labelCountOfTicks;

        private System.Windows.Forms.TextBox textBoxKeyPressChecker;

        private System.Windows.Forms.GroupBox groupBoxPressKeyCheck;

        private System.Windows.Forms.RadioButton radioButtonGreen;
        private System.Windows.Forms.RadioButton radioButtonBlue;
        private System.Windows.Forms.Label labelToColor;

        private System.Windows.Forms.GroupBox groupBoxColorText;

        private System.Windows.Forms.RadioButton radioButtonRed;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton3;

        private System.Windows.Forms.Label labelMouseClickInfo;

        private System.Windows.Forms.Label labelMousePositionInfo;

        private System.Windows.Forms.Label labelKeyPressInfo;

        private System.Windows.Forms.TextBox textBoxMousePositionInfo;
        private System.Windows.Forms.TextBox textBoxMouseClickInfo;
        private System.Windows.Forms.TextBox textBoxKeyPressInfo;

        #endregion
    }
}