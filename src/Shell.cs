using System;
using System.IO;
using System.Reflection;
using System.Diagnostics;
using System.Windows.Forms;

public class Shell
{

    private static string CygPath()
    {
        var uri = new Uri(Assembly.GetExecutingAssembly().CodeBase);
        return Path.GetDirectoryName(Uri.UnescapeDataString(
            uri.AbsolutePath.Replace('/', Path.DirectorySeparatorChar)
        ));
    }

    public static int Main(string[] args)
    {
        var proc = new Process();
        proc.StartInfo.FileName = CygPath() + "\\bin\\mintty.exe";
        proc.StartInfo.Arguments = "-";
        proc.StartInfo.UseShellExecute = false;
        
        try
        {
            proc.Start();
            proc.WaitForExit();
            return proc.ExitCode;
        }
        catch (SystemException e) 
        {
            MessageBox.Show(e.Message + e.StackTrace, proc.StartInfo.FileName, MessageBoxButtons.OK);
            return 255;
        } 
        finally
        {
            proc.Close();
        }
    }
}