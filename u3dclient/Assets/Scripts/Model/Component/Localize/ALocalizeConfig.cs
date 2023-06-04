using System;

namespace Model
{
    [Serializable]
    public abstract class ALocalizeConfig
    {
        public string key;

        public abstract string value { get; }
    }
}