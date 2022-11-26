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
            this.attendanceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
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
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.pmWorkingTime_txt = new System.Windows.Forms.TextBox();
            this.amWorkingTime_txt = new System.Windows.Forms.TextBox();
            this.actualTime_txt = new System.Windows.Forms.TextBox();
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
            this.menuStrip1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.employeeIn4_grid)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.attendanceToolStripMenuItem,
            this.menuToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1194, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // attendanceToolStripMenuItem
            // 
            this.attendanceToolStripMenuItem.Name = "attendanceToolStripMenuItem";
            this.attendanceToolStripMenuItem.Size = new System.Drawing.Size(99, 24);
            this.attendanceToolStripMenuItem.Text = "Attendance";
            // 
            // menuToolStripMenuItem
            // 
            this.menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            this.menuToolStripMenuItem.Size = new System.Drawing.Size(60, 24);
            this.menuToolStripMenuItem.Text = "Menu";
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
            this.panel1.Controls.Add(this.dateTimePicker1);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.pmWorkingTime_txt);
            this.panel1.Controls.Add(this.amWorkingTime_txt);
            this.panel1.Controls.Add(this.actualTime_txt);
            this.panel1.Location = new System.Drawing.Point(838, 245);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(318, 351);
            this.panel1.TabIndex = 4;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(16, 189);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 22);
            this.dateTimePicker1.TabIndex = 6;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(3, 137);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(72, 24);
            this.label6.TabIndex = 5;
            this.label6.Text = "pm.WT";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(3, 77);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 24);
            this.label5.TabIndex = 4;
            this.label5.Text = "am.WT";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(3, 16);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 24);
            this.label4.TabIndex = 3;
            this.label4.Text = "Time";
            // 
            // pmWorkingTime_txt
            // 
            this.pmWorkingTime_txt.Location = new System.Drawing.Point(84, 139);
            this.pmWorkingTime_txt.Name = "pmWorkingTime_txt";
            this.pmWorkingTime_txt.Size = new System.Drawing.Size(226, 22);
            this.pmWorkingTime_txt.TabIndex = 2;
            // 
            // amWorkingTime_txt
            // 
            this.amWorkingTime_txt.Location = new System.Drawing.Point(84, 77);
            this.amWorkingTime_txt.Name = "amWorkingTime_txt";
            this.amWorkingTime_txt.Size = new System.Drawing.Size(226, 22);
            this.amWorkingTime_txt.TabIndex = 1;
            // 
            // actualTime_txt
            // 
            this.actualTime_txt.Location = new System.Drawing.Point(84, 16);
            this.actualTime_txt.Name = "actualTime_txt";
            this.actualTime_txt.Size = new System.Drawing.Size(226, 22);
            this.actualTime_txt.TabIndex = 0;
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
            // formMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1194, 630);
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
        private System.Windows.Forms.ToolStripMenuItem attendanceToolStripMenuItem;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.ToolStripMenuItem menuToolStripMenuItem;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox pmWorkingTime_txt;
        private System.Windows.Forms.TextBox amWorkingTime_txt;
        private System.Windows.Forms.TextBox actualTime_txt;
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
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
    }
}