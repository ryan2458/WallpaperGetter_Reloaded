namespace WallpaperGetter_Reloaded
{
	class Program
	{
		static void Main(string[] args)
		{
			WallpaperGetter wg = new WallpaperGetter();
			wg.Setup();
			wg.GetWallpapers();
		}
	}
}
