using UnityEngine;
using UnityEditor;
using System.Diagnostics;

public class RunPythonScriptMenu : MonoBehaviour
{
    [MenuItem("Tools/Geospatial Semantics/BrickSchema-Automate Generate")]
    public static void RunPythonScript()
    {
        string pythonExecutablePath = Application.dataPath + "/BrickCSVtoPyGenerate.exe"; 

        if (!System.IO.File.Exists(pythonExecutablePath))
        {
            UnityEngine.Debug.LogError("Python executable not found at path: " + pythonExecutablePath);
            return;
        }

        Process process = new Process();
        process.StartInfo.FileName = pythonExecutablePath;
        process.StartInfo.UseShellExecute = false;
        process.StartInfo.RedirectStandardOutput = true;
        process.StartInfo.RedirectStandardError = true;
        process.Start();

        string output = process.StandardOutput.ReadToEnd();
        string error = process.StandardError.ReadToEnd();

        process.WaitForExit();

        if (process.ExitCode == 0)
        {
            UnityEngine.Debug.Log("Python script executed successfully:\n" + output);
        }
        else
        {
            UnityEngine.Debug.LogError("Error executing Python script:\n" + error);
        }
    }
}
