
namespace CustomerDatabaseLookup
{
    partial class MainWindow
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
            this.nameLabel = new System.Windows.Forms.Label();
            this.phoneLabel = new System.Windows.Forms.Label();
            this.descriptionLabel = new System.Windows.Forms.Label();
            this.nameHolderLabel = new System.Windows.Forms.Label();
            this.phoneNumberHolderLabel = new System.Windows.Forms.Label();
            this.descriptionHolderLabel = new System.Windows.Forms.Label();
            this.editUserDateButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Location = new System.Drawing.Point(62, 26);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(49, 17);
            this.nameLabel.TabIndex = 0;
            this.nameLabel.Text = "Name:";
            // 
            // phoneLabel
            // 
            this.phoneLabel.AutoSize = true;
            this.phoneLabel.Location = new System.Drawing.Point(62, 43);
            this.phoneLabel.Name = "phoneLabel";
            this.phoneLabel.Size = new System.Drawing.Size(107, 17);
            this.phoneLabel.TabIndex = 1;
            this.phoneLabel.Text = "Phone Number:";
            // 
            // descriptionLabel
            // 
            this.descriptionLabel.AutoSize = true;
            this.descriptionLabel.Location = new System.Drawing.Point(62, 60);
            this.descriptionLabel.Name = "descriptionLabel";
            this.descriptionLabel.Size = new System.Drawing.Size(83, 17);
            this.descriptionLabel.TabIndex = 2;
            this.descriptionLabel.Text = "Description:";
            // 
            // nameHolderLabel
            // 
            this.nameHolderLabel.AutoSize = true;
            this.nameHolderLabel.Location = new System.Drawing.Point(187, 26);
            this.nameHolderLabel.Name = "nameHolderLabel";
            this.nameHolderLabel.Size = new System.Drawing.Size(28, 17);
            this.nameHolderLabel.TabIndex = 3;
            this.nameHolderLabel.Text = "tbd";
            // 
            // phoneNumberHolderLabel
            // 
            this.phoneNumberHolderLabel.AutoSize = true;
            this.phoneNumberHolderLabel.Location = new System.Drawing.Point(187, 43);
            this.phoneNumberHolderLabel.Name = "phoneNumberHolderLabel";
            this.phoneNumberHolderLabel.Size = new System.Drawing.Size(28, 17);
            this.phoneNumberHolderLabel.TabIndex = 4;
            this.phoneNumberHolderLabel.Text = "tbd";
            // 
            // descriptionHolderLabel
            // 
            this.descriptionHolderLabel.AutoSize = true;
            this.descriptionHolderLabel.Location = new System.Drawing.Point(187, 60);
            this.descriptionHolderLabel.Name = "descriptionHolderLabel";
            this.descriptionHolderLabel.Size = new System.Drawing.Size(28, 17);
            this.descriptionHolderLabel.TabIndex = 5;
            this.descriptionHolderLabel.Text = "tbd";
            // 
            // editUserDateButton
            // 
            this.editUserDateButton.Location = new System.Drawing.Point(13, 236);
            this.editUserDateButton.Name = "editUserDateButton";
            this.editUserDateButton.Size = new System.Drawing.Size(156, 64);
            this.editUserDateButton.TabIndex = 6;
            this.editUserDateButton.Text = "Edit user data";
            this.editUserDateButton.UseVisualStyleBackColor = true;
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.editUserDateButton);
            this.Controls.Add(this.descriptionHolderLabel);
            this.Controls.Add(this.phoneNumberHolderLabel);
            this.Controls.Add(this.nameHolderLabel);
            this.Controls.Add(this.descriptionLabel);
            this.Controls.Add(this.phoneLabel);
            this.Controls.Add(this.nameLabel);
            this.Name = "MainWindow";
            this.Text = "Customer Database";
            this.Load += new System.EventHandler(this.MainWindow_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Label phoneLabel;
        private System.Windows.Forms.Label descriptionLabel;
        private System.Windows.Forms.Label nameHolderLabel;
        private System.Windows.Forms.Label phoneNumberHolderLabel;
        private System.Windows.Forms.Label descriptionHolderLabel;
        private System.Windows.Forms.Button editUserDateButton;
    }
}

