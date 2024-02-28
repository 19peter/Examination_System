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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InstructorMainPage));
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            label5 = new Label();
            pictureBox1 = new PictureBox();
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
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
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
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(792, 385);
            tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            tabPage1.BackgroundImage = (Image)resources.GetObject("tabPage1.BackgroundImage");
            tabPage1.Controls.Add(label5);
            tabPage1.Controls.Add(pictureBox1);
            tabPage1.Controls.Add(generationInfoLbl);
            tabPage1.Controls.Add(generateBtn);
            tabPage1.Controls.Add(label3);
            tabPage1.Controls.Add(crsCbox);
            tabPage1.Controls.Add(tfNum);
            tabPage1.Controls.Add(mcqNum);
            tabPage1.Controls.Add(label2);
            tabPage1.Controls.Add(label1);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(784, 357);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Generate Exam";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label5.ForeColor = Color.FromArgb(192, 0, 0);
            label5.Location = new Point(128, 52);
            label5.Name = "label5";
            label5.Size = new Size(281, 29);
            label5.TabIndex = 9;
            label5.Text = "Welcome, ";
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(25, 21);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(97, 89);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 8;
            pictureBox1.TabStop = false;
            // 
            // generationInfoLbl
            // 
            generationInfoLbl.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            generationInfoLbl.ForeColor = Color.FromArgb(192, 0, 0);
            generationInfoLbl.Location = new Point(128, 245);
            generationInfoLbl.Name = "generationInfoLbl";
            generationInfoLbl.Size = new Size(527, 29);
            generationInfoLbl.TabIndex = 7;
            generationInfoLbl.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // generateBtn
            // 
            generateBtn.Anchor = AnchorStyles.None;
            generateBtn.BackColor = Color.Black;
            generateBtn.Font = new Font("Segoe UI", 12F);
            generateBtn.ForeColor = SystemColors.Control;
            generateBtn.Location = new Point(251, 277);
            generateBtn.Name = "generateBtn";
            generateBtn.Size = new Size(252, 37);
            generateBtn.TabIndex = 6;
            generateBtn.Text = "Generate Exam";
            generateBtn.UseVisualStyleBackColor = false;
            generateBtn.Click += generateBtn_Click;
            generateBtn.MouseLeave += generateBtn_MouseLeave;
            generateBtn.MouseHover += generateBtn_MouseHover;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.None;
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label3.ForeColor = Color.FromArgb(192, 0, 0);
            label3.Location = new Point(264, 189);
            label3.Name = "label3";
            label3.Size = new Size(88, 21);
            label3.TabIndex = 5;
            label3.Text = "True/False";
            // 
            // crsCbox
            // 
            crsCbox.Anchor = AnchorStyles.None;
            crsCbox.FormattingEnabled = true;
            crsCbox.Location = new Point(382, 113);
            crsCbox.Name = "crsCbox";
            crsCbox.Size = new Size(121, 23);
            crsCbox.TabIndex = 4;
            // 
            // tfNum
            // 
            tfNum.Anchor = AnchorStyles.None;
            tfNum.Location = new Point(382, 182);
            tfNum.Name = "tfNum";
            tfNum.Size = new Size(121, 23);
            tfNum.TabIndex = 3;
            // 
            // mcqNum
            // 
            mcqNum.Anchor = AnchorStyles.None;
            mcqNum.ForeColor = SystemColors.MenuText;
            mcqNum.Location = new Point(382, 142);
            mcqNum.Name = "mcqNum";
            mcqNum.Size = new Size(121, 23);
            mcqNum.TabIndex = 2;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.None;
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label2.ForeColor = Color.FromArgb(192, 0, 0);
            label2.Location = new Point(264, 149);
            label2.Name = "label2";
            label2.Size = new Size(51, 21);
            label2.TabIndex = 1;
            label2.Text = "MCQ ";
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label1.ForeColor = Color.FromArgb(192, 0, 0);
            label1.Location = new Point(264, 115);
            label1.Name = "label1";
            label1.Size = new Size(112, 21);
            label1.TabIndex = 0;
            label1.Text = "Course Name";
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(splitContainer1);
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(784, 357);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "View Exam";
            tabPage2.UseVisualStyleBackColor = true;
            tabPage2.Click += tabPage2_Click;
            // 
            // splitContainer1
            // 
            splitContainer1.Dock = DockStyle.Fill;
            splitContainer1.Location = new Point(3, 3);
            splitContainer1.Margin = new Padding(3, 2, 3, 2);
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
            splitContainer1.Size = new Size(778, 351);
            splitContainer1.SplitterDistance = 142;
            splitContainer1.TabIndex = 4;
            // 
            // examIdNum
            // 
            examIdNum.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            examIdNum.Location = new Point(4, 34);
            examIdNum.Name = "examIdNum";
            examIdNum.Size = new Size(135, 23);
            examIdNum.TabIndex = 1;
            // 
            // viewBtn
            // 
            viewBtn.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            viewBtn.Location = new Point(4, 79);
            viewBtn.Name = "viewBtn";
            viewBtn.Size = new Size(135, 23);
            viewBtn.TabIndex = 3;
            viewBtn.Text = "View Exam";
            viewBtn.UseVisualStyleBackColor = true;
            viewBtn.Click += viewBtn_Click;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label4.AutoSize = true;
            label4.Location = new Point(4, 9);
            label4.Name = "label4";
            label4.Size = new Size(50, 15);
            label4.TabIndex = 0;
            label4.Text = "Exam ID";
            // 
            // examGridView
            // 
            examGridView.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            examGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            examGridView.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            examGridView.BackgroundColor = Color.FromArgb(192, 0, 0);
            examGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            examGridView.Location = new Point(3, 3);
            examGridView.Name = "examGridView";
            examGridView.RowHeadersWidth = 51;
            examGridView.Size = new Size(626, 345);
            examGridView.TabIndex = 2;
            // 
            // InstructorMainPage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(786, 383);
            Controls.Add(tabControl1);
            Name = "InstructorMainPage";
            Text = "InstructorMainPage";
            FormClosing += InstructorMainPage_FormClosing;
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
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
        private PictureBox pictureBox1;
        private Label label5;
    }
}