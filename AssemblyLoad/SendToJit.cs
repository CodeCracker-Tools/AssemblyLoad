/*
 * Created by SharpDevelop.
 * User: Bogdan
 * Date: 03.01.2013
 * Time: 17:31
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.IO;
 
namespace AssemblyLoad
{
	/// <summary>
	/// Description of SendToJit.
	/// </summary>
	public class SendToJit
	{
		public SendToJit()
		{
		}
	static int methodcount=0;
	static int failed=0;
	static Module imodule;
	static int methodtoken;
	private static void SendMethodToJit(MethodBase mbase)
	{
methodcount++;
if (mbase.MetadataToken>methodtoken)
methodtoken=mbase.MetadataToken;


	}

[UnmanagedFunctionPointer(CallingConvention.ThisCall)]
private delegate IntPtr DoPrestub(RuntimeMethodHandle method);

	private static DoPrestub doPrestub;
	private unsafe static void InitPrestub()
	{
	// 0x79e80f8d
	// 7A0C743F mscorwks!MethodDesc::CompileMethod = "_CompileMethod" from RuntimeHelpers:
	// 7a0c74e5 call mscorwks!MethodDesc::DoPrestub (79e80f8d) - "clr/src/vm/prestub.cpp"
	IntPtr compileaddress = (IntPtr)typeof(RuntimeHelpers).GetMethod("_CompileMethod", BindingFlags.NonPublic | BindingFlags.Static | BindingFlags.Instance).MethodHandle.GetFunctionPointer().ToPointer();
	
	int N=0;
	do
	{
	N++;
	}
	while (Marshal.ReadInt32(compileaddress, N)!=0x01FC45C6);
	N = N+8;
	
	IntPtr IntPtrdoprestub = (IntPtr)(Marshal.ReadInt32(compileaddress,N+1)+(int)compileaddress+N+5);
	
	doPrestub = (DoPrestub)System.Runtime.InteropServices.Marshal.GetDelegateForFunctionPointer(IntPtrdoprestub,typeof(DoPrestub));
	}
	
 
	private static void SendMethodsToJit()
	{
MethodBase mbase =null;

for (int j = 0x06000001; j <= methodtoken; j++)
{
try
{
mbase = imodule.ResolveMethod(j);
RuntimeTypeHandle handle = new RuntimeTypeHandle();
doPrestub(mbase.MethodHandle);

}
catch
{

}


}
	}
	private static void SendTypeToJit(Type tdef)
	{
MethodBase[] mbases = tdef.GetMethods(BindingFlags.NonPublic | BindingFlags.Public
| BindingFlags.Instance | BindingFlags.Static);
for (int i = 0; i < mbases.Length; i++)
{
if (mbases[i].Module==imodule)
SendMethodToJit(mbases[i]);
}

MethodBase[] cbases = tdef.GetConstructors(BindingFlags.NonPublic | BindingFlags.Public
| BindingFlags.Instance | BindingFlags.Static);
for (int i = 0; i < cbases.Length; i++)
{
if (cbases[i].Module==imodule)
SendMethodToJit(cbases[i]);
}

Type[] nestedtypes = tdef.GetNestedTypes();
for (int i = 0; i < nestedtypes.Length; i++)
SendTypeToJit(nestedtypes[i]);

	}
	public static void SendModuleToJit(Module mod)
	{
InitPrestub();
imodule = mod;

MethodBase[] mbases = mod.GetMethods(BindingFlags.NonPublic | BindingFlags.Public
| BindingFlags.Instance | BindingFlags.Static);
for (int i = 0; i < mbases.Length; i++)
{
if ( mbases[i].Module==imodule)
SendMethodToJit(mbases[i]);
}
Type[] types = mod.GetTypes();
for (int i = 0; i < types.Length; i++)
SendTypeToJit(types[i]);

SendMethodsToJit();


MessageBox.Show("Last method token: "+methodtoken.ToString("X8")+"; failed: "+failed.ToString());
	}
	

	}
}
