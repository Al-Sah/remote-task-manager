using System.ComponentModel;

namespace ControlPanel.View
{
    partial class ProcessManipulationResult
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private IContainer components = null;

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
            this.ControlsLayout = new System.Windows.Forms.TableLayoutPanel();
            this.OkBtn = new System.Windows.Forms.Button();
            this.ResultsDataGridView = new System.Windows.Forms.DataGridView();
            this.DeletedProcessId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DeletedProcessStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ActionLabel = new System.Windows.Forms.Label();
            this.MainLayout.SuspendLayout();
            this.ControlsLayout.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ResultsDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // MainLayout
            // 
            this.MainLayout.ColumnCount = 1;
            this.MainLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.MainLayout.Controls.Add(this.ControlsLayout, 0, 2);
            this.MainLayout.Controls.Add(this.ResultsDataGridView, 0, 1);
            this.MainLayout.Controls.Add(this.ActionLabel, 0, 0);
            this.MainLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainLayout.Location = new System.Drawing.Point(0, 0);
            this.MainLayout.Margin = new System.Windows.Forms.Padding(4);
            this.MainLayout.Name = "MainLayout";
            this.MainLayout.RowCount = 3;
            this.MainLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.MainLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 242F));
            this.MainLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 57F));
            this.MainLayout.Size = new System.Drawing.Size(372, 348);
            this.MainLayout.TabIndex = 0;
            // 
            // ControlsLayout
            // 
            this.ControlsLayout.ColumnCount = 3;
            this.ControlsLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.ControlsLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.ControlsLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.ControlsLayout.Controls.Add(this.OkBtn, 1, 0);
            this.ControlsLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ControlsLayout.Location = new System.Drawing.Point(4, 295);
            this.ControlsLayout.Margin = new System.Windows.Forms.Padding(4);
            this.ControlsLayout.Name = "ControlsLayout";
            this.ControlsLayout.RowCount = 1;
            this.ControlsLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.ControlsLayout.Size = new System.Drawing.Size(364, 49);
            this.ControlsLayout.TabIndex = 0;
            // 
            // OkBtn
            // 
            this.OkBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.OkBtn.Location = new System.Drawing.Point(125, 4);
            this.OkBtn.Margin = new System.Windows.Forms.Padding(4);
            this.OkBtn.Name = "OkBtn";
            this.OkBtn.Size = new System.Drawing.Size(113, 41);
            this.OkBtn.TabIndex = 0;
            this.OkBtn.Text = "Ok";
            this.OkBtn.UseVisualStyleBackColor = true;
            this.OkBtn.Click += new System.EventHandler(this.OkBtn_Click);
            // 
            // ResultsDataGridView
            // 
            this.ResultsDataGridView.AllowUserToAddRows = false;
            this.ResultsDataGridView.AllowUserToDeleteRows = false;
            this.ResultsDataGridView.AllowUserToOrderColumns = true;
            this.ResultsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ResultsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.DeletedProcessId,
            this.DeletedProcessStatus});
            this.ResultsDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ResultsDataGridView.Location = new System.Drawing.Point(3, 52);
            this.ResultsDataGridView.Name = "ResultsDataGridView";
            this.ResultsDataGridView.ReadOnly = true;
            this.ResultsDataGridView.Size = new System.Drawing.Size(366, 236);
            this.ResultsDataGridView.TabIndex = 1;
            // 
            // DeletedProcessId
            // 
            this.DeletedProcessId.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.DeletedProcessId.HeaderText = "ProcessId";
            this.DeletedProcessId.Name = "DeletedProcessId";
            this.DeletedProcessId.ReadOnly = true;
            // 
            // DeletedProcessStatus
            // 
            this.DeletedProcessStatus.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.DeletedProcessStatus.HeaderText = "Status";
            this.DeletedProcessStatus.Name = "DeletedProcessStatus";
            this.DeletedProcessStatus.ReadOnly = true;
            // 
            // ActionLabel
            // 
            this.ActionLabel.AutoSize = true;
            this.ActionLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ActionLabel.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ActionLabel.Location = new System.Drawing.Point(3, 0);
            this.ActionLabel.Name = "ActionLabel";
            this.ActionLabel.Size = new System.Drawing.Size(366, 49);
            this.ActionLabel.TabIndex = 2;
            this.ActionLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ProcessManipulationResult
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(372, 348);
            this.Controls.Add(this.MainLayout);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ProcessManipulationResult";
            this.Text = "Results";
            this.Load += new System.EventHandler(this.ProcessManipulationResult_LoadDialog);
            this.MainLayout.ResumeLayout(false);
            this.MainLayout.PerformLayout();
            this.ControlsLayout.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ResultsDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel MainLayout;
        private System.Windows.Forms.TableLayoutPanel ControlsLayout;
        private System.Windows.Forms.Button OkBtn;
        private System.Windows.Forms.DataGridView ResultsDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn DeletedProcessId;
        private System.Windows.Forms.DataGridViewTextBoxColumn DeletedProcessStatus;
        private System.Windows.Forms.Label ActionLabel;
    }
}