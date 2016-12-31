/*
 * Created by SharpDevelop.
 * User: Bogdan
 * Date: 01.01.2013
 * Time: 19:59
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.Reflection;
using System.Runtime.InteropServices;

namespace AssemblyLoad
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		public MainForm()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
		void MainFormShown(object sender, EventArgs e)
		{
		Assembly[] asemblies = AppDomain.CurrentDomain.GetAssemblies();
        for (int i=0;i<asemblies.Length;i++)
        {
         Graphics g = assemblieslist.CreateGraphics();
         Font objFont = new Font("Microsoft Sans Serif", 8);
         SizeF stringSize = new SizeF();
         stringSize = g.MeasureString(asemblies[i].FullName, objFont);
         int assemblieslenght = (int)(stringSize.Width+assemblieslist.Margin.Horizontal*2);
         
         if (assemblieslenght>assemblies.Width)
         {
         assemblies.Width=assemblieslenght;
         }
        IntPtr address = Marshal.GetHINSTANCE(asemblies[i].ManifestModule);
        string modaddress = ((uint)(address)).ToString("X8");
        string[] prcdetails = new string[]{modaddress,asemblies[i].FullName};
        ListViewItem proc = new ListViewItem(prcdetails);
        assemblieslist.Items.Add(proc);
        }
		}
		
		void CopyHandleToolStripMenuItemClick(object sender, EventArgs e)
		{
if (assemblieslist.SelectedIndices.Count>0)
{	
string strtoset = assemblieslist.Items[assemblieslist.SelectedIndices[0]].SubItems[0].Text;
if (strtoset!="") Clipboard.SetText(strtoset);
}
		}
		
		void SendMainModuleToJitToolStripMenuItemClick(object sender, EventArgs e)
		{
if (assemblieslist.SelectedIndices.Count>0)
{	
string fullname = assemblieslist.Items[assemblieslist.SelectedIndices[0]].SubItems[1].Text;
        Assembly[] asemblies = AppDomain.CurrentDomain.GetAssemblies();
        for (int i=0;i<asemblies.Length;i++)
        {
        if (asemblies[i].FullName==fullname)
        {
        SendToJit.SendModuleToJit(asemblies[i].ManifestModule);
        }
        }
}
		}
		
		void EnumModulesToolStripMenuItemClick(object sender, EventArgs e)
		{
if (assemblieslist.SelectedIndices.Count>0)
{	
string fullname = assemblieslist.Items[assemblieslist.SelectedIndices[0]].SubItems[1].Text;
        Assembly[] asemblies = AppDomain.CurrentDomain.GetAssemblies();
        for (int i=0;i<asemblies.Length;i++)
        {
        if (asemblies[i].FullName==fullname)
        {
        Modules modform = new Modules(asemblies[i]);
        modform.Show();
        }
        }
}
		}
	}
}
