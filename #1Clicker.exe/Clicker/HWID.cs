using System;
using System.Management;

namespace Clicker
{
	// Token: 0x02000005 RID: 5
	internal class HWID
	{
		// Token: 0x06000050 RID: 80 RVA: 0x000088C8 File Offset: 0x00006AC8
		public static string getSerialRam()
		{
			ManagementObjectCollection instances = new ManagementClass("Win32_PhysicalMemory").GetInstances();
			string result = string.Empty;
			using (ManagementObjectCollection.ManagementObjectEnumerator enumerator = instances.GetEnumerator())
			{
				bool flag = enumerator.MoveNext();
				if (flag)
				{
					result = enumerator.Current.Properties["SerialNumber"].Value.ToString();
				}
			}
			return result;
		}

		// Token: 0x06000051 RID: 81 RVA: 0x00008944 File Offset: 0x00006B44
		public static string getSerialProcesseur()
		{
			ManagementObjectCollection instances = new ManagementClass("Win32_Processor").GetInstances();
			string result = string.Empty;
			using (ManagementObjectCollection.ManagementObjectEnumerator enumerator = instances.GetEnumerator())
			{
				bool flag = enumerator.MoveNext();
				if (flag)
				{
					result = enumerator.Current.Properties["ProcessorId"].Value.ToString();
				}
			}
			return result;
		}

		// Token: 0x06000052 RID: 82 RVA: 0x000089C0 File Offset: 0x00006BC0
		public static string getSerialBaseBoard()
		{
			ManagementObjectCollection instances = new ManagementClass("Win32_BaseBoard").GetInstances();
			string result = string.Empty;
			using (ManagementObjectCollection.ManagementObjectEnumerator enumerator = instances.GetEnumerator())
			{
				bool flag = enumerator.MoveNext();
				if (flag)
				{
					result = enumerator.Current.Properties["SerialNumber"].Value.ToString();
				}
			}
			return result;
		}

		// Token: 0x06000053 RID: 83 RVA: 0x00008A3C File Offset: 0x00006C3C
		public static string getSerialBIOS()
		{
			ManagementObjectCollection instances = new ManagementClass("Win32_BIOS").GetInstances();
			string result = string.Empty;
			using (ManagementObjectCollection.ManagementObjectEnumerator enumerator = instances.GetEnumerator())
			{
				bool flag = enumerator.MoveNext();
				if (flag)
				{
					result = enumerator.Current.Properties["SerialNumber"].Value.ToString();
				}
			}
			return result;
		}

		// Token: 0x06000054 RID: 84 RVA: 0x00008AB8 File Offset: 0x00006CB8
		public static string getSerialDriveDisk()
		{
			ManagementObjectCollection instances = new ManagementClass("Win32_DiskDrive").GetInstances();
			string result = string.Empty;
			using (ManagementObjectCollection.ManagementObjectEnumerator enumerator = instances.GetEnumerator())
			{
				bool flag = enumerator.MoveNext();
				if (flag)
				{
					result = enumerator.Current.Properties["SerialNumber"].Value.ToString();
				}
			}
			return result;
		}

		// Token: 0x06000055 RID: 85 RVA: 0x00008B34 File Offset: 0x00006D34
		public static string getSerialHDD()
		{
			ManagementObjectCollection instances = new ManagementClass("Win32_LogicalDisk").GetInstances();
			string result = string.Empty;
			using (ManagementObjectCollection.ManagementObjectEnumerator enumerator = instances.GetEnumerator())
			{
				bool flag = enumerator.MoveNext();
				if (flag)
				{
					result = enumerator.Current.Properties["VolumeSerialNumber"].Value.ToString();
				}
			}
			return result;
		}

		// Token: 0x06000056 RID: 86 RVA: 0x00008BB0 File Offset: 0x00006DB0
		public static string getUniqueSerialId()
		{
			string empty = string.Empty;
			return string.Concat(new string[]
			{
				HWID.getSerialHDD(),
				"-",
				HWID.getSerialDriveDisk(),
				"-",
				HWID.getSerialBIOS(),
				"-",
				HWID.getSerialBaseBoard(),
				"-",
				HWID.getSerialProcesseur(),
				"-",
				HWID.getSerialRam()
			});
		}
	}
}
