namespace DrawShape
{
    partial class FormLine
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
            this.LinePanel = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // LinePanel
            // 
            this.LinePanel.Location = new System.Drawing.Point(12, 12);
            this.LinePanel.Name = "LinePanel";
            this.LinePanel.Size = new System.Drawing.Size(830, 518);
            this.LinePanel.TabIndex = 0;
            // 
            // FormLine
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(854, 542);
            this.Controls.Add(this.LinePanel);
            this.Name = "FormLine";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel LinePanel;
    }
}

