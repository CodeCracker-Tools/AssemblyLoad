/*
 * Created by SharpDevelop.
 * User: Bogdan
 * Date: 03.01.2013
 * Time: 20:15
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Drawing;
using System.Windows.Forms;
using System.Reflection;
using System.Runtime.InteropServices;

namespace AssemblyLoad
{
	/// <summary>
	/// Description of Modules.
	/// </summary>
	public partial class Modules : Form
	{
		Assembly asm;
		public Modules(Assembly inputasm)
		{
			asm = inputasm;

			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
		void ModulesShown(object sender, EventArgs e)
		{
		this.Text = "Modules from "+asm.FullName;
		
		Module[] modules = asm.GetModules();
        for (int i=0;i<modules.Length;i++)
        {
        IntPtr address = Marshal.GetHINSTANCE(modules[i]);
        string modaddress = ((uint)(address)).ToString("X8");
        string[] prcdetails = new string[]{modaddress,modules[i].Name};
        ListViewItem proc = new ListViewItem(prcdetails);
        moduleslist.Items.Add(proc);
        }
		}
		
		void SendModuleToJitToolStripMenuItemClick(object sender, EventArgs e)
		{
if (moduleslist.SelectedIndices.Count>0)
{	
string moduleaddress = moduleslist.Items[moduleslist.SelectedIndices[0]].SubItems[0].Text;
int modulevalue = Convert.ToInt32(moduleaddress, 16);

		Module[] mod = asm.GetModules();
        for (int i=0;i<mod.Length;i++)
        {
        int address = (int)Marshal.GetHINSTANCE(mod[i]);
        if (modulevalue==address)
        {
        SendToJit.SendModuleToJit(mod[i]);
        }
        }
}
		}
		
		void CopyToolStripMenuItemClick(object sender, EventArgs e)
		{
if (moduleslist.SelectedIndices.Count>0)
{	
string strtoset = moduleslist.Items[moduleslist.SelectedIndices[0]].SubItems[0].Text;
if (strtoset!="") Clipboard.SetText(strtoset);
}
		}
	}
}
