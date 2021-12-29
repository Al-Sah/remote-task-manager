
namespace ControlPanel.View
{
    partial class ProcessModificationDialog
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
            this.MainLayout = new System.Windows.Forms.TableLayoutPanel();
            this.ControlLayout = new System.Windows.Forms.TableLayoutPanel();
            this.NameLabel = new System.Windows.Forms.Label();
            this.PriorityLabel = new System.Windows.Forms.Label();
            this.AffinityLabel = new System.Windows.Forms.Label();
            this.AffinityLayout = new System.Windows.Forms.TableLayoutPanel();
            this.ConfigAffinityBtn = new System.Windows.Forms.Button();
            this.AffinityTextBoxLayout = new System.Windows.Forms.TableLayoutPanel();
            this.AffinityTextBox = new System.Windows.Forms.TextBox();
            this.PriorityLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.PrioritiesList = new System.Windows.Forms.ComboBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.NameTextBox = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.ApplyBtn = new System.Windows.Forms.Button();
            this.RequestsList = new System.Windows.Forms.ListBox();
            this.MainLayout.SuspendLayout();
            this.ControlLayout.SuspendLayout();
            this.AffinityLayout.SuspendLayout();
            this.AffinityTextBoxLayout.SuspendLayout();
            this.PriorityLayoutPanel.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainLayout
            // 
            this.MainLayout.ColumnCount = 2;
            this.MainLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.MainLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 150F));
            this.MainLayout.Controls.Add(this.ControlLayout, 0, 1);
            this.MainLayout.Controls.Add(this.tableLayoutPanel2, 0, 2);
            this.MainLayout.Controls.Add(this.RequestsList, 1, 1);
            this.MainLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainLayout.Location = new System.Drawing.Point(0, 0);
            this.MainLayout.Name = "MainLayout";
            this.MainLayout.RowCount = 3;
            this.MainLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.72414F));
            this.MainLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 69.31035F));
            this.MainLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 18.55956F));
            this.MainLayout.Size = new System.Drawing.Size(566, 301);
            this.MainLayout.TabIndex = 1;
            // 
            // ControlLayout
            // 
            this.ControlLayout.ColumnCount = 2;
            this.ControlLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 27.31707F));
            this.ControlLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 72.68293F));
            this.ControlLayout.Controls.Add(this.NameLabel, 0, 0);
            this.ControlLayout.Controls.Add(this.PriorityLabel, 0, 1);
            this.ControlLayout.Controls.Add(this.AffinityLabel, 0, 2);
            this.ControlLayout.Controls.Add(this.AffinityLayout, 1, 2);
            this.ControlLayout.Controls.Add(this.PriorityLayoutPanel, 1, 1);
            this.ControlLayout.Controls.Add(this.tableLayoutPanel1, 1, 0);
            this.ControlLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ControlLayout.Location = new System.Drawing.Point(3, 38);
            this.ControlLayout.Name = "ControlLayout";
            this.ControlLayout.RowCount = 3;
            this.ControlLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.ControlLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.ControlLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.ControlLayout.Size = new System.Drawing.Size(410, 203);
            this.ControlLayout.TabIndex = 2;
            // 
            // NameLabel
            // 
            this.NameLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.NameLabel.Location = new System.Drawing.Point(3, 0);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(106, 67);
            this.NameLabel.TabIndex = 1;
            this.NameLabel.Text = "Name";
            this.NameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // PriorityLabel
            // 
            this.PriorityLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PriorityLabel.Location = new System.Drawing.Point(3, 67);
            this.PriorityLabel.Name = "PriorityLabel";
            this.PriorityLabel.Size = new System.Drawing.Size(106, 67);
            this.PriorityLabel.TabIndex = 3;
            this.PriorityLabel.Text = "Priority";
            this.PriorityLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // AffinityLabel
            // 
            this.AffinityLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.AffinityLabel.Location = new System.Drawing.Point(3, 134);
            this.AffinityLabel.Name = "AffinityLabel";
            this.AffinityLabel.Size = new System.Drawing.Size(106, 69);
            this.AffinityLabel.TabIndex = 4;
            this.AffinityLabel.Text = "Affinity";
            this.AffinityLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // AffinityLayout
            // 
            this.AffinityLayout.ColumnCount = 2;
            this.AffinityLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 35.76389F));
            this.AffinityLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 64.23611F));
            this.AffinityLayout.Controls.Add(this.ConfigAffinityBtn, 1, 0);
            this.AffinityLayout.Controls.Add(this.AffinityTextBoxLayout, 0, 0);
            this.AffinityLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.AffinityLayout.Location = new System.Drawing.Point(115, 137);
            this.AffinityLayout.Name = "AffinityLayout";
            this.AffinityLayout.RowCount = 1;
            this.AffinityLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.AffinityLayout.Size = new System.Drawing.Size(292, 63);
            this.AffinityLayout.TabIndex = 6;
            // 
            // ConfigAffinityBtn
            // 
            this.ConfigAffinityBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ConfigAffinityBtn.Location = new System.Drawing.Point(107, 3);
            this.ConfigAffinityBtn.Name = "ConfigAffinityBtn";
            this.ConfigAffinityBtn.Size = new System.Drawing.Size(182, 57);
            this.ConfigAffinityBtn.TabIndex = 2;
            this.ConfigAffinityBtn.Text = "Config";
            this.ConfigAffinityBtn.UseVisualStyleBackColor = true;
            this.ConfigAffinityBtn.Click += new System.EventHandler(this.ConfigAffinityBtn_Click);
            // 
            // AffinityTextBoxLayout
            // 
            this.AffinityTextBoxLayout.ColumnCount = 1;
            this.AffinityTextBoxLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.AffinityTextBoxLayout.Controls.Add(this.AffinityTextBox, 0, 1);
            this.AffinityTextBoxLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.AffinityTextBoxLayout.Location = new System.Drawing.Point(3, 3);
            this.AffinityTextBoxLayout.Name = "AffinityTextBoxLayout";
            this.AffinityTextBoxLayout.RowCount = 3;
            this.AffinityTextBoxLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 19.4241F));
            this.AffinityTextBoxLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 61.1518F));
            this.AffinityTextBoxLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 19.4241F));
            this.AffinityTextBoxLayout.Size = new System.Drawing.Size(98, 57);
            this.AffinityTextBoxLayout.TabIndex = 0;
            // 
            // AffinityTextBox
            // 
            this.AffinityTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.AffinityTextBox.Location = new System.Drawing.Point(3, 14);
            this.AffinityTextBox.Multiline = true;
            this.AffinityTextBox.Name = "AffinityTextBox";
            this.AffinityTextBox.Size = new System.Drawing.Size(92, 28);
            this.AffinityTextBox.TabIndex = 6;
            // 
            // PriorityLayoutPanel
            // 
            this.PriorityLayoutPanel.ColumnCount = 1;
            this.PriorityLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.PriorityLayoutPanel.Controls.Add(this.PrioritiesList, 0, 1);
            this.PriorityLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PriorityLayoutPanel.Location = new System.Drawing.Point(115, 70);
            this.PriorityLayoutPanel.Name = "PriorityLayoutPanel";
            this.PriorityLayoutPanel.RowCount = 3;
            this.PriorityLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 22.88812F));
            this.PriorityLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 54.22376F));
            this.PriorityLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 22.88812F));
            this.PriorityLayoutPanel.Size = new System.Drawing.Size(292, 61);
            this.PriorityLayoutPanel.TabIndex = 7;
            // 
            // PrioritiesList
            // 
            this.PrioritiesList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PrioritiesList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.PrioritiesList.FormattingEnabled = true;
            this.PrioritiesList.Items.AddRange(new object[] {
            "Normal",
            "BelowNormal",
            "AboveNormal",
            "High",
            "RealTime",
            "Idle"});
            this.PrioritiesList.Location = new System.Drawing.Point(3, 16);
            this.PrioritiesList.Name = "PrioritiesList";
            this.PrioritiesList.Size = new System.Drawing.Size(286, 28);
            this.PrioritiesList.TabIndex = 10;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.NameTextBox, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(115, 3);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 21.87196F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 56.25607F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 21.87196F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(292, 61);
            this.tableLayoutPanel1.TabIndex = 8;
            // 
            // NameTextBox
            // 
            this.NameTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.NameTextBox.Location = new System.Drawing.Point(3, 16);
            this.NameTextBox.Multiline = true;
            this.NameTextBox.Name = "NameTextBox";
            this.NameTextBox.Size = new System.Drawing.Size(286, 28);
            this.NameTextBox.TabIndex = 6;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 3;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.90244F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 37.56097F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 28.29268F));
            this.tableLayoutPanel2.Controls.Add(this.ApplyBtn, 1, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 247);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(410, 51);
            this.tableLayoutPanel2.TabIndex = 3;
            // 
            // ApplyBtn
            // 
            this.ApplyBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ApplyBtn.Location = new System.Drawing.Point(142, 3);
            this.ApplyBtn.Name = "ApplyBtn";
            this.ApplyBtn.Size = new System.Drawing.Size(148, 45);
            this.ApplyBtn.TabIndex = 1;
            this.ApplyBtn.Text = "Apply";
            this.ApplyBtn.UseVisualStyleBackColor = true;
            this.ApplyBtn.Click += new System.EventHandler(this.ApplyBtn_Click);
            // 
            // RequestsList
            // 
            this.RequestsList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.RequestsList.FormattingEnabled = true;
            this.RequestsList.ItemHeight = 20;
            this.RequestsList.Location = new System.Drawing.Point(419, 38);
            this.RequestsList.Name = "RequestsList";
            this.RequestsList.Size = new System.Drawing.Size(144, 203);
            this.RequestsList.TabIndex = 4;
            this.RequestsList.SelectedIndexChanged += RequestsList_SelectedIndexChanged;
            // 
            // ProcessModificationDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(566, 301);
            this.Controls.Add(this.MainLayout);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "ProcessModificationDialog";
            this.Text = "Modify process ";
            this.Load += new System.EventHandler(this.ModifyProcessDialog_Load);
            this.MainLayout.ResumeLayout(false);
            this.ControlLayout.ResumeLayout(false);
            this.AffinityLayout.ResumeLayout(false);
            this.AffinityTextBoxLayout.ResumeLayout(false);
            this.AffinityTextBoxLayout.PerformLayout();
            this.PriorityLayoutPanel.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        private System.Windows.Forms.ComboBox PrioritiesList;

        private System.Windows.Forms.TextBox AffinityTextBox;

        private System.Windows.Forms.Button ConfigAffinityBtn;

        private System.Windows.Forms.Label NameLabel;

        private System.Windows.Forms.Label AffinityLabel;

        private System.Windows.Forms.TextBox NameTextBox;

        private System.Windows.Forms.TableLayoutPanel PriorityLayoutPanel;
        
        private System.Windows.Forms.TableLayoutPanel ControlLayout;

        private System.Windows.Forms.TableLayoutPanel AffinityLayout;

        private System.Windows.Forms.TableLayoutPanel AffinityTextBoxLayout;

        private System.Windows.Forms.Label PriorityLabel;

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;

        private System.Windows.Forms.Button ApplyBtn;

        private System.Windows.Forms.TableLayoutPanel MainLayout;

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        
        private System.Windows.Forms.ListBox RequestsList;

        #endregion

        
    }
}