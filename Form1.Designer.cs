namespace HashVerifier
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
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.sele_btn = new System.Windows.Forms.Button();
            this.select_label = new System.Windows.Forms.Label();
            this.input = new System.Windows.Forms.TextBox();
            this.fileselect_choose_label = new System.Windows.Forms.CheckBox();
            this.hash_input_label = new System.Windows.Forms.CheckBox();
            this.progress_panel = new System.Windows.Forms.GroupBox();
            this.progressBar2 = new System.Windows.Forms.ProgressBar();
            this.verif_btn = new System.Windows.Forms.Button();
            this.inputsha1notice = new System.Windows.Forms.Label();
            this.chengeToCN = new System.Windows.Forms.LinkLabel();
            this.chengeToEN = new System.Windows.Forms.LinkLabel();
            this.developer_web_btn = new System.Windows.Forms.LinkLabel();
            this.select_bar = new System.Windows.Forms.TrackBar();
            this.algo_select_notice = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.maker_name = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.counter_label = new System.Windows.Forms.Label();
            this.select_status = new System.Windows.Forms.CheckBox();
            this.progress_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.select_bar)).BeginInit();
            this.algo_select_notice.SuspendLayout();
            this.SuspendLayout();
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // sele_btn
            // 
            this.sele_btn.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.sele_btn.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sele_btn.Location = new System.Drawing.Point(15, 153);
            this.sele_btn.Name = "sele_btn";
            this.sele_btn.Size = new System.Drawing.Size(77, 33);
            this.sele_btn.TabIndex = 0;
            this.sele_btn.Text = "Select";
            this.sele_btn.UseVisualStyleBackColor = false;
            this.sele_btn.Click += new System.EventHandler(this.button1_Click);
            // 
            // select_label
            // 
            this.select_label.AutoSize = true;
            this.select_label.Font = new System.Drawing.Font("Arial Narrow", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.select_label.Location = new System.Drawing.Point(98, 157);
            this.select_label.Name = "select_label";
            this.select_label.Size = new System.Drawing.Size(295, 23);
            this.select_label.TabIndex = 1;
            this.select_label.Text = "Please Selecte a file that you want to verify\r\n";
            this.select_label.Click += new System.EventHandler(this.label1_Click);
            // 
            // input
            // 
            this.input.Location = new System.Drawing.Point(27, 229);
            this.input.MaxLength = 96;
            this.input.Name = "input";
            this.input.Size = new System.Drawing.Size(366, 25);
            this.input.TabIndex = 2;
            this.input.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // fileselect_choose_label
            // 
            this.fileselect_choose_label.AutoCheck = false;
            this.fileselect_choose_label.AutoSize = true;
            this.fileselect_choose_label.Enabled = false;
            this.fileselect_choose_label.Font = new System.Drawing.Font("Arial Narrow", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fileselect_choose_label.Location = new System.Drawing.Point(35, 69);
            this.fileselect_choose_label.Name = "fileselect_choose_label";
            this.fileselect_choose_label.Size = new System.Drawing.Size(103, 24);
            this.fileselect_choose_label.TabIndex = 3;
            this.fileselect_choose_label.Text = "Select a File ";
            this.fileselect_choose_label.UseVisualStyleBackColor = true;
            this.fileselect_choose_label.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // hash_input_label
            // 
            this.hash_input_label.AutoCheck = false;
            this.hash_input_label.AutoSize = true;
            this.hash_input_label.Enabled = false;
            this.hash_input_label.Font = new System.Drawing.Font("Arial Narrow", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hash_input_label.Location = new System.Drawing.Point(35, 99);
            this.hash_input_label.Name = "hash_input_label";
            this.hash_input_label.Size = new System.Drawing.Size(149, 24);
            this.hash_input_label.TabIndex = 4;
            this.hash_input_label.Text = "Type the SHA-1 Hash";
            this.hash_input_label.UseVisualStyleBackColor = true;
            // 
            // progress_panel
            // 
            this.progress_panel.Controls.Add(this.select_status);
            this.progress_panel.Controls.Add(this.fileselect_choose_label);
            this.progress_panel.Controls.Add(this.hash_input_label);
            this.progress_panel.Font = new System.Drawing.Font("Arial Narrow", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.progress_panel.Location = new System.Drawing.Point(42, 316);
            this.progress_panel.Name = "progress_panel";
            this.progress_panel.Size = new System.Drawing.Size(298, 156);
            this.progress_panel.TabIndex = 5;
            this.progress_panel.TabStop = false;
            this.progress_panel.Text = "Input Prograss";
            this.progress_panel.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // progressBar2
            // 
            this.progressBar2.Location = new System.Drawing.Point(27, 260);
            this.progressBar2.Name = "progressBar2";
            this.progressBar2.Size = new System.Drawing.Size(230, 34);
            this.progressBar2.TabIndex = 5;
            this.progressBar2.Click += new System.EventHandler(this.progressBar2_Click);
            // 
            // verif_btn
            // 
            this.verif_btn.Font = new System.Drawing.Font("SimSun", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.verif_btn.Location = new System.Drawing.Point(25, 495);
            this.verif_btn.Name = "verif_btn";
            this.verif_btn.Size = new System.Drawing.Size(348, 55);
            this.verif_btn.TabIndex = 6;
            this.verif_btn.Text = "Verify !";
            this.verif_btn.UseVisualStyleBackColor = true;
            this.verif_btn.Click += new System.EventHandler(this.verif_btn_Click);
            // 
            // inputsha1notice
            // 
            this.inputsha1notice.AutoSize = true;
            this.inputsha1notice.Font = new System.Drawing.Font("Arial Narrow", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inputsha1notice.Location = new System.Drawing.Point(29, 203);
            this.inputsha1notice.Name = "inputsha1notice";
            this.inputsha1notice.Size = new System.Drawing.Size(52, 23);
            this.inputsha1notice.TabIndex = 7;
            this.inputsha1notice.Text = "label2";
            this.inputsha1notice.Click += new System.EventHandler(this.inputsha1notice_Click);
            // 
            // chengeToCN
            // 
            this.chengeToCN.AutoSize = true;
            this.chengeToCN.Location = new System.Drawing.Point(312, 587);
            this.chengeToCN.Name = "chengeToCN";
            this.chengeToCN.Size = new System.Drawing.Size(67, 15);
            this.chengeToCN.TabIndex = 8;
            this.chengeToCN.TabStop = true;
            this.chengeToCN.Text = "简体中文";
            this.chengeToCN.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // chengeToEN
            // 
            this.chengeToEN.AutoSize = true;
            this.chengeToEN.Location = new System.Drawing.Point(312, 602);
            this.chengeToEN.Name = "chengeToEN";
            this.chengeToEN.Size = new System.Drawing.Size(95, 15);
            this.chengeToEN.TabIndex = 9;
            this.chengeToEN.TabStop = true;
            this.chengeToEN.Text = "English(UK)";
            this.chengeToEN.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.chengeToEN_LinkClicked);
            // 
            // developer_web_btn
            // 
            this.developer_web_btn.AutoSize = true;
            this.developer_web_btn.Location = new System.Drawing.Point(0, 602);
            this.developer_web_btn.Name = "developer_web_btn";
            this.developer_web_btn.Size = new System.Drawing.Size(143, 15);
            this.developer_web_btn.TabIndex = 10;
            this.developer_web_btn.TabStop = true;
            this.developer_web_btn.Text = "Developer Website";
            this.developer_web_btn.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.developer_web_btn_LinkClicked);
            // 
            // select_bar
            // 
            this.select_bar.LargeChange = 1;
            this.select_bar.Location = new System.Drawing.Point(30, 34);
            this.select_bar.Maximum = 3;
            this.select_bar.Name = "select_bar";
            this.select_bar.Size = new System.Drawing.Size(331, 56);
            this.select_bar.SmallChange = 0;
            this.select_bar.TabIndex = 11;
            this.select_bar.Value = 1;
            this.select_bar.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            // 
            // algo_select_notice
            // 
            this.algo_select_notice.Controls.Add(this.label4);
            this.algo_select_notice.Controls.Add(this.label3);
            this.algo_select_notice.Controls.Add(this.label2);
            this.algo_select_notice.Controls.Add(this.label1);
            this.algo_select_notice.Controls.Add(this.select_bar);
            this.algo_select_notice.Font = new System.Drawing.Font("Arial Narrow", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.algo_select_notice.Location = new System.Drawing.Point(3, 12);
            this.algo_select_notice.Name = "algo_select_notice";
            this.algo_select_notice.Size = new System.Drawing.Size(400, 112);
            this.algo_select_notice.TabIndex = 12;
            this.algo_select_notice.TabStop = false;
            this.algo_select_notice.Text = "Select the cryptographic algorithm for verification";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 23);
            this.label1.TabIndex = 12;
            this.label1.Text = "MD5";
            this.label1.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(122, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 23);
            this.label2.TabIndex = 13;
            this.label2.Text = "SHA-1";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(207, 74);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 23);
            this.label3.TabIndex = 14;
            this.label3.Text = "SHA-256";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(308, 74);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 23);
            this.label4.TabIndex = 15;
            this.label4.Text = "SHA-384";
            // 
            // maker_name
            // 
            this.maker_name.AutoSize = true;
            this.maker_name.Location = new System.Drawing.Point(0, 578);
            this.maker_name.Name = "maker_name";
            this.maker_name.Size = new System.Drawing.Size(127, 15);
            this.maker_name.TabIndex = 13;
            this.maker_name.Text = "Code by FortyIX";
            this.maker_name.Click += new System.EventHandler(this.maker_name_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(257, 270);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(103, 15);
            this.label5.TabIndex = 14;
            this.label5.Text = "Digits left:";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // counter_label
            // 
            this.counter_label.AutoSize = true;
            this.counter_label.Location = new System.Drawing.Point(356, 270);
            this.counter_label.Name = "counter_label";
            this.counter_label.Size = new System.Drawing.Size(23, 15);
            this.counter_label.TabIndex = 15;
            this.counter_label.Text = "32";
            // 
            // select_status
            // 
            this.select_status.AutoCheck = false;
            this.select_status.AutoEllipsis = true;
            this.select_status.AutoSize = true;
            this.select_status.Enabled = false;
            this.select_status.Font = new System.Drawing.Font("Arial Narrow", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.select_status.Location = new System.Drawing.Point(35, 39);
            this.select_status.Name = "select_status";
            this.select_status.Size = new System.Drawing.Size(209, 24);
            this.select_status.TabIndex = 5;
            this.select_status.Text = "Select a cryptographic algorithm";
            this.select_status.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(412, 626);
            this.Controls.Add(this.counter_label);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.progressBar2);
            this.Controls.Add(this.maker_name);
            this.Controls.Add(this.developer_web_btn);
            this.Controls.Add(this.chengeToEN);
            this.Controls.Add(this.chengeToCN);
            this.Controls.Add(this.inputsha1notice);
            this.Controls.Add(this.verif_btn);
            this.Controls.Add(this.input);
            this.Controls.Add(this.select_label);
            this.Controls.Add(this.sele_btn);
            this.Controls.Add(this.progress_panel);
            this.Controls.Add(this.algo_select_notice);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "FileVerifier";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.progress_panel.ResumeLayout(false);
            this.progress_panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.select_bar)).EndInit();
            this.algo_select_notice.ResumeLayout(false);
            this.algo_select_notice.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button sele_btn;
        private System.Windows.Forms.Label select_label;
        private System.Windows.Forms.TextBox input;
        private System.Windows.Forms.CheckBox fileselect_choose_label;
        private System.Windows.Forms.CheckBox hash_input_label;
        private System.Windows.Forms.GroupBox progress_panel;
        private System.Windows.Forms.Button verif_btn;
        private System.Windows.Forms.ProgressBar progressBar2;
        private System.Windows.Forms.Label inputsha1notice;
        private System.Windows.Forms.LinkLabel chengeToCN;
        private System.Windows.Forms.LinkLabel chengeToEN;
        private System.Windows.Forms.LinkLabel developer_web_btn;
        private System.Windows.Forms.TrackBar select_bar;
        private System.Windows.Forms.GroupBox algo_select_notice;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label maker_name;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckBox select_status;
        private System.Windows.Forms.Label counter_label;
    }
}

