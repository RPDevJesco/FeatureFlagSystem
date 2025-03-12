using System.ComponentModel;

namespace GraphicalExample
{
    partial class MainForm
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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.userRolesLabel = new System.Windows.Forms.Label();
            this.userEmailLabel = new System.Windows.Forms.Label();
            this.userIdLabel = new System.Windows.Forms.Label();
            this.randomUserButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.userComboBox = new System.Windows.Forms.ComboBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.refreshButton = new System.Windows.Forms.Button();
            this.toggleFlagButton = new System.Windows.Forms.Button();
            this.flagsDataGridView = new System.Windows.Forms.DataGridView();
            this.panel3 = new System.Windows.Forms.Panel();
            this.clearLogButton = new System.Windows.Forms.Button();
            this.logTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.flagsDataGridView)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.panel2);
            this.splitContainer1.Panel1.Controls.Add(this.panel1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.panel3);
            this.splitContainer1.Size = new System.Drawing.Size(800, 600);
            this.splitContainer1.SplitterDistance = 350;
            this.splitContainer1.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.randomUserButton);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.userComboBox);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 120);
            this.panel1.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.userRolesLabel);
            this.groupBox1.Controls.Add(this.userEmailLabel);
            this.groupBox1.Controls.Add(this.userIdLabel);
            this.groupBox1.Location = new System.Drawing.Point(318, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(470, 96);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "User Information";
            // 
            // userRolesLabel
            // 
            this.userRolesLabel.AutoSize = true;
            this.userRolesLabel.Location = new System.Drawing.Point(16, 72);
            this.userRolesLabel.Name = "userRolesLabel";
            this.userRolesLabel.Size = new System.Drawing.Size(40, 13);
            this.userRolesLabel.TabIndex = 2;
            this.userRolesLabel.Text = "Roles: ";
            // 
            // userEmailLabel
            // 
            this.userEmailLabel.AutoSize = true;
            this.userEmailLabel.Location = new System.Drawing.Point(16, 48);
            this.userEmailLabel.Name = "userEmailLabel";
            this.userEmailLabel.Size = new System.Drawing.Size(38, 13);
            this.userEmailLabel.TabIndex = 1;
            this.userEmailLabel.Text = "Email: ";
            // 
            // userIdLabel
            // 
            this.userIdLabel.AutoSize = true;
            this.userIdLabel.Location = new System.Drawing.Point(16, 24);
            this.userIdLabel.Name = "userIdLabel";
            this.userIdLabel.Size = new System.Drawing.Size(24, 13);
            this.userIdLabel.TabIndex = 0;
            this.userIdLabel.Text = "ID: ";
            // 
            // randomUserButton
            // 
            this.randomUserButton.Location = new System.Drawing.Point(12, 85);
            this.randomUserButton.Name = "randomUserButton";
            this.randomUserButton.Size = new System.Drawing.Size(300, 23);
            this.randomUserButton.TabIndex = 2;
            this.randomUserButton.Text = "Create Random User";
            this.randomUserButton.UseVisualStyleBackColor = true;
            this.randomUserButton.Click += new System.EventHandler(this.randomUserButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Select User Type:";
            // 
            // userComboBox
            // 
            this.userComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.userComboBox.FormattingEnabled = true;
            this.userComboBox.Location = new System.Drawing.Point(12, 35);
            this.userComboBox.Name = "userComboBox";
            this.userComboBox.Size = new System.Drawing.Size(300, 21);
            this.userComboBox.TabIndex = 0;
            this.userComboBox.SelectedIndexChanged += new System.EventHandler(this.userComboBox_SelectedIndexChanged);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.refreshButton);
            this.panel2.Controls.Add(this.toggleFlagButton);
            this.panel2.Controls.Add(this.flagsDataGridView);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 120);
            this.panel2.Name = "panel2";
            this.panel2.Padding = new System.Windows.Forms.Padding(10);
            this.panel2.Size = new System.Drawing.Size(800, 230);
            this.panel2.TabIndex = 1;
            // 
            // refreshButton
            // 
            this.refreshButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.refreshButton.Location = new System.Drawing.Point(624, 194);
            this.refreshButton.Name = "refreshButton";
            this.refreshButton.Size = new System.Drawing.Size(75, 23);
            this.refreshButton.TabIndex = 2;
            this.refreshButton.Text = "Refresh";
            this.refreshButton.UseVisualStyleBackColor = true;
            this.refreshButton.Click += new System.EventHandler(this.refreshButton_Click);
            // 
            // toggleFlagButton
            // 
            this.toggleFlagButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.toggleFlagButton.Location = new System.Drawing.Point(705, 194);
            this.toggleFlagButton.Name = "toggleFlagButton";
            this.toggleFlagButton.Size = new System.Drawing.Size(75, 23);
            this.toggleFlagButton.TabIndex = 1;
            this.toggleFlagButton.Text = "Toggle Flag";
            this.toggleFlagButton.UseVisualStyleBackColor = true;
            this.toggleFlagButton.Click += new System.EventHandler(this.toggleFlagButton_Click);
            // 
            // flagsDataGridView
            // 
            this.flagsDataGridView.AllowUserToAddRows = false;
            this.flagsDataGridView.AllowUserToDeleteRows = false;
            this.flagsDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flagsDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.flagsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.flagsDataGridView.Location = new System.Drawing.Point(13, 13);
            this.flagsDataGridView.MultiSelect = false;
            this.flagsDataGridView.Name = "flagsDataGridView";
            this.flagsDataGridView.ReadOnly = true;
            this.flagsDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.flagsDataGridView.Size = new System.Drawing.Size(774, 175);
            this.flagsDataGridView.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.clearLogButton);
            this.panel3.Controls.Add(this.logTextBox);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Padding = new System.Windows.Forms.Padding(10);
            this.panel3.Size = new System.Drawing.Size(800, 246);
            this.panel3.TabIndex = 0;
            // 
            // clearLogButton
            // 
            this.clearLogButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.clearLogButton.Location = new System.Drawing.Point(705, 10);
            this.clearLogButton.Name = "clearLogButton";
            this.clearLogButton.Size = new System.Drawing.Size(75, 23);
            this.clearLogButton.TabIndex = 2;
            this.clearLogButton.Text = "Clear Log";
            this.clearLogButton.UseVisualStyleBackColor = true;
            this.clearLogButton.Click += new System.EventHandler(this.clearLogButton_Click);
            // 
            // logTextBox
            // 
            this.logTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.logTextBox.Location = new System.Drawing.Point(13, 36);
            this.logTextBox.Multiline = true;
            this.logTextBox.Name = "logTextBox";
            this.logTextBox.ReadOnly = true;
            this.logTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.logTextBox.Size = new System.Drawing.Size(774, 197);
            this.logTextBox.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(151, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Feature Flag Activity Log:";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 600);
            this.Controls.Add(this.splitContainer1);
            this.MinimumSize = new System.Drawing.Size(600, 400);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Feature Flag System Demo";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.flagsDataGridView)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox userComboBox;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView flagsDataGridView;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox logTextBox;
        private System.Windows.Forms.Button randomUserButton;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label userRolesLabel;
        private System.Windows.Forms.Label userEmailLabel;
        private System.Windows.Forms.Label userIdLabel;
        private System.Windows.Forms.Button toggleFlagButton;
        private System.Windows.Forms.Button refreshButton;
        private System.Windows.Forms.Button clearLogButton;
    }
}