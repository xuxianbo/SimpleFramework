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
    public partial class ShapeConfig :  AConfig 
    {
    	/// <summary>
    	/// 别名 形状定义
    	/// </summary>
        [JsonProperty]
        public AShape  alias_shape { get; private set; }
    	/// <summary>
    	/// 类名 形状定义
    	/// </summary>
        [JsonProperty]
        public AShape  name_shape { get; private set; }
    	/// <summary>
    	/// 定义在一个单元格内
    	/// </summary>
        [JsonProperty("in_one_shapes")]
        private System.Collections.Generic.List<AShape> _in_one_shapes { get; set; }
      
        [JsonIgnore]
        private IReadOnlyList<AShape> __in_one_shapes;

        [JsonIgnore]
        public IReadOnlyList<AShape> in_one_shapes => __in_one_shapes ??= _in_one_shapes.AsReadOnly();
    	/// <summary>
    	/// 多列展开
    	/// </summary>
        [JsonProperty("rows_shapes")]
        private System.Collections.Generic.List<AShape> _rows_shapes { get; set; }
      
        [JsonIgnore]
        private IReadOnlyList<AShape> __rows_shapes;

        [JsonIgnore]
        public IReadOnlyList<AShape> rows_shapes => __rows_shapes ??= _rows_shapes.AsReadOnly();
    	/// <summary>
    	/// 多列全展开
    	/// </summary>
        [JsonProperty("rows_sep_shapes")]
        private System.Collections.Generic.List<AShape> _rows_sep_shapes { get; set; }
      
        [JsonIgnore]
        private IReadOnlyList<AShape> __rows_sep_shapes;

        [JsonIgnore]
        public IReadOnlyList<AShape> rows_sep_shapes => __rows_sep_shapes ??= _rows_sep_shapes.AsReadOnly();
    	/// <summary>
    	/// 按列展开
    	/// </summary>
        [JsonProperty("colums_shapes")]
        private System.Collections.Generic.List<AShape> _colums_shapes { get; set; }
      
        [JsonIgnore]
        private IReadOnlyList<AShape> __colums_shapes;

        [JsonIgnore]
        public IReadOnlyList<AShape> colums_shapes => __colums_shapes ??= _colums_shapes.AsReadOnly();

        public override void EndInit() 
        {
            alias_shape?.EndInit();
            name_shape?.EndInit();
            foreach(var _e in in_one_shapes) { _e?.EndInit(); }
            foreach(var _e in rows_shapes) { _e?.EndInit(); }
            foreach(var _e in rows_sep_shapes) { _e?.EndInit(); }
            foreach(var _e in colums_shapes) { _e?.EndInit(); }
            base.EndInit();
        }

        public override void TranslateText()
        {
            alias_shape?.TranslateText();
            name_shape?.TranslateText();
            foreach(var _e in in_one_shapes) { _e?.TranslateText(); }
            foreach(var _e in rows_shapes) { _e?.TranslateText(); }
            foreach(var _e in rows_sep_shapes) { _e?.TranslateText(); }
            foreach(var _e in colums_shapes) { _e?.TranslateText(); }
            base.TranslateText();
        }

        public override void BindRef() 
        {
        }

        public override string ToString() => JsonConvert.SerializeObject(this);
    }
}
