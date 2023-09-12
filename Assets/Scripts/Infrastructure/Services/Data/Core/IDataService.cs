namespace Infrastructure.Services.Data.Core
{
    public interface IDataService
    {
        public void Save<T>(T data, string key);

        public T Load<T>(string key);

        public T Load<T>(string key, T defaultValue);

        public bool HasKey(string key);
    }
}
