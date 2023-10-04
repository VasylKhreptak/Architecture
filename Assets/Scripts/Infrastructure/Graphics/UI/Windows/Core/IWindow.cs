namespace Infrastructure.Graphics.UI.Windows.Core
{
    public interface IWindow
    {
        public bool Enabled { get; }

        public void Show();

        public void Hide();
    }
}
