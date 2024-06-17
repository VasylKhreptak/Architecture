using UnityEngine;
using Zenject;

namespace Infrastructure.Tools
{
    public static class InstallerHelper
    {
        public static TOut SelectImplementation<TOut, TAndroid, TIOS, TDefault>(DiContainer container)
            where TAndroid : TOut
            where TIOS : TOut
            where TDefault : TOut
        {
            TOut implementation;

            if (Application.platform == RuntimePlatform.Android)
                implementation = container.Resolve<TAndroid>();
            else if (Application.platform == RuntimePlatform.IPhonePlayer)
                implementation = container.Resolve<TIOS>();
            else
                implementation = container.Resolve<TDefault>();

            return implementation;
        }
    }
}