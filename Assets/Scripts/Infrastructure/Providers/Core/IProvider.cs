﻿namespace Infrastructure.Providers.Core
{
    public interface IProvider<out T>
    {
        public T Get();
    }
}