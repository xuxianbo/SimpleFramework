//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
using System;
using Newtonsoft.Json;
using System.Collections.Generic;
//using Encrypt;








namespace Model
{
    [Serializable]
    public partial class Triangle :  AShape 
    {
        [JsonProperty("a")]
        private float _a { get; set; }

        [JsonIgnore]
        public float a { get; private set; } = new();
        [JsonProperty("b")]
        private float _b { get; set; }

        [JsonIgnore]
        public float b { get; private set; } = new();
        [JsonProperty("c")]
        private float _c { get; set; }

        [JsonIgnore]
        public float c { get; private set; } = new();

        public override void EndInit() 
        {
            a = _a;
            b = _b;
            c = _c;
            base.EndInit();
        }

        public override void TranslateText()
        {
            base.TranslateText();
        }

        public override void BindRef() 
        {
        }

        public override string ToString() => JsonConvert.SerializeObject(this);
    }
}
