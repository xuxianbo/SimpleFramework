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
    public partial class Circle :  AShape 
    {
        [JsonProperty("radius")]
        private float _radius { get; set; }

        [JsonIgnore]
        public float radius { get; private set; } = new();

        public override void EndInit() 
        {
            radius = _radius;
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
