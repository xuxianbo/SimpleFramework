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
    public partial class GroupConfig :  AConfig 
    {
    	/// <summary>
    	/// 客户端使用
    	/// </summary>
        [JsonProperty]
        public string  client_name { get; private set; }

        public override void EndInit() 
        {
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
