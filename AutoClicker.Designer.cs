namespace MyUtility
{
    partial class AutoClicker
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AutoClicker));
            this.myNotifyIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.grPositions = new System.Windows.Forms.GroupBox();
            this.btnSavePos = new System.Windows.Forms.Button();
            this.btnAddPos = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.grDelayTime = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.numSecond = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.numMinute = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.numHour = new System.Windows.Forms.NumericUpDown();
            this.btnRepeat = new System.Windows.Forms.Button();
            this.grPositions.SuspendLayout();
            this.grDelayTime.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numSecond)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMinute)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numHour)).BeginInit();
            this.SuspendLayout();
            // 
            // myNotifyIcon
            // 
            this.myNotifyIcon.Text = "notifyIcon1";
            this.myNotifyIcon.Visible = true;
            // 
            // grPositions
            // 
            this.grPositions.Controls.Add(this.btnSavePos);
            this.grPositions.Controls.Add(this.btnAddPos);
            this.grPositions.Controls.Add(this.textBox2);
            this.grPositions.Controls.Add(this.textBox1);
            this.grPositions.Controls.Add(this.label2);
            this.grPositions.Controls.Add(this.label1);
            this.grPositions.Location = new System.Drawing.Point(25, 17);
            this.grPositions.Name = "grPositions";
            this.grPositions.Size = new System.Drawing.Size(407, 123);
            this.grPositions.TabIndex = 0;
            this.grPositions.TabStop = false;
            this.grPositions.Text = "Positions ";
            // 
            // btnSavePos
            // 
            this.btnSavePos.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSavePos.Location = new System.Drawing.Point(273, 74);
            this.btnSavePos.Name = "btnSavePos";
            this.btnSavePos.Size = new System.Drawing.Size(110, 30);
            this.btnSavePos.TabIndex = 2;
            this.btnSavePos.Text = "Save (Shift + 1)";
            this.btnSavePos.UseVisualStyleBackColor = true;
            this.btnSavePos.Click += new System.EventHandler(this.btnSavePos_Click);
            // 
            // btnAddPos
            // 
            this.btnAddPos.Location = new System.Drawing.Point(273, 32);
            this.btnAddPos.Name = "btnAddPos";
            this.btnAddPos.Size = new System.Drawing.Size(110, 30);
            this.btnAddPos.TabIndex = 2;
            this.btnAddPos.Text = "Add";
            this.btnAddPos.UseVisualStyleBackColor = true;
            this.btnAddPos.Click += new System.EventHandler(this.btnAddPos_Click);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(52, 78);
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(196, 23);
            this.textBox2.TabIndex = 1;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(52, 35);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(196, 23);
            this.textBox1.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(17, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "Y";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "X";
            // 
            // grDelayTime
            // 
            this.grDelayTime.Controls.Add(this.label5);
            this.grDelayTime.Controls.Add(this.numSecond);
            this.grDelayTime.Controls.Add(this.label4);
            this.grDelayTime.Controls.Add(this.numMinute);
            this.grDelayTime.Controls.Add(this.label3);
            this.grDelayTime.Controls.Add(this.numHour);
            this.grDelayTime.Location = new System.Drawing.Point(25, 160);
            this.grDelayTime.Name = "grDelayTime";
            this.grDelayTime.Size = new System.Drawing.Size(407, 81);
            this.grDelayTime.TabIndex = 1;
            this.grDelayTime.TabStop = false;
            this.grDelayTime.Text = "Delay time between two repeat";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(339, 39);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 16);
            this.label5.TabIndex = 1;
            this.label5.Text = "second";
            // 
            // numSecond
            // 
            this.numSecond.Location = new System.Drawing.Point(274, 36);
            this.numSecond.Name = "numSecond";
            this.numSecond.Size = new System.Drawing.Size(53, 23);
            this.numSecond.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(206, 39);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 16);
            this.label4.TabIndex = 1;
            this.label4.Text = "minute";
            // 
            // numMinute
            // 
            this.numMinute.Location = new System.Drawing.Point(141, 36);
            this.numMinute.Name = "numMinute";
            this.numMinute.Size = new System.Drawing.Size(53, 23);
            this.numMinute.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(88, 39);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 16);
            this.label3.TabIndex = 1;
            this.label3.Text = "hour";
            // 
            // numHour
            // 
            this.numHour.Location = new System.Drawing.Point(24, 36);
            this.numHour.Name = "numHour";
            this.numHour.Size = new System.Drawing.Size(53, 23);
            this.numHour.TabIndex = 0;
            // 
            // btnRepeat
            // 
            this.btnRepeat.Location = new System.Drawing.Point(169, 261);
            this.btnRepeat.Name = "btnRepeat";
            this.btnRepeat.Size = new System.Drawing.Size(120, 30);
            this.btnRepeat.TabIndex = 2;
            this.btnRepeat.Text = "Repeat (Alt + 1)";
            this.btnRepeat.UseVisualStyleBackColor = true;
            this.btnRepeat.Click += new System.EventHandler(this.btnRepeat_Click);
            // 
            // AutoClicker
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(458, 313);
            this.Controls.Add(this.btnRepeat);
            this.Controls.Add(this.grDelayTime);
            this.Controls.Add(this.grPositions);
            this.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AutoClicker";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Auto Clicker";
            this.grPositions.ResumeLayout(false);
            this.grPositions.PerformLayout();
            this.grDelayTime.ResumeLayout(false);
            this.grDelayTime.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numSecond)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMinute)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numHour)).EndInit();
            this.ResumeLayout(false);

        }




        #endregion

        private System.Windows.Forms.NotifyIcon myNotifyIcon;
        private System.Windows.Forms.GroupBox grPositions;
        private System.Windows.Forms.Button btnSavePos;
        private System.Windows.Forms.Button btnAddPos;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox grDelayTime;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown numSecond;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown numMinute;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown numHour;
        private System.Windows.Forms.Button btnRepeat;
    }
}