namespace ControlPanel.View
{
    partial class MainWindow
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
            this.MainLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.ComutersControlBasePanel = new System.Windows.Forms.TableLayoutPanel();
            this.ComputersLabel = new System.Windows.Forms.Label();
            this.ComputersControlPanel = new System.Windows.Forms.TableLayoutPanel();
            this.ConnectBtn = new System.Windows.Forms.Button();
            this.ShowInfoComputerBtn = new System.Windows.Forms.Button();
            this.ListPanel = new System.Windows.Forms.TableLayoutPanel();
            this.ComputersList = new System.Windows.Forms.ComboBox();
            this.ProcessControlPanel = new System.Windows.Forms.TableLayoutPanel();
            this.DeleteProcessBtn = new System.Windows.Forms.Button();
            this.AddProcessBtn = new System.Windows.Forms.Button();
            this.ModifyProcessBtn = new System.Windows.Forms.Button();
            this.ProcessesGridView = new System.Windows.Forms.DataGridView();
            this.Process = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Priority = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Affinity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RAM = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Path = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MainLayoutPanel.SuspendLayout();
            this.ComutersControlBasePanel.SuspendLayout();
            this.ComputersControlPanel.SuspendLayout();
            this.ListPanel.SuspendLayout();
            this.ProcessControlPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ProcessesGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // MainLayoutPanel
            // 
            this.MainLayoutPanel.ColumnCount = 1;
            this.MainLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.MainLayoutPanel.Controls.Add(this.ComutersControlBasePanel, 0, 0);
            this.MainLayoutPanel.Controls.Add(this.ProcessControlPanel, 0, 2);
            this.MainLayoutPanel.Controls.Add(this.ProcessesGridView, 0, 1);
            this.MainLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.MainLayoutPanel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MainLayoutPanel.Name = "MainLayoutPanel";
            this.MainLayoutPanel.RowCount = 3;
            this.MainLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.79698F));
            this.MainLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 78.05212F));
            this.MainLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.07463F));
            this.MainLayoutPanel.Size = new System.Drawing.Size(1008, 729);
            this.MainLayoutPanel.TabIndex = 0;
            // 
            // ComutersControlBasePanel
            // 
            this.ComutersControlBasePanel.ColumnCount = 3;
            this.ComutersControlBasePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.ComutersControlBasePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 24.1517F));
            this.ComutersControlBasePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 55.88822F));
            this.ComutersControlBasePanel.Controls.Add(this.ComputersLabel, 0, 0);
            this.ComutersControlBasePanel.Controls.Add(this.ComputersControlPanel, 2, 0);
            this.ComutersControlBasePanel.Controls.Add(this.ListPanel, 1, 0);
            this.ComutersControlBasePanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ComutersControlBasePanel.Location = new System.Drawing.Point(3, 3);
            this.ComutersControlBasePanel.Name = "ComutersControlBasePanel";
            this.ComutersControlBasePanel.RowCount = 1;
            this.ComutersControlBasePanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.ComutersControlBasePanel.Size = new System.Drawing.Size(1002, 80);
            this.ComutersControlBasePanel.TabIndex = 6;
            // 
            // ComputersLabel
            // 
            this.ComputersLabel.AutoSize = true;
            this.ComputersLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ComputersLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ComputersLabel.Location = new System.Drawing.Point(3, 0);
            this.ComputersLabel.Name = "ComputersLabel";
            this.ComputersLabel.Size = new System.Drawing.Size(194, 80);
            this.ComputersLabel.TabIndex = 0;
            this.ComputersLabel.Text = "Computers";
            this.ComputersLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ComputersControlPanel
            // 
            this.ComputersControlPanel.ColumnCount = 2;
            this.ComputersControlPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.ComputersControlPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.ComputersControlPanel.Controls.Add(this.ConnectBtn, 0, 0);
            this.ComputersControlPanel.Controls.Add(this.ShowInfoComputerBtn, 0, 0);
            this.ComputersControlPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ComputersControlPanel.Location = new System.Drawing.Point(444, 3);
            this.ComputersControlPanel.Name = "ComputersControlPanel";
            this.ComputersControlPanel.RowCount = 1;
            this.ComputersControlPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.ComputersControlPanel.Size = new System.Drawing.Size(555, 74);
            this.ComputersControlPanel.TabIndex = 1;
            // 
            // ConnectBtn
            // 
            this.ConnectBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ConnectBtn.Location = new System.Drawing.Point(281, 5);
            this.ConnectBtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ConnectBtn.Name = "ConnectBtn";
            this.ConnectBtn.Size = new System.Drawing.Size(270, 64);
            this.ConnectBtn.TabIndex = 7;
            this.ConnectBtn.Text = "Connect";
            this.ConnectBtn.UseVisualStyleBackColor = true;
            this.ConnectBtn.Click += new System.EventHandler(this.ConnectBtn_Click);
            // 
            // ShowInfoComputerBtn
            // 
            this.ShowInfoComputerBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ShowInfoComputerBtn.Location = new System.Drawing.Point(4, 5);
            this.ShowInfoComputerBtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ShowInfoComputerBtn.Name = "ShowInfoComputerBtn";
            this.ShowInfoComputerBtn.Size = new System.Drawing.Size(269, 64);
            this.ShowInfoComputerBtn.TabIndex = 6;
            this.ShowInfoComputerBtn.Text = "Show info";
            this.ShowInfoComputerBtn.UseVisualStyleBackColor = true;
            this.ShowInfoComputerBtn.Click += new System.EventHandler(this.ShowInfoComputerBtn_Click);
            // 
            // ListPanel
            // 
            this.ListPanel.ColumnCount = 1;
            this.ListPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.ListPanel.Controls.Add(this.ComputersList, 0, 1);
            this.ListPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ListPanel.Location = new System.Drawing.Point(203, 3);
            this.ListPanel.Name = "ListPanel";
            this.ListPanel.RowCount = 3;
            this.ListPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.ListPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.ListPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.ListPanel.Size = new System.Drawing.Size(235, 74);
            this.ListPanel.TabIndex = 2;
            // 
            // ComputersList
            // 
            this.ComputersList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ComputersList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComputersList.FormattingEnabled = true;
            this.ComputersList.Location = new System.Drawing.Point(3, 27);
            this.ComputersList.Name = "ComputersList";
            this.ComputersList.Size = new System.Drawing.Size(229, 28);
            this.ComputersList.TabIndex = 0;
            this.ComputersList.SelectedIndexChanged += new System.EventHandler(this.ComputersList_SelectedIndexChanged);
            // 
            // ProcessControlPanel
            // 
            this.ProcessControlPanel.ColumnCount = 4;
            this.ProcessControlPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.ProcessControlPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.ProcessControlPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.ProcessControlPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.ProcessControlPanel.Controls.Add(this.DeleteProcessBtn, 1, 0);
            this.ProcessControlPanel.Controls.Add(this.AddProcessBtn, 0, 0);
            this.ProcessControlPanel.Controls.Add(this.ModifyProcessBtn, 3, 0);
            this.ProcessControlPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ProcessControlPanel.Location = new System.Drawing.Point(4, 660);
            this.ProcessControlPanel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ProcessControlPanel.Name = "ProcessControlPanel";
            this.ProcessControlPanel.RowCount = 1;
            this.ProcessControlPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.ProcessControlPanel.Size = new System.Drawing.Size(1000, 64);
            this.ProcessControlPanel.TabIndex = 2;
            // 
            // DeleteProcessBtn
            // 
            this.DeleteProcessBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DeleteProcessBtn.Location = new System.Drawing.Point(254, 5);
            this.DeleteProcessBtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.DeleteProcessBtn.Name = "DeleteProcessBtn";
            this.DeleteProcessBtn.Size = new System.Drawing.Size(242, 54);
            this.DeleteProcessBtn.TabIndex = 2;
            this.DeleteProcessBtn.Text = "Delete process";
            this.DeleteProcessBtn.UseVisualStyleBackColor = true;
            // 
            // AddProcessBtn
            // 
            this.AddProcessBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.AddProcessBtn.Location = new System.Drawing.Point(4, 5);
            this.AddProcessBtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.AddProcessBtn.Name = "AddProcessBtn";
            this.AddProcessBtn.Size = new System.Drawing.Size(242, 54);
            this.AddProcessBtn.TabIndex = 1;
            this.AddProcessBtn.Text = "Add process";
            this.AddProcessBtn.UseVisualStyleBackColor = true;
            // 
            // ModifyProcessBtn
            // 
            this.ModifyProcessBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ModifyProcessBtn.Location = new System.Drawing.Point(754, 5);
            this.ModifyProcessBtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ModifyProcessBtn.Name = "ModifyProcessBtn";
            this.ModifyProcessBtn.Size = new System.Drawing.Size(242, 54);
            this.ModifyProcessBtn.TabIndex = 3;
            this.ModifyProcessBtn.Text = "Modify process";
            this.ModifyProcessBtn.UseVisualStyleBackColor = true;
            // 
            // ProcessesGridView
            // 
            this.ProcessesGridView.AllowUserToAddRows = false;
            this.ProcessesGridView.AllowUserToOrderColumns = true;
            this.ProcessesGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ProcessesGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Process,
            this.PID,
            this.Priority,
            this.Affinity,
            this.RAM,
            this.Path});
            this.ProcessesGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ProcessesGridView.Location = new System.Drawing.Point(3, 89);
            this.ProcessesGridView.Name = "ProcessesGridView";
            this.ProcessesGridView.ReadOnly = true;
            this.ProcessesGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.ProcessesGridView.Size = new System.Drawing.Size(1002, 563);
            this.ProcessesGridView.TabIndex = 5;
            // 
            // Process
            // 
            this.Process.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Process.HeaderText = "Process";
            this.Process.Name = "Process";
            this.Process.ReadOnly = true;
            // 
            // PID
            // 
            this.PID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.PID.HeaderText = "PID";
            this.PID.Name = "PID";
            this.PID.ReadOnly = true;
            // 
            // Priority
            // 
            this.Priority.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Priority.HeaderText = "Priority";
            this.Priority.Name = "Priority";
            this.Priority.ReadOnly = true;
            // 
            // Affinity
            // 
            this.Affinity.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Affinity.HeaderText = "Affinity";
            this.Affinity.Name = "Affinity";
            this.Affinity.ReadOnly = true;
            // 
            // RAM
            // 
            this.RAM.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.RAM.HeaderText = "RAM usage";
            this.RAM.Name = "RAM";
            this.RAM.ReadOnly = true;
            // 
            // Path
            // 
            this.Path.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Path.HeaderText = "Path";
            this.Path.Name = "Path";
            this.Path.ReadOnly = true;
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 729);
            this.Controls.Add(this.MainLayoutPanel);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MinimumSize = new System.Drawing.Size(800, 650);
            this.Name = "MainWindow";
            this.Text = "Task Manager";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainWindow_FormClosed);
            this.MainLayoutPanel.ResumeLayout(false);
            this.ComutersControlBasePanel.ResumeLayout(false);
            this.ComutersControlBasePanel.PerformLayout();
            this.ComputersControlPanel.ResumeLayout(false);
            this.ListPanel.ResumeLayout(false);
            this.ProcessControlPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ProcessesGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel MainLayoutPanel;
        private System.Windows.Forms.TableLayoutPanel ProcessControlPanel;
        private System.Windows.Forms.Button DeleteProcessBtn;
        private System.Windows.Forms.Button AddProcessBtn;
        private System.Windows.Forms.Button ModifyProcessBtn;
        private System.Windows.Forms.TableLayoutPanel ComutersControlBasePanel;
        private System.Windows.Forms.Label ComputersLabel;
        private System.Windows.Forms.TableLayoutPanel ComputersControlPanel;
        private System.Windows.Forms.Button ShowInfoComputerBtn;
        private System.Windows.Forms.TableLayoutPanel ListPanel;
        private System.Windows.Forms.ComboBox ComputersList;
        private System.Windows.Forms.DataGridViewTextBoxColumn Process;
        private System.Windows.Forms.DataGridViewTextBoxColumn PID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Priority;
        private System.Windows.Forms.DataGridViewTextBoxColumn Affinity;
        private System.Windows.Forms.DataGridViewTextBoxColumn RAM;
        private System.Windows.Forms.DataGridViewTextBoxColumn Path;
        private System.Windows.Forms.DataGridView ProcessesGridView;
        private System.Windows.Forms.Button ConnectBtn;
    }
}

