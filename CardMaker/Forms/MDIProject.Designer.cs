////////////////////////////////////////////////////////////////////////////////
// The MIT License (MIT)
//
// Copyright (c) 2015 Tim Stair
//
// Permission is hereby granted, free of charge, to any person obtaining a copy
// of this software and associated documentation files (the "Software"), to deal
// in the Software without restriction, including without limitation the rights
// to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
// copies of the Software, and to permit persons to whom the Software is
// furnished to do so, subject to the following conditions:
//
// The above copyright notice and this permission notice shall be included in all
// copies or substantial portions of the Software.
//
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
// IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
// FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
// AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
// LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
// OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE
// SOFTWARE.
////////////////////////////////////////////////////////////////////////////////

namespace CardMaker.Forms
{
    partial class MDIProject
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
            this.components = new System.ComponentModel.Container();
            this.treeView = new System.Windows.Forms.TreeView();
            this.contextMenuStripProject = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.addCardLayoutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addCardLayoutFromTemplateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripMenuItemSetProjectNameFormat = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStripLayout = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.duplicateLayoutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.defineAsTemplateLayoutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.removeCardLayoutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.printPreviewCardLayoutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.printCardLayoutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exportCardLayoutAsImagesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exportCardLayoutAsPDFToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem4 = new System.Windows.Forms.ToolStripSeparator();
            this.addReferenceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addGoogleSpreadsheetReferenceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripMenuItemSetLayoutNameFormat = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStripReference = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.setAsDefaultReferenceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.removeReferenceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStripProject.SuspendLayout();
            this.contextMenuStripLayout.SuspendLayout();
            this.contextMenuStripReference.SuspendLayout();
            this.SuspendLayout();
            // 
            // treeView
            // 
            this.treeView.AllowDrop = true;
            this.treeView.ContextMenuStrip = this.contextMenuStripProject;
            this.treeView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treeView.HideSelection = false;
            this.treeView.LabelEdit = true;
            this.treeView.Location = new System.Drawing.Point(0, 0);
            this.treeView.Name = "treeView";
            this.treeView.ShowRootLines = false;
            this.treeView.Size = new System.Drawing.Size(192, 335);
            this.treeView.TabIndex = 1;
            this.treeView.BeforeLabelEdit += new System.Windows.Forms.NodeLabelEditEventHandler(this.treeView_BeforeLabelEdit);
            this.treeView.AfterLabelEdit += new System.Windows.Forms.NodeLabelEditEventHandler(this.treeView_AfterLabelEdit);
            this.treeView.ItemDrag += new System.Windows.Forms.ItemDragEventHandler(this.treeView_ItemDrag);
            this.treeView.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeView_AfterSelect);
            this.treeView.DragDrop += new System.Windows.Forms.DragEventHandler(this.treeView_DragDrop);
            this.treeView.DragEnter += new System.Windows.Forms.DragEventHandler(this.treeView_DragEnter);
            this.treeView.MouseClick += new System.Windows.Forms.MouseEventHandler(this.treeView_MouseClick);
            // 
            // contextMenuStripProject
            // 
            this.contextMenuStripProject.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addCardLayoutToolStripMenuItem,
            this.addCardLayoutFromTemplateToolStripMenuItem,
            this.toolStripMenuItem1,
            this.toolStripMenuItemSetProjectNameFormat});
            this.contextMenuStripProject.Name = "contextMenuStripTreeView";
            this.contextMenuStripProject.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.contextMenuStripProject.Size = new System.Drawing.Size(242, 76);
            this.contextMenuStripProject.Opening += new System.ComponentModel.CancelEventHandler(this.contextMenuStripTreeView_Opening);
            // 
            // addCardLayoutToolStripMenuItem
            // 
            this.addCardLayoutToolStripMenuItem.Name = "addCardLayoutToolStripMenuItem";
            this.addCardLayoutToolStripMenuItem.Size = new System.Drawing.Size(241, 22);
            this.addCardLayoutToolStripMenuItem.Text = "Add Card Layout...";
            this.addCardLayoutToolStripMenuItem.Click += new System.EventHandler(this.addLayoutToolStripMenuItem_Click);
            // 
            // addCardLayoutFromTemplateToolStripMenuItem
            // 
            this.addCardLayoutFromTemplateToolStripMenuItem.Name = "addCardLayoutFromTemplateToolStripMenuItem";
            this.addCardLayoutFromTemplateToolStripMenuItem.Size = new System.Drawing.Size(241, 22);
            this.addCardLayoutFromTemplateToolStripMenuItem.Text = "Add Card Layout From Template...";
            this.addCardLayoutFromTemplateToolStripMenuItem.Click += new System.EventHandler(this.addCardLayoutFromTemplateToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(238, 6);
            // 
            // toolStripMenuItemSetProjectNameFormat
            // 
            this.toolStripMenuItemSetProjectNameFormat.Name = "toolStripMenuItemSetProjectNameFormat";
            this.toolStripMenuItemSetProjectNameFormat.Size = new System.Drawing.Size(241, 22);
            this.toolStripMenuItemSetProjectNameFormat.Text = "Set Name Format...";
            this.toolStripMenuItemSetProjectNameFormat.Click += new System.EventHandler(this.setNameFormatToolStripMenuItem_Click);
            // 
            // contextMenuStripLayout
            // 
            this.contextMenuStripLayout.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.duplicateLayoutToolStripMenuItem,
            this.defineAsTemplateLayoutToolStripMenuItem,
            this.removeCardLayoutToolStripMenuItem,
            this.toolStripMenuItem2,
            this.printPreviewCardLayoutToolStripMenuItem,
            this.printCardLayoutToolStripMenuItem,
            this.exportCardLayoutAsImagesToolStripMenuItem,
            this.exportCardLayoutAsPDFToolStripMenuItem,
            this.toolStripMenuItem4,
            this.addReferenceToolStripMenuItem,
            this.addGoogleSpreadsheetReferenceToolStripMenuItem,
            this.toolStripMenuItem3,
            this.toolStripMenuItemSetLayoutNameFormat});
            this.contextMenuStripLayout.Name = "contextMenuStripLayout";
            this.contextMenuStripLayout.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.contextMenuStripLayout.Size = new System.Drawing.Size(259, 264);
            // 
            // duplicateLayoutToolStripMenuItem
            // 
            this.duplicateLayoutToolStripMenuItem.Name = "duplicateLayoutToolStripMenuItem";
            this.duplicateLayoutToolStripMenuItem.Size = new System.Drawing.Size(258, 22);
            this.duplicateLayoutToolStripMenuItem.Text = "Duplicate Layout";
            this.duplicateLayoutToolStripMenuItem.Click += new System.EventHandler(this.duplicateLayoutToolStripMenuItem_Click);
            // 
            // defineAsTemplateLayoutToolStripMenuItem
            // 
            this.defineAsTemplateLayoutToolStripMenuItem.Name = "defineAsTemplateLayoutToolStripMenuItem";
            this.defineAsTemplateLayoutToolStripMenuItem.Size = new System.Drawing.Size(258, 22);
            this.defineAsTemplateLayoutToolStripMenuItem.Text = "Define As Template Layout...";
            this.defineAsTemplateLayoutToolStripMenuItem.Click += new System.EventHandler(this.defineAsTemplateLayoutToolStripMenuItem_Click);
            // 
            // removeCardLayoutToolStripMenuItem
            // 
            this.removeCardLayoutToolStripMenuItem.Name = "removeCardLayoutToolStripMenuItem";
            this.removeCardLayoutToolStripMenuItem.Size = new System.Drawing.Size(258, 22);
            this.removeCardLayoutToolStripMenuItem.Text = "Remove Card Layout";
            this.removeCardLayoutToolStripMenuItem.Click += new System.EventHandler(this.removeLayoutToolStripMenuItem_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(255, 6);
            // 
            // printPreviewCardLayoutToolStripMenuItem
            // 
            this.printPreviewCardLayoutToolStripMenuItem.Name = "printPreviewCardLayoutToolStripMenuItem";
            this.printPreviewCardLayoutToolStripMenuItem.Size = new System.Drawing.Size(258, 22);
            this.printPreviewCardLayoutToolStripMenuItem.Text = "Print Preview Card Layout...";
            this.printPreviewCardLayoutToolStripMenuItem.Click += new System.EventHandler(this.printPreviewCardLayoutToolStripMenuItem_Click);
            // 
            // printCardLayoutToolStripMenuItem
            // 
            this.printCardLayoutToolStripMenuItem.Name = "printCardLayoutToolStripMenuItem";
            this.printCardLayoutToolStripMenuItem.Size = new System.Drawing.Size(258, 22);
            this.printCardLayoutToolStripMenuItem.Text = "Print Card Layout...";
            this.printCardLayoutToolStripMenuItem.Click += new System.EventHandler(this.printCardLayoutToolStripMenuItem_Click);
            // 
            // exportCardLayoutAsImagesToolStripMenuItem
            // 
            this.exportCardLayoutAsImagesToolStripMenuItem.Name = "exportCardLayoutAsImagesToolStripMenuItem";
            this.exportCardLayoutAsImagesToolStripMenuItem.Size = new System.Drawing.Size(258, 22);
            this.exportCardLayoutAsImagesToolStripMenuItem.Text = "Export Card Layout as Images...";
            this.exportCardLayoutAsImagesToolStripMenuItem.Click += new System.EventHandler(this.exportCardLayoutAsImagesToolStripMenuItem_Click);
            // 
            // exportCardLayoutAsPDFToolStripMenuItem
            // 
            this.exportCardLayoutAsPDFToolStripMenuItem.Name = "exportCardLayoutAsPDFToolStripMenuItem";
            this.exportCardLayoutAsPDFToolStripMenuItem.Size = new System.Drawing.Size(258, 22);
            this.exportCardLayoutAsPDFToolStripMenuItem.Text = "Export Card Layout as PDF...";
            this.exportCardLayoutAsPDFToolStripMenuItem.Click += new System.EventHandler(this.exportCardLayoutAsPDFToolStripMenuItem_Click);
            // 
            // toolStripMenuItem4
            // 
            this.toolStripMenuItem4.Name = "toolStripMenuItem4";
            this.toolStripMenuItem4.Size = new System.Drawing.Size(255, 6);
            // 
            // addReferenceToolStripMenuItem
            // 
            this.addReferenceToolStripMenuItem.Name = "addReferenceToolStripMenuItem";
            this.addReferenceToolStripMenuItem.Size = new System.Drawing.Size(258, 22);
            this.addReferenceToolStripMenuItem.Text = "Add Reference...";
            this.addReferenceToolStripMenuItem.Click += new System.EventHandler(this.addReferenceToolStripMenuItem_Click);
            // 
            // addGoogleSpreadsheetReferenceToolStripMenuItem
            // 
            this.addGoogleSpreadsheetReferenceToolStripMenuItem.Name = "addGoogleSpreadsheetReferenceToolStripMenuItem";
            this.addGoogleSpreadsheetReferenceToolStripMenuItem.Size = new System.Drawing.Size(258, 22);
            this.addGoogleSpreadsheetReferenceToolStripMenuItem.Text = "Add Google Spreadsheet Reference...";
            this.addGoogleSpreadsheetReferenceToolStripMenuItem.Click += new System.EventHandler(this.addGoogleSpreadsheetReferenceToolStripMenuItem_Click);
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(255, 6);
            // 
            // toolStripMenuItemSetLayoutNameFormat
            // 
            this.toolStripMenuItemSetLayoutNameFormat.Name = "toolStripMenuItemSetLayoutNameFormat";
            this.toolStripMenuItemSetLayoutNameFormat.Size = new System.Drawing.Size(258, 22);
            this.toolStripMenuItemSetLayoutNameFormat.Text = "Configure Layout Export...";
            this.toolStripMenuItemSetLayoutNameFormat.Click += new System.EventHandler(this.setNameFormatToolStripMenuItem_Click);
            // 
            // contextMenuStripReference
            // 
            this.contextMenuStripReference.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.setAsDefaultReferenceToolStripMenuItem,
            this.removeReferenceToolStripMenuItem});
            this.contextMenuStripReference.Name = "contextMenuStripReference";
            this.contextMenuStripReference.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.contextMenuStripReference.Size = new System.Drawing.Size(197, 48);
            // 
            // setAsDefaultReferenceToolStripMenuItem
            // 
            this.setAsDefaultReferenceToolStripMenuItem.Name = "setAsDefaultReferenceToolStripMenuItem";
            this.setAsDefaultReferenceToolStripMenuItem.Size = new System.Drawing.Size(196, 22);
            this.setAsDefaultReferenceToolStripMenuItem.Text = "Set As Default Reference";
            this.setAsDefaultReferenceToolStripMenuItem.Click += new System.EventHandler(this.setAsDefaultReferenceToolStripMenuItem_Click);
            // 
            // removeReferenceToolStripMenuItem
            // 
            this.removeReferenceToolStripMenuItem.Name = "removeReferenceToolStripMenuItem";
            this.removeReferenceToolStripMenuItem.Size = new System.Drawing.Size(196, 22);
            this.removeReferenceToolStripMenuItem.Text = "Remove Reference";
            this.removeReferenceToolStripMenuItem.Click += new System.EventHandler(this.removeReferenceToolStripMenuItem_Click);
            // 
            // MDIProject
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(192, 335);
            this.Controls.Add(this.treeView);
            this.Name = "MDIProject";
            this.ShowIcon = false;
            this.Text = " Project";
            this.contextMenuStripProject.ResumeLayout(false);
            this.contextMenuStripLayout.ResumeLayout(false);
            this.contextMenuStripReference.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TreeView treeView;
        private System.Windows.Forms.ContextMenuStrip contextMenuStripProject;
        private System.Windows.Forms.ToolStripMenuItem addCardLayoutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemSetProjectNameFormat;
        private System.Windows.Forms.ToolStripMenuItem addCardLayoutFromTemplateToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStripLayout;
        private System.Windows.Forms.ContextMenuStrip contextMenuStripReference;
        private System.Windows.Forms.ToolStripMenuItem duplicateLayoutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem removeCardLayoutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem defineAsTemplateLayoutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addReferenceToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem printPreviewCardLayoutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem printCardLayoutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exportCardLayoutAsImagesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem setAsDefaultReferenceToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem removeReferenceToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemSetLayoutNameFormat;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem4;
        private System.Windows.Forms.ToolStripMenuItem addGoogleSpreadsheetReferenceToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exportCardLayoutAsPDFToolStripMenuItem;
    }
}