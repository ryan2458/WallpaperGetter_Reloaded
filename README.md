# WallpaperGetter_Reloaded
You know those wallpapers that appear out of nowhere on your lockscreen on Windows 10?  Whelp, turns out those are stored locally on your machine, but they're stored in
a directory with a bunch of other garbage that I don't really care about.  This program copies only the files that are wallpapers.

I didn't add any kind of UI for this program to allow for you to decide where the wallpapers get saved, so running it once creates 
a directory called "WallpapersGetterDirectory" in your Documents folder.

If you want to have this program run on startup:
1. Build the program
2. Press windows-key+r and run "shell:startup". This should take you to the current user's startup directory.
3. Copy the debug .exe that you build in Visual Studio to the startup directory you just opened

Note: Don't copy a release .exe here, otherwise Windows Defender will flag it as a trojan.  This probably occurs since I'm doing File IO and I guess
Windows Defender doesn't like that.  I promise this isn't a trojan, I just didn't want to spend time working with certificates and signatures for such a small application that
would probably be better as a script, but oh well, I did it in C#.

If this program isn't working for you, please let me know by creating a new issue!
