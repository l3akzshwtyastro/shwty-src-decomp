using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;

namespace Clicker.Mods
{
	// Token: 0x0200000E RID: 14
	internal class Core
	{
		// Token: 0x06000064 RID: 100 RVA: 0x0000501C File Offset: 0x0000321C
		[DebuggerStepThrough]
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

		// Token: 0x06000065 RID: 101 RVA: 0x00005068 File Offset: 0x00003268
		[DebuggerStepThrough]
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

		// Token: 0x06000066 RID: 102 RVA: 0x000050B4 File Offset: 0x000032B4
		[DebuggerStepThrough]
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

		// Token: 0x06000067 RID: 103 RVA: 0x00005100 File Offset: 0x00003300
		[DebuggerStepThrough]
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

		// Token: 0x0400003F RID: 63
		public static Random rnd = new Random();
	}
}
