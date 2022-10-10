namespace CustomerDatabaseLookup.Frontend
{
    partial class LoginWindow
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
            this.lb1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.lb_2 = new System.Windows.Forms.Label();
            this.tb_UserName = new System.Windows.Forms.TextBox();
            this.tb_Password = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lb1
            // 
            this.lb1.AutoSize = true;
            this.lb1.Location = new System.Drawing.Point(12, 9);
            this.lb1.Name = "lb1";
            this.lb1.Size = new System.Drawing.Size(83, 17);
            this.lb1.TabIndex = 0;
            this.lb1.Text = "User Name:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(51, 124);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 35);
            this.button1.TabIndex = 1;
            this.button1.Text = "Log In";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // lb_2
            // 
            this.lb_2.AutoSize = true;
            this.lb_2.Location = new System.Drawing.Point(12, 76);
            this.lb_2.Name = "lb_2";
            this.lb_2.Size = new System.Drawing.Size(73, 17);
            this.lb_2.TabIndex = 2;
            this.lb_2.Text = "Password:";
            // 
            // tb_UserName
            // 
            this.tb_UserName.Location = new System.Drawing.Point(104, 9);
            this.tb_UserName.Name = "tb_UserName";
            this.tb_UserName.Size = new System.Drawing.Size(100, 22);
            this.tb_UserName.TabIndex = 3;
            // 
            // tb_Password
            // 
            this.tb_Password.Location = new System.Drawing.Point(104, 76);
            this.tb_Password.Name = "tb_Password";
            this.tb_Password.Size = new System.Drawing.Size(100, 22);
            this.tb_Password.TabIndex = 4;
            // 
            // LoginWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(223, 200);
            this.Controls.Add(this.tb_Password);
            this.Controls.Add(this.tb_UserName);
            this.Controls.Add(this.lb_2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lb1);
            this.Name = "LoginWindow";
            this.Text = "Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label lb1;
        private System.Windows.Forms.Button button1;
        public System.Windows.Forms.Label lb_2;
        public System.Windows.Forms.TextBox tb_UserName;
        public System.Windows.Forms.TextBox tb_Password;
    }
}