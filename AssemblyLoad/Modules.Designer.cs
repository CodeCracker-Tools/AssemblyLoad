/*
 * Created by SharpDevelop.
 * User: Bogdan
 * Date: 03.01.2013
 * Time: 20:15
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace AssemblyLoad
{
	partial class Modules
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
			this.moduleslist = new System.Windows.Forms.ListView();
			this.handle = new System.Windows.Forms.ColumnHeader();
			this.moduless = new System.Windows.Forms.ColumnHeader();
			this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.sendModuleToJitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.copyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.contextMenuStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// moduleslist
			// 
			this.moduleslist.Alignment = System.Windows.Forms.ListViewAlignment.Default;
			this.moduleslist.AllowDrop = true;
			this.moduleslist.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
									| System.Windows.Forms.AnchorStyles.Left) 
									| System.Windows.Forms.AnchorStyles.Right)));
			this.moduleslist.AutoArrange = false;
			this.moduleslist.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
									this.handle,
									this.moduless});
			this.moduleslist.ContextMenuStrip = this.contextMenuStrip1;
			this.moduleslist.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
			this.moduleslist.FullRowSelect = true;
			this.moduleslist.GridLines = true;
			this.moduleslist.Location = new System.Drawing.Point(12, 12);
			this.moduleslist.Name = "moduleslist";
			this.moduleslist.Size = new System.Drawing.Size(586, 231);
			this.moduleslist.TabIndex = 69;
			this.moduleslist.UseCompatibleStateImageBehavior = false;
			this.moduleslist.View = System.Windows.Forms.View.Details;
			// 
			// handle
			// 
			this.handle.Text = "Handle:";
			this.handle.Width = 91;
			// 
			// moduless
			// 
			this.moduless.Text = "Modules";
			this.moduless.Width = 168;
			// 
			// contextMenuStrip1
			// 
			this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
									this.sendModuleToJitToolStripMenuItem,
									this.copyToolStripMenuItem});
			this.contextMenuStrip1.Name = "contextMenuStrip1";
			this.contextMenuStrip1.Size = new System.Drawing.Size(172, 70);
			// 
			// sendModuleToJitToolStripMenuItem
			// 
			this.sendModuleToJitToolStripMenuItem.Name = "sendModuleToJitToolStripMenuItem";
			this.sendModuleToJitToolStripMenuItem.Size = new System.Drawing.Size(171, 22);
			this.sendModuleToJitToolStripMenuItem.Text = "Send module to jit";
			this.sendModuleToJitToolStripMenuItem.Click += new System.EventHandler(this.SendModuleToJitToolStripMenuItemClick);
			// 
			// copyToolStripMenuItem
			// 
			this.copyToolStripMenuItem.Name = "copyToolStripMenuItem";
			this.copyToolStripMenuItem.Size = new System.Drawing.Size(171, 22);
			this.copyToolStripMenuItem.Text = "Copy handle";
			this.copyToolStripMenuItem.Click += new System.EventHandler(this.CopyToolStripMenuItemClick);
			// 
			// Modules
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(619, 266);
			this.Controls.Add(this.moduleslist);
			this.Name = "Modules";
			this.Text = "Modules";
			this.Shown += new System.EventHandler(this.ModulesShown);
			this.contextMenuStrip1.ResumeLayout(false);
			this.ResumeLayout(false);
		}
		private System.Windows.Forms.ToolStripMenuItem copyToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem sendModuleToJitToolStripMenuItem;
		private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
		private System.Windows.Forms.ColumnHeader moduless;
		private System.Windows.Forms.ColumnHeader handle;
		private System.Windows.Forms.ListView moduleslist;
	}
}
