using System;
using System.Management;

namespace Clicker
{
	// Token: 0x02000008 RID: 8
	internal class HWID
	{
		// Token: 0x06000053 RID: 83 RVA: 0x00008918 File Offset: 0x00006B18
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

		// Token: 0x06000054 RID: 84 RVA: 0x00008994 File Offset: 0x00006B94
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

		// Token: 0x06000055 RID: 85 RVA: 0x00008A10 File Offset: 0x00006C10
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

		// Token: 0x06000056 RID: 86 RVA: 0x00008A8C File Offset: 0x00006C8C
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

		// Token: 0x06000057 RID: 87 RVA: 0x00008B08 File Offset: 0x00006D08
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

		// Token: 0x06000058 RID: 88 RVA: 0x00008B84 File Offset: 0x00006D84
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

		// Token: 0x06000059 RID: 89 RVA: 0x00008C00 File Offset: 0x00006E00
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
