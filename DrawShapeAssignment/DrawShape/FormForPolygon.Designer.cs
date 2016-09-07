namespace DrawShape
{
    partial class FormForPolygon
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
            this.PolygonPanel = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // PolygonPanel
            // 
            this.PolygonPanel.Location = new System.Drawing.Point(29, 69);
            this.PolygonPanel.Name = "PolygonPanel";
            this.PolygonPanel.Size = new System.Drawing.Size(1118, 708);
            this.PolygonPanel.TabIndex = 0;
            // 
            // FormForPolygon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1170, 789);
            this.Controls.Add(this.PolygonPanel);
            this.Name = "FormForPolygon";
            this.Text = "FormForPolygon";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PolygonPanel;
    }
}