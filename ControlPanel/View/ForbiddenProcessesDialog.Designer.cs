
namespace ControlPanel.View
{
    partial class ForbiddenProcessesDialog
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
            this.ButtonsLayout = new System.Windows.Forms.TableLayoutPanel();
            this.AddBtn = new System.Windows.Forms.Button();
            this.UpdateListBtn = new System.Windows.Forms.Button();
            this.DeleteBtn = new System.Windows.Forms.Button();
            this.NamesListBox = new System.Windows.Forms.ListBox();
            this.MainLayout.SuspendLayout();
            this.ButtonsLayout.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainLayout
            // 
            this.MainLayout.ColumnCount = 3;
            this.MainLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.MainLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.MainLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.MainLayout.Controls.Add(this.ButtonsLayout, 1, 2);
            this.MainLayout.Controls.Add(this.NamesListBox, 1, 1);
            this.MainLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainLayout.Location = new System.Drawing.Point(0, 0);
            this.MainLayout.Name = "MainLayout";
            this.MainLayout.RowCount = 3;
            this.MainLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.52654F));
            this.MainLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 87.47346F));
            this.MainLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 67F));
            this.MainLayout.Size = new System.Drawing.Size(363, 492);
            this.MainLayout.TabIndex = 0;
            // 
            // ButtonsLayout
            // 
            this.ButtonsLayout.ColumnCount = 3;
            this.ButtonsLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.ButtonsLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.ButtonsLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.ButtonsLayout.Controls.Add(this.AddBtn, 0, 0);
            this.ButtonsLayout.Controls.Add(this.UpdateListBtn, 1, 0);
            this.ButtonsLayout.Controls.Add(this.DeleteBtn, 2, 0);
            this.ButtonsLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ButtonsLayout.Location = new System.Drawing.Point(57, 427);
            this.ButtonsLayout.Name = "ButtonsLayout";
            this.ButtonsLayout.RowCount = 1;
            this.ButtonsLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.ButtonsLayout.Size = new System.Drawing.Size(248, 62);
            this.ButtonsLayout.TabIndex = 0;
            // 
            // AddBtn
            // 
            this.AddBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.AddBtn.Location = new System.Drawing.Point(3, 3);
            this.AddBtn.Name = "AddBtn";
            this.AddBtn.Size = new System.Drawing.Size(76, 56);
            this.AddBtn.TabIndex = 0;
            this.AddBtn.Text = "Add";
            this.AddBtn.UseVisualStyleBackColor = true;
            this.AddBtn.Click += new System.EventHandler(this.AddBtn_Click);
            // 
            // UpdateListBtn
            // 
            this.UpdateListBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.UpdateListBtn.Location = new System.Drawing.Point(85, 3);
            this.UpdateListBtn.Name = "UpdateListBtn";
            this.UpdateListBtn.Size = new System.Drawing.Size(76, 56);
            this.UpdateListBtn.TabIndex = 1;
            this.UpdateListBtn.Text = "Update List";
            this.UpdateListBtn.UseVisualStyleBackColor = true;
            this.UpdateListBtn.Click += new System.EventHandler(this.UpdateListBtn_Click);
            // 
            // DeleteBtn
            // 
            this.DeleteBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DeleteBtn.Location = new System.Drawing.Point(167, 3);
            this.DeleteBtn.Name = "DeleteBtn";
            this.DeleteBtn.Size = new System.Drawing.Size(78, 56);
            this.DeleteBtn.TabIndex = 2;
            this.DeleteBtn.Text = "Delete";
            this.DeleteBtn.UseVisualStyleBackColor = true;
            this.DeleteBtn.Click += new System.EventHandler(this.DeleteBtn_Click);
            // 
            // NamesListBox
            // 
            this.NamesListBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.NamesListBox.FormattingEnabled = true;
            this.NamesListBox.ItemHeight = 21;
            this.NamesListBox.Location = new System.Drawing.Point(74, 73);
            this.NamesListBox.Margin = new System.Windows.Forms.Padding(20);
            this.NamesListBox.Name = "NamesListBox";
            this.NamesListBox.Size = new System.Drawing.Size(214, 331);
            this.NamesListBox.TabIndex = 1;
            // 
            // ForbiddenProcessesDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(363, 492);
            this.Controls.Add(this.MainLayout);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ForbiddenProcessesDialog";
            this.Text = "ForbiddenProcessesDialog";
            this.Load += new System.EventHandler(this.ForbiddenProcessesDialog_Load);
            this.MainLayout.ResumeLayout(false);
            this.ButtonsLayout.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel MainLayout;
        private System.Windows.Forms.TableLayoutPanel ButtonsLayout;
        private System.Windows.Forms.Button AddBtn;
        private System.Windows.Forms.Button UpdateListBtn;
        private System.Windows.Forms.Button DeleteBtn;
        private System.Windows.Forms.ListBox NamesListBox;
    }
}