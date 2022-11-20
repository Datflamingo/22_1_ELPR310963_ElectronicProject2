namespace DA2_CHAM_CONG.Forms
{
    partial class formManagement
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.AddEmployee = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.label8 = new System.Windows.Forms.Label();
            this.id1_txt = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.id2_txt = new System.Windows.Forms.TextBox();
            this.id3_txt = new System.Windows.Forms.TextBox();
            this.id4_txt = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.AddEmployee.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.SuspendLayout();
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
            this.panel2.Location = new System.Drawing.Point(836, 49);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(319, 186);
            this.panel2.TabIndex = 3;
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
            this.panel1.Location = new System.Drawing.Point(837, 241);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(318, 351);
            this.panel1.TabIndex = 5;
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
            this.panel3.Controls.Add(this.tabControl1);
            this.panel3.Location = new System.Drawing.Point(41, 49);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(789, 543);
            this.panel3.TabIndex = 6;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.AddEmployee);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(786, 543);
            this.tabControl1.TabIndex = 0;
            // 
            // AddEmployee
            // 
            this.AddEmployee.Controls.Add(this.label7);
            this.AddEmployee.Controls.Add(this.label8);
            this.AddEmployee.Controls.Add(this.id1_txt);
            this.AddEmployee.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddEmployee.Location = new System.Drawing.Point(4, 25);
            this.AddEmployee.Name = "AddEmployee";
            this.AddEmployee.Padding = new System.Windows.Forms.Padding(3);
            this.AddEmployee.Size = new System.Drawing.Size(778, 514);
            this.AddEmployee.TabIndex = 0;
            this.AddEmployee.Text = "Add Employee";
            this.AddEmployee.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.label9);
            this.tabPage2.Controls.Add(this.id2_txt);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(778, 514);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Edit Employee";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.label10);
            this.tabPage1.Controls.Add(this.id3_txt);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(778, 514);
            this.tabPage1.TabIndex = 2;
            this.tabPage1.Text = "Remove Employee";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.label11);
            this.tabPage3.Controls.Add(this.id4_txt);
            this.tabPage3.Location = new System.Drawing.Point(4, 25);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(778, 514);
            this.tabPage3.TabIndex = 3;
            this.tabPage3.Text = "Inventory";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(177, 90);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(112, 24);
            this.label8.TabIndex = 5;
            this.label8.Text = "Empoyee Id";
            // 
            // id1_txt
            // 
            this.id1_txt.Location = new System.Drawing.Point(330, 90);
            this.id1_txt.Name = "id1_txt";
            this.id1_txt.Size = new System.Drawing.Size(265, 28);
            this.id1_txt.TabIndex = 4;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label7.Location = new System.Drawing.Point(214, 42);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(347, 29);
            this.label7.TabIndex = 6;
            this.label7.Text = "EMPLOYEE ATTENDANCE";
            // 
            // id2_txt
            // 
            this.id2_txt.Location = new System.Drawing.Point(257, 246);
            this.id2_txt.Name = "id2_txt";
            this.id2_txt.Size = new System.Drawing.Size(265, 22);
            this.id2_txt.TabIndex = 5;
            // 
            // id3_txt
            // 
            this.id3_txt.Location = new System.Drawing.Point(257, 246);
            this.id3_txt.Name = "id3_txt";
            this.id3_txt.Size = new System.Drawing.Size(265, 22);
            this.id3_txt.TabIndex = 6;
            // 
            // id4_txt
            // 
            this.id4_txt.Location = new System.Drawing.Point(257, 246);
            this.id4_txt.Name = "id4_txt";
            this.id4_txt.Size = new System.Drawing.Size(265, 22);
            this.id4_txt.TabIndex = 6;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label9.Location = new System.Drawing.Point(219, 50);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(347, 29);
            this.label9.TabIndex = 7;
            this.label9.Text = "EMPLOYEE ATTENDANCE";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label10.Location = new System.Drawing.Point(221, 42);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(347, 29);
            this.label10.TabIndex = 7;
            this.label10.Text = "EMPLOYEE ATTENDANCE";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label11.Location = new System.Drawing.Point(295, 50);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(166, 29);
            this.label11.TabIndex = 7;
            this.label11.Text = "INVENTORY";
            // 
            // formManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1194, 630);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Name = "formManagement";
            this.Text = "Management";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.AddEmployee.ResumeLayout(false);
            this.AddEmployee.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label cnnStatus_label;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button discnn_Button;
        private System.Windows.Forms.Button cnn_Button;
        private System.Windows.Forms.ComboBox baudRate_cbBox;
        private System.Windows.Forms.ComboBox comPort_cbBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox pmWorkingTime_txt;
        private System.Windows.Forms.TextBox amWorkingTime_txt;
        private System.Windows.Forms.TextBox actualTime_txt;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage AddEmployee;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage3;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox id1_txt;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox id2_txt;
        private System.Windows.Forms.TextBox id3_txt;
        private System.Windows.Forms.TextBox id4_txt;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
    }
}