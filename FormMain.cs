using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MarkdownPreview
{
    public partial class FormMain : Form
    {
        private MarkdownSharp.Markdown markdown_;
        private string targetPath_;
        private System.IO.FileInfo targetInfo_;
        private System.IO.FileSystemWatcher watcher_;
        private Point scrollPos_ = new Point(0,0);

        public FormMain()
        {
            InitializeComponent();
            markdown_ = new MarkdownSharp.Markdown();
        }

        /**
        @brief Convert markdown format to html
        */
        private void convert()
        {
            if(string.IsNullOrEmpty(targetPath_)) {
                return;
            }
            if(null == targetInfo_) {
                targetInfo_ = new System.IO.FileInfo(targetPath_);
            }
            this.Text = targetInfo_.Name;

            if(null != WebBrowserMain.Document){
                scrollPos_ = new Point(WebBrowserMain.Document.Body.ScrollLeft, WebBrowserMain.Document.Body.ScrollTop);
            }else{
                scrollPos_ = new Point(0,0);
            }

            string content = System.IO.File.ReadAllText(targetPath_);
            WebBrowserMain.DocumentText = markdown_.Transform(content);
        }


        //--- FileSystemWatcher
        //------------------------------------------------------------------------------
        private void startWatching()
        {
            if(null != watcher_) {
                stopWatching();
            }
            if(string.IsNullOrEmpty(targetPath_)) {
                return;
            }
            if(null == targetInfo_) {
                targetInfo_ = new System.IO.FileInfo(targetPath_);
            }
            watcher_ = new System.IO.FileSystemWatcher();
            watcher_.Path = targetInfo_.Directory.FullName;

            watcher_.NotifyFilter = System.IO.NotifyFilters.LastWrite | System.IO.NotifyFilters.FileName;
            watcher_.SynchronizingObject = this;

            watcher_.Changed += new System.IO.FileSystemEventHandler(onTargetChanged);
            watcher_.Deleted += new System.IO.FileSystemEventHandler(onTargetChanged);
            watcher_.Renamed += new System.IO.RenamedEventHandler(onTargetRenamed);

            watcher_.EnableRaisingEvents = true;
        }

        private void stopWatching()
        {
            if(null == watcher_) {
                return;
            }
            watcher_.EnableRaisingEvents = false;
            watcher_.Dispose();
            watcher_ = null;
        }

        private void onTargetChanged(System.Object source, System.IO.FileSystemEventArgs e)
        {
            //Process only target path
            switch(e.ChangeType) {
            case System.IO.WatcherChangeTypes.Changed:
                if(targetPath_ == e.FullPath) {
                    convert();
                }
                break;
            case System.IO.WatcherChangeTypes.Created:
                if(targetPath_ == e.FullPath) {
                    convert();
                }
                break;
            case System.IO.WatcherChangeTypes.Deleted:
                if(targetPath_ == e.FullPath) {
                }
                break;
            }
        }

        private void onTargetRenamed(System.Object source, System.IO.RenamedEventArgs e)
        {
            //Track change based on the path name
            if(targetPath_ == e.FullPath) {
                convert();
            }
        }


        //--- Handle drag-drop
        //------------------------------------------------------------------------------
        private void PanelDrop_DragDrop(object sender, DragEventArgs e)
        {
            string[] filepaths = e.Data.GetData(DataFormats.FileDrop) as string[];
            if(null == filepaths){
                return;
            }
            foreach(string path in filepaths) {
                System.IO.FileInfo fileinfo = new System.IO.FileInfo(path);
                targetPath_ = fileinfo.FullName;
                targetInfo_ = fileinfo;
                convert();
                startWatching();
                return;
            }
        }

        private void PanelDrop_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.All;
            e.Data.SetData(DataFormats.FileDrop);
        }

        private void PanelDrop_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.DrawString("Drop On", PanelDrop.Font, Brushes.Black, new RectangleF(0.0f, 0.0f, e.ClipRectangle.Width, e.ClipRectangle.Height));
        }

        //--- Load and save preferences
        //------------------------------------------------------------------------------
        private void FormMainLoad(object sender, EventArgs e)
        {
            Bounds = Properties.Settings.Default.Bounds;
            WindowState = Properties.Settings.Default.WindowState;
            TrackBottomToolStripMenuItem.Checked = Properties.Settings.Default.TrackBottom;
        }

        private void FormMainClosing(object sender, FormClosingEventArgs e)
        {
            Properties.Settings.Default.Bounds = (FormWindowState.Normal == WindowState) ? Bounds : RestoreBounds;
            Properties.Settings.Default.WindowState = WindowState;
            Properties.Settings.Default.TrackBottom = TrackBottomToolStripMenuItem.Checked;
            Properties.Settings.Default.Save();
        }

        //--- Handle WebBrowser events
        //------------------------------------------------------------------------------
        private void WebBrowserMain_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            if(null == WebBrowserMain.Document) {
                return;
            }
            if(TrackBottomToolStripMenuItem.Checked) {
                WebBrowserMain.Document.Window.ScrollTo(scrollPos_.X, WebBrowserMain.Document.Body.ScrollRectangle.Height);
            } else {
                WebBrowserMain.Document.Window.ScrollTo(scrollPos_);
            }
        }
    }
}
