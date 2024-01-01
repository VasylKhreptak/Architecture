using System;

namespace Infrastructure.Curtain.Core
{
    public interface ILoadingScreen
    {
        public void Show();

        public void Hide(Action onComplete = null);
    }
}