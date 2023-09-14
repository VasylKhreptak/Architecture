using System.ComponentModel;
using JetBrains.Annotations;

namespace DebuggerOptions
{
    public class SROptionsContainer
    {
        [Category("Main Category"), UsedImplicitly]
        public void PrintMessageToConsole() => UnityEngine.Debug.Log("SROptions work's perfectly!");
    }
}
