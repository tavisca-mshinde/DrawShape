namespace DrawShape
{
    partial class FormForTriangle
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
            this.TrianglePanel = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // TrianglePanel
            // 
            this.TrianglePanel.Location = new System.Drawing.Point(35, 43);
            this.TrianglePanel.Name = "TrianglePanel";
            this.TrianglePanel.Size = new System.Drawing.Size(1071, 716);
            this.TrianglePanel.TabIndex = 0;
            // 
            // FormForTriangle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1151, 802);
            this.Controls.Add(this.TrianglePanel);
            this.Name = "FormForTriangle";
            this.Text = "FormForTriangle";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel TrianglePanel;
    }
}