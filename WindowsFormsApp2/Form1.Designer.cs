namespace WindowsFormsApp2
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
            this.components = new System.ComponentModel.Container();
            this.Fox_pb = new System.Windows.Forms.PictureBox();
            this.Api_p = new System.Windows.Forms.Panel();
            this.path_tb = new System.Windows.Forms.TextBox();
            this.Back_b = new System.Windows.Forms.Button();
            this.Next_b = new System.Windows.Forms.Button();
            this.OpenDirective_b = new System.Windows.Forms.Button();
            this.Quote_rtb = new System.Windows.Forms.RichTextBox();
            this.DirectoryShow_wb = new System.Windows.Forms.WebBrowser();
            this.Directory_fbd = new System.Windows.Forms.FolderBrowserDialog();
            this.Api_t = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.Fox_pb)).BeginInit();
            this.Api_p.SuspendLayout();
            this.SuspendLayout();
            // 
            // Fox_pb
            // 
            this.Fox_pb.Location = new System.Drawing.Point(12, 12);
            this.Fox_pb.Name = "Fox_pb";
            this.Fox_pb.Size = new System.Drawing.Size(50, 50);
            this.Fox_pb.TabIndex = 0;
            this.Fox_pb.TabStop = false;
            // 
            // Api_p
            // 
            this.Api_p.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Api_p.Controls.Add(this.Fox_pb);
            this.Api_p.Location = new System.Drawing.Point(0, 0);
            this.Api_p.Name = "Api_p";
            this.Api_p.Size = new System.Drawing.Size(800, 76);
            this.Api_p.TabIndex = 2;
            // 
            // path_tb
            // 
            this.path_tb.Location = new System.Drawing.Point(68, 82);
            this.path_tb.Name = "path_tb";
            this.path_tb.Size = new System.Drawing.Size(639, 20);
            this.path_tb.TabIndex = 3;
            // 
            // Back_b
            // 
            this.Back_b.Location = new System.Drawing.Point(12, 80);
            this.Back_b.Name = "Back_b";
            this.Back_b.Size = new System.Drawing.Size(23, 23);
            this.Back_b.TabIndex = 4;
            this.Back_b.Text = "<";
            this.Back_b.UseVisualStyleBackColor = true;
            this.Back_b.Click += new System.EventHandler(this.Back_b_Click);
            // 
            // Next_b
            // 
            this.Next_b.Location = new System.Drawing.Point(39, 80);
            this.Next_b.Name = "Next_b";
            this.Next_b.Size = new System.Drawing.Size(23, 23);
            this.Next_b.TabIndex = 6;
            this.Next_b.Text = ">";
            this.Next_b.UseVisualStyleBackColor = true;
            this.Next_b.Click += new System.EventHandler(this.Next_b_Click);
            // 
            // OpenDirective_b
            // 
            this.OpenDirective_b.Location = new System.Drawing.Point(713, 79);
            this.OpenDirective_b.Name = "OpenDirective_b";
            this.OpenDirective_b.Size = new System.Drawing.Size(75, 23);
            this.OpenDirective_b.TabIndex = 7;
            this.OpenDirective_b.Text = "Open";
            this.OpenDirective_b.UseVisualStyleBackColor = true;
            // 
            // Quote_rtb
            // 
            this.Quote_rtb.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Quote_rtb.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Quote_rtb.Cursor = System.Windows.Forms.Cursors.Default;
            this.Quote_rtb.ForeColor = System.Drawing.SystemColors.WindowText;
            this.Quote_rtb.Location = new System.Drawing.Point(68, 12);
            this.Quote_rtb.Name = "Quote_rtb";
            this.Quote_rtb.ReadOnly = true;
            this.Quote_rtb.Size = new System.Drawing.Size(720, 50);
            this.Quote_rtb.TabIndex = 1;
            this.Quote_rtb.Text = "";
            // 
            // DirectoryShow_wb
            // 
            this.DirectoryShow_wb.Location = new System.Drawing.Point(12, 108);
            this.DirectoryShow_wb.MinimumSize = new System.Drawing.Size(20, 20);
            this.DirectoryShow_wb.Name = "DirectoryShow_wb";
            this.DirectoryShow_wb.Size = new System.Drawing.Size(776, 339);
            this.DirectoryShow_wb.TabIndex = 8;
            this.DirectoryShow_wb.Navigated += new System.Windows.Forms.WebBrowserNavigatedEventHandler(this.DirectoryShow_wb_Navigated);
            // 
            // Directory_fbd
            // 
            this.Directory_fbd.Description = "Select your path.";
            // 
            // Api_t
            // 
            this.Api_t.Interval = 15000;
            this.Api_t.Tick += new System.EventHandler(this.Api_t_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.DirectoryShow_wb);
            this.Controls.Add(this.Quote_rtb);
            this.Controls.Add(this.OpenDirective_b);
            this.Controls.Add(this.Next_b);
            this.Controls.Add(this.Back_b);
            this.Controls.Add(this.path_tb);
            this.Controls.Add(this.Api_p);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.Fox_pb)).EndInit();
            this.Api_p.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox Fox_pb;
        private System.Windows.Forms.Panel Api_p;
        private System.Windows.Forms.TextBox path_tb;
        private System.Windows.Forms.Button Back_b;
        private System.Windows.Forms.Button Next_b;
        private System.Windows.Forms.Button OpenDirective_b;
        private System.Windows.Forms.RichTextBox Quote_rtb;
        private System.Windows.Forms.WebBrowser DirectoryShow_wb;
        private System.Windows.Forms.FolderBrowserDialog Directory_fbd;
        private System.Windows.Forms.Timer Api_t;
    }
}

