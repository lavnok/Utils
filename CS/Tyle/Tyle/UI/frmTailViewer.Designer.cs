﻿using System.Drawing;

namespace Tyle.UI
{
    partial class frmTailViewer
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
            if (tailedFile != null)
            {
                tailedFile.Close();
            }
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
            this.mnuTailForm = new System.Windows.Forms.MenuStrip();
            this.mnuEdit = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuECopy = new System.Windows.Forms.ToolStripMenuItem();
            this.tssAfterCopy = new System.Windows.Forms.ToolStripSeparator();
            this.mnuEFind = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuEFindNext = new System.Windows.Forms.ToolStripMenuItem();
            this.lsvTailViewer = new Tyle.UI.TailListView();
            this.mnuTailForm.SuspendLayout();
            this.SuspendLayout();
            // 
            // mnuTailForm
            // 
            this.mnuTailForm.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.mnuTailForm.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuEdit});
            this.mnuTailForm.Location = new System.Drawing.Point(0, 0);
            this.mnuTailForm.Name = "mnuTailForm";
            this.mnuTailForm.Size = new System.Drawing.Size(282, 28);
            this.mnuTailForm.TabIndex = 1;
            this.mnuTailForm.Text = "mnuTail";
            this.mnuTailForm.Visible = false;
            // 
            // mnuEdit
            // 
            this.mnuEdit.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuECopy,
            this.tssAfterCopy,
            this.mnuEFind,
            this.mnuEFindNext});
            this.mnuEdit.MergeAction = System.Windows.Forms.MergeAction.Replace;
            this.mnuEdit.MergeIndex = 1;
            this.mnuEdit.Name = "mnuEdit";
            this.mnuEdit.Size = new System.Drawing.Size(47, 24);
            this.mnuEdit.Text = "&Edit";
            // 
            // mnuECopy
            // 
            this.mnuECopy.Name = "mnuECopy";
            this.mnuECopy.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
            this.mnuECopy.Size = new System.Drawing.Size(171, 26);
            this.mnuECopy.Text = "&Copy";
            this.mnuECopy.Click += new System.EventHandler(this.mnuECopy_Click);
            // 
            // tssAfterCopy
            // 
            this.tssAfterCopy.Name = "tssAfterCopy";
            this.tssAfterCopy.Size = new System.Drawing.Size(168, 6);
            // 
            // mnuEFind
            // 
            this.mnuEFind.Name = "mnuEFind";
            this.mnuEFind.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.F)));
            this.mnuEFind.Size = new System.Drawing.Size(171, 26);
            this.mnuEFind.Text = "&Find";
            this.mnuEFind.Click += new System.EventHandler(this.mnuEFind_Click);
            // 
            // mnuEFindNext
            // 
            this.mnuEFindNext.Enabled = false;
            this.mnuEFindNext.Name = "mnuEFindNext";
            this.mnuEFindNext.ShortcutKeys = System.Windows.Forms.Keys.F3;
            this.mnuEFindNext.Size = new System.Drawing.Size(171, 26);
            this.mnuEFindNext.Text = "Find &Next";
            this.mnuEFindNext.Click += new System.EventHandler(this.mnuEFindNext_Click);
            // 
            // lsvTailViewer
            // 
            this.lsvTailViewer.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lsvTailViewer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lsvTailViewer.Font = new System.Drawing.Font("Courier New", 12F);
            this.lsvTailViewer.ForeColor = System.Drawing.Color.Black;
            this.lsvTailViewer.FullRowSelect = true;
            this.lsvTailViewer.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None;
            this.lsvTailViewer.Location = new System.Drawing.Point(0, 0);
            this.lsvTailViewer.Name = "lsvTailViewer";
            this.lsvTailViewer.ShowGroups = false;
            this.lsvTailViewer.Size = new System.Drawing.Size(282, 253);
            this.lsvTailViewer.TabIndex = 0;
            this.lsvTailViewer.UseCompatibleStateImageBehavior = false;
            this.lsvTailViewer.View = System.Windows.Forms.View.Details;
            this.lsvTailViewer.VirtualMode = true;
            this.lsvTailViewer.RetrieveVirtualItem += new System.Windows.Forms.RetrieveVirtualItemEventHandler(this.lsvTailViewer_RetrieveVirtualItem);
            // 
            // frmTailViewer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(282, 253);
            this.Controls.Add(this.lsvTailViewer);
            this.Controls.Add(this.mnuTailForm);
            this.MainMenuStrip = this.mnuTailForm;
            this.Name = "frmTailViewer";
            this.Text = "TailViewer";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmTailViewer_FormClosing);
            this.mnuTailForm.ResumeLayout(false);
            this.mnuTailForm.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TailListView lsvTailViewer;
        private System.Windows.Forms.MenuStrip mnuTailForm;
        private System.Windows.Forms.ToolStripMenuItem mnuEdit;
        private System.Windows.Forms.ToolStripMenuItem mnuECopy;
        private System.Windows.Forms.ToolStripSeparator tssAfterCopy;
        private System.Windows.Forms.ToolStripMenuItem mnuEFind;
        private System.Windows.Forms.ToolStripMenuItem mnuEFindNext;
    }

    #region TailListView
    class TailListView : System.Windows.Forms.ListView
    {
        public TailListView() : base()
        {
            DoubleBuffered = true;
            VirtualMode = true;
            View = System.Windows.Forms.View.Details;
            FullRowSelect = true;
            Dock = System.Windows.Forms.DockStyle.Fill;
            Font = new Font("Courier New", 12, FontStyle.Regular);
            ShowGroups = false;
#if DEBUG
            GridLines = true;
#endif
            HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None;
            Columns.Add("LineNumber", -1, System.Windows.Forms.HorizontalAlignment.Left);
            Columns.Add("Line", -1, System.Windows.Forms.HorizontalAlignment.Left);
        }
        public void AutoFitColumnsToContent(string longestLine)
        {
            int longLineMaxWidth = (int)System.Math.Ceiling(MeasureString(longestLine).Width + 50f);
            Columns[0].Width = -2;
            Columns[1].Width = (Columns[1].Width < longLineMaxWidth ? longLineMaxWidth : Columns[1].Width);
        }
        public void SelectVirtualItem(int index)
        {
            SelectedIndices.Clear();
            SelectedIndices.Add(index);
            EnsureVisible(index);
            Items[index].Focused = true;
            Focus();
        }
        protected SizeF MeasureString(string stringToMeasure)
        {
            // [BIB]:  https://stackoverflow.com/a/6705023
            SizeF measuredSize;
            using (Graphics g = this.CreateGraphics())
            {
                measuredSize = g.MeasureString(stringToMeasure, Font);
            }
            return measuredSize;
        }
    }
    #endregion
}