namespace UserValidationOfRotatedText
{
    partial class frmMain
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
            this.picBoard = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtContent = new System.Windows.Forms.RichTextBox();
            this.btnCreate = new System.Windows.Forms.Button();
            this.btnCheck = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picBoard)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // picBoard
            // 
            this.picBoard.BackColor = System.Drawing.SystemColors.ControlDark;
            this.picBoard.Dock = System.Windows.Forms.DockStyle.Fill;
            this.picBoard.Location = new System.Drawing.Point(3, 17);
            this.picBoard.Name = "picBoard";
            this.picBoard.Size = new System.Drawing.Size(194, 116);
            this.picBoard.TabIndex = 0;
            this.picBoard.TabStop = false;
            this.picBoard.Paint += new System.Windows.Forms.PaintEventHandler(this.picBoard_Paint);
            this.picBoard.MouseClick += new System.Windows.Forms.MouseEventHandler(this.picBoard_MouseClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.picBoard);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 136);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "内容显示及操作区";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtContent);
            this.groupBox2.Location = new System.Drawing.Point(218, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(144, 133);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "原始文本";
            // 
            // txtContent
            // 
            this.txtContent.Dock = System.Windows.Forms.DockStyle.Left;
            this.txtContent.Location = new System.Drawing.Point(3, 17);
            this.txtContent.Name = "txtContent";
            this.txtContent.Size = new System.Drawing.Size(129, 113);
            this.txtContent.TabIndex = 0;
            this.txtContent.Text = "昆德拉接";
            // 
            // btnCreate
            // 
            this.btnCreate.Location = new System.Drawing.Point(368, 18);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(75, 40);
            this.btnCreate.TabIndex = 1;
            this.btnCreate.Text = "生    成";
            this.btnCreate.UseVisualStyleBackColor = true;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // btnCheck
            // 
            this.btnCheck.Location = new System.Drawing.Point(368, 102);
            this.btnCheck.Name = "btnCheck";
            this.btnCheck.Size = new System.Drawing.Size(75, 40);
            this.btnCheck.TabIndex = 1;
            this.btnCheck.Text = "检    测";
            this.btnCheck.UseVisualStyleBackColor = true;
            this.btnCheck.Click += new System.EventHandler(this.btnCheck_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(453, 157);
            this.Controls.Add(this.btnCheck);
            this.Controls.Add(this.btnCreate);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.picBoard)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox picBoard;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RichTextBox txtContent;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.Button btnCheck;
    }
}

