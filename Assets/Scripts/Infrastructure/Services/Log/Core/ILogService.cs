using UnityEngine;

namespace Infrastructure.Services.Log.Core
{
    public interface ILogService
    {
        public void Log(object message, Object context);

        public void LogWarning(object message, Object context);

        public void LogError(object message, Object context);
    }
}