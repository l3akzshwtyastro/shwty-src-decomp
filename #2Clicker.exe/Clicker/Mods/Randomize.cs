using System;
using System.Runtime.CompilerServices;
using Microsoft.CSharp.RuntimeBinder;

namespace Clicker.Mods
{
	// Token: 0x0200000C RID: 12
	public class Randomize
	{
		// Token: 0x17000012 RID: 18
		// (get) Token: 0x06000068 RID: 104 RVA: 0x00008E22 File Offset: 0x00007022
		// (set) Token: 0x06000069 RID: 105 RVA: 0x00008E29 File Offset: 0x00007029
		public static Random C_Random { get; protected set; }

		// Token: 0x17000013 RID: 19
		// (get) Token: 0x0600006A RID: 106 RVA: 0x00008E31 File Offset: 0x00007031
		// (set) Token: 0x0600006B RID: 107 RVA: 0x00008E39 File Offset: 0x00007039
		public int Seed { get; protected set; }

		// Token: 0x0600006C RID: 108 RVA: 0x00008E42 File Offset: 0x00007042
		public Randomize(uint seed)
		{
			Randomize.C_Random = new Random((int)seed);
			this.Seed = (int)seed;
		}

		// Token: 0x0600006D RID: 109 RVA: 0x00008E60 File Offset: 0x00007060
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
