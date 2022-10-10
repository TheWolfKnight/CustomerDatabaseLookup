
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
            this.components = new System.ComponentModel.Container();
            this.nameLabel = new System.Windows.Forms.Label();
            this.phoneLabel = new System.Windows.Forms.Label();
            this.descriptionLabel = new System.Windows.Forms.Label();
            this.nameHolderLabel = new System.Windows.Forms.Label();
            this.phoneNumberHolderLabel = new System.Windows.Forms.Label();
            this.descriptionHolderLabel = new System.Windows.Forms.Label();
            this.editUserDateButton = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.TabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.dgv_CustomerOrderHistories = new System.Windows.Forms.DataGridView();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.titleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.orderdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalPriceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.orderBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.orderFilterBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.orderFilterBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.dgv_CustomerOrderPriceIncress = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.titleDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.orderdDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalPriceDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabControl1.SuspendLayout();
            this.TabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_CustomerOrderHistories)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderFilterBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderFilterBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_CustomerOrderPriceIncress)).BeginInit();
            this.SuspendLayout();
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Location = new System.Drawing.Point(62, 26);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(47, 16);
            this.nameLabel.TabIndex = 0;
            this.nameLabel.Text = "Name:";
            // 
            // phoneLabel
            // 
            this.phoneLabel.AutoSize = true;
            this.phoneLabel.Location = new System.Drawing.Point(62, 43);
            this.phoneLabel.Name = "phoneLabel";
            this.phoneLabel.Size = new System.Drawing.Size(100, 16);
            this.phoneLabel.TabIndex = 1;
            this.phoneLabel.Text = "Phone Number:";
            // 
            // descriptionLabel
            // 
            this.descriptionLabel.AutoSize = true;
            this.descriptionLabel.Location = new System.Drawing.Point(62, 60);
            this.descriptionLabel.Name = "descriptionLabel";
            this.descriptionLabel.Size = new System.Drawing.Size(78, 16);
            this.descriptionLabel.TabIndex = 2;
            this.descriptionLabel.Text = "Description:";
            // 
            // nameHolderLabel
            // 
            this.nameHolderLabel.AutoSize = true;
            this.nameHolderLabel.Location = new System.Drawing.Point(187, 26);
            this.nameHolderLabel.Name = "nameHolderLabel";
            this.nameHolderLabel.Size = new System.Drawing.Size(26, 16);
            this.nameHolderLabel.TabIndex = 3;
            this.nameHolderLabel.Text = "tbd";
            // 
            // phoneNumberHolderLabel
            // 
            this.phoneNumberHolderLabel.AutoSize = true;
            this.phoneNumberHolderLabel.Location = new System.Drawing.Point(187, 43);
            this.phoneNumberHolderLabel.Name = "phoneNumberHolderLabel";
            this.phoneNumberHolderLabel.Size = new System.Drawing.Size(26, 16);
            this.phoneNumberHolderLabel.TabIndex = 4;
            this.phoneNumberHolderLabel.Text = "tbd";
            // 
            // descriptionHolderLabel
            // 
            this.descriptionHolderLabel.AutoSize = true;
            this.descriptionHolderLabel.Location = new System.Drawing.Point(187, 60);
            this.descriptionHolderLabel.Name = "descriptionHolderLabel";
            this.descriptionHolderLabel.Size = new System.Drawing.Size(26, 16);
            this.descriptionHolderLabel.TabIndex = 5;
            this.descriptionHolderLabel.Text = "tbd";
            // 
            // editUserDateButton
            // 
            this.editUserDateButton.Location = new System.Drawing.Point(919, 438);
            this.editUserDateButton.Name = "editUserDateButton";
            this.editUserDateButton.Size = new System.Drawing.Size(156, 64);
            this.editUserDateButton.TabIndex = 6;
            this.editUserDateButton.Text = "Edit user data";
            this.editUserDateButton.UseVisualStyleBackColor = true;
            this.editUserDateButton.Click += new System.EventHandler(this.editUserDateButton_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.TabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(48, 157);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(977, 275);
            this.tabControl1.TabIndex = 7;
            // 
            // TabPage1
            // 
            this.TabPage1.Controls.Add(this.dgv_CustomerOrderHistories);
            this.TabPage1.Location = new System.Drawing.Point(4, 25);
            this.TabPage1.Name = "TabPage1";
            this.TabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.TabPage1.Size = new System.Drawing.Size(969, 246);
            this.TabPage1.TabIndex = 0;
            this.TabPage1.Text = "Order Histories";
            this.TabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.dgv_CustomerOrderPriceIncress);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(969, 246);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Order Price Incress";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // dgv_CustomerOrderHistories
            // 
            this.dgv_CustomerOrderHistories.AutoGenerateColumns = false;
            this.dgv_CustomerOrderHistories.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_CustomerOrderHistories.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.titleDataGridViewTextBoxColumn,
            this.orderdDataGridViewTextBoxColumn,
            this.totalPriceDataGridViewTextBoxColumn,
            this.statusDataGridViewTextBoxColumn});
            this.dgv_CustomerOrderHistories.DataSource = this.orderBindingSource;
            this.dgv_CustomerOrderHistories.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_CustomerOrderHistories.Location = new System.Drawing.Point(3, 3);
            this.dgv_CustomerOrderHistories.Name = "dgv_CustomerOrderHistories";
            this.dgv_CustomerOrderHistories.RowHeadersWidth = 51;
            this.dgv_CustomerOrderHistories.RowTemplate.Height = 24;
            this.dgv_CustomerOrderHistories.Size = new System.Drawing.Size(963, 240);
            this.dgv_CustomerOrderHistories.TabIndex = 0;
            // 
            // tabPage3
            // 
            this.tabPage3.Location = new System.Drawing.Point(4, 25);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(969, 246);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Completed Orders";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            this.idDataGridViewTextBoxColumn.Width = 125;
            // 
            // titleDataGridViewTextBoxColumn
            // 
            this.titleDataGridViewTextBoxColumn.DataPropertyName = "Title";
            this.titleDataGridViewTextBoxColumn.HeaderText = "Title";
            this.titleDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.titleDataGridViewTextBoxColumn.Name = "titleDataGridViewTextBoxColumn";
            this.titleDataGridViewTextBoxColumn.ReadOnly = true;
            this.titleDataGridViewTextBoxColumn.Width = 125;
            // 
            // orderdDataGridViewTextBoxColumn
            // 
            this.orderdDataGridViewTextBoxColumn.DataPropertyName = "Orderd";
            this.orderdDataGridViewTextBoxColumn.HeaderText = "Orderd";
            this.orderdDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.orderdDataGridViewTextBoxColumn.Name = "orderdDataGridViewTextBoxColumn";
            this.orderdDataGridViewTextBoxColumn.ReadOnly = true;
            this.orderdDataGridViewTextBoxColumn.Width = 125;
            // 
            // totalPriceDataGridViewTextBoxColumn
            // 
            this.totalPriceDataGridViewTextBoxColumn.DataPropertyName = "TotalPrice";
            this.totalPriceDataGridViewTextBoxColumn.HeaderText = "TotalPrice";
            this.totalPriceDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.totalPriceDataGridViewTextBoxColumn.Name = "totalPriceDataGridViewTextBoxColumn";
            this.totalPriceDataGridViewTextBoxColumn.ReadOnly = true;
            this.totalPriceDataGridViewTextBoxColumn.Width = 125;
            // 
            // statusDataGridViewTextBoxColumn
            // 
            this.statusDataGridViewTextBoxColumn.DataPropertyName = "Status";
            this.statusDataGridViewTextBoxColumn.HeaderText = "Status";
            this.statusDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.statusDataGridViewTextBoxColumn.Name = "statusDataGridViewTextBoxColumn";
            this.statusDataGridViewTextBoxColumn.ReadOnly = true;
            this.statusDataGridViewTextBoxColumn.Width = 125;
            // 
            // orderBindingSource
            // 
            this.orderBindingSource.DataSource = typeof(CustomerDatabaseLookup.Src.Models.OrderHistories);
            // 
            // orderFilterBindingSource
            // 
            this.orderFilterBindingSource.DataSource = typeof(CustomerDatabaseLookup.Src.Services.OrderFilter);
            // 
            // orderFilterBindingSource1
            // 
            this.orderFilterBindingSource1.DataSource = typeof(CustomerDatabaseLookup.Src.Services.OrderFilter);
            // 
            // dgv_CustomerOrderPriceIncress
            // 
            this.dgv_CustomerOrderPriceIncress.AutoGenerateColumns = false;
            this.dgv_CustomerOrderPriceIncress.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_CustomerOrderPriceIncress.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn1,
            this.titleDataGridViewTextBoxColumn1,
            this.orderdDataGridViewTextBoxColumn1,
            this.totalPriceDataGridViewTextBoxColumn1,
            this.statusDataGridViewTextBoxColumn1});
            this.dgv_CustomerOrderPriceIncress.DataSource = this.orderBindingSource;
            this.dgv_CustomerOrderPriceIncress.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_CustomerOrderPriceIncress.Location = new System.Drawing.Point(3, 3);
            this.dgv_CustomerOrderPriceIncress.Name = "dgv_CustomerOrderPriceIncress";
            this.dgv_CustomerOrderPriceIncress.RowHeadersWidth = 51;
            this.dgv_CustomerOrderPriceIncress.RowTemplate.Height = 24;
            this.dgv_CustomerOrderPriceIncress.Size = new System.Drawing.Size(963, 240);
            this.dgv_CustomerOrderPriceIncress.TabIndex = 0;
            // 
            // idDataGridViewTextBoxColumn1
            // 
            this.idDataGridViewTextBoxColumn1.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn1.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.idDataGridViewTextBoxColumn1.Name = "idDataGridViewTextBoxColumn1";
            this.idDataGridViewTextBoxColumn1.ReadOnly = true;
            this.idDataGridViewTextBoxColumn1.Width = 125;
            // 
            // titleDataGridViewTextBoxColumn1
            // 
            this.titleDataGridViewTextBoxColumn1.DataPropertyName = "Title";
            this.titleDataGridViewTextBoxColumn1.HeaderText = "Title";
            this.titleDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.titleDataGridViewTextBoxColumn1.Name = "titleDataGridViewTextBoxColumn1";
            this.titleDataGridViewTextBoxColumn1.ReadOnly = true;
            this.titleDataGridViewTextBoxColumn1.Width = 125;
            // 
            // orderdDataGridViewTextBoxColumn1
            // 
            this.orderdDataGridViewTextBoxColumn1.DataPropertyName = "Orderd";
            this.orderdDataGridViewTextBoxColumn1.HeaderText = "Orderd";
            this.orderdDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.orderdDataGridViewTextBoxColumn1.Name = "orderdDataGridViewTextBoxColumn1";
            this.orderdDataGridViewTextBoxColumn1.ReadOnly = true;
            this.orderdDataGridViewTextBoxColumn1.Width = 125;
            // 
            // totalPriceDataGridViewTextBoxColumn1
            // 
            this.totalPriceDataGridViewTextBoxColumn1.DataPropertyName = "TotalPrice";
            this.totalPriceDataGridViewTextBoxColumn1.HeaderText = "TotalPrice";
            this.totalPriceDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.totalPriceDataGridViewTextBoxColumn1.Name = "totalPriceDataGridViewTextBoxColumn1";
            this.totalPriceDataGridViewTextBoxColumn1.ReadOnly = true;
            this.totalPriceDataGridViewTextBoxColumn1.Width = 125;
            // 
            // statusDataGridViewTextBoxColumn1
            // 
            this.statusDataGridViewTextBoxColumn1.DataPropertyName = "Status";
            this.statusDataGridViewTextBoxColumn1.HeaderText = "Status";
            this.statusDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.statusDataGridViewTextBoxColumn1.Name = "statusDataGridViewTextBoxColumn1";
            this.statusDataGridViewTextBoxColumn1.ReadOnly = true;
            this.statusDataGridViewTextBoxColumn1.Width = 125;
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1087, 514);
            this.Controls.Add(this.tabControl1);
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
            this.tabControl1.ResumeLayout(false);
            this.TabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_CustomerOrderHistories)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderFilterBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderFilterBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_CustomerOrderPriceIncress)).EndInit();
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
        private System.Windows.Forms.BindingSource orderFilterBindingSource;
        private System.Windows.Forms.BindingSource orderFilterBindingSource1;
        private System.Windows.Forms.BindingSource orderBindingSource;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage TabPage1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn titleDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn orderdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalPriceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn statusDataGridViewTextBoxColumn;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        public System.Windows.Forms.DataGridView dgv_CustomerOrderHistories;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn titleDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn orderdDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalPriceDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn statusDataGridViewTextBoxColumn1;
        public System.Windows.Forms.DataGridView dgv_CustomerOrderPriceIncress;
    }
}

