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
using UnityEngine;
using System.Linq;




namespace Model
{
    [Config]
    public partial class ShapeConfigCategory : ACategory<ShapeConfig>
    {
        public static ShapeConfigCategory Instance { get; private set; }

        public ShapeConfigCategory()
        {
            Instance = this;
        }

        public override void TranslateText()
        {
            foreach(var v in dict.Values)
            {
                v.TranslateText();
            }
        }

    }
}
