using System.ComponentModel;

namespace ControlPanel.View
{
    partial class ShowServerInfoDialog
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
            this.CloseBtn = new System.Windows.Forms.Button();
            this.InfoLayout = new System.Windows.Forms.TableLayoutPanel();
            this.PortInfoLabel = new System.Windows.Forms.Label();
            this.PortValueLabel = new System.Windows.Forms.Label();
            this.AddressValueLabel = new System.Windows.Forms.Label();
            this.AddressInfoLabel = new System.Windows.Forms.Label();
            this.CurrentStateValueLabel = new System.Windows.Forms.Label();
            this.CurrentStateInfoLabel = new System.Windows.Forms.Label();
            this.LastUpdateValueLabel = new System.Windows.Forms.Label();
            this.LastUpdateInfoLabel = new System.Windows.Forms.Label();
            this.ServiceInstanceNameValueLabel = new System.Windows.Forms.Label();
            this.ServiceInstanceNameInfoLabel = new System.Windows.Forms.Label();
            this.MainLayout.SuspendLayout();
            this.ControlsLayout.SuspendLayout();
            this.InfoLayout.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainLayout
            // 
            this.MainLayout.ColumnCount = 3;
            this.MainLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 7.5F));
            this.MainLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 85F));
            this.MainLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 7.5F));
            this.MainLayout.Controls.Add(this.ControlsLayout, 1, 2);
            this.MainLayout.Controls.Add(this.InfoLayout, 1, 1);
            this.MainLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainLayout.Location = new System.Drawing.Point(0, 0);
            this.MainLayout.Name = "MainLayout";
            this.MainLayout.RowCount = 3;
            this.MainLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.MainLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 68F));
            this.MainLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 22F));
            this.MainLayout.Size = new System.Drawing.Size(516, 323);
            this.MainLayout.TabIndex = 0;
            // 
            // ControlsLayout
            // 
            this.ControlsLayout.ColumnCount = 3;
            this.ControlsLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.ControlsLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.ControlsLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.ControlsLayout.Controls.Add(this.CloseBtn, 1, 0);
            this.ControlsLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ControlsLayout.Location = new System.Drawing.Point(41, 254);
            this.ControlsLayout.Name = "ControlsLayout";
            this.ControlsLayout.RowCount = 1;
            this.ControlsLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.ControlsLayout.Size = new System.Drawing.Size(432, 66);
            this.ControlsLayout.TabIndex = 0;
            // 
            // CloseBtn
            // 
            this.CloseBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CloseBtn.Location = new System.Drawing.Point(147, 3);
            this.CloseBtn.Name = "CloseBtn";
            this.CloseBtn.Size = new System.Drawing.Size(138, 60);
            this.CloseBtn.TabIndex = 0;
            this.CloseBtn.Text = "Close";
            this.CloseBtn.UseVisualStyleBackColor = true;
            this.CloseBtn.Click += new System.EventHandler(this.CloseBtn_Click);
            // 
            // InfoLayout
            // 
            this.InfoLayout.ColumnCount = 2;
            this.InfoLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.InfoLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.InfoLayout.Controls.Add(this.PortInfoLabel, 0, 4);
            this.InfoLayout.Controls.Add(this.PortValueLabel, 0, 4);
            this.InfoLayout.Controls.Add(this.AddressValueLabel, 1, 3);
            this.InfoLayout.Controls.Add(this.AddressInfoLabel, 0, 3);
            this.InfoLayout.Controls.Add(this.CurrentStateValueLabel, 1, 2);
            this.InfoLayout.Controls.Add(this.CurrentStateInfoLabel, 0, 2);
            this.InfoLayout.Controls.Add(this.LastUpdateValueLabel, 1, 1);
            this.InfoLayout.Controls.Add(this.LastUpdateInfoLabel, 0, 1);
            this.InfoLayout.Controls.Add(this.ServiceInstanceNameValueLabel, 1, 0);
            this.InfoLayout.Controls.Add(this.ServiceInstanceNameInfoLabel, 0, 0);
            this.InfoLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.InfoLayout.Location = new System.Drawing.Point(41, 35);
            this.InfoLayout.Name = "InfoLayout";
            this.InfoLayout.RowCount = 5;
            this.InfoLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.InfoLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.InfoLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.InfoLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.InfoLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.InfoLayout.Size = new System.Drawing.Size(432, 213);
            this.InfoLayout.TabIndex = 1;
            // 
            // PortInfoLabel
            // 
            this.PortInfoLabel.AutoSize = true;
            this.PortInfoLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PortInfoLabel.Location = new System.Drawing.Point(3, 168);
            this.PortInfoLabel.Name = "PortInfoLabel";
            this.PortInfoLabel.Size = new System.Drawing.Size(210, 45);
            this.PortInfoLabel.TabIndex = 9;
            this.PortInfoLabel.Text = "Port";
            this.PortInfoLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // PortValueLabel
            // 
            this.PortValueLabel.AutoSize = true;
            this.PortValueLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PortValueLabel.Location = new System.Drawing.Point(219, 168);
            this.PortValueLabel.Name = "PortValueLabel";
            this.PortValueLabel.Size = new System.Drawing.Size(210, 45);
            this.PortValueLabel.TabIndex = 8;
            this.PortValueLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // AddressValueLabel
            // 
            this.AddressValueLabel.AutoSize = true;
            this.AddressValueLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.AddressValueLabel.Location = new System.Drawing.Point(219, 126);
            this.AddressValueLabel.Name = "AddressValueLabel";
            this.AddressValueLabel.Size = new System.Drawing.Size(210, 42);
            this.AddressValueLabel.TabIndex = 7;
            this.AddressValueLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // AddressInfoLabel
            // 
            this.AddressInfoLabel.AutoSize = true;
            this.AddressInfoLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.AddressInfoLabel.Location = new System.Drawing.Point(3, 126);
            this.AddressInfoLabel.Name = "AddressInfoLabel";
            this.AddressInfoLabel.Size = new System.Drawing.Size(210, 42);
            this.AddressInfoLabel.TabIndex = 6;
            this.AddressInfoLabel.Text = "Address";
            this.AddressInfoLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // CurrentStateValueLabel
            // 
            this.CurrentStateValueLabel.AutoSize = true;
            this.CurrentStateValueLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CurrentStateValueLabel.Location = new System.Drawing.Point(219, 84);
            this.CurrentStateValueLabel.Name = "CurrentStateValueLabel";
            this.CurrentStateValueLabel.Size = new System.Drawing.Size(210, 42);
            this.CurrentStateValueLabel.TabIndex = 5;
            this.CurrentStateValueLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // CurrentStateInfoLabel
            // 
            this.CurrentStateInfoLabel.AutoSize = true;
            this.CurrentStateInfoLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CurrentStateInfoLabel.Location = new System.Drawing.Point(3, 84);
            this.CurrentStateInfoLabel.Name = "CurrentStateInfoLabel";
            this.CurrentStateInfoLabel.Size = new System.Drawing.Size(210, 42);
            this.CurrentStateInfoLabel.TabIndex = 4;
            this.CurrentStateInfoLabel.Text = "Current state";
            this.CurrentStateInfoLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // LastUpdateValueLabel
            // 
            this.LastUpdateValueLabel.AutoSize = true;
            this.LastUpdateValueLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LastUpdateValueLabel.Location = new System.Drawing.Point(219, 42);
            this.LastUpdateValueLabel.Name = "LastUpdateValueLabel";
            this.LastUpdateValueLabel.Size = new System.Drawing.Size(210, 42);
            this.LastUpdateValueLabel.TabIndex = 3;
            this.LastUpdateValueLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // LastUpdateInfoLabel
            // 
            this.LastUpdateInfoLabel.AutoSize = true;
            this.LastUpdateInfoLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LastUpdateInfoLabel.Location = new System.Drawing.Point(3, 42);
            this.LastUpdateInfoLabel.Name = "LastUpdateInfoLabel";
            this.LastUpdateInfoLabel.Size = new System.Drawing.Size(210, 42);
            this.LastUpdateInfoLabel.TabIndex = 2;
            this.LastUpdateInfoLabel.Text = "Last update";
            this.LastUpdateInfoLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // ServiceInstanceNameValueLabel
            // 
            this.ServiceInstanceNameValueLabel.AutoSize = true;
            this.ServiceInstanceNameValueLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ServiceInstanceNameValueLabel.Location = new System.Drawing.Point(219, 0);
            this.ServiceInstanceNameValueLabel.Name = "ServiceInstanceNameValueLabel";
            this.ServiceInstanceNameValueLabel.Size = new System.Drawing.Size(210, 42);
            this.ServiceInstanceNameValueLabel.TabIndex = 1;
            this.ServiceInstanceNameValueLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // ServiceInstanceNameInfoLabel
            // 
            this.ServiceInstanceNameInfoLabel.AutoSize = true;
            this.ServiceInstanceNameInfoLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ServiceInstanceNameInfoLabel.Location = new System.Drawing.Point(3, 0);
            this.ServiceInstanceNameInfoLabel.Name = "ServiceInstanceNameInfoLabel";
            this.ServiceInstanceNameInfoLabel.Size = new System.Drawing.Size(210, 42);
            this.ServiceInstanceNameInfoLabel.TabIndex = 0;
            this.ServiceInstanceNameInfoLabel.Text = "Service instance name";
            this.ServiceInstanceNameInfoLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // ShowServerInfoDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(516, 323);
            this.Controls.Add(this.MainLayout);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ShowServerInfoDialog";
            this.Text = "Server information";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ShowServerInfoDialog_FormClosing);
            this.Load += new System.EventHandler(this.ShowServerInfoDialog_Load);
            this.MainLayout.ResumeLayout(false);
            this.ControlsLayout.ResumeLayout(false);
            this.InfoLayout.ResumeLayout(false);
            this.InfoLayout.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel MainLayout;
        private System.Windows.Forms.TableLayoutPanel ControlsLayout;
        private System.Windows.Forms.TableLayoutPanel InfoLayout;
        private System.Windows.Forms.Label PortInfoLabel;
        private System.Windows.Forms.Label PortValueLabel;
        private System.Windows.Forms.Label AddressValueLabel;
        private System.Windows.Forms.Label AddressInfoLabel;
        private System.Windows.Forms.Label CurrentStateValueLabel;
        private System.Windows.Forms.Label CurrentStateInfoLabel;
        private System.Windows.Forms.Label LastUpdateValueLabel;
        private System.Windows.Forms.Label LastUpdateInfoLabel;
        private System.Windows.Forms.Label ServiceInstanceNameValueLabel;
        private System.Windows.Forms.Label ServiceInstanceNameInfoLabel;
        private System.Windows.Forms.Button CloseBtn;
    }
}