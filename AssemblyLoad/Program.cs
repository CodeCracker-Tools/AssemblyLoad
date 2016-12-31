/*
 * Created by SharpDevelop.
 * User: Bogdan
 * Date: 01.01.2013
 * Time: 19:59
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Windows.Forms;
using System.Reflection;
using System.Runtime.InteropServices;

namespace AssemblyLoad
{
	public class MyClass
    {
        // This method will be called by native code inside the target process...
        public static int MyMethod(String pwzArgument)
        {
        try
        {
        Application.EnableVisualStyles();
		Application.SetCompatibleTextRenderingDefault(false);
        }
        catch
        {
        }
		MainForm mf = new MainForm();
		mf.Show();
		Application.Run();


            return 0;
        }

    }
			    
	/// <summary>
	/// Class with program entry point.
	/// </summary>
	internal sealed class Program
	{

		/// <summary>
		/// Program entry point.
		/// </summary>
		[STAThread]
		public static void Main(string[] args)
		{
	string target = @"C:\\Deobfuscator.exe";
	Assembly asm = Assembly.LoadFile(target);
	SendToJit.SendModuleToJit(asm.ManifestModule);
			
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			Application.Run(new MainForm());
		}
		
	}
}
