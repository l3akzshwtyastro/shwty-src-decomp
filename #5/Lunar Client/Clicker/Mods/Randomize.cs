using System;
using System.Runtime.CompilerServices;
using Microsoft.CSharp.RuntimeBinder;

namespace Clicker.Mods
{
	// Token: 0x0200000C RID: 12
	public class Randomize
	{
		// Token: 0x1700000E RID: 14
		// (get) Token: 0x0600005E RID: 94 RVA: 0x00004F38 File Offset: 0x00003138
		// (set) Token: 0x0600005F RID: 95 RVA: 0x00004F3F File Offset: 0x0000313F
		public static Random C_Random { get; protected set; }

		// Token: 0x1700000F RID: 15
		// (get) Token: 0x06000060 RID: 96 RVA: 0x00004F47 File Offset: 0x00003147
		// (set) Token: 0x06000061 RID: 97 RVA: 0x00004F4F File Offset: 0x0000314F
		public int Seed { get; protected set; }

		// Token: 0x06000062 RID: 98 RVA: 0x00004F58 File Offset: 0x00003158
		public Randomize(uint seed)
		{
			Randomize.C_Random = new Random((int)seed);
			this.Seed = (int)seed;
		}

		// Token: 0x06000063 RID: 99 RVA: 0x00004F78 File Offset: 0x00003178
		public int Rnd(dynamic min, dynamic max)
		{
			Random c_Random = Randomize.C_Random;
			if (Randomize.<>o__9.<>p__0 == null)
			{
				Randomize.<>o__9.<>p__0 = CallSite<Func<CallSite, object, int>>.Create(Binder.Convert(CSharpBinderFlags.ConvertExplicit, typeof(int), typeof(Randomize)));
			}
			int minValue = Randomize.<>o__9.<>p__0.Target(Randomize.<>o__9.<>p__0, min);
			if (Randomize.<>o__9.<>p__1 == null)
			{
				Randomize.<>o__9.<>p__1 = CallSite<Func<CallSite, object, int>>.Create(Binder.Convert(CSharpBinderFlags.ConvertExplicit, typeof(int), typeof(Randomize)));
			}
			return c_Random.Next(minValue, Randomize.<>o__9.<>p__1.Target(Randomize.<>o__9.<>p__1, max));
		}
	}
}
