using System;
using System.Runtime.CompilerServices;
using Microsoft.CSharp.RuntimeBinder;

namespace Clicker.Mods
{
	// Token: 0x02000009 RID: 9
	public class Randomize
	{
		// Token: 0x17000012 RID: 18
		// (get) Token: 0x06000065 RID: 101 RVA: 0x00008DD2 File Offset: 0x00006FD2
		// (set) Token: 0x06000066 RID: 102 RVA: 0x00008DD9 File Offset: 0x00006FD9
		public static Random C_Random { get; protected set; }

		// Token: 0x17000013 RID: 19
		// (get) Token: 0x06000067 RID: 103 RVA: 0x00008DE1 File Offset: 0x00006FE1
		// (set) Token: 0x06000068 RID: 104 RVA: 0x00008DE9 File Offset: 0x00006FE9
		public int Seed { get; protected set; }

		// Token: 0x06000069 RID: 105 RVA: 0x00008DF2 File Offset: 0x00006FF2
		public Randomize(uint seed)
		{
			Randomize.C_Random = new Random((int)seed);
			this.Seed = (int)seed;
		}

		// Token: 0x0600006A RID: 106 RVA: 0x00008E10 File Offset: 0x00007010
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
