namespace Services.ID
{
    public class IDService : IIDService
    {
        private long _value = 0;

        public long Get() => _value++;
    }
}
