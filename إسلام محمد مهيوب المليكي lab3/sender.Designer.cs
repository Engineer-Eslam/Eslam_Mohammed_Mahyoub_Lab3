namespace إسلام_محمد_مهيوب_المليكي_lab3
{
    partial class sender
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
            this.button1 = new System.Windows.Forms.Button();
            this.btnYellow = new System.Windows.Forms.Button();
            this.btnGreen = new System.Windows.Forms.Button();
            this.btnRed = new System.Windows.Forms.Button();
            this.device1 = new System.Windows.Forms.Label();
            this.device2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Location = new System.Drawing.Point(138, 175);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(148, 46);
            this.button1.TabIndex = 0;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // btnYellow
            // 
            this.btnYellow.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnYellow.Location = new System.Drawing.Point(318, 86);
            this.btnYellow.Name = "btnYellow";
            this.btnYellow.Size = new System.Drawing.Size(102, 36);
            this.btnYellow.TabIndex = 1;
            this.btnYellow.Text = "أصفر";
            this.btnYellow.UseVisualStyleBackColor = true;
            // 
            // btnGreen
            // 
            this.btnGreen.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnGreen.Location = new System.Drawing.Point(166, 86);
            this.btnGreen.Name = "btnGreen";
            this.btnGreen.Size = new System.Drawing.Size(102, 36);
            this.btnGreen.TabIndex = 2;
            this.btnGreen.Text = "أخضر";
            this.btnGreen.UseVisualStyleBackColor = true;
            // 
            // btnRed
            // 
            this.btnRed.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnRed.Location = new System.Drawing.Point(21, 86);
            this.btnRed.Name = "btnRed";
            this.btnRed.Size = new System.Drawing.Size(102, 36);
            this.btnRed.TabIndex = 3;
            this.btnRed.Text = "أحمر";
            this.btnRed.UseVisualStyleBackColor = true;
            // 
            // device1
            // 
            this.device1.AutoSize = true;
            this.device1.Location = new System.Drawing.Point(115, 34);
            this.device1.Name = "device1";
            this.device1.Size = new System.Drawing.Size(68, 23);
            this.device1.TabIndex = 4;
            this.device1.Text = "جهاز 1";
            // 
            // device2
            // 
            this.device2.AutoSize = true;
            this.device2.Location = new System.Drawing.Point(257, 34);
            this.device2.Name = "device2";
            this.device2.Size = new System.Drawing.Size(68, 23);
            this.device2.TabIndex = 5;
            this.device2.Text = "جهاز 2";
            // 
            // sender
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(446, 292);
            this.Controls.Add(this.device2);
            this.Controls.Add(this.device1);
            this.Controls.Add(this.btnRed);
            this.Controls.Add(this.btnGreen);
            this.Controls.Add(this.btnYellow);
            this.Controls.Add(this.button1);
            this.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.Name = "sender";
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "sender";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnYellow;
        private System.Windows.Forms.Button btnGreen;
        private System.Windows.Forms.Button btnRed;
        private System.Windows.Forms.Label device1;
        private System.Windows.Forms.Label device2;
    }
}