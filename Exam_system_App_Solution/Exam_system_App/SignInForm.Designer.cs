namespace Exam_system_App
{
    partial class SignInForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SignInForm));
            label1 = new Label();
            choosecombobox = new ComboBox();
            idtxtbox = new TextBox();
            label2 = new Label();
            passwordtxtbox = new TextBox();
            label3 = new Label();
            SignInbtn = new Button();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 20F, FontStyle.Bold | FontStyle.Italic);
            label1.ForeColor = Color.FromArgb(192, 0, 0);
            label1.Location = new Point(296, 205);
            label1.Name = "label1";
            label1.Size = new Size(105, 37);
            label1.TabIndex = 0;
            label1.Text = "Sign In";
            label1.Click += label1_Click;
            // 
            // choosecombobox
            // 
            choosecombobox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            choosecombobox.FormattingEnabled = true;
            choosecombobox.Items.AddRange(new object[] { "Instructor", "Student" });
            choosecombobox.Location = new Point(226, 263);
            choosecombobox.Margin = new Padding(5);
            choosecombobox.Name = "choosecombobox";
            choosecombobox.Size = new Size(263, 23);
            choosecombobox.TabIndex = 1;
            choosecombobox.Text = "Select Your Identity :";
            // 
            // idtxtbox
            // 
            idtxtbox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            idtxtbox.ForeColor = Color.FromArgb(192, 0, 0);
            idtxtbox.Location = new Point(226, 334);
            idtxtbox.Margin = new Padding(3, 2, 3, 2);
            idtxtbox.Name = "idtxtbox";
            idtxtbox.Size = new Size(263, 23);
            idtxtbox.TabIndex = 2;
            idtxtbox.TextChanged += idtxtbox_TextChanged;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI", 15F, FontStyle.Bold | FontStyle.Italic);
            label2.ForeColor = Color.FromArgb(192, 0, 0);
            label2.Location = new Point(226, 302);
            label2.Name = "label2";
            label2.Size = new Size(66, 30);
            label2.TabIndex = 3;
            label2.Text = "ID";
            label2.Click += label2_Click;
            // 
            // passwordtxtbox
            // 
            passwordtxtbox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            passwordtxtbox.Location = new Point(226, 408);
            passwordtxtbox.Margin = new Padding(3, 2, 3, 2);
            passwordtxtbox.Name = "passwordtxtbox";
            passwordtxtbox.PasswordChar = '*';
            passwordtxtbox.Size = new Size(263, 23);
            passwordtxtbox.TabIndex = 4;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI", 15F, FontStyle.Bold | FontStyle.Italic);
            label3.ForeColor = Color.FromArgb(192, 0, 0);
            label3.Location = new Point(226, 376);
            label3.Name = "label3";
            label3.Size = new Size(123, 30);
            label3.TabIndex = 5;
            label3.Text = "Password";
            label3.Click += label3_Click;
            // 
            // SignInbtn
            // 
            SignInbtn.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            SignInbtn.BackColor = Color.Black;
            SignInbtn.FlatStyle = FlatStyle.Flat;
            SignInbtn.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            SignInbtn.ForeColor = SystemColors.ButtonFace;
            SignInbtn.Location = new Point(252, 455);
            SignInbtn.Margin = new Padding(3, 2, 3, 2);
            SignInbtn.Name = "SignInbtn";
            SignInbtn.Size = new Size(192, 38);
            SignInbtn.TabIndex = 6;
            SignInbtn.Text = "Sign In";
            SignInbtn.UseVisualStyleBackColor = false;
            SignInbtn.Click += SignInbtn_Click;
            SignInbtn.MouseLeave += SignInbtn_MouseLeave;
            SignInbtn.MouseHover += SignInbtn_MouseHover;
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.BackgroundImageLayout = ImageLayout.Center;
            pictureBox1.Location = new Point(310, 35);
            pictureBox1.Margin = new Padding(3, 2, 3, 2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(91, 152);
            pictureBox1.TabIndex = 7;
            pictureBox1.TabStop = false;
            // 
            // SignInForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(64, 64, 64);
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(685, 546);
            Controls.Add(pictureBox1);
            Controls.Add(SignInbtn);
            Controls.Add(label3);
            Controls.Add(passwordtxtbox);
            Controls.Add(label2);
            Controls.Add(idtxtbox);
            Controls.Add(choosecombobox);
            Controls.Add(label1);
            ForeColor = Color.FromArgb(192, 0, 0);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Margin = new Padding(3, 2, 3, 2);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "SignInForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Sign InForm";
            Load += SignInForm_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ComboBox choosecombobox;
        private TextBox idtxtbox;
        private Label label2;
        private TextBox passwordtxtbox;
        private Label label3;
        private Button SignInbtn;
        private PictureBox pictureBox1;
    }
}