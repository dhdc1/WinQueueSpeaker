namespace WinQueueSpeaker
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
            this.lbShowQueue = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lbFullName = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbShowQueue
            // 
            this.lbShowQueue.AutoSize = true;
            this.lbShowQueue.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.lbShowQueue.Location = new System.Drawing.Point(12, 119);
            this.lbShowQueue.Name = "lbShowQueue";
            this.lbShowQueue.Size = new System.Drawing.Size(103, 38);
            this.lbShowQueue.TabIndex = 0;
            this.lbShowQueue.Text = "label1";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(517, 32);
            this.label1.TabIndex = 1;
            this.label1.Text = "WinQueueSpeaker V1.0.0 (2019-03-12)";
            // 
            // lbFullName
            // 
            this.lbFullName.AutoSize = true;
            this.lbFullName.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.lbFullName.Location = new System.Drawing.Point(19, 178);
            this.lbFullName.Name = "lbFullName";
            this.lbFullName.Size = new System.Drawing.Size(93, 32);
            this.lbFullName.TabIndex = 2;
            this.lbFullName.Text = "label2";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(590, 372);
            this.Controls.Add(this.lbFullName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbShowQueue);
            this.Name = "Form1";
            this.Text = "SmartQueue";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbShowQueue;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbFullName;
    }
}

