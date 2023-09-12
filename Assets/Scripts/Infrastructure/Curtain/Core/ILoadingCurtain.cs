using System;

namespace Infrastructure.Curtain.Core
{
    public interface ILoadingCurtain
    {
        public event Action OnHidden;

        public void Show();

        public void Hide();
    }
}
