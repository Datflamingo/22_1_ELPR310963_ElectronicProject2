namespace DA2_CHAM_CONG.Forms
{
    partial class formMain
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.panel2 = new System.Windows.Forms.Panel();
            this.cnnStatus_label = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.discnn_Button = new System.Windows.Forms.Button();
            this.cnn_Button = new System.Windows.Forms.Button();
            this.baudRate_cbBox = new System.Windows.Forms.ComboBox();
            this.comPort_cbBox = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.second_txt = new System.Windows.Forms.TextBox();
            this.minute_txt = new System.Windows.Forms.TextBox();
            this.hour_txt = new System.Windows.Forms.TextBox();
            this.day_txt = new System.Windows.Forms.TextBox();
            this.month_txt = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.year_txt = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label10 = new System.Windows.Forms.Label();
            this.employeeIn4_grid = new System.Windows.Forms.DataGridView();
            this.label7 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.timeCheckIn_txt = new System.Windows.Forms.TextBox();
            this.id_txt = new System.Windows.Forms.TextBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.pmWorkingTime_txt = new System.Windows.Forms.TextBox();
            this.amWorkingTime_txt = new System.Windows.Forms.TextBox();
            this.setTime_btn = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.employeeIn4_grid)).BeginInit();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1194, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuToolStripMenuItem
            // 
            this.menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            this.menuToolStripMenuItem.Size = new System.Drawing.Size(60, 24);
            this.menuToolStripMenuItem.Text = "Menu";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(55, 24);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(225, 26);
            this.toolStripMenuItem1.Text = "toolStripMenuItem1";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel2.Controls.Add(this.cnnStatus_label);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.discnn_Button);
            this.panel2.Controls.Add(this.cnn_Button);
            this.panel2.Controls.Add(this.baudRate_cbBox);
            this.panel2.Controls.Add(this.comPort_cbBox);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(838, 53);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(319, 186);
            this.panel2.TabIndex = 2;
            // 
            // cnnStatus_label
            // 
            this.cnnStatus_label.AutoSize = true;
            this.cnnStatus_label.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.cnnStatus_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cnnStatus_label.ForeColor = System.Drawing.Color.Red;
            this.cnnStatus_label.Location = new System.Drawing.Point(145, 138);
            this.cnnStatus_label.Name = "cnnStatus_label";
            this.cnnStatus_label.Size = new System.Drawing.Size(126, 24);
            this.cnnStatus_label.TabIndex = 7;
            this.cnnStatus_label.Text = "Disconnected";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(3, 138);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(136, 24);
            this.label3.TabIndex = 6;
            this.label3.Text = "Connect Status";
            // 
            // discnn_Button
            // 
            this.discnn_Button.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.discnn_Button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.discnn_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.discnn_Button.Location = new System.Drawing.Point(151, 67);
            this.discnn_Button.Name = "discnn_Button";
            this.discnn_Button.Size = new System.Drawing.Size(159, 51);
            this.discnn_Button.TabIndex = 5;
            this.discnn_Button.Text = "Disconnect";
            this.discnn_Button.UseVisualStyleBackColor = false;
            this.discnn_Button.Click += new System.EventHandler(this.discnn_Button_Click);
            // 
            // cnn_Button
            // 
            this.cnn_Button.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.cnn_Button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cnn_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cnn_Button.Location = new System.Drawing.Point(7, 67);
            this.cnn_Button.Name = "cnn_Button";
            this.cnn_Button.Size = new System.Drawing.Size(138, 52);
            this.cnn_Button.TabIndex = 4;
            this.cnn_Button.Text = "Connect";
            this.cnn_Button.UseVisualStyleBackColor = false;
            this.cnn_Button.Click += new System.EventHandler(this.cnn_Button_Click);
            // 
            // baudRate_cbBox
            // 
            this.baudRate_cbBox.FormattingEnabled = true;
            this.baudRate_cbBox.Location = new System.Drawing.Point(101, 37);
            this.baudRate_cbBox.Name = "baudRate_cbBox";
            this.baudRate_cbBox.Size = new System.Drawing.Size(209, 24);
            this.baudRate_cbBox.TabIndex = 3;
            // 
            // comPort_cbBox
            // 
            this.comPort_cbBox.FormattingEnabled = true;
            this.comPort_cbBox.Location = new System.Drawing.Point(101, 11);
            this.comPort_cbBox.Name = "comPort_cbBox";
            this.comPort_cbBox.Size = new System.Drawing.Size(209, 24);
            this.comPort_cbBox.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(3, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "Baud Rate";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "COM Port";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel1.Controls.Add(this.setTime_btn);
            this.panel1.Controls.Add(this.label16);
            this.panel1.Controls.Add(this.label15);
            this.panel1.Controls.Add(this.label14);
            this.panel1.Controls.Add(this.label13);
            this.panel1.Controls.Add(this.label12);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.second_txt);
            this.panel1.Controls.Add(this.minute_txt);
            this.panel1.Controls.Add(this.hour_txt);
            this.panel1.Controls.Add(this.day_txt);
            this.panel1.Controls.Add(this.month_txt);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.year_txt);
            this.panel1.Location = new System.Drawing.Point(838, 245);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(318, 245);
            this.panel1.TabIndex = 4;
            // 
            // second_txt
            // 
            this.second_txt.Location = new System.Drawing.Point(101, 179);
            this.second_txt.Name = "second_txt";
            this.second_txt.Size = new System.Drawing.Size(190, 22);
            this.second_txt.TabIndex = 11;
            // 
            // minute_txt
            // 
            this.minute_txt.Location = new System.Drawing.Point(101, 151);
            this.minute_txt.Name = "minute_txt";
            this.minute_txt.Size = new System.Drawing.Size(190, 22);
            this.minute_txt.TabIndex = 10;
            // 
            // hour_txt
            // 
            this.hour_txt.Location = new System.Drawing.Point(101, 123);
            this.hour_txt.Name = "hour_txt";
            this.hour_txt.Size = new System.Drawing.Size(190, 22);
            this.hour_txt.TabIndex = 9;
            // 
            // day_txt
            // 
            this.day_txt.Location = new System.Drawing.Point(101, 95);
            this.day_txt.Name = "day_txt";
            this.day_txt.Size = new System.Drawing.Size(190, 22);
            this.day_txt.TabIndex = 8;
            // 
            // month_txt
            // 
            this.month_txt.Location = new System.Drawing.Point(101, 67);
            this.month_txt.Name = "month_txt";
            this.month_txt.Size = new System.Drawing.Size(190, 22);
            this.month_txt.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(145, 12);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 24);
            this.label4.TabIndex = 3;
            this.label4.Text = "Time";
            // 
            // year_txt
            // 
            this.year_txt.Location = new System.Drawing.Point(101, 39);
            this.year_txt.Name = "year_txt";
            this.year_txt.Size = new System.Drawing.Size(190, 22);
            this.year_txt.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel3.Controls.Add(this.label10);
            this.panel3.Controls.Add(this.employeeIn4_grid);
            this.panel3.Controls.Add(this.label7);
            this.panel3.Controls.Add(this.label9);
            this.panel3.Controls.Add(this.label8);
            this.panel3.Controls.Add(this.timeCheckIn_txt);
            this.panel3.Controls.Add(this.id_txt);
            this.panel3.Location = new System.Drawing.Point(41, 53);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(791, 542);
            this.panel3.TabIndex = 5;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(39, 204);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(193, 24);
            this.label10.TabIndex = 7;
            this.label10.Text = "Employee Information";
            // 
            // employeeIn4_grid
            // 
            this.employeeIn4_grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.employeeIn4_grid.Location = new System.Drawing.Point(43, 231);
            this.employeeIn4_grid.Name = "employeeIn4_grid";
            this.employeeIn4_grid.RowHeadersWidth = 51;
            this.employeeIn4_grid.RowTemplate.Height = 24;
            this.employeeIn4_grid.Size = new System.Drawing.Size(717, 173);
            this.employeeIn4_grid.TabIndex = 6;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label7.Location = new System.Drawing.Point(234, 58);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(347, 29);
            this.label7.TabIndex = 5;
            this.label7.Text = "EMPLOYEE ATTENDANCE";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(189, 149);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(133, 24);
            this.label9.TabIndex = 4;
            this.label9.Text = "Check-in Time";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(189, 110);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(112, 24);
            this.label8.TabIndex = 3;
            this.label8.Text = "Empoyee Id";
            // 
            // timeCheckIn_txt
            // 
            this.timeCheckIn_txt.Location = new System.Drawing.Point(342, 149);
            this.timeCheckIn_txt.Name = "timeCheckIn_txt";
            this.timeCheckIn_txt.Size = new System.Drawing.Size(265, 22);
            this.timeCheckIn_txt.TabIndex = 1;
            // 
            // id_txt
            // 
            this.id_txt.Location = new System.Drawing.Point(342, 110);
            this.id_txt.Name = "id_txt";
            this.id_txt.Size = new System.Drawing.Size(265, 22);
            this.id_txt.TabIndex = 0;
            this.id_txt.TextChanged += new System.EventHandler(this.id_txt_TextChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(8, 45);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(44, 16);
            this.label11.TabIndex = 12;
            this.label11.Text = "YEAR";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(8, 70);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(57, 16);
            this.label12.TabIndex = 13;
            this.label12.Text = "MONTH";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(8, 98);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(35, 16);
            this.label13.TabIndex = 14;
            this.label13.Text = "DAY";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(8, 126);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(47, 16);
            this.label14.TabIndex = 15;
            this.label14.Text = "HOUR";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(10, 154);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(59, 16);
            this.label15.TabIndex = 16;
            this.label15.Text = "MINUTE";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(8, 185);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(64, 16);
            this.label16.TabIndex = 17;
            this.label16.Text = "SECOND";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel4.Controls.Add(this.label6);
            this.panel4.Controls.Add(this.label5);
            this.panel4.Controls.Add(this.pmWorkingTime_txt);
            this.panel4.Controls.Add(this.amWorkingTime_txt);
            this.panel4.Location = new System.Drawing.Point(838, 497);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(319, 98);
            this.panel4.TabIndex = 6;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(7, 50);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(72, 24);
            this.label6.TabIndex = 9;
            this.label6.Text = "pm.WT";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(8, 25);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 24);
            this.label5.TabIndex = 8;
            this.label5.Text = "am.WT";
            // 
            // pmWorkingTime_txt
            // 
            this.pmWorkingTime_txt.Location = new System.Drawing.Point(85, 52);
            this.pmWorkingTime_txt.Name = "pmWorkingTime_txt";
            this.pmWorkingTime_txt.Size = new System.Drawing.Size(226, 22);
            this.pmWorkingTime_txt.TabIndex = 7;
            // 
            // amWorkingTime_txt
            // 
            this.amWorkingTime_txt.Location = new System.Drawing.Point(85, 24);
            this.amWorkingTime_txt.Name = "amWorkingTime_txt";
            this.amWorkingTime_txt.Size = new System.Drawing.Size(226, 22);
            this.amWorkingTime_txt.TabIndex = 6;
            // 
            // setTime_btn
            // 
            this.setTime_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.setTime_btn.Location = new System.Drawing.Point(85, 208);
            this.setTime_btn.Name = "setTime_btn";
            this.setTime_btn.Size = new System.Drawing.Size(175, 34);
            this.setTime_btn.TabIndex = 18;
            this.setTime_btn.Text = "APPLY";
            this.setTime_btn.UseVisualStyleBackColor = true;
            this.setTime_btn.Click += new System.EventHandler(this.setTime_btn_Click);
            // 
            // formMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1194, 630);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "formMain";
            this.Text = "Main";
            this.Load += new System.EventHandler(this.formMain_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.employeeIn4_grid)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label cnnStatus_label;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button discnn_Button;
        private System.Windows.Forms.Button cnn_Button;
        private System.Windows.Forms.ComboBox baudRate_cbBox;
        private System.Windows.Forms.ComboBox comPort_cbBox;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.ToolStripMenuItem menuToolStripMenuItem;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox year_txt;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.TextBox id_txt;
        private System.Windows.Forms.DataGridView employeeIn4_grid;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox timeCheckIn_txt;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.TextBox second_txt;
        private System.Windows.Forms.TextBox minute_txt;
        private System.Windows.Forms.TextBox hour_txt;
        private System.Windows.Forms.TextBox day_txt;
        private System.Windows.Forms.TextBox month_txt;
        private System.Windows.Forms.Button setTime_btn;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox pmWorkingTime_txt;
        private System.Windows.Forms.TextBox amWorkingTime_txt;
    }
}