using System;
using Zenject;

namespace DebuggerOptions.Core
{
    public class BaseOptions : IInitializable, IDisposable
    {
        private bool _initialized;
        private bool _disposed;

        public void Initialize()
        {
            if (_initialized)
                return;

            SRDebug.Instance.AddOptionContainer(this);

            _initialized = true;
            _disposed = false;
        }

        public void Dispose()
        {
            if (_disposed)
                return;

            SRDebug.Instance?.RemoveOptionContainer(this);

            _initialized = false;
        }
    }
}