namespace MyPomodoroClock
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.baslatButton = new System.Windows.Forms.Button();
            this.calismaSuresiComboBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.molaComboBox = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tekrarlaCheckBox = new System.Windows.Forms.CheckBox();
            this.myTimer = new System.Windows.Forms.Timer(this.components);
            this.molaTimer = new System.Windows.Forms.Timer(this.components);
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.labelText = new System.Windows.Forms.Label();
            this.lblDk = new System.Windows.Forms.Label();
            this.lblSn = new System.Windows.Forms.Label();
            this.labelTimer = new System.Windows.Forms.Timer(this.components);
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // baslatButton
            // 
            this.baslatButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.baslatButton.Location = new System.Drawing.Point(377, 79);
            this.baslatButton.Name = "baslatButton";
            this.baslatButton.Size = new System.Drawing.Size(107, 34);
            this.baslatButton.TabIndex = 0;
            this.baslatButton.Text = "Başlat";
            this.baslatButton.UseVisualStyleBackColor = true;
            this.baslatButton.Click += new System.EventHandler(this.baslatButton_Click);
            // 
            // calismaSuresiComboBox
            // 
            this.calismaSuresiComboBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.calismaSuresiComboBox.FormattingEnabled = true;
            this.calismaSuresiComboBox.Items.AddRange(new object[] {
            "2-DAKİKA",
            "25-DAKİKA",
            "30-DAKİKA",
            "35-DAKİKA",
            "40-DAKİKA",
            "45-DAKİKA",
            "50-DAKİKA"});
            this.calismaSuresiComboBox.Location = new System.Drawing.Point(152, 84);
            this.calismaSuresiComboBox.Name = "calismaSuresiComboBox";
            this.calismaSuresiComboBox.Size = new System.Drawing.Size(114, 29);
            this.calismaSuresiComboBox.TabIndex = 1;
            this.calismaSuresiComboBox.SelectedIndexChanged += new System.EventHandler(this.calismaSuresiComboBox_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(22, 86);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 21);
            this.label1.TabIndex = 2;
            this.label1.Text = "Çalışma Süresi:";
            // 
            // molaComboBox
            // 
            this.molaComboBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.molaComboBox.FormattingEnabled = true;
            this.molaComboBox.Items.AddRange(new object[] {
            "1-DAKİKA",
            "5-DAKİKA",
            "10-DAKİKA",
            "15-DAKİKA",
            "20-DAKİKA"});
            this.molaComboBox.Location = new System.Drawing.Point(152, 150);
            this.molaComboBox.Name = "molaComboBox";
            this.molaComboBox.Size = new System.Drawing.Size(114, 29);
            this.molaComboBox.TabIndex = 1;
            this.molaComboBox.SelectedIndexChanged += new System.EventHandler(this.molaComboBox_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(22, 153);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 21);
            this.label2.TabIndex = 2;
            this.label2.Text = "Mola Süresi:";
            // 
            // tekrarlaCheckBox
            // 
            this.tekrarlaCheckBox.AutoSize = true;
            this.tekrarlaCheckBox.Location = new System.Drawing.Point(355, 154);
            this.tekrarlaCheckBox.Name = "tekrarlaCheckBox";
            this.tekrarlaCheckBox.Size = new System.Drawing.Size(104, 19);
            this.tekrarlaCheckBox.TabIndex = 3;
            this.tekrarlaCheckBox.Text = "Sürekli Tekrarla";
            this.tekrarlaCheckBox.UseVisualStyleBackColor = true;
            // 
            // myTimer
            // 
            this.myTimer.Tick += new System.EventHandler(this.TimerEventProcessor);
            // 
            // molaTimer
            // 
            this.molaTimer.Tick += new System.EventHandler(this.TimerEventProcessorMola);
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.notifyIcon1.BalloonTipTitle = "Pomodoro Tekniği";
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "notifyIcon1";
            this.notifyIcon1.Visible = true;
            // 
            // labelText
            // 
            this.labelText.AutoSize = true;
            this.labelText.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelText.Location = new System.Drawing.Point(22, 230);
            this.labelText.Name = "labelText";
            this.labelText.Size = new System.Drawing.Size(101, 30);
            this.labelText.TabIndex = 4;
            this.labelText.Text = "labelText";
            // 
            // lblDk
            // 
            this.lblDk.AutoSize = true;
            this.lblDk.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblDk.Location = new System.Drawing.Point(376, 228);
            this.lblDk.Name = "lblDk";
            this.lblDk.Size = new System.Drawing.Size(61, 32);
            this.lblDk.TabIndex = 4;
            this.lblDk.Text = "lblD";
            // 
            // lblSn
            // 
            this.lblSn.AutoSize = true;
            this.lblSn.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblSn.Location = new System.Drawing.Point(428, 228);
            this.lblSn.Name = "lblSn";
            this.lblSn.Size = new System.Drawing.Size(56, 32);
            this.lblSn.TabIndex = 4;
            this.lblSn.Text = "lblS";
            // 
            // labelTimer
            // 
            this.labelTimer.Tick += new System.EventHandler(this.labelTimer_Tick);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(412, 228);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(21, 32);
            this.label3.TabIndex = 4;
            this.label3.Text = ":";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblSn);
            this.Controls.Add(this.lblDk);
            this.Controls.Add(this.labelText);
            this.Controls.Add(this.tekrarlaCheckBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.molaComboBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.calismaSuresiComboBox);
            this.Controls.Add(this.baslatButton);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Pomodoro Tekniği";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button baslatButton;
        private System.Windows.Forms.ComboBox calismaSuresiComboBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox molaComboBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox tekrarlaCheckBox;
        private System.Windows.Forms.Timer myTimer;
        private System.Windows.Forms.Timer molaTimer;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.Label labelText;
        private System.Windows.Forms.Label lblDk;
        private System.Windows.Forms.Label lblSn;
        private System.Windows.Forms.Timer showTimer;
        private System.Windows.Forms.Timer labelTimer;
        private System.Windows.Forms.Label label3;
    }
}

