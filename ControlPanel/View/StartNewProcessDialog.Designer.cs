
using System.Windows.Forms;

namespace ControlPanel.View
{
    partial class StartNewProcessDialog
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
            this.MainLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.ButtonPanel = new System.Windows.Forms.TableLayoutPanel();
            this.SetupProcessBtn = new System.Windows.Forms.Button();
            this.PropertiesLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.FileTextBox = new System.Windows.Forms.TextBox();
            this.ArgumentsTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.PrioritiesList = new System.Windows.Forms.ComboBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.AffinityTextBox = new System.Windows.Forms.TextBox();
            this.ManageAffinityBtn = new System.Windows.Forms.Button();
            this.RequestsList = new System.Windows.Forms.ListBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.AddBtn = new System.Windows.Forms.Button();
            this.DeleteBtn = new System.Windows.Forms.Button();
            this.MainLayoutPanel.SuspendLayout();
            this.ButtonPanel.SuspendLayout();
            this.PropertiesLayoutPanel.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainLayoutPanel
            // 
            this.MainLayoutPanel.ColumnCount = 2;
            this.MainLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.MainLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 164F));
            this.MainLayoutPanel.Controls.Add(this.ButtonPanel, 0, 2);
            this.MainLayoutPanel.Controls.Add(this.PropertiesLayoutPanel, 0, 1);
            this.MainLayoutPanel.Controls.Add(this.RequestsList, 1, 1);
            this.MainLayoutPanel.Controls.Add(this.tableLayoutPanel1, 1, 2);
            this.MainLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.MainLayoutPanel.Name = "MainLayoutPanel";
            this.MainLayoutPanel.RowCount = 3;
            this.MainLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.21865F));
            this.MainLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 64.24419F));
            this.MainLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 23.83721F));
            this.MainLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.MainLayoutPanel.Size = new System.Drawing.Size(612, 344);
            this.MainLayoutPanel.TabIndex = 0;
            // 
            // ButtonPanel
            // 
            this.ButtonPanel.ColumnCount = 3;
            this.ButtonPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.ButtonPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.ButtonPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.ButtonPanel.Controls.Add(this.SetupProcessBtn, 1, 0);
            this.ButtonPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ButtonPanel.Location = new System.Drawing.Point(3, 264);
            this.ButtonPanel.Name = "ButtonPanel";
            this.ButtonPanel.RowCount = 1;
            this.ButtonPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.ButtonPanel.Size = new System.Drawing.Size(442, 77);
            this.ButtonPanel.TabIndex = 0;
            // 
            // SetupProcessBtn
            // 
            this.SetupProcessBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SetupProcessBtn.Location = new System.Drawing.Point(150, 3);
            this.SetupProcessBtn.Name = "SetupProcessBtn";
            this.SetupProcessBtn.Size = new System.Drawing.Size(141, 71);
            this.SetupProcessBtn.TabIndex = 0;
            this.SetupProcessBtn.Text = "Setup Processes";
            this.SetupProcessBtn.UseVisualStyleBackColor = true;
            this.SetupProcessBtn.Click += new System.EventHandler(this.SetupProcessBtn_Click);
            // 
            // PropertiesLayoutPanel
            // 
            this.PropertiesLayoutPanel.ColumnCount = 2;
            this.PropertiesLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 29.95595F));
            this.PropertiesLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70.04405F));
            this.PropertiesLayoutPanel.Controls.Add(this.FileTextBox, 1, 0);
            this.PropertiesLayoutPanel.Controls.Add(this.ArgumentsTextBox, 1, 1);
            this.PropertiesLayoutPanel.Controls.Add(this.label1, 0, 0);
            this.PropertiesLayoutPanel.Controls.Add(this.label2, 0, 1);
            this.PropertiesLayoutPanel.Controls.Add(this.label3, 0, 2);
            this.PropertiesLayoutPanel.Controls.Add(this.label4, 0, 3);
            this.PropertiesLayoutPanel.Controls.Add(this.PrioritiesList, 1, 3);
            this.PropertiesLayoutPanel.Controls.Add(this.tableLayoutPanel2, 1, 2);
            this.PropertiesLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PropertiesLayoutPanel.Location = new System.Drawing.Point(3, 44);
            this.PropertiesLayoutPanel.Name = "PropertiesLayoutPanel";
            this.PropertiesLayoutPanel.RowCount = 4;
            this.PropertiesLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 21.14537F));
            this.PropertiesLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.PropertiesLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 26.02041F));
            this.PropertiesLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 27.55102F));
            this.PropertiesLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.PropertiesLayoutPanel.Size = new System.Drawing.Size(442, 214);
            this.PropertiesLayoutPanel.TabIndex = 1;
            // 
            // FileTextBox
            // 
            this.FileTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FileTextBox.Location = new System.Drawing.Point(135, 6);
            this.FileTextBox.Margin = new System.Windows.Forms.Padding(3, 6, 3, 3);
            this.FileTextBox.Name = "FileTextBox";
            this.FileTextBox.Size = new System.Drawing.Size(304, 26);
            this.FileTextBox.TabIndex = 11;
            // 
            // ArgumentsTextBox
            // 
            this.ArgumentsTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ArgumentsTextBox.Location = new System.Drawing.Point(135, 55);
            this.ArgumentsTextBox.Margin = new System.Windows.Forms.Padding(3, 10, 3, 3);
            this.ArgumentsTextBox.Name = "ArgumentsTextBox";
            this.ArgumentsTextBox.Size = new System.Drawing.Size(304, 26);
            this.ArgumentsTextBox.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Location = new System.Drawing.Point(3, 3);
            this.label1.Margin = new System.Windows.Forms.Padding(3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 39);
            this.label1.TabIndex = 0;
            this.label1.Text = "File";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Location = new System.Drawing.Point(3, 48);
            this.label2.Margin = new System.Windows.Forms.Padding(3);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(126, 47);
            this.label2.TabIndex = 1;
            this.label2.Text = "Arguments";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Location = new System.Drawing.Point(3, 101);
            this.label3.Margin = new System.Windows.Forms.Padding(3);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(126, 49);
            this.label3.TabIndex = 2;
            this.label3.Text = "Processor Affinity";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label4.Location = new System.Drawing.Point(3, 156);
            this.label4.Margin = new System.Windows.Forms.Padding(3);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(126, 55);
            this.label4.TabIndex = 3;
            this.label4.Text = "Proirity";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
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
            this.PrioritiesList.Location = new System.Drawing.Point(135, 163);
            this.PrioritiesList.Margin = new System.Windows.Forms.Padding(3, 10, 3, 3);
            this.PrioritiesList.Name = "PrioritiesList";
            this.PrioritiesList.Size = new System.Drawing.Size(304, 28);
            this.PrioritiesList.TabIndex = 9;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 219F));
            this.tableLayoutPanel2.Controls.Add(this.AffinityTextBox, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.ManageAffinityBtn, 1, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(135, 101);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(304, 49);
            this.tableLayoutPanel2.TabIndex = 13;
            // 
            // ProcessorAffinityTextBox
            // 
            this.AffinityTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.AffinityTextBox.Location = new System.Drawing.Point(6, 6);
            this.AffinityTextBox.Margin = new System.Windows.Forms.Padding(6);
            this.AffinityTextBox.Multiline = true;
            this.AffinityTextBox.Name = "AffinityTextBox";
            this.AffinityTextBox.Size = new System.Drawing.Size(73, 37);
            this.AffinityTextBox.TabIndex = 14;
            // 
            // ManageAffinityBtn
            // 
            this.ManageAffinityBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ManageAffinityBtn.Location = new System.Drawing.Point(88, 3);
            this.ManageAffinityBtn.Name = "ManageAffinityBtn";
            this.ManageAffinityBtn.Size = new System.Drawing.Size(213, 43);
            this.ManageAffinityBtn.TabIndex = 13;
            this.ManageAffinityBtn.Text = "Configure processor affinity";
            this.ManageAffinityBtn.UseVisualStyleBackColor = true;
            this.ManageAffinityBtn.Click += new System.EventHandler(this.ManageAffinityBtn_Click);
            // 
            // RequestsList
            // 
            this.RequestsList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.RequestsList.FormattingEnabled = true;
            this.RequestsList.ItemHeight = 20;
            this.RequestsList.Location = new System.Drawing.Point(451, 44);
            this.RequestsList.Name = "RequestsList";
            this.RequestsList.Size = new System.Drawing.Size(158, 214);
            this.RequestsList.TabIndex = 2;
            this.RequestsList.SelectedIndexChanged += new System.EventHandler(this.RequestsList_SelectedIndexChanged);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.DeleteBtn, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.AddBtn, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(451, 264);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(158, 77);
            this.tableLayoutPanel1.TabIndex = 3;
            // 
            // AddBtn
            // 
            this.AddBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.AddBtn.Location = new System.Drawing.Point(3, 3);
            this.AddBtn.Name = "AddBtn";
            this.AddBtn.Size = new System.Drawing.Size(73, 71);
            this.AddBtn.TabIndex = 1;
            this.AddBtn.Text = "Add";
            this.AddBtn.UseVisualStyleBackColor = true;
            this.AddBtn.Click += new System.EventHandler(this.AddBtn_Click);
            // 
            // DeleteBtn
            // 
            this.DeleteBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DeleteBtn.Location = new System.Drawing.Point(82, 3);
            this.DeleteBtn.Name = "DeleteBtn";
            this.DeleteBtn.Size = new System.Drawing.Size(73, 71);
            this.DeleteBtn.TabIndex = 2;
            this.DeleteBtn.Text = "Delete";
            this.DeleteBtn.UseVisualStyleBackColor = true;
            this.DeleteBtn.Click += new System.EventHandler(this.DeleteBtn_Click);
            // 
            // StartNewProcessDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(612, 344);
            this.Controls.Add(this.MainLayoutPanel);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "StartNewProcessDialog";
            this.Text = "Process creation dialog";
            this.Load += new System.EventHandler(this.StartProcessDialog_Load);
            this.MainLayoutPanel.ResumeLayout(false);
            this.ButtonPanel.ResumeLayout(false);
            this.PropertiesLayoutPanel.ResumeLayout(false);
            this.PropertiesLayoutPanel.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        private System.Windows.Forms.TextBox AffinityTextBox;

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;

        #endregion

        private System.Windows.Forms.TableLayoutPanel MainLayoutPanel;
        private System.Windows.Forms.TableLayoutPanel ButtonPanel;
        private System.Windows.Forms.Button SetupProcessBtn;
        private System.Windows.Forms.TableLayoutPanel PropertiesLayoutPanel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox PrioritiesList;
        private System.Windows.Forms.TextBox ArgumentsTextBox;
        private System.Windows.Forms.Button ManageAffinityBtn;
        private System.Windows.Forms.TextBox FileTextBox;
        private System.Windows.Forms.ListBox RequestsList;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button DeleteBtn;
        private System.Windows.Forms.Button AddBtn;
    }
}