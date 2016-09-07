namespace DrawShape
{
    partial class FormForRectangle
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
            this.RectanglePanel = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // RectanglePanel
            // 
            this.RectanglePanel.Location = new System.Drawing.Point(26, 35);
            this.RectanglePanel.Name = "RectanglePanel";
            this.RectanglePanel.Size = new System.Drawing.Size(1203, 751);
            this.RectanglePanel.TabIndex = 0;
            // 
            // FormForRectangle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1256, 811);
            this.Controls.Add(this.RectanglePanel);
            this.Name = "FormForRectangle";
            this.Text = "FormForRectangle";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel RectanglePanel;
    }
}