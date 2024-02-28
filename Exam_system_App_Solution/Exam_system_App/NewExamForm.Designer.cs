namespace Exam_system_App
{
    partial class NewExamForm
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
            nxtBtn = new Button();
            prevBtn = new Button();
            questionLbl = new Label();
            Achoice = new RadioButton();
            Bchoice = new RadioButton();
            Cchoice = new RadioButton();
            Dchoice = new RadioButton();
            submitbtn = new Button();
            SuspendLayout();
            // 
            // nxtBtn
            // 
            nxtBtn.Location = new Point(354, 276);
            nxtBtn.Margin = new Padding(3, 2, 3, 2);
            nxtBtn.Name = "nxtBtn";
            nxtBtn.Size = new Size(239, 29);
            nxtBtn.TabIndex = 0;
            nxtBtn.Text = "Next";
            nxtBtn.UseVisualStyleBackColor = true;
            nxtBtn.Click += nxtBtn_Click;
            // 
            // prevBtn
            // 
            prevBtn.Location = new Point(42, 276);
            prevBtn.Margin = new Padding(3, 2, 3, 2);
            prevBtn.Name = "prevBtn";
            prevBtn.Size = new Size(239, 29);
            prevBtn.TabIndex = 1;
            prevBtn.Text = "Previous";
            prevBtn.UseVisualStyleBackColor = true;
            prevBtn.Click += prevBtn_Click;
            // 
            // questionLbl
            // 
            questionLbl.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            questionLbl.BackColor = Color.Transparent;
            questionLbl.BorderStyle = BorderStyle.Fixed3D;
            questionLbl.Location = new Point(42, 9);
            questionLbl.Name = "questionLbl";
            questionLbl.Size = new Size(863, 61);
            questionLbl.TabIndex = 2;
            questionLbl.Text = "....";
            // 
            // Achoice
            // 
            Achoice.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            Achoice.AutoSize = true;
            Achoice.BackColor = Color.Transparent;
            Achoice.FlatAppearance.BorderColor = Color.Red;
            Achoice.Font = new Font("Segoe UI", 12F);
            Achoice.Location = new Point(42, 102);
            Achoice.Margin = new Padding(3, 2, 3, 2);
            Achoice.Name = "Achoice";
            Achoice.Size = new Size(119, 25);
            Achoice.TabIndex = 3;
            Achoice.TabStop = true;
            Achoice.Text = "radioButton1";
            Achoice.UseVisualStyleBackColor = false;
            Achoice.Click += Achoice_Click;
            // 
            // Bchoice
            // 
            Bchoice.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            Bchoice.AutoSize = true;
            Bchoice.BackColor = Color.Transparent;
            Bchoice.FlatAppearance.BorderColor = Color.Red;
            Bchoice.Font = new Font("Segoe UI", 12F);
            Bchoice.Location = new Point(42, 139);
            Bchoice.Margin = new Padding(3, 2, 3, 2);
            Bchoice.Name = "Bchoice";
            Bchoice.Size = new Size(119, 25);
            Bchoice.TabIndex = 4;
            Bchoice.TabStop = true;
            Bchoice.Text = "radioButton2";
            Bchoice.UseVisualStyleBackColor = false;
            Bchoice.Click += Bchoice_Click;
            // 
            // Cchoice
            // 
            Cchoice.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            Cchoice.AutoSize = true;
            Cchoice.BackColor = Color.Transparent;
            Cchoice.FlatAppearance.BorderColor = Color.Red;
            Cchoice.Font = new Font("Segoe UI", 12F);
            Cchoice.Location = new Point(42, 170);
            Cchoice.Margin = new Padding(3, 2, 3, 2);
            Cchoice.Name = "Cchoice";
            Cchoice.Size = new Size(119, 25);
            Cchoice.TabIndex = 5;
            Cchoice.TabStop = true;
            Cchoice.Text = "radioButton3";
            Cchoice.UseVisualStyleBackColor = false;
            Cchoice.Click += Cchoice_Click;
            // 
            // Dchoice
            // 
            Dchoice.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            Dchoice.AutoSize = true;
            Dchoice.BackColor = Color.Transparent;
            Dchoice.FlatAppearance.BorderColor = Color.Red;
            Dchoice.Font = new Font("Segoe UI", 12F);
            Dchoice.Location = new Point(42, 205);
            Dchoice.Margin = new Padding(3, 2, 3, 2);
            Dchoice.Name = "Dchoice";
            Dchoice.Size = new Size(119, 25);
            Dchoice.TabIndex = 6;
            Dchoice.TabStop = true;
            Dchoice.Text = "radioButton4";
            Dchoice.UseVisualStyleBackColor = false;
            Dchoice.Click += Dchoice_Click;
            // 
            // submitbtn
            // 
            submitbtn.Location = new Point(666, 276);
            submitbtn.Margin = new Padding(3, 2, 3, 2);
            submitbtn.Name = "submitbtn";
            submitbtn.Size = new Size(239, 29);
            submitbtn.TabIndex = 7;
            submitbtn.Text = "Submit";
            submitbtn.UseVisualStyleBackColor = true;
            submitbtn.Click += submitbtn_Click;
            // 
            // NewExamForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(933, 352);
            Controls.Add(submitbtn);
            Controls.Add(Dchoice);
            Controls.Add(Cchoice);
            Controls.Add(Bchoice);
            Controls.Add(Achoice);
            Controls.Add(questionLbl);
            Controls.Add(prevBtn);
            Controls.Add(nxtBtn);
            Margin = new Padding(3, 2, 3, 2);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "NewExamForm";
            Text = "NewExamForm";
            WindowState = FormWindowState.Maximized;
            FormClosing += NewExamForm_FormClosing;
            Load += NewExamForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button nxtBtn;
        private Button prevBtn;
        private Label questionLbl;
        private RadioButton Achoice;
        private RadioButton Bchoice;
        private RadioButton Cchoice;
        private RadioButton Dchoice;
        private Button submitbtn;
    }
}