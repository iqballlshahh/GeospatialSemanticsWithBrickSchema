using UnityEngine;
using UnityEditor;
using System.Diagnostics;
using System.Threading.Tasks;

public class RunRDFVisualizer : MonoBehaviour
{
    [MenuItem("Tools/Geospatial Semantics/Simple RDF Visualizer")]
    public static async void RunRDFVisualizerScript()
    {
        string exePath = Application.dataPath + "/SimpleRDFViewer.exe";

        if (System.IO.File.Exists(exePath))
        {
            ProcessStartInfo startInfo = new ProcessStartInfo();
            startInfo.FileName = exePath;
            startInfo.WindowStyle = ProcessWindowStyle.Hidden;
            startInfo.UseShellExecute = false; // Required to redirect output
            startInfo.RedirectStandardOutput = true; // Redirect output so we can read it
            Process process = new Process();
            process.StartInfo = startInfo;

            UnityEngine.Debug.Log("Starting RDF Visualizer...");
            process.Start();

            await Task.Run(() => process.WaitForExit());

            // After the process exits, read the output:
            string output = process.StandardOutput.ReadToEnd();
            UnityEngine.Debug.Log($"RDF Visualizer Finished. Output: {output}");
        }
        else
        {
            UnityEngine.Debug.LogError("Executable file not found: " + exePath);
        }
    }
}
