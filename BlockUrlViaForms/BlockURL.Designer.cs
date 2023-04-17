namespace BlockUrlViaForms
{
    partial class BlockURL
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
            this.label1 = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.btnAddUrl = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.btnSampleUrl = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label1.Font = new System.Drawing.Font("Georgia", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(276, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(217, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Block URL Via Host file";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(357, 139);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(85, 29);
            this.button1.TabIndex = 1;
            this.button1.Text = "Backup";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(216, 142);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = " Backup Host file";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(210, 246);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(113, 16);
            this.label3.TabIndex = 3;
            this.label3.Text = "Add URL to Block";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(357, 240);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(257, 22);
            this.textBox1.TabIndex = 4;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(474, 139);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(76, 29);
            this.button2.TabIndex = 5;
            this.button2.Text = "Revert";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnAddUrl
            // 
            this.btnAddUrl.Location = new System.Drawing.Point(436, 283);
            this.btnAddUrl.Name = "btnAddUrl";
            this.btnAddUrl.Size = new System.Drawing.Size(79, 31);
            this.btnAddUrl.TabIndex = 7;
            this.btnAddUrl.Text = "Add Url";
            this.btnAddUrl.UseVisualStyleBackColor = true;
            this.btnAddUrl.Click += new System.EventHandler(this.btnAddUrl_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(216, 184);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(94, 16);
            this.label4.TabIndex = 8;
            this.label4.Text = "Sample URL\'s";
            // 
            // btnSampleUrl
            // 
            this.btnSampleUrl.Location = new System.Drawing.Point(357, 181);
            this.btnSampleUrl.Name = "btnSampleUrl";
            this.btnSampleUrl.Size = new System.Drawing.Size(85, 28);
            this.btnSampleUrl.TabIndex = 9;
            this.btnSampleUrl.Text = "Example";
            this.btnSampleUrl.UseVisualStyleBackColor = true;
            this.btnSampleUrl.Click += new System.EventHandler(this.btnSampleUrl_Click);
            // 
            // BlockURL
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnSampleUrl);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnAddUrl);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Name = "BlockURL";
            this.Text = "BlockURL";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnAddUrl;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnSampleUrl;
    }
}