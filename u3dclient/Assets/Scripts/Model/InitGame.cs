using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;
using cfg;
using cfg.item;
using Core;
using SimpleJSON;
using UnityEngine;
using UnityEngine.Serialization;
using YooAsset;


public class InitGame : MonoBehaviour
{
    /// <summary>
    /// 播放类型
    /// </summary>
    // public YooAssets.EPlayMode ePlayMode = YooAssets.EPlayMode.;
    //是否允许debug（会产生log）
    [Tooltip("是否允许debug，勾选后产生log")] [FormerlySerializedAs("Debug")] [SerializeField]
    public bool debug = true;

    //单例
    public static InitGame Instance;

    
    /// <summary>
    /// 初始化
    /// </summary>
    private void Awake()
    {
        //单例
        if (Instance != null)
        {
            Destroy(Instance.gameObject);
        }

        Instance = this;
        DontDestroyOnLoad(gameObject);
    }
    
    // Start is called before the first frame update
    private ResourcePackage mian;
    void Start()
    {
        Updater.Instance.StartUpdate();
    }

    /// <summary>
    /// 加载热更
    /// </summary>
    public async Task LoadHotUpdateCallback()
    {
        Log.Print("=================热更流程走完=============");
        // 各种初始化
        
        Tables tables = new Tables(loader);
        Item item = tables.TbItem.Get(10010);
        Debug.Log($"{item.Name}  {item.Desc}");
        
        await AssetMgr.LoadSceneAsync(Updater.Instance.gameScene);
    }

    private JSONNode loader(string fileName)
    {
        string msg = AssetMgr.Load<TextAsset>(fileName).text;
            
        // AssetOperationHandle assetOperationHandle = mian.LoadAssetAsync(mian.GetAssetInfo("fileName"));
        // string  filePath = File.ReadAllText(Application.dataPath + "/Res/Config/json/" + fileName + ".json");
        return JSON.Parse( msg );
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
