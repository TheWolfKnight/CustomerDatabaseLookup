
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
            this.nameLabel.Location = new System.Drawing.Point(93, 41);
            this.nameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(74, 25);
            this.nameLabel.TabIndex = 0;
            this.nameLabel.Text = "Name:";
            // 
            // phoneLabel
            // 
            this.phoneLabel.AutoSize = true;
            this.phoneLabel.Location = new System.Drawing.Point(93, 67);
            this.phoneLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.phoneLabel.Name = "phoneLabel";
            this.phoneLabel.Size = new System.Drawing.Size(161, 25);
            this.phoneLabel.TabIndex = 1;
            this.phoneLabel.Text = "Phone Number:";
            // 
            // descriptionLabel
            // 
            this.descriptionLabel.AutoSize = true;
            this.descriptionLabel.Location = new System.Drawing.Point(93, 94);
            this.descriptionLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.descriptionLabel.Name = "descriptionLabel";
            this.descriptionLabel.Size = new System.Drawing.Size(126, 25);
            this.descriptionLabel.TabIndex = 2;
            this.descriptionLabel.Text = "Description:";
            // 
            // nameHolderLabel
            // 
            this.nameHolderLabel.AutoSize = true;
            this.nameHolderLabel.Location = new System.Drawing.Point(280, 41);
            this.nameHolderLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.nameHolderLabel.Name = "nameHolderLabel";
            this.nameHolderLabel.Size = new System.Drawing.Size(42, 25);
            this.nameHolderLabel.TabIndex = 3;
            this.nameHolderLabel.Text = "tbd";
            // 
            // phoneNumberHolderLabel
            // 
            this.phoneNumberHolderLabel.AutoSize = true;
            this.phoneNumberHolderLabel.Location = new System.Drawing.Point(280, 67);
            this.phoneNumberHolderLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.phoneNumberHolderLabel.Name = "phoneNumberHolderLabel";
            this.phoneNumberHolderLabel.Size = new System.Drawing.Size(42, 25);
            this.phoneNumberHolderLabel.TabIndex = 4;
            this.phoneNumberHolderLabel.Text = "tbd";
            // 
            // descriptionHolderLabel
            // 
            this.descriptionHolderLabel.AutoSize = true;
            this.descriptionHolderLabel.Location = new System.Drawing.Point(280, 94);
            this.descriptionHolderLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.descriptionHolderLabel.Name = "descriptionHolderLabel";
            this.descriptionHolderLabel.Size = new System.Drawing.Size(42, 25);
            this.descriptionHolderLabel.TabIndex = 5;
            this.descriptionHolderLabel.Text = "tbd";
            // 
            // editUserDateButton
            // 
            this.editUserDateButton.Location = new System.Drawing.Point(20, 369);
            this.editUserDateButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.editUserDateButton.Name = "editUserDateButton";
            this.editUserDateButton.Size = new System.Drawing.Size(234, 100);
            this.editUserDateButton.TabIndex = 6;
            this.editUserDateButton.Text = "Edit user data";
            this.editUserDateButton.UseVisualStyleBackColor = true;
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 703);
            this.Controls.Add(this.editUserDateButton);
            this.Controls.Add(this.descriptionHolderLabel);
            this.Controls.Add(this.phoneNumberHolderLabel);
            this.Controls.Add(this.nameHolderLabel);
            this.Controls.Add(this.descriptionLabel);
            this.Controls.Add(this.phoneLabel);
            this.Controls.Add(this.nameLabel);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
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
        private System.Windows.Forms.Button editUserDateButton;
        public System.Windows.Forms.Label nameHolderLabel;
        public System.Windows.Forms.Label phoneNumberHolderLabel;
        public System.Windows.Forms.Label descriptionHolderLabel;
    }
}

