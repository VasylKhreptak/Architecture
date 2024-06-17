using System;

namespace Infrastructure.SceneTransition.Core
{
    public interface ITransitionScreen
    {
        public void Show(Action onComplete = null);

        public void Hide(Action onComplete = null);

        public void ShowImmediately();

        public void HideImmediately();
    }
}