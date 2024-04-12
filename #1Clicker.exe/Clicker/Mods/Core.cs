using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;

namespace Clicker.Mods
{
	// Token: 0x0200000A RID: 10
	internal class Core
	{
		// Token: 0x0600006B RID: 107 RVA: 0x00008EB4 File Offset: 0x000070B4
		[DebuggerStepThrough]
		[Obfuscation(Feature = "virtualization", Exclude = true)]
		public static Task leftclick(IntPtr window, int timeout)
		{
			Core.<leftclick>d__1 <leftclick>d__ = new Core.<leftclick>d__1();
			<leftclick>d__.<>t__builder = AsyncTaskMethodBuilder.Create();
			<leftclick>d__.window = window;
			<leftclick>d__.timeout = timeout;
			<leftclick>d__.<>1__state = -1;
			<leftclick>d__.<>t__builder.Start<Core.<leftclick>d__1>(ref <leftclick>d__);
			return <leftclick>d__.<>t__builder.Task;
		}

		// Token: 0x0600006C RID: 108 RVA: 0x00008F00 File Offset: 0x00007100
		[DebuggerStepThrough]
		[Obfuscation(Feature = "virtualization", Exclude = true)]
		public static Task breakblock(IntPtr window, int timeout)
		{
			Core.<breakblock>d__2 <breakblock>d__ = new Core.<breakblock>d__2();
			<breakblock>d__.<>t__builder = AsyncTaskMethodBuilder.Create();
			<breakblock>d__.window = window;
			<breakblock>d__.timeout = timeout;
			<breakblock>d__.<>1__state = -1;
			<breakblock>d__.<>t__builder.Start<Core.<breakblock>d__2>(ref <breakblock>d__);
			return <breakblock>d__.<>t__builder.Task;
		}

		// Token: 0x0600006D RID: 109 RVA: 0x00008F4C File Offset: 0x0000714C
		[DebuggerStepThrough]
		[Obfuscation(Feature = "virtualization", Exclude = true)]
		public static Task Mode18(IntPtr window, int timeout)
		{
			Core.<Mode18>d__3 <Mode18>d__ = new Core.<Mode18>d__3();
			<Mode18>d__.<>t__builder = AsyncTaskMethodBuilder.Create();
			<Mode18>d__.window = window;
			<Mode18>d__.timeout = timeout;
			<Mode18>d__.<>1__state = -1;
			<Mode18>d__.<>t__builder.Start<Core.<Mode18>d__3>(ref <Mode18>d__);
			return <Mode18>d__.<>t__builder.Task;
		}

		// Token: 0x0600006E RID: 110 RVA: 0x00008F98 File Offset: 0x00007198
		[DebuggerStepThrough]
		[Obfuscation(Feature = "virtualization", Exclude = true)]
		public static Task rightclick(IntPtr window, int timeout)
		{
			Core.<rightclick>d__4 <rightclick>d__ = new Core.<rightclick>d__4();
			<rightclick>d__.<>t__builder = AsyncTaskMethodBuilder.Create();
			<rightclick>d__.window = window;
			<rightclick>d__.timeout = timeout;
			<rightclick>d__.<>1__state = -1;
			<rightclick>d__.<>t__builder.Start<Core.<rightclick>d__4>(ref <rightclick>d__);
			return <rightclick>d__.<>t__builder.Task;
		}

		// Token: 0x04000065 RID: 101
		public static Random rnd = new Random();
	}
}
