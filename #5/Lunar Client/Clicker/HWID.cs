using System;
using System.Management;

namespace Clicker
{
	// Token: 0x0200000A RID: 10
	internal class HWID
	{
		// Token: 0x06000054 RID: 84 RVA: 0x00004B98 File Offset: 0x00002D98
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

		// Token: 0x06000055 RID: 85 RVA: 0x00004C14 File Offset: 0x00002E14
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

		// Token: 0x06000056 RID: 86 RVA: 0x00004C90 File Offset: 0x00002E90
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

		// Token: 0x06000057 RID: 87 RVA: 0x00004D0C File Offset: 0x00002F0C
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

		// Token: 0x06000058 RID: 88 RVA: 0x00004D88 File Offset: 0x00002F88
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

		// Token: 0x06000059 RID: 89 RVA: 0x00004E04 File Offset: 0x00003004
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

		// Token: 0x0600005A RID: 90 RVA: 0x00004E80 File Offset: 0x00003080
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
