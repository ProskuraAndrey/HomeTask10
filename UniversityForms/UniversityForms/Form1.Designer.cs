namespace UniversityForms
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Department = new System.Windows.Forms.ComboBox();
            this.TeacherFIO = new System.Windows.Forms.ComboBox();
            this.Group = new System.Windows.Forms.Label();
            this.stud1 = new System.Windows.Forms.Label();
            this.stud2 = new System.Windows.Forms.Label();
            this.stud3 = new System.Windows.Forms.Label();
            this.stud4 = new System.Windows.Forms.Label();
            this.stud5 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.comboBox4 = new System.Windows.Forms.ComboBox();
            this.comboBox5 = new System.Windows.Forms.ComboBox();
            this.Marks = new System.Windows.Forms.Label();
            this.Result = new System.Windows.Forms.Label();
            this.calc_button = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(249, 9);
            this.label1.MaximumSize = new System.Drawing.Size(150, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "UNIVERSITY\r\n";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(81, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Choose Department ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(385, 44);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Select a teacher";
            // 
            // Department
            // 
            this.Department.FormattingEnabled = true;
            this.Department.Items.AddRange(new object[] {
            "Matematics",
            "Chemistry",
            "Phylosofy",
            "History",
            "Biology"});
            this.Department.Location = new System.Drawing.Point(84, 70);
            this.Department.Name = "Department";
            this.Department.Size = new System.Drawing.Size(101, 21);
            this.Department.TabIndex = 3;
            this.Department.SelectedIndexChanged += new System.EventHandler(this.Department_SelectedIndexChanged);
            // 
            // TeacherFIO
            // 
            this.TeacherFIO.FormattingEnabled = true;
            this.TeacherFIO.Items.AddRange(new object[] {
            "Petrov B.I.",
            "Shelest S.O.",
            "Vinohradov A.T."});
            this.TeacherFIO.Location = new System.Drawing.Point(388, 70);
            this.TeacherFIO.Name = "TeacherFIO";
            this.TeacherFIO.Size = new System.Drawing.Size(105, 21);
            this.TeacherFIO.TabIndex = 4;
            // 
            // Group
            // 
            this.Group.AutoSize = true;
            this.Group.Location = new System.Drawing.Point(102, 137);
            this.Group.Name = "Group";
            this.Group.Size = new System.Drawing.Size(101, 13);
            this.Group.TabIndex = 5;
            this.Group.Text = "GROUP of students";
            // 
            // stud1
            // 
            this.stud1.AutoSize = true;
            this.stud1.Location = new System.Drawing.Point(122, 169);
            this.stud1.Name = "stud1";
            this.stud1.Size = new System.Drawing.Size(63, 13);
            this.stud1.TabIndex = 6;
            this.stud1.Text = "Alex Ivanov";
            // 
            // stud2
            // 
            this.stud2.AutoSize = true;
            this.stud2.Location = new System.Drawing.Point(135, 196);
            this.stud2.Name = "stud2";
            this.stud2.Size = new System.Drawing.Size(50, 13);
            this.stud2.TabIndex = 7;
            this.stud2.Text = "Petr Salo";
            // 
            // stud3
            // 
            this.stud3.AutoSize = true;
            this.stud3.Location = new System.Drawing.Point(124, 223);
            this.stud3.Name = "stud3";
            this.stud3.Size = new System.Drawing.Size(61, 13);
            this.stud3.TabIndex = 8;
            this.stud3.Text = "Serg Perviy";
            // 
            // stud4
            // 
            this.stud4.AutoSize = true;
            this.stud4.Location = new System.Drawing.Point(102, 250);
            this.stud4.Name = "stud4";
            this.stud4.Size = new System.Drawing.Size(83, 13);
            this.stud4.TabIndex = 9;
            this.stud4.Text = "Nikolo Pyatnitso";
            // 
            // stud5
            // 
            this.stud5.AutoSize = true;
            this.stud5.Location = new System.Drawing.Point(91, 277);
            this.stud5.Name = "stud5";
            this.stud5.Size = new System.Drawing.Size(94, 13);
            this.stud5.TabIndex = 10;
            this.stud5.Text = "Veranika Sorokina";
            this.stud5.Click += new System.EventHandler(this.stud5_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5"});
            this.comboBox1.Location = new System.Drawing.Point(252, 166);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(39, 21);
            this.comboBox1.TabIndex = 11;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5"});
            this.comboBox2.Location = new System.Drawing.Point(252, 193);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(39, 21);
            this.comboBox2.TabIndex = 12;
            this.comboBox2.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // comboBox3
            // 
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5"});
            this.comboBox3.Location = new System.Drawing.Point(252, 220);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(39, 21);
            this.comboBox3.TabIndex = 13;
            this.comboBox3.SelectedIndexChanged += new System.EventHandler(this.comboBox3_SelectedIndexChanged);
            // 
            // comboBox4
            // 
            this.comboBox4.FormattingEnabled = true;
            this.comboBox4.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5"});
            this.comboBox4.Location = new System.Drawing.Point(252, 247);
            this.comboBox4.Name = "comboBox4";
            this.comboBox4.Size = new System.Drawing.Size(39, 21);
            this.comboBox4.TabIndex = 14;
            this.comboBox4.SelectedIndexChanged += new System.EventHandler(this.comboBox4_SelectedIndexChanged);
            // 
            // comboBox5
            // 
            this.comboBox5.FormattingEnabled = true;
            this.comboBox5.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5"});
            this.comboBox5.Location = new System.Drawing.Point(252, 274);
            this.comboBox5.Name = "comboBox5";
            this.comboBox5.Size = new System.Drawing.Size(39, 21);
            this.comboBox5.TabIndex = 15;
            this.comboBox5.SelectedIndexChanged += new System.EventHandler(this.comboBox5_SelectedIndexChanged);
            // 
            // Marks
            // 
            this.Marks.AutoSize = true;
            this.Marks.Location = new System.Drawing.Point(213, 137);
            this.Marks.Name = "Marks";
            this.Marks.Size = new System.Drawing.Size(122, 13);
            this.Marks.TabIndex = 16;
            this.Marks.Text = "Choose mark for student";
            // 
            // Result
            // 
            this.Result.AutoSize = true;
            this.Result.Location = new System.Drawing.Point(81, 367);
            this.Result.Name = "Result";
            this.Result.Size = new System.Drawing.Size(232, 13);
            this.Result.TabIndex = 17;
            this.Result.Text = "Average performance for the group is equal to =";
            // 
            // calc_button
            // 
            this.calc_button.Location = new System.Drawing.Point(84, 330);
            this.calc_button.Name = "calc_button";
            this.calc_button.Size = new System.Drawing.Size(207, 23);
            this.calc_button.TabIndex = 18;
            this.calc_button.Text = "Сalculation";
            this.calc_button.UseVisualStyleBackColor = true;
            this.calc_button.Click += new System.EventHandler(this.calc_button_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label4.Location = new System.Drawing.Point(319, 367);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 15);
            this.label4.TabIndex = 19;
            this.label4.Text = "______";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(370, 367);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 13);
            this.label5.TabIndex = 20;
            this.label5.Text = "in our group";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(439, 367);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(73, 13);
            this.label6.TabIndex = 21;
            this.label6.Text = "___________";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(518, 367);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(41, 13);
            this.label7.TabIndex = 22;
            this.label7.Text = "subject";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(622, 480);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.calc_button);
            this.Controls.Add(this.Result);
            this.Controls.Add(this.Marks);
            this.Controls.Add(this.comboBox5);
            this.Controls.Add(this.comboBox4);
            this.Controls.Add(this.comboBox3);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.stud5);
            this.Controls.Add(this.stud4);
            this.Controls.Add(this.stud3);
            this.Controls.Add(this.stud2);
            this.Controls.Add(this.stud1);
            this.Controls.Add(this.Group);
            this.Controls.Add(this.TeacherFIO);
            this.Controls.Add(this.Department);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox Department;
        private System.Windows.Forms.ComboBox TeacherFIO;
        private System.Windows.Forms.Label Group;
        private System.Windows.Forms.Label stud1;
        private System.Windows.Forms.Label stud2;
        private System.Windows.Forms.Label stud3;
        private System.Windows.Forms.Label stud4;
        private System.Windows.Forms.Label stud5;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.ComboBox comboBox4;
        private System.Windows.Forms.ComboBox comboBox5;
        private System.Windows.Forms.Label Marks;
        private System.Windows.Forms.Label Result;
        private System.Windows.Forms.Button calc_button;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
    }
}

