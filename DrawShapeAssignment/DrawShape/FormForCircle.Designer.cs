namespace DrawShape
{
    partial class FormForCircle
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
            this.CirclePanel = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // CirclePanel
            // 
            this.CirclePanel.Location = new System.Drawing.Point(12, 37);
            this.CirclePanel.Name = "CirclePanel";
            this.CirclePanel.Size = new System.Drawing.Size(1231, 754);
            this.CirclePanel.TabIndex = 0;
            // 
            // FormForCircle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1255, 803);
            this.Controls.Add(this.CirclePanel);
            this.Name = "FormForCircle";
            this.Text = "FormForCircle";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel CirclePanel;
    }
}