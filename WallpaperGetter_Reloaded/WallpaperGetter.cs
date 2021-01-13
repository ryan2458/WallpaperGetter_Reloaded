using System;
using System.IO;

namespace WallpaperGetter_Reloaded
{
	public class WallpaperGetter
	{
		private DriveInfo[] di;

		private string dest;

		public WallpaperGetter()
		{
			di = DriveInfo.GetDrives();
		}

		public void Setup()
		{  
			Console.WriteLine(di[0]);
			dest = di[0] + "Users\\" + Environment.UserName + "\\Documents\\WallpapersGetterDirectory";
			Directory.CreateDirectory(dest);
		}

		public void GetWallpapers()
		{
			string wpLocation = di[0] + "Users\\" + Environment.UserName +
				"\\AppData\\Local\\Packages\\Microsoft.Windows.ContentDeliveryManager_cw5n1h2txyewy\\LocalState\\Assets";

			var jpeg = new byte[] { 255, 216, 255, 224 };
			string[] files = Directory.GetFiles(wpLocation);
			for(int i = 0; i < files.Length; ++i)
			{
				bool isJpeg = false;
				byte[] header = new byte[4];
				using (BinaryReader br = new BinaryReader(new FileStream(files[i], FileMode.Open)))
				{
					br.Read(header, 0, 4);
				}

				for(int j = 0; j < jpeg.Length; ++j)
				{
					if(header[j] != jpeg[j])
					{
						isJpeg = false;
						break;
					}
					else
					{
						isJpeg = true;
					}
				}

				if(isJpeg)
				{
					try
					{
						string[] name = files[i].Split('\\');
						File.Copy(files[i], dest + "\\" + name[name.Length - 1] + ".jpeg");
					}
					catch (IOException ioe)
					{
						// do nothing
					}
				}
			}


		}
	}
}
