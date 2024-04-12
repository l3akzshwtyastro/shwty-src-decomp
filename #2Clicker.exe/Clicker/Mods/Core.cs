using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;

namespace Clicker.Mods
{
	// Token: 0x0200000E RID: 14
	internal class Core
	{
		// Token: 0x0600006E RID: 110 RVA: 0x00008F04 File Offset: 0x00007104
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

		// Token: 0x0600006F RID: 111 RVA: 0x00008F50 File Offset: 0x00007150
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

		// Token: 0x06000070 RID: 112 RVA: 0x00008F9C File Offset: 0x0000719C
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

		// Token: 0x06000071 RID: 113 RVA: 0x00008FE8 File Offset: 0x000071E8
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

		// Token: 0x0400006D RID: 109
		public static Random rnd = new Random();
	}
}
