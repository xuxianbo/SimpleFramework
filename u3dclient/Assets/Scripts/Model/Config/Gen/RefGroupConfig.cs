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
    public partial class RefGroupConfig :  AConfig 
    {
    	/// <summary>
    	/// 引用一个 ID
    	/// </summary>
        [JsonProperty("ref_id")]
        private int _ref_id { get; set; }

        [JsonIgnore]
        public int ref_id { get; private set; } = new();
    	/// <summary>
    	/// 引用一组 ID
    	/// </summary>
        [JsonProperty("ref_ids")]
        private System.Collections.Generic.List<int> _ref_ids { get; set; }
      
        [JsonIgnore]
        private IReadOnlyList<int> __ref_ids;

        [JsonIgnore]
        public IReadOnlyList<int> ref_ids => __ref_ids ??= _ref_ids.AsReadOnly();
    	/// <summary>
    	/// 引用 4 个 ID，允许为 0
    	/// </summary>
        [JsonProperty("ref_zero_ids")]
        private System.Collections.Generic.List<int> _ref_zero_ids { get; set; }
      
        [JsonIgnore]
        private IReadOnlyList<int> __ref_zero_ids;

        [JsonIgnore]
        public IReadOnlyList<int> ref_zero_ids => __ref_zero_ids ??= _ref_zero_ids.AsReadOnly();

        public override void EndInit() 
        {
            ref_id = _ref_id;
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
