namespace MyCodeAddin
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
			this.cklTableTree = new System.Windows.Forms.CheckedListBox();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.rdbEditRead = new System.Windows.Forms.RadioButton();
			this.rdbEdit = new System.Windows.Forms.RadioButton();
			this.rdbReadOnly = new System.Windows.Forms.RadioButton();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.cbPath = new System.Windows.Forms.CheckBox();
			this.btnOpen1 = new System.Windows.Forms.Button();
			this.btnOpen = new System.Windows.Forms.Button();
			this.txtDataPath = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.txtPath = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.btnStart = new System.Windows.Forms.Button();
			this.cbAll = new System.Windows.Forms.CheckBox();
			this.groupBox3 = new System.Windows.Forms.GroupBox();
			this.cbDal = new System.Windows.Forms.CheckBox();
			this.cbBus = new System.Windows.Forms.CheckBox();
			this.groupBox5 = new System.Windows.Forms.GroupBox();
			this.btnStartAll = new System.Windows.Forms.Button();
			this.btnDel = new System.Windows.Forms.Button();
			this.groupBox4 = new System.Windows.Forms.GroupBox();
			this.txtDalFile = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.txtBusFile = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.groupBox6 = new System.Windows.Forms.GroupBox();
			this.cklColumnSel = new System.Windows.Forms.CheckedListBox();
			this.groupBox7 = new System.Windows.Forms.GroupBox();
			this.button3 = new System.Windows.Forms.Button();
			this.button2 = new System.Windows.Forms.Button();
			this.btnInsert = new System.Windows.Forms.Button();
			this.groupBox1.SuspendLayout();
			this.groupBox2.SuspendLayout();
			this.groupBox3.SuspendLayout();
			this.groupBox5.SuspendLayout();
			this.groupBox4.SuspendLayout();
			this.groupBox6.SuspendLayout();
			this.groupBox7.SuspendLayout();
			this.SuspendLayout();
			// 
			// cklTableTree
			// 
			this.cklTableTree.Dock = System.Windows.Forms.DockStyle.Left;
			this.cklTableTree.FormattingEnabled = true;
			this.cklTableTree.Location = new System.Drawing.Point(3, 17);
			this.cklTableTree.Name = "cklTableTree";
			this.cklTableTree.Size = new System.Drawing.Size(215, 507);
			this.cklTableTree.TabIndex = 1;
			this.cklTableTree.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.cklTableTree_ItemCheck);
			this.cklTableTree.SelectedIndexChanged += new System.EventHandler(this.cklTableTree_SelectedIndexChanged);
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.rdbEditRead);
			this.groupBox1.Controls.Add(this.rdbEdit);
			this.groupBox1.Controls.Add(this.rdbReadOnly);
			this.groupBox1.Location = new System.Drawing.Point(21, 20);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(306, 52);
			this.groupBox1.TabIndex = 2;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "对象类型";
			// 
			// rdbEditRead
			// 
			this.rdbEditRead.AutoSize = true;
			this.rdbEditRead.Location = new System.Drawing.Point(225, 20);
			this.rdbEditRead.Name = "rdbEditRead";
			this.rdbEditRead.Size = new System.Drawing.Size(71, 16);
			this.rdbEditRead.TabIndex = 1;
			this.rdbEditRead.Text = "编辑只读";
			this.rdbEditRead.UseVisualStyleBackColor = true;
			// 
			// rdbEdit
			// 
			this.rdbEdit.AutoSize = true;
			this.rdbEdit.Location = new System.Drawing.Point(133, 20);
			this.rdbEdit.Name = "rdbEdit";
			this.rdbEdit.Size = new System.Drawing.Size(47, 16);
			this.rdbEdit.TabIndex = 0;
			this.rdbEdit.Text = "编辑";
			this.rdbEdit.UseVisualStyleBackColor = true;
			// 
			// rdbReadOnly
			// 
			this.rdbReadOnly.AutoSize = true;
			this.rdbReadOnly.Checked = true;
			this.rdbReadOnly.Location = new System.Drawing.Point(48, 20);
			this.rdbReadOnly.Name = "rdbReadOnly";
			this.rdbReadOnly.Size = new System.Drawing.Size(47, 16);
			this.rdbReadOnly.TabIndex = 0;
			this.rdbReadOnly.TabStop = true;
			this.rdbReadOnly.Text = "只读";
			this.rdbReadOnly.UseVisualStyleBackColor = true;
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.cbPath);
			this.groupBox2.Controls.Add(this.btnOpen1);
			this.groupBox2.Controls.Add(this.btnOpen);
			this.groupBox2.Controls.Add(this.txtDataPath);
			this.groupBox2.Controls.Add(this.label4);
			this.groupBox2.Controls.Add(this.txtPath);
			this.groupBox2.Controls.Add(this.label1);
			this.groupBox2.Location = new System.Drawing.Point(21, 305);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(306, 150);
			this.groupBox2.TabIndex = 3;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "生成路径";
			// 
			// cbPath
			// 
			this.cbPath.AutoSize = true;
			this.cbPath.Location = new System.Drawing.Point(176, 122);
			this.cbPath.Name = "cbPath";
			this.cbPath.Size = new System.Drawing.Size(120, 16);
			this.cbPath.TabIndex = 11;
			this.cbPath.Text = "设为默认生成路径";
			this.cbPath.UseVisualStyleBackColor = true;
			this.cbPath.CheckedChanged += new System.EventHandler(this.cbPath_CheckedChanged);
			// 
			// btnOpen1
			// 
			this.btnOpen1.Location = new System.Drawing.Point(252, 83);
			this.btnOpen1.Name = "btnOpen1";
			this.btnOpen1.Size = new System.Drawing.Size(48, 23);
			this.btnOpen1.TabIndex = 9;
			this.btnOpen1.Text = "浏览";
			this.btnOpen1.UseVisualStyleBackColor = true;
			this.btnOpen1.Click += new System.EventHandler(this.btnOpen1_Click);
			// 
			// btnOpen
			// 
			this.btnOpen.Location = new System.Drawing.Point(252, 30);
			this.btnOpen.Name = "btnOpen";
			this.btnOpen.Size = new System.Drawing.Size(48, 23);
			this.btnOpen.TabIndex = 10;
			this.btnOpen.Text = "浏览";
			this.btnOpen.UseVisualStyleBackColor = true;
			this.btnOpen.Click += new System.EventHandler(this.btnOpen_Click);
			// 
			// txtDataPath
			// 
			this.txtDataPath.Location = new System.Drawing.Point(55, 85);
			this.txtDataPath.Name = "txtDataPath";
			this.txtDataPath.Size = new System.Drawing.Size(191, 21);
			this.txtDataPath.TabIndex = 8;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(8, 88);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(41, 12);
			this.label4.TabIndex = 5;
			this.label4.Text = "数据层";
			// 
			// txtPath
			// 
			this.txtPath.Location = new System.Drawing.Point(55, 32);
			this.txtPath.Name = "txtPath";
			this.txtPath.Size = new System.Drawing.Size(191, 21);
			this.txtPath.TabIndex = 7;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(8, 35);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(41, 12);
			this.label1.TabIndex = 6;
			this.label1.Text = "业务层";
			// 
			// btnStart
			// 
			this.btnStart.Location = new System.Drawing.Point(142, 495);
			this.btnStart.Name = "btnStart";
			this.btnStart.Size = new System.Drawing.Size(75, 23);
			this.btnStart.TabIndex = 4;
			this.btnStart.Text = "生成";
			this.btnStart.UseVisualStyleBackColor = true;
			this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
			// 
			// cbAll
			// 
			this.cbAll.AutoSize = true;
			this.cbAll.Location = new System.Drawing.Point(26, 502);
			this.cbAll.Name = "cbAll";
			this.cbAll.Size = new System.Drawing.Size(48, 16);
			this.cbAll.TabIndex = 5;
			this.cbAll.Text = "全选";
			this.cbAll.UseVisualStyleBackColor = true;
			this.cbAll.CheckedChanged += new System.EventHandler(this.cbAll_CheckedChanged);
			// 
			// groupBox3
			// 
			this.groupBox3.Controls.Add(this.cbDal);
			this.groupBox3.Controls.Add(this.cbBus);
			this.groupBox3.Location = new System.Drawing.Point(21, 78);
			this.groupBox3.Name = "groupBox3";
			this.groupBox3.Size = new System.Drawing.Size(306, 70);
			this.groupBox3.TabIndex = 6;
			this.groupBox3.TabStop = false;
			this.groupBox3.Text = "生成选择";
			// 
			// cbDal
			// 
			this.cbDal.AutoSize = true;
			this.cbDal.Checked = true;
			this.cbDal.CheckState = System.Windows.Forms.CheckState.Checked;
			this.cbDal.Location = new System.Drawing.Point(169, 34);
			this.cbDal.Name = "cbDal";
			this.cbDal.Size = new System.Drawing.Size(60, 16);
			this.cbDal.TabIndex = 0;
			this.cbDal.Text = "数据层";
			this.cbDal.UseVisualStyleBackColor = true;
			// 
			// cbBus
			// 
			this.cbBus.AutoSize = true;
			this.cbBus.Checked = true;
			this.cbBus.CheckState = System.Windows.Forms.CheckState.Checked;
			this.cbBus.Location = new System.Drawing.Point(74, 34);
			this.cbBus.Name = "cbBus";
			this.cbBus.Size = new System.Drawing.Size(60, 16);
			this.cbBus.TabIndex = 0;
			this.cbBus.Text = "业务层";
			this.cbBus.UseVisualStyleBackColor = true;
			// 
			// groupBox5
			// 
			this.groupBox5.Controls.Add(this.btnStartAll);
			this.groupBox5.Controls.Add(this.btnDel);
			this.groupBox5.Controls.Add(this.groupBox1);
			this.groupBox5.Controls.Add(this.groupBox4);
			this.groupBox5.Controls.Add(this.groupBox2);
			this.groupBox5.Controls.Add(this.groupBox3);
			this.groupBox5.Controls.Add(this.btnStart);
			this.groupBox5.Controls.Add(this.cbAll);
			this.groupBox5.Dock = System.Windows.Forms.DockStyle.Right;
			this.groupBox5.Location = new System.Drawing.Point(624, 0);
			this.groupBox5.Name = "groupBox5";
			this.groupBox5.Size = new System.Drawing.Size(346, 527);
			this.groupBox5.TabIndex = 8;
			this.groupBox5.TabStop = false;
			this.groupBox5.Text = "参数设置";
			// 
			// btnStartAll
			// 
			this.btnStartAll.Location = new System.Drawing.Point(142, 461);
			this.btnStartAll.Name = "btnStartAll";
			this.btnStartAll.Size = new System.Drawing.Size(108, 23);
			this.btnStartAll.TabIndex = 9;
			this.btnStartAll.Text = "全部生成(只读)";
			this.btnStartAll.UseVisualStyleBackColor = true;
			this.btnStartAll.Click += new System.EventHandler(this.btnStartAll_Click);
			// 
			// btnDel
			// 
			this.btnDel.Location = new System.Drawing.Point(252, 495);
			this.btnDel.Name = "btnDel";
			this.btnDel.Size = new System.Drawing.Size(75, 23);
			this.btnDel.TabIndex = 8;
			this.btnDel.Text = "删除";
			this.btnDel.UseVisualStyleBackColor = true;
			this.btnDel.Click += new System.EventHandler(this.btnDel_Click);
			// 
			// groupBox4
			// 
			this.groupBox4.Controls.Add(this.txtDalFile);
			this.groupBox4.Controls.Add(this.label2);
			this.groupBox4.Controls.Add(this.txtBusFile);
			this.groupBox4.Controls.Add(this.label3);
			this.groupBox4.Location = new System.Drawing.Point(21, 154);
			this.groupBox4.Name = "groupBox4";
			this.groupBox4.Size = new System.Drawing.Size(306, 132);
			this.groupBox4.TabIndex = 7;
			this.groupBox4.TabStop = false;
			this.groupBox4.Text = "文件名称";
			// 
			// txtDalFile
			// 
			this.txtDalFile.Location = new System.Drawing.Point(55, 85);
			this.txtDalFile.Name = "txtDalFile";
			this.txtDalFile.Size = new System.Drawing.Size(241, 21);
			this.txtDalFile.TabIndex = 8;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(8, 88);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(41, 12);
			this.label2.TabIndex = 5;
			this.label2.Text = "数据层";
			// 
			// txtBusFile
			// 
			this.txtBusFile.Location = new System.Drawing.Point(55, 36);
			this.txtBusFile.Name = "txtBusFile";
			this.txtBusFile.Size = new System.Drawing.Size(241, 21);
			this.txtBusFile.TabIndex = 7;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(8, 39);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(41, 12);
			this.label3.TabIndex = 6;
			this.label3.Text = "业务层";
			// 
			// groupBox6
			// 
			this.groupBox6.Controls.Add(this.cklTableTree);
			this.groupBox6.Dock = System.Windows.Forms.DockStyle.Left;
			this.groupBox6.Location = new System.Drawing.Point(0, 0);
			this.groupBox6.Name = "groupBox6";
			this.groupBox6.Size = new System.Drawing.Size(224, 527);
			this.groupBox6.TabIndex = 9;
			this.groupBox6.TabStop = false;
			this.groupBox6.Text = "表名";
			// 
			// cklColumnSel
			// 
			this.cklColumnSel.Dock = System.Windows.Forms.DockStyle.Left;
			this.cklColumnSel.FormattingEnabled = true;
			this.cklColumnSel.Location = new System.Drawing.Point(3, 17);
			this.cklColumnSel.Name = "cklColumnSel";
			this.cklColumnSel.Size = new System.Drawing.Size(232, 507);
			this.cklColumnSel.TabIndex = 2;
			// 
			// groupBox7
			// 
			this.groupBox7.Controls.Add(this.btnInsert);
			this.groupBox7.Controls.Add(this.button3);
			this.groupBox7.Controls.Add(this.button2);
			this.groupBox7.Controls.Add(this.cklColumnSel);
			this.groupBox7.Dock = System.Windows.Forms.DockStyle.Left;
			this.groupBox7.Location = new System.Drawing.Point(224, 0);
			this.groupBox7.Name = "groupBox7";
			this.groupBox7.Size = new System.Drawing.Size(390, 527);
			this.groupBox7.TabIndex = 10;
			this.groupBox7.TabStop = false;
			this.groupBox7.Text = "字段挑选";
			// 
			// button3
			// 
			this.button3.Location = new System.Drawing.Point(263, 242);
			this.button3.Name = "button3";
			this.button3.Size = new System.Drawing.Size(75, 23);
			this.button3.TabIndex = 6;
			this.button3.Text = "反选";
			this.button3.UseVisualStyleBackColor = true;
			// 
			// button2
			// 
			this.button2.Location = new System.Drawing.Point(263, 167);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(75, 23);
			this.button2.TabIndex = 5;
			this.button2.Text = "全选";
			this.button2.UseVisualStyleBackColor = true;
			// 
			// btnInsert
			// 
			this.btnInsert.Location = new System.Drawing.Point(263, 78);
			this.btnInsert.Name = "btnInsert";
			this.btnInsert.Size = new System.Drawing.Size(75, 23);
			this.btnInsert.TabIndex = 7;
			this.btnInsert.Text = "属性插入";
			this.btnInsert.UseVisualStyleBackColor = true;
			this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(970, 527);
			this.Controls.Add(this.groupBox7);
			this.Controls.Add(this.groupBox6);
			this.Controls.Add(this.groupBox5);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Name = "Form1";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "代码自动生成器";
			this.Load += new System.EventHandler(this.Form1_Load);
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.groupBox2.ResumeLayout(false);
			this.groupBox2.PerformLayout();
			this.groupBox3.ResumeLayout(false);
			this.groupBox3.PerformLayout();
			this.groupBox5.ResumeLayout(false);
			this.groupBox5.PerformLayout();
			this.groupBox4.ResumeLayout(false);
			this.groupBox4.PerformLayout();
			this.groupBox6.ResumeLayout(false);
			this.groupBox7.ResumeLayout(false);
			this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.CheckedListBox cklTableTree;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdbEdit;
        private System.Windows.Forms.RadioButton rdbReadOnly;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnOpen1;
        private System.Windows.Forms.Button btnOpen;
        private System.Windows.Forms.TextBox txtDataPath;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtPath;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.CheckBox cbAll;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.CheckBox cbDal;
        private System.Windows.Forms.CheckBox cbBus;
        private System.Windows.Forms.CheckBox cbPath;
		private System.Windows.Forms.RadioButton rdbEditRead;
		private System.Windows.Forms.GroupBox groupBox5;
		private System.Windows.Forms.GroupBox groupBox6;
		private System.Windows.Forms.CheckedListBox cklColumnSel;
		private System.Windows.Forms.GroupBox groupBox7;
		private System.Windows.Forms.Button button3;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.GroupBox groupBox4;
		private System.Windows.Forms.TextBox txtDalFile;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox txtBusFile;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Button btnDel;
		private System.Windows.Forms.Button btnStartAll;
		private System.Windows.Forms.Button btnInsert;
    }
}

