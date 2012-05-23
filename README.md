Github for Windows: Cygwin shell wrapper 
========================================
This is a simple wrapper to be able to use a Cygwin shell inside the 
excellent [GitHub for Windows](http://windows.github.com/) GUI. 
Unfortunately, its setting dialog doesn't allow to pass command line
parameters to the command used in the "open shell here" option, so
this is what this tool does.

Compile and install
-------------------
To compile, use the C# compiler as follows:

```sh
$ csc /target:winexe Shell.cs
```

Put the `Shell.exe` into your Cygwin base folder, e.g. `F:\cygwin`.
Finally, point GitHub for Windows to a custom default shell and 
past the exe's location. Done!