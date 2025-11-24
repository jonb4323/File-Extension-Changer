namespace FileExtensionChanger {
    partial class Form1 {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) { components.Dispose(); }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.input_file_btn = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.start_btn = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.status_label = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.select_file_from_list_btn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.label1.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(99, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(234, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "File Extension Changer v1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(9, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Select a file:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-518, -376);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1157, 815);
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // input_file_btn
            // 
            this.input_file_btn.BackColor = System.Drawing.Color.White;
            this.input_file_btn.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.input_file_btn.Location = new System.Drawing.Point(8, 56);
            this.input_file_btn.Name = "input_file_btn";
            this.input_file_btn.Size = new System.Drawing.Size(100, 23);
            this.input_file_btn.TabIndex = 3;
            this.input_file_btn.Text = "INPUT";
            this.input_file_btn.UseVisualStyleBackColor = false;
            this.input_file_btn.Click += new System.EventHandler(this.button1_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(323, 37);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(99, 212);
            this.listBox1.TabIndex = 4;
            // 
            // start_btn
            // 
            this.start_btn.BackColor = System.Drawing.Color.Black;
            this.start_btn.Font = new System.Drawing.Font("Verdana", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.start_btn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.start_btn.Location = new System.Drawing.Point(12, 162);
            this.start_btn.Name = "start_btn";
            this.start_btn.Size = new System.Drawing.Size(210, 43);
            this.start_btn.TabIndex = 6;
            this.start_btn.Text = "GO";
            this.start_btn.UseVisualStyleBackColor = false;
            this.start_btn.Click += new System.EventHandler(this.start_btn_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Verdana", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(12, 220);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(121, 32);
            this.label3.TabIndex = 7;
            this.label3.Text = "Status:";
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(0, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 23);
            this.label4.TabIndex = 0;
            // 
            // status_label
            // 
            this.status_label.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.status_label.Font = new System.Drawing.Font("Verdana", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.status_label.Location = new System.Drawing.Point(144, 220);
            this.status_label.Name = "status_label";
            this.status_label.Size = new System.Drawing.Size(173, 32);
            this.status_label.TabIndex = 0;
            this.status_label.Text = "Idle";
            this.status_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(0, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(100, 23);
            this.label6.TabIndex = 0;
            // 
            // select_file_from_list_btn
            // 
            this.select_file_from_list_btn.BackColor = System.Drawing.Color.White;
            this.select_file_from_list_btn.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.select_file_from_list_btn.ForeColor = System.Drawing.Color.Black;
            this.select_file_from_list_btn.Location = new System.Drawing.Point(172, 37);
            this.select_file_from_list_btn.Name = "select_file_from_list_btn";
            this.select_file_from_list_btn.Size = new System.Drawing.Size(145, 54);
            this.select_file_from_list_btn.TabIndex = 5;
            this.select_file_from_list_btn.Text = "Click Here\r\nwhen Selected ->";
            this.select_file_from_list_btn.UseVisualStyleBackColor = false;
            this.select_file_from_list_btn.Click += new System.EventHandler(this.select_file_from_list_btn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(434, 261);
            this.Controls.Add(this.status_label);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.start_btn);
            this.Controls.Add(this.select_file_from_list_btn);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.input_file_btn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(450, 300);
            this.MinimumSize = new System.Drawing.Size(450, 300);
            this.Name = "Form1";
            this.Text = "File Extension Changer";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button input_file_btn;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button start_btn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label status_label;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button select_file_from_list_btn;
    }
}

