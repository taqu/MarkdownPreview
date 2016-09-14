namespace MarkdownPreview
{
    partial class FormMain
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージ リソースが破棄される場合 true、破棄されない場合は false です。</param>
        protected override void Dispose(bool disposing)
        {
            if(disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.WebBrowserMain = new System.Windows.Forms.WebBrowser();
            this.PanelDrop = new System.Windows.Forms.Panel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.FileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.EditToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.TrackBottomToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tableLayoutPanel1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            //
            // tableLayoutPanel1
            //
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.WebBrowserMain, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.PanelDrop, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 26);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 89.98109F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 53F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(524, 503);
            this.tableLayoutPanel1.TabIndex = 0;
            //
            // WebBrowserMain
            //
            this.WebBrowserMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.WebBrowserMain.Location = new System.Drawing.Point(3, 3);
            this.WebBrowserMain.MinimumSize = new System.Drawing.Size(20, 20);
            this.WebBrowserMain.Name = "WebBrowserMain";
            this.WebBrowserMain.Size = new System.Drawing.Size(518, 444);
            this.WebBrowserMain.TabIndex = 0;
            this.WebBrowserMain.DocumentCompleted += new System.Windows.Forms.WebBrowserDocumentCompletedEventHandler(this.WebBrowserMain_DocumentCompleted);
            //
            // PanelDrop
            //
            this.PanelDrop.AllowDrop = true;
            this.PanelDrop.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PanelDrop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelDrop.Font = new System.Drawing.Font("MS UI Gothic", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.PanelDrop.Location = new System.Drawing.Point(3, 453);
            this.PanelDrop.Name = "PanelDrop";
            this.PanelDrop.Size = new System.Drawing.Size(518, 47);
            this.PanelDrop.TabIndex = 1;
            this.PanelDrop.DragDrop += new System.Windows.Forms.DragEventHandler(this.PanelDrop_DragDrop);
            this.PanelDrop.DragEnter += new System.Windows.Forms.DragEventHandler(this.PanelDrop_DragEnter);
            this.PanelDrop.Paint += new System.Windows.Forms.PaintEventHandler(this.PanelDrop_Paint);
            //
            // menuStrip1
            //
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.FileToolStripMenuItem,
            this.EditToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(524, 26);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            //
            // FileToolStripMenuItem
            //
            this.FileToolStripMenuItem.Name = "FileToolStripMenuItem";
            this.FileToolStripMenuItem.Size = new System.Drawing.Size(57, 22);
            this.FileToolStripMenuItem.Text = "File(&F)";
            //
            // EditToolStripMenuItem
            //
            this.EditToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TrackBottomToolStripMenuItem});
            this.EditToolStripMenuItem.Name = "EditToolStripMenuItem";
            this.EditToolStripMenuItem.Size = new System.Drawing.Size(59, 22);
            this.EditToolStripMenuItem.Text = "Edit(&E)";
            //
            // TrackBottomToolStripMenuItem
            //
            this.TrackBottomToolStripMenuItem.Checked = true;
            this.TrackBottomToolStripMenuItem.CheckOnClick = true;
            this.TrackBottomToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.TrackBottomToolStripMenuItem.Name = "TrackBottomToolStripMenuItem";
            this.TrackBottomToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
            this.TrackBottomToolStripMenuItem.Text = "Track Bottom";
            //
            // FormMain
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(524, 529);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormMain";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormMainClosing);
            this.Load += new System.EventHandler(this.FormMainLoad);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.WebBrowser WebBrowserMain;
        private System.Windows.Forms.Panel PanelDrop;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem FileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem EditToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem TrackBottomToolStripMenuItem;
    }
}

