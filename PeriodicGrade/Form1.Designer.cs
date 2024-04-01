namespace PeriodicGrade
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
            label1 = new Label();
            groupQuiz = new GroupBox();
            txtQuizN2 = new TextBox();
            label16 = new Label();
            txtQuizN1 = new TextBox();
            label15 = new Label();
            txtQuiz2 = new TextBox();
            txtQuiz1 = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label20 = new Label();
            label19 = new Label();
            txtLab1 = new TextBox();
            txtLab2 = new TextBox();
            label18 = new Label();
            txtLabN1 = new TextBox();
            label17 = new Label();
            txtLabN2 = new TextBox();
            groupLab = new GroupBox();
            txtLabN3 = new TextBox();
            label4 = new Label();
            txtLab3 = new TextBox();
            label5 = new Label();
            groupClass = new GroupBox();
            txtClassN3 = new TextBox();
            txtClassN2 = new TextBox();
            label6 = new Label();
            label7 = new Label();
            txtClass3 = new TextBox();
            txtClassN1 = new TextBox();
            label8 = new Label();
            label9 = new Label();
            txtClass2 = new TextBox();
            txtClass1 = new TextBox();
            label10 = new Label();
            label11 = new Label();
            groupExam = new GroupBox();
            label12 = new Label();
            label21 = new Label();
            txtExam = new TextBox();
            label23 = new Label();
            btnSub = new Button();
            btnClear = new Button();
            label22 = new Label();
            lblRemarks = new Label();
            label14 = new Label();
            label13 = new Label();
            lblPeriodicGrade = new Label();
            lblEquivalentGrade = new Label();
            groupBox5 = new GroupBox();
            label24 = new Label();
            groupQuiz.SuspendLayout();
            groupLab.SuspendLayout();
            groupClass.SuspendLayout();
            groupExam.SuspendLayout();
            groupBox5.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BorderStyle = BorderStyle.Fixed3D;
            label1.Font = new Font("Arial", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.FloralWhite;
            label1.Location = new Point(112, 9);
            label1.Name = "label1";
            label1.Size = new Size(310, 31);
            label1.TabIndex = 0;
            label1.Text = "Periodic Grade Calculator";
            // 
            // groupQuiz
            // 
            groupQuiz.Controls.Add(txtQuizN2);
            groupQuiz.Controls.Add(label16);
            groupQuiz.Controls.Add(txtQuizN1);
            groupQuiz.Controls.Add(label15);
            groupQuiz.Controls.Add(txtQuiz2);
            groupQuiz.Controls.Add(txtQuiz1);
            groupQuiz.Controls.Add(label3);
            groupQuiz.Controls.Add(label2);
            groupQuiz.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            groupQuiz.Location = new Point(12, 63);
            groupQuiz.Name = "groupQuiz";
            groupQuiz.Size = new Size(207, 165);
            groupQuiz.TabIndex = 1;
            groupQuiz.TabStop = false;
            groupQuiz.Text = "Quiz";
            groupQuiz.Enter += groupQuiz_Enter;
            // 
            // txtQuizN2
            // 
            txtQuizN2.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtQuizN2.Location = new Point(146, 98);
            txtQuizN2.Name = "txtQuizN2";
            txtQuizN2.Size = new Size(36, 27);
            txtQuizN2.TabIndex = 7;
            txtQuizN2.TextChanged += txtQuizN2_TextChanged;
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Font = new Font("Segoe UI", 12F, FontStyle.Italic, GraphicsUnit.Point);
            label16.Location = new Point(124, 100);
            label16.Name = "label16";
            label16.Size = new Size(16, 21);
            label16.TabIndex = 6;
            label16.Text = "/";
            // 
            // txtQuizN1
            // 
            txtQuizN1.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtQuizN1.Location = new Point(146, 49);
            txtQuizN1.Name = "txtQuizN1";
            txtQuizN1.Size = new Size(36, 27);
            txtQuizN1.TabIndex = 5;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new Font("Segoe UI", 12F, FontStyle.Italic, GraphicsUnit.Point);
            label15.Location = new Point(124, 51);
            label15.Name = "label15";
            label15.Size = new Size(16, 21);
            label15.TabIndex = 4;
            label15.Text = "/";
            // 
            // txtQuiz2
            // 
            txtQuiz2.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtQuiz2.Location = new Point(82, 96);
            txtQuiz2.Name = "txtQuiz2";
            txtQuiz2.Size = new Size(36, 27);
            txtQuiz2.TabIndex = 3;
            // 
            // txtQuiz1
            // 
            txtQuiz1.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtQuiz1.Location = new Point(82, 49);
            txtQuiz1.Name = "txtQuiz1";
            txtQuiz1.Size = new Size(36, 27);
            txtQuiz1.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(18, 98);
            label3.Name = "label3";
            label3.Size = new Size(63, 21);
            label3.TabIndex = 1;
            label3.Text = "Quiz#2";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(18, 51);
            label2.Name = "label2";
            label2.Size = new Size(63, 21);
            label2.TabIndex = 0;
            label2.Text = "Quiz#1";
            // 
            // label20
            // 
            label20.AutoSize = true;
            label20.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label20.Location = new Point(18, 59);
            label20.Name = "label20";
            label20.Size = new Size(53, 21);
            label20.TabIndex = 0;
            label20.Text = "Act#1";
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label19.Location = new Point(18, 106);
            label19.Name = "label19";
            label19.Size = new Size(53, 21);
            label19.TabIndex = 1;
            label19.Text = "Act#2";
            // 
            // txtLab1
            // 
            txtLab1.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtLab1.Location = new Point(82, 57);
            txtLab1.Name = "txtLab1";
            txtLab1.Size = new Size(36, 27);
            txtLab1.TabIndex = 2;
            // 
            // txtLab2
            // 
            txtLab2.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtLab2.Location = new Point(82, 104);
            txtLab2.Name = "txtLab2";
            txtLab2.Size = new Size(36, 27);
            txtLab2.TabIndex = 3;
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Font = new Font("Segoe UI", 12F, FontStyle.Italic, GraphicsUnit.Point);
            label18.Location = new Point(124, 59);
            label18.Name = "label18";
            label18.Size = new Size(16, 21);
            label18.TabIndex = 4;
            label18.Text = "/";
            // 
            // txtLabN1
            // 
            txtLabN1.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtLabN1.Location = new Point(146, 57);
            txtLabN1.Name = "txtLabN1";
            txtLabN1.Size = new Size(36, 27);
            txtLabN1.TabIndex = 5;
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Font = new Font("Segoe UI", 12F, FontStyle.Italic, GraphicsUnit.Point);
            label17.Location = new Point(124, 108);
            label17.Name = "label17";
            label17.Size = new Size(16, 21);
            label17.TabIndex = 6;
            label17.Text = "/";
            // 
            // txtLabN2
            // 
            txtLabN2.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtLabN2.Location = new Point(146, 104);
            txtLabN2.Name = "txtLabN2";
            txtLabN2.Size = new Size(36, 27);
            txtLabN2.TabIndex = 7;
            // 
            // groupLab
            // 
            groupLab.Controls.Add(txtLabN3);
            groupLab.Controls.Add(txtLabN2);
            groupLab.Controls.Add(label4);
            groupLab.Controls.Add(label17);
            groupLab.Controls.Add(txtLab3);
            groupLab.Controls.Add(txtLabN1);
            groupLab.Controls.Add(label5);
            groupLab.Controls.Add(label18);
            groupLab.Controls.Add(txtLab2);
            groupLab.Controls.Add(txtLab1);
            groupLab.Controls.Add(label19);
            groupLab.Controls.Add(label20);
            groupLab.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            groupLab.Location = new Point(12, 436);
            groupLab.Name = "groupLab";
            groupLab.Size = new Size(202, 196);
            groupLab.TabIndex = 6;
            groupLab.TabStop = false;
            groupLab.Text = "Laboratory Activities";
            // 
            // txtLabN3
            // 
            txtLabN3.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtLabN3.Location = new Point(146, 150);
            txtLabN3.Name = "txtLabN3";
            txtLabN3.Size = new Size(36, 27);
            txtLabN3.TabIndex = 11;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Italic, GraphicsUnit.Point);
            label4.Location = new Point(124, 154);
            label4.Name = "label4";
            label4.Size = new Size(16, 21);
            label4.TabIndex = 10;
            label4.Text = "/";
            // 
            // txtLab3
            // 
            txtLab3.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtLab3.Location = new Point(82, 150);
            txtLab3.Name = "txtLab3";
            txtLab3.Size = new Size(36, 27);
            txtLab3.TabIndex = 9;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(18, 152);
            label5.Name = "label5";
            label5.Size = new Size(53, 21);
            label5.TabIndex = 8;
            label5.Text = "Act#3";
            // 
            // groupClass
            // 
            groupClass.Controls.Add(txtClassN3);
            groupClass.Controls.Add(txtClassN2);
            groupClass.Controls.Add(label6);
            groupClass.Controls.Add(label7);
            groupClass.Controls.Add(txtClass3);
            groupClass.Controls.Add(txtClassN1);
            groupClass.Controls.Add(label8);
            groupClass.Controls.Add(label9);
            groupClass.Controls.Add(txtClass2);
            groupClass.Controls.Add(txtClass1);
            groupClass.Controls.Add(label10);
            groupClass.Controls.Add(label11);
            groupClass.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            groupClass.Location = new Point(12, 234);
            groupClass.Name = "groupClass";
            groupClass.Size = new Size(202, 196);
            groupClass.TabIndex = 7;
            groupClass.TabStop = false;
            groupClass.Text = "Classroom Activities";
            // 
            // txtClassN3
            // 
            txtClassN3.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtClassN3.Location = new Point(146, 142);
            txtClassN3.Name = "txtClassN3";
            txtClassN3.Size = new Size(36, 27);
            txtClassN3.TabIndex = 11;
            // 
            // txtClassN2
            // 
            txtClassN2.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtClassN2.Location = new Point(146, 98);
            txtClassN2.Name = "txtClassN2";
            txtClassN2.Size = new Size(36, 27);
            txtClassN2.TabIndex = 7;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Italic, GraphicsUnit.Point);
            label6.Location = new Point(124, 146);
            label6.Name = "label6";
            label6.Size = new Size(16, 21);
            label6.TabIndex = 10;
            label6.Text = "/";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F, FontStyle.Italic, GraphicsUnit.Point);
            label7.Location = new Point(124, 100);
            label7.Name = "label7";
            label7.Size = new Size(16, 21);
            label7.TabIndex = 6;
            label7.Text = "/";
            // 
            // txtClass3
            // 
            txtClass3.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtClass3.Location = new Point(82, 142);
            txtClass3.Name = "txtClass3";
            txtClass3.Size = new Size(36, 27);
            txtClass3.TabIndex = 9;
            // 
            // txtClassN1
            // 
            txtClassN1.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtClassN1.Location = new Point(146, 49);
            txtClassN1.Name = "txtClassN1";
            txtClassN1.Size = new Size(36, 27);
            txtClassN1.TabIndex = 5;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label8.Location = new Point(18, 144);
            label8.Name = "label8";
            label8.Size = new Size(53, 21);
            label8.TabIndex = 8;
            label8.Text = "Act#3";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 12F, FontStyle.Italic, GraphicsUnit.Point);
            label9.Location = new Point(124, 51);
            label9.Name = "label9";
            label9.Size = new Size(16, 21);
            label9.TabIndex = 4;
            label9.Text = "/";
            // 
            // txtClass2
            // 
            txtClass2.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtClass2.Location = new Point(82, 96);
            txtClass2.Name = "txtClass2";
            txtClass2.Size = new Size(36, 27);
            txtClass2.TabIndex = 3;
            // 
            // txtClass1
            // 
            txtClass1.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtClass1.Location = new Point(82, 49);
            txtClass1.Name = "txtClass1";
            txtClass1.Size = new Size(36, 27);
            txtClass1.TabIndex = 2;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label10.Location = new Point(18, 98);
            label10.Name = "label10";
            label10.Size = new Size(53, 21);
            label10.TabIndex = 1;
            label10.Text = "Act#2";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label11.Location = new Point(18, 51);
            label11.Name = "label11";
            label11.Size = new Size(53, 21);
            label11.TabIndex = 0;
            label11.Text = "Act#1";
            // 
            // groupExam
            // 
            groupExam.Controls.Add(label12);
            groupExam.Controls.Add(label21);
            groupExam.Controls.Add(txtExam);
            groupExam.Controls.Add(label23);
            groupExam.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            groupExam.Location = new Point(241, 114);
            groupExam.Name = "groupExam";
            groupExam.Size = new Size(214, 85);
            groupExam.TabIndex = 8;
            groupExam.TabStop = false;
            groupExam.Text = "Exam";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label12.Location = new Point(144, 43);
            label12.Name = "label12";
            label12.Size = new Size(37, 21);
            label12.TabIndex = 5;
            label12.Text = "100";
            // 
            // label21
            // 
            label21.AutoSize = true;
            label21.Font = new Font("Segoe UI", 12F, FontStyle.Italic, GraphicsUnit.Point);
            label21.Location = new Point(122, 43);
            label21.Name = "label21";
            label21.Size = new Size(16, 21);
            label21.TabIndex = 4;
            label21.Text = "/";
            // 
            // txtExam
            // 
            txtExam.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtExam.Location = new Point(80, 41);
            txtExam.Name = "txtExam";
            txtExam.Size = new Size(36, 27);
            txtExam.TabIndex = 2;
            // 
            // label23
            // 
            label23.AutoSize = true;
            label23.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label23.Location = new Point(16, 43);
            label23.Name = "label23";
            label23.Size = new Size(52, 21);
            label23.TabIndex = 0;
            label23.Text = "Exam";
            // 
            // btnSub
            // 
            btnSub.BackColor = SystemColors.ButtonShadow;
            btnSub.FlatStyle = FlatStyle.Popup;
            btnSub.Font = new Font("Roboto", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnSub.ForeColor = Color.White;
            btnSub.Location = new Point(241, 542);
            btnSub.Name = "btnSub";
            btnSub.Size = new Size(122, 44);
            btnSub.TabIndex = 9;
            btnSub.Text = "Calculate";
            btnSub.UseVisualStyleBackColor = false;
            btnSub.Click += btnSub_Click;
            // 
            // btnClear
            // 
            btnClear.BackColor = SystemColors.ButtonShadow;
            btnClear.FlatStyle = FlatStyle.Popup;
            btnClear.Font = new Font("Roboto", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnClear.ForeColor = Color.White;
            btnClear.Location = new Point(382, 542);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(108, 44);
            btnClear.TabIndex = 10;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = false;
            btnClear.Click += btnClear_Click;
            // 
            // label22
            // 
            label22.AutoSize = true;
            label22.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label22.Location = new Point(298, 436);
            label22.Name = "label22";
            label22.Size = new Size(78, 21);
            label22.TabIndex = 11;
            label22.Text = "Remarks:";
            // 
            // lblRemarks
            // 
            lblRemarks.AutoSize = true;
            lblRemarks.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblRemarks.Location = new Point(382, 440);
            lblRemarks.Name = "lblRemarks";
            lblRemarks.Size = new Size(41, 17);
            lblRemarks.TabIndex = 12;
            lblRemarks.Text = "None";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label14.Location = new Point(16, 38);
            label14.Name = "label14";
            label14.Size = new Size(205, 21);
            label14.TabIndex = 0;
            label14.Text = "Computed Periodic Grades:";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label13.Location = new Point(18, 103);
            label13.Name = "label13";
            label13.Size = new Size(137, 21);
            label13.TabIndex = 1;
            label13.Text = "Equivalent Grade:";
            // 
            // lblPeriodicGrade
            // 
            lblPeriodicGrade.AutoSize = true;
            lblPeriodicGrade.Location = new Point(18, 62);
            lblPeriodicGrade.Name = "lblPeriodicGrade";
            lblPeriodicGrade.Size = new Size(39, 25);
            lblPeriodicGrade.TabIndex = 2;
            lblPeriodicGrade.Text = "0.0";
            lblPeriodicGrade.Click += lblPeriodicGrade_Click;
            // 
            // lblEquivalentGrade
            // 
            lblEquivalentGrade.AutoSize = true;
            lblEquivalentGrade.Location = new Point(18, 135);
            lblEquivalentGrade.Name = "lblEquivalentGrade";
            lblEquivalentGrade.Size = new Size(39, 25);
            lblEquivalentGrade.TabIndex = 11;
            lblEquivalentGrade.Text = "0.0";
            // 
            // groupBox5
            // 
            groupBox5.Controls.Add(lblEquivalentGrade);
            groupBox5.Controls.Add(lblPeriodicGrade);
            groupBox5.Controls.Add(label13);
            groupBox5.Controls.Add(label14);
            groupBox5.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            groupBox5.Location = new Point(238, 246);
            groupBox5.Name = "groupBox5";
            groupBox5.Size = new Size(252, 174);
            groupBox5.TabIndex = 5;
            groupBox5.TabStop = false;
            groupBox5.Text = "Results";
            // 
            // label24
            // 
            label24.AutoSize = true;
            label24.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label24.Location = new Point(117, 40);
            label24.Name = "label24";
            label24.Size = new Size(292, 21);
            label24.TabIndex = 13;
            label24.Text = "Input your scores and total in the boxes\r\n";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(508, 643);
            Controls.Add(label24);
            Controls.Add(lblRemarks);
            Controls.Add(label22);
            Controls.Add(btnClear);
            Controls.Add(btnSub);
            Controls.Add(groupExam);
            Controls.Add(groupClass);
            Controls.Add(groupLab);
            Controls.Add(groupBox5);
            Controls.Add(groupQuiz);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Periodic Grade Calculator";
            Load += Form1_Load;
            groupQuiz.ResumeLayout(false);
            groupQuiz.PerformLayout();
            groupLab.ResumeLayout(false);
            groupLab.PerformLayout();
            groupClass.ResumeLayout(false);
            groupClass.PerformLayout();
            groupExam.ResumeLayout(false);
            groupExam.PerformLayout();
            groupBox5.ResumeLayout(false);
            groupBox5.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private GroupBox groupQuiz;
        private Label label3;
        private Label label2;
        private TextBox txtQuizN2;
        private Label label16;
        private TextBox txtQuizN1;
        private Label label15;
        private TextBox txtQuiz2;
        private TextBox txtQuiz1;
        private Label label20;
        private Label label19;
        private TextBox txtLab1;
        private TextBox txtLab2;
        private Label label18;
        private TextBox txtLabN1;
        private Label label17;
        private TextBox txtLabN2;
        private GroupBox groupLab;
        private TextBox txtLabN3;
        private Label label4;
        private TextBox txtLab3;
        private Label label5;
        private GroupBox groupClass;
        private TextBox txtClassN3;
        private TextBox txtClassN2;
        private Label label6;
        private Label label7;
        private TextBox txtClass3;
        private TextBox txtClassN1;
        private Label label8;
        private Label label9;
        private TextBox txtClass2;
        private TextBox txtClass1;
        private Label label10;
        private Label label11;
        private GroupBox groupExam;
        private Label label12;
        private Label label21;
        private TextBox txtExam;
        private Label label23;
        private Button btnSub;
        private Button btnClear;
        private Label label22;
        private Label lblRemarks;
        private Label label14;
        private Label label13;
        private Label lblPeriodicGrade;
        private Label lblEquivalentGrade;
        private GroupBox groupBox5;
        private Label label24;
    }
}