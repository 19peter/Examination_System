namespace Exam_system_App
{
    partial class InstructorMainPage
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
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            generationInfoLbl = new Label();
            generateBtn = new Button();
            label3 = new Label();
            crsCbox = new ComboBox();
            tfNum = new NumericUpDown();
            mcqNum = new NumericUpDown();
            label2 = new Label();
            label1 = new Label();
            tabPage2 = new TabPage();
            splitContainer1 = new SplitContainer();
            examIdNum = new NumericUpDown();
            viewBtn = new Button();
            label4 = new Label();
            examGridView = new DataGridView();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)tfNum).BeginInit();
            ((System.ComponentModel.ISupportInitialize)mcqNum).BeginInit();
            tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)examIdNum).BeginInit();
            ((System.ComponentModel.ISupportInitialize)examGridView).BeginInit();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Location = new Point(0, 0);
            tabControl1.Margin = new Padding(3, 4, 3, 4);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(905, 460);
            tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(generationInfoLbl);
            tabPage1.Controls.Add(generateBtn);
            tabPage1.Controls.Add(label3);
            tabPage1.Controls.Add(crsCbox);
            tabPage1.Controls.Add(tfNum);
            tabPage1.Controls.Add(mcqNum);
            tabPage1.Controls.Add(label2);
            tabPage1.Controls.Add(label1);
            tabPage1.Location = new Point(4, 29);
            tabPage1.Margin = new Padding(3, 4, 3, 4);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3, 4, 3, 4);
            tabPage1.Size = new Size(897, 427);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Generate Exam";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // generationInfoLbl
            // 
            generationInfoLbl.Location = new Point(127, 464);
            generationInfoLbl.Name = "generationInfoLbl";
            generationInfoLbl.Size = new Size(602, 39);
            generationInfoLbl.TabIndex = 7;
            // 
            // generateBtn
            // 
            generateBtn.Anchor = AnchorStyles.None;
            generateBtn.Location = new Point(287, 372);
            generateBtn.Margin = new Padding(3, 4, 3, 4);
            generateBtn.Name = "generateBtn";
            generateBtn.Size = new Size(288, 35);
            generateBtn.TabIndex = 6;
            generateBtn.Text = "Generate Exam";
            generateBtn.UseVisualStyleBackColor = true;
            generateBtn.Click += generateBtn_Click;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.None;
            label3.AutoSize = true;
            label3.Location = new Point(287, 273);
            label3.Name = "label3";
            label3.Size = new Size(75, 20);
            label3.TabIndex = 5;
            label3.Text = "True/False";
            // 
            // crsCbox
            // 
            crsCbox.Anchor = AnchorStyles.None;
            crsCbox.FormattingEnabled = true;
            crsCbox.Location = new Point(437, 185);
            crsCbox.Margin = new Padding(3, 4, 3, 4);
            crsCbox.Name = "crsCbox";
            crsCbox.Size = new Size(138, 28);
            crsCbox.TabIndex = 4;
            // 
            // tfNum
            // 
            tfNum.Anchor = AnchorStyles.None;
            tfNum.Location = new Point(437, 263);
            tfNum.Margin = new Padding(3, 4, 3, 4);
            tfNum.Name = "tfNum";
            tfNum.Size = new Size(138, 27);
            tfNum.TabIndex = 3;
            // 
            // mcqNum
            // 
            mcqNum.Anchor = AnchorStyles.None;
            mcqNum.Location = new Point(437, 224);
            mcqNum.Margin = new Padding(3, 4, 3, 4);
            mcqNum.Name = "mcqNum";
            mcqNum.Size = new Size(138, 27);
            mcqNum.TabIndex = 2;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.None;
            label2.AutoSize = true;
            label2.Location = new Point(287, 235);
            label2.Name = "label2";
            label2.Size = new Size(46, 20);
            label2.TabIndex = 1;
            label2.Text = "MCQ ";
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.Location = new Point(287, 189);
            label1.Name = "label1";
            label1.Size = new Size(98, 20);
            label1.TabIndex = 0;
            label1.Text = "Course Name";
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(splitContainer1);
            tabPage2.Location = new Point(4, 29);
            tabPage2.Margin = new Padding(3, 4, 3, 4);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3, 4, 3, 4);
            tabPage2.Size = new Size(897, 427);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "View Exam";
            tabPage2.UseVisualStyleBackColor = true;
            tabPage2.Click += tabPage2_Click;
            // 
            // splitContainer1
            // 
            splitContainer1.Dock = DockStyle.Fill;
            splitContainer1.Location = new Point(3, 4);
            splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(examIdNum);
            splitContainer1.Panel1.Controls.Add(viewBtn);
            splitContainer1.Panel1.Controls.Add(label4);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(examGridView);
            splitContainer1.Size = new Size(891, 419);
            splitContainer1.SplitterDistance = 163;
            splitContainer1.TabIndex = 4;
            // 
            // examIdNum
            // 
            examIdNum.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            examIdNum.Location = new Point(5, 46);
            examIdNum.Margin = new Padding(3, 4, 3, 4);
            examIdNum.Name = "examIdNum";
            examIdNum.Size = new Size(155, 27);
            examIdNum.TabIndex = 1;
            // 
            // viewBtn
            // 
            viewBtn.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            viewBtn.Location = new Point(5, 81);
            viewBtn.Margin = new Padding(3, 4, 3, 4);
            viewBtn.Name = "viewBtn";
            viewBtn.Size = new Size(155, 31);
            viewBtn.TabIndex = 3;
            viewBtn.Text = "View Exam";
            viewBtn.UseVisualStyleBackColor = true;
            viewBtn.Click += viewBtn_Click;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label4.AutoSize = true;
            label4.Location = new Point(5, 12);
            label4.Name = "label4";
            label4.Size = new Size(64, 20);
            label4.TabIndex = 0;
            label4.Text = "Exam ID";
            // 
            // examGridView
            // 
            examGridView.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            examGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            examGridView.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            examGridView.BackgroundColor = Color.Teal;
            examGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            examGridView.Location = new Point(3, 4);
            examGridView.Margin = new Padding(3, 4, 3, 4);
            examGridView.Name = "examGridView";
            examGridView.RowHeadersWidth = 51;
            examGridView.Size = new Size(718, 411);
            examGridView.TabIndex = 2;
            // 
            // InstructorMainPage
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(898, 457);
            Controls.Add(tabControl1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "InstructorMainPage";
            Text = "InstructorMainPage";
            FormClosing += InstructorMainPage_FormClosing;
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)tfNum).EndInit();
            ((System.ComponentModel.ISupportInitialize)mcqNum).EndInit();
            tabPage2.ResumeLayout(false);
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel1.PerformLayout();
            splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)examIdNum).EndInit();
            ((System.ComponentModel.ISupportInitialize)examGridView).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabPage1;
        private NumericUpDown mcqNum;
        private Label label2;
        private TabPage tabPage2;
        private Button generateBtn;
        private Label label3;
        private NumericUpDown tfNum;
        private Button viewBtn;
        private DataGridView examGridView;
        private NumericUpDown examIdNum;
        private Label label4;
        private ComboBox crsCbox;
        private Label label1;
        private Label generationInfoLbl;
        private SplitContainer splitContainer1;
    }
}