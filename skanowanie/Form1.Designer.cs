namespace skanowanie
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
            this.lbMessage = new System.Windows.Forms.ListBox();
            this.btScann = new System.Windows.Forms.Button();
            this.tbhostAdress = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbMessage
            // 
            this.lbMessage.FormattingEnabled = true;
            this.lbMessage.Location = new System.Drawing.Point(12, 67);
            this.lbMessage.Name = "lbMessage";
            this.lbMessage.Size = new System.Drawing.Size(327, 433);
            this.lbMessage.TabIndex = 0;
            // 
            // btScann
            // 
            this.btScann.Location = new System.Drawing.Point(285, 26);
            this.btScann.Name = "btScann";
            this.btScann.Size = new System.Drawing.Size(75, 23);
            this.btScann.TabIndex = 1;
            this.btScann.Text = "Scan";
            this.btScann.UseVisualStyleBackColor = true;
            this.btScann.Click += new System.EventHandler(this.btScann_Click);
            // 
            // tbhostAdress
            // 
            this.tbhostAdress.Location = new System.Drawing.Point(77, 26);
            this.tbhostAdress.Name = "tbhostAdress";
            this.tbhostAdress.Size = new System.Drawing.Size(155, 20);
            this.tbhostAdress.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Host";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(372, 519);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbhostAdress);
            this.Controls.Add(this.btScann);
            this.Controls.Add(this.lbMessage);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbMessage;
        private System.Windows.Forms.Button btScann;
        private System.Windows.Forms.TextBox tbhostAdress;
        private System.Windows.Forms.Label label1;
    }
}

