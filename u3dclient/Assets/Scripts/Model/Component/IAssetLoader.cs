using Cysharp.Threading.Tasks;
using UnityEngine;

namespace Model
{
    public interface IAssetLoader
    {
        UniTask<T> Load<T>(string name) where T : Object;
    }
}