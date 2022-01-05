
namespace PlamemoTransTool
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openFilecsvToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveFilecsvToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.tb_line = new System.Windows.Forms.TextBox();
            this.tB_name = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tB_nick = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tB_lineKR = new System.Windows.Forms.TextBox();
            this.tB_nickKR = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tB_nameKR = new System.Windows.Forms.TextBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.btn_apply = new System.Windows.Forms.Button();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.lable_fileName = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(733, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openFilecsvToolStripMenuItem,
            this.saveFilecsvToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // openFilecsvToolStripMenuItem
            // 
            this.openFilecsvToolStripMenuItem.Name = "openFilecsvToolStripMenuItem";
            this.openFilecsvToolStripMenuItem.Size = new System.Drawing.Size(125, 22);
            this.openFilecsvToolStripMenuItem.Text = "Open File";
            this.openFilecsvToolStripMenuItem.Click += new System.EventHandler(this.openFilecsvToolStripMenuItem_Click);
            // 
            // saveFilecsvToolStripMenuItem
            // 
            this.saveFilecsvToolStripMenuItem.Name = "saveFilecsvToolStripMenuItem";
            this.saveFilecsvToolStripMenuItem.Size = new System.Drawing.Size(125, 22);
            this.saveFilecsvToolStripMenuItem.Text = "Save File";
            this.saveFilecsvToolStripMenuItem.Click += new System.EventHandler(this.saveFilecsvToolStripMenuItem_Click);
            // 
            // listBox1
            // 
            this.listBox1.Font = new System.Drawing.Font("Gulim", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.listBox1.FormattingEnabled = true;
            this.listBox1.HorizontalScrollbar = true;
            this.listBox1.ItemHeight = 15;
            this.listBox1.Location = new System.Drawing.Point(12, 27);
            this.listBox1.Name = "listBox1";
            this.listBox1.ScrollAlwaysVisible = true;
            this.listBox1.Size = new System.Drawing.Size(282, 319);
            this.listBox1.TabIndex = 1;
            this.listBox1.Click += new System.EventHandler(this.listBox1_Click);
            // 
            // tb_line
            // 
            this.tb_line.Font = new System.Drawing.Font("Gulim", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.tb_line.Location = new System.Drawing.Point(122, 36);
            this.tb_line.Multiline = true;
            this.tb_line.Name = "tb_line";
            this.tb_line.ReadOnly = true;
            this.tb_line.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tb_line.Size = new System.Drawing.Size(294, 92);
            this.tb_line.TabIndex = 2;
            // 
            // tB_name
            // 
            this.tB_name.Font = new System.Drawing.Font("Gulim", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.tB_name.Location = new System.Drawing.Point(6, 36);
            this.tB_name.Name = "tB_name";
            this.tB_name.ReadOnly = true;
            this.tB_name.Size = new System.Drawing.Size(110, 22);
            this.tB_name.TabIndex = 4;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.tb_line);
            this.groupBox1.Controls.Add(this.tB_nick);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.tB_name);
            this.groupBox1.Location = new System.Drawing.Point(300, 27);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(426, 144);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "원본";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(122, 20);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(29, 12);
            this.label5.TabIndex = 9;
            this.label5.Text = "대사";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 12);
            this.label2.TabIndex = 8;
            this.label2.Text = "닉네임";
            // 
            // tB_nick
            // 
            this.tB_nick.Font = new System.Drawing.Font("Gulim", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.tB_nick.Location = new System.Drawing.Point(6, 94);
            this.tB_nick.Name = "tB_nick";
            this.tB_nick.ReadOnly = true;
            this.tB_nick.Size = new System.Drawing.Size(110, 22);
            this.tB_nick.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 12);
            this.label1.TabIndex = 6;
            this.label1.Text = "이름";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.tB_lineKR);
            this.groupBox2.Controls.Add(this.tB_nickKR);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.tB_nameKR);
            this.groupBox2.Location = new System.Drawing.Point(300, 177);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(426, 142);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "[ 번역본 ]";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(122, 21);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(29, 12);
            this.label6.TabIndex = 10;
            this.label6.Text = "대사";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 79);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 12);
            this.label3.TabIndex = 8;
            this.label3.Text = "닉네임";
            // 
            // tB_lineKR
            // 
            this.tB_lineKR.Font = new System.Drawing.Font("Gulim", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.tB_lineKR.Location = new System.Drawing.Point(122, 36);
            this.tB_lineKR.Multiline = true;
            this.tB_lineKR.Name = "tB_lineKR";
            this.tB_lineKR.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tB_lineKR.Size = new System.Drawing.Size(294, 92);
            this.tB_lineKR.TabIndex = 2;
            // 
            // tB_nickKR
            // 
            this.tB_nickKR.Font = new System.Drawing.Font("Gulim", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.tB_nickKR.Location = new System.Drawing.Point(6, 94);
            this.tB_nickKR.Name = "tB_nickKR";
            this.tB_nickKR.Size = new System.Drawing.Size(110, 22);
            this.tB_nickKR.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 21);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 12);
            this.label4.TabIndex = 6;
            this.label4.Text = "이름";
            // 
            // tB_nameKR
            // 
            this.tB_nameKR.Font = new System.Drawing.Font("Gulim", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.tB_nameKR.Location = new System.Drawing.Point(6, 36);
            this.tB_nameKR.Name = "tB_nameKR";
            this.tB_nameKR.Size = new System.Drawing.Size(110, 22);
            this.tB_nameKR.TabIndex = 4;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.Filter = "csv files (*csv)|*.csv";
            this.openFileDialog1.Title = "파일 열기";
            // 
            // btn_apply
            // 
            this.btn_apply.Location = new System.Drawing.Point(606, 325);
            this.btn_apply.Name = "btn_apply";
            this.btn_apply.Size = new System.Drawing.Size(110, 27);
            this.btn_apply.TabIndex = 11;
            this.btn_apply.Text = "적용";
            this.btn_apply.UseVisualStyleBackColor = true;
            this.btn_apply.Click += new System.EventHandler(this.button1_Click);
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.Filter = "csv files (*csv)|*.csv";
            // 
            // lable_fileName
            // 
            this.lable_fileName.AutoSize = true;
            this.lable_fileName.Location = new System.Drawing.Point(300, 333);
            this.lable_fileName.Name = "lable_fileName";
            this.lable_fileName.Size = new System.Drawing.Size(0, 12);
            this.lable_fileName.TabIndex = 12;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.Crimson;
            this.label7.Location = new System.Drawing.Point(503, 332);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(97, 12);
            this.label7.TabIndex = 13;
            this.label7.Text = "적용 꼭 누르기!!!";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(733, 364);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.lable_fileName);
            this.Controls.Add(this.btn_apply);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "플라메모 번역툴 v0.3";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openFilecsvToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveFilecsvToolStripMenuItem;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.TextBox tb_line;
        private System.Windows.Forms.TextBox tB_name;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tB_nick;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tB_lineKR;
        private System.Windows.Forms.TextBox tB_nickKR;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tB_nameKR;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button btn_apply;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Label lable_fileName;
        private System.Windows.Forms.Label label7;
    }
}

