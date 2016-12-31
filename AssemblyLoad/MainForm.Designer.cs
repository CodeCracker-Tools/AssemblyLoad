/*
 * Created by SharpDevelop.
 * User: Bogdan
 * Date: 01.01.2013
 * Time: 19:59
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace AssemblyLoad
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			this.assemblieslist = new System.Windows.Forms.ListView();
			this.handle = new System.Windows.Forms.ColumnHeader();
			this.assemblies = new System.Windows.Forms.ColumnHeader();
			this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.copyHandleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.sendMainModuleToJitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.enumModulesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.contextMenuStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// assemblieslist
			// 
			this.assemblieslist.Alignment = System.Windows.Forms.ListViewAlignment.Default;
			this.assemblieslist.AllowDrop = true;
			this.assemblieslist.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
									| System.Windows.Forms.AnchorStyles.Left) 
									| System.Windows.Forms.AnchorStyles.Right)));
			this.assemblieslist.AutoArrange = false;
			this.assemblieslist.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
									this.handle,
									this.assemblies});
			this.assemblieslist.ContextMenuStrip = this.contextMenuStrip1;
			this.assemblieslist.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
			this.assemblieslist.FullRowSelect = true;
			this.assemblieslist.GridLines = true;
			this.assemblieslist.Location = new System.Drawing.Point(22, 12);
			this.assemblieslist.Name = "assemblieslist";
			this.assemblieslist.Size = new System.Drawing.Size(555, 307);
			this.assemblieslist.TabIndex = 68;
			this.assemblieslist.UseCompatibleStateImageBehavior = false;
			this.assemblieslist.View = System.Windows.Forms.View.Details;
			// 
			// handle
			// 
			this.handle.Text = "Handle:";
			this.handle.Width = 91;
			// 
			// assemblies
			// 
			this.assemblies.Text = "Assemblies";
			this.assemblies.Width = 168;
			// 
			// contextMenuStrip1
			// 
			this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
									this.copyHandleToolStripMenuItem,
									this.sendMainModuleToJitToolStripMenuItem,
									this.enumModulesToolStripMenuItem});
			this.contextMenuStrip1.Name = "contextMenuStrip1";
			this.contextMenuStrip1.Size = new System.Drawing.Size(197, 92);
			// 
			// copyHandleToolStripMenuItem
			// 
			this.copyHandleToolStripMenuItem.Name = "copyHandleToolStripMenuItem";
			this.copyHandleToolStripMenuItem.Size = new System.Drawing.Size(196, 22);
			this.copyHandleToolStripMenuItem.Text = "Copy Handle";
			this.copyHandleToolStripMenuItem.Click += new System.EventHandler(this.CopyHandleToolStripMenuItemClick);
			// 
			// sendMainModuleToJitToolStripMenuItem
			// 
			this.sendMainModuleToJitToolStripMenuItem.Name = "sendMainModuleToJitToolStripMenuItem";
			this.sendMainModuleToJitToolStripMenuItem.Size = new System.Drawing.Size(196, 22);
			this.sendMainModuleToJitToolStripMenuItem.Text = "Send main module to jit";
			this.sendMainModuleToJitToolStripMenuItem.Click += new System.EventHandler(this.SendMainModuleToJitToolStripMenuItemClick);
			// 
			// enumModulesToolStripMenuItem
			// 
			this.enumModulesToolStripMenuItem.Name = "enumModulesToolStripMenuItem";
			this.enumModulesToolStripMenuItem.Size = new System.Drawing.Size(196, 22);
			this.enumModulesToolStripMenuItem.Text = "Enumerate modules";
			this.enumModulesToolStripMenuItem.Click += new System.EventHandler(this.EnumModulesToolStripMenuItemClick);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(589, 344);
			this.Controls.Add(this.assemblieslist);
			this.Name = "MainForm";
			this.Text = "Assemblies list:";
			this.Shown += new System.EventHandler(this.MainFormShown);
			this.contextMenuStrip1.ResumeLayout(false);
			this.ResumeLayout(false);
		}
		private System.Windows.Forms.ToolStripMenuItem enumModulesToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem sendMainModuleToJitToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem copyHandleToolStripMenuItem;
		private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
		private System.Windows.Forms.ColumnHeader handle;
		private System.Windows.Forms.ColumnHeader assemblies;
		private System.Windows.Forms.ListView assemblieslist;
	}
}
