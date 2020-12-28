
namespace Login_Form
{
    partial class LoginSuccessForm
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
            this.SuccessLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // SuccessLabel
            // 
            this.SuccessLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SuccessLabel.Location = new System.Drawing.Point(158, 119);
            this.SuccessLabel.Name = "SuccessLabel";
            this.SuccessLabel.Size = new System.Drawing.Size(170, 78);
            this.SuccessLabel.TabIndex = 0;
            this.SuccessLabel.Text = "Login Successful!!!";
            this.SuccessLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LoginSuccessForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(488, 315);
            this.Controls.Add(this.SuccessLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "LoginSuccessForm";
            this.Text = "Login Success";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label SuccessLabel;
    }
}