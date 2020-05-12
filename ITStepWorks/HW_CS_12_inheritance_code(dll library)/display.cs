using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using WinApi_DeviceCap_enum;

namespace HW_CS_12_inheritance_code_dll_library_ {
    public partial class WinApi {

		#region structs, constant and enums

		[Flags()]
		public enum ChangeDisplaySettingsFlags : uint {
			CDS_NONE = 0,
			CDS_UPDATEREGISTRY = 0x00000001,
			CDS_TEST = 0x00000002,
			CDS_FULLSCREEN = 0x00000004,
			CDS_GLOBAL = 0x00000008,
			CDS_SET_PRIMARY = 0x00000010,
			CDS_VIDEOPARAMETERS = 0x00000020,
			CDS_ENABLE_UNSAFE_MODES = 0x00000100,
			CDS_DISABLE_UNSAFE_MODES = 0x00000200,
			CDS_RESET = 0x40000000,
			CDS_RESET_EX = 0x20000000,
			CDS_NORESET = 0x10000000
		}
		const int ENUM_CURRENT_SETTINGS = -1;
		const int ENUM_REGISTRY_SETTINGS = -2;
		[StructLayout(LayoutKind.Sequential)]
		public struct DEVMODE {
			private const int CCHDEVICENAME = 0x20;
			private const int CCHFORMNAME = 0x20;
			[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 0x20)]
			public string dmDeviceName;
			public short dmSpecVersion;
			public short dmDriverVersion;
			public short dmSize;
			public short dmDriverExtra;
			public int dmFields;
			public int dmPositionX;
			public int dmPositionY;
			public int dmDisplayOrientation;
			public int dmDisplayFixedOutput;
			public short dmColor;
			public short dmDuplex;
			public short dmYResolution;
			public short dmTTOption;
			public short dmCollate;
			[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 0x20)]
			public string dmFormName;
			public short dmLogPixels;
			public int dmBitsPerPel;
			public int dmPelsWidth;
			public int dmPelsHeight;
			public int dmDisplayFlags;
			public int dmDisplayFrequency;
			public int dmICMMethod;
			public int dmICMIntent;
			public int dmMediaType;
			public int dmDitherType;
			public int dmReserved1;
			public int dmReserved2;
			public int dmPanningWidth;
			public int dmPanningHeight;
		}

		public struct DisplayInfo {
			public int drvVersion;
			public int wSize;
			public int hSize;
			public double diagonal { get => Math.Sqrt((wSize * wSize) + (hSize * hSize)); }
		}
		#endregion

		#region dll imports
		[DllImport("gdi32.dll")]
		static extern int GetDeviceCaps(IntPtr hdc, int nIndex);

		[DllImport("user32.dll")]
		public static extern bool EnumDisplaySettings(string lpszDeviceName, int iModeNum, ref DEVMODE lpDevMode);

		[DllImport("user32.dll")]
		public static extern int ChangeDisplaySettings(ref DEVMODE lpDevMode, ChangeDisplaySettingsFlags dwFlags);

		#endregion



		#region methods
		public static DisplayInfo GetDisplayInfo(Graphics dev) {
			DisplayInfo di = new DisplayInfo();
			IntPtr hdc = dev.GetHdc();
			di.drvVersion = GetDeviceCaps(hdc, (int)DeviceCap.DRIVERVERSION);
			di.wSize = GetDeviceCaps(hdc, (int)DeviceCap.HORZSIZE);
			di.hSize = GetDeviceCaps(hdc, (int)DeviceCap.VERTSIZE);
			dev.ReleaseHdc();
			return di;
		}

		private static bool GetDisplayResolution(int w, int h, ref DEVMODE vDevMode) {
			int i = 0;
			while (EnumDisplaySettings(null, i, ref vDevMode)) {
				if(vDevMode.dmPelsWidth == w && vDevMode.dmPelsHeight == h) {
					return true;
				}
				i++;
			}
			return false;
		}

		public static bool ChangeResolution(int w, int h) {
			DEVMODE vDevMode = new DEVMODE();
			if(GetDisplayResolution(w,h,ref vDevMode)) {
				if (ChangeDisplaySettings(ref vDevMode, ChangeDisplaySettingsFlags.CDS_UPDATEREGISTRY) != 0)
					return true;
				else return false;
			} else {
				Console.WriteLine("This resolution is not apply");
				return false;
			}
		}



		#endregion

		//[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Auto)]
		//public struct RectStruct {
		//	public Int32 left;
		//	public Int32 top;
		//	public Int32 right;
		//	public Int32 bottom;
		//}

		//[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Auto)]
		//internal struct MonitorInfoEx {
		//	public uint cbSize;
		//	public RectStruct rcMonitor;
		//	public RectStruct rcWork;
		//	public int dwFlags;
		//};

		//[DllImport("user32.dll", CharSet = CharSet.Auto)]
		//static extern bool GetMonitorInfoW(IntPtr hMonitor, ref MonitorInfoEx lpmi);



		//[DllImport("user32.dll", CharSet = CharSet.Auto)]
		//static extern bool EnumDisplayMonitors(IntPtr hdc, IntPtr lprcClip, MonitorEnumProcDelegate lpfnEnum,  IntPtr dwData);
		//public delegate bool MonitorEnumProcDelegate(IntPtr hMonitor, IntPtr hdcMonitor, ref RectStruct lprcMonitor, IntPtr dwData);
		//public struct DisplayInfo {
		//	public string Availability { get; set; }
		//	public string ScreenHeight { get; set; }
		//	public string ScreenWidth { get; set; }
		//	public RectStruct MonitorArea { get; set; }
		//	public RectStruct WorkArea { get; set; }
		//	public 
		//}

		//public class DisplayInfoCollection : List<DisplayInfo> {}

		//public DisplayInfoCollection GetDisplays() {
		//	DisplayInfoCollection col = new DisplayInfoCollection();

		//	EnumDisplayMonitors(IntPtr.Zero, IntPtr.Zero, delegate (IntPtr hMonitor, IntPtr hdcMonitor, ref RectStruct lprcMonitor, IntPtr dwData) {
		//			MonitorInfoEx mi = new MonitorInfoEx();
		//			mi.cbSize = (uint)Marshal.SizeOf(mi);
		//			bool success = GetMonitorInfoW(hMonitor, ref mi);
		//			if (success) {
		//				DisplayInfo di = new DisplayInfo();
		//				di.ScreenWidth = (mi.rcMonitor.right - mi.rcMonitor.left).ToString();
		//				di.ScreenHeight = (mi.rcMonitor.bottom - mi.rcMonitor.top).ToString();
		//				di.MonitorArea = mi.rcMonitor;
		//				di.WorkArea = mi.rcWork;
		//				di.Availability = mi.dwFlags.ToString();
		//				col.Add(di);
		//			}
		//			return true;
		//		}, IntPtr.Zero);
		//	return col;
		//}
	}
}
