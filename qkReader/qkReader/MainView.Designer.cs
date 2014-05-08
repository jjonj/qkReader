namespace qkReader
{
    partial class MainView
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
            this.sourceTextField = new System.Windows.Forms.RichTextBox();
            this.wordField = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // sourceTextField
            // 
            this.sourceTextField.Location = new System.Drawing.Point(237, 304);
            this.sourceTextField.Name = "sourceTextField";
            this.sourceTextField.Size = new System.Drawing.Size(396, 213);
            this.sourceTextField.TabIndex = 0;
            this.sourceTextField.Text = "";
            // 
            // wordField
            // 
            this.wordField.AutoSize = true;
            this.wordField.Font = new System.Drawing.Font("Tahoma", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.wordField.Location = new System.Drawing.Point(381, 104);
            this.wordField.Name = "wordField";
            this.wordField.Size = new System.Drawing.Size(88, 39);
            this.wordField.TabIndex = 1;
            this.wordField.Text = "word";
            // 
            // MainView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.OldLace;
            this.ClientSize = new System.Drawing.Size(888, 529);
            this.Controls.Add(this.wordField);
            this.Controls.Add(this.sourceTextField);
            this.Name = "MainView";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox sourceTextField;
        private System.Windows.Forms.Label wordField;
    }
}

