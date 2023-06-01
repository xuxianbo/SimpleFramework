using System;
using UnityEngine;

namespace Core
{
    public static partial class ConstMgr
    {
        public const float Bytes2Mb = 1f / (1024 * 1024);

        public static byte[] NullBytes => Array.Empty<byte>();
        public static object[] NullObjects => Array.Empty<object>();

        public static WaitForSecondsRealtime WaitFor1Sec = new WaitForSecondsRealtime(0.001f);
    }
}