using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;
using Core;
using Cysharp.Threading.Tasks;
using Google.Protobuf;
using Model;
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
        ViewAssetLoader loader = new ViewAssetLoader();

        new ConfigComponent(new ConfigComponentConfig(loader, "Model", typeof(ConfigComponent).Assembly));
        await ConfigComponent.Instance.Load();
        
        new LocalizeComponent(
            new LocalizeComponentConfig(
                loader,
                SystemLanguage.Chinese,
                SystemLanguage.English,
                null
            )
        );

        await LocalizeComponent.Instance.Load();

        // 单例表
        Debug.Log($"单例表: {GlobalConfigCategory.Single.default_icon}");

        // 多主键表
        var config = MultipleKeyConfigCategory.Instance.TryGet("First", 100, 200);
        Debug.Log($"多主键表: {config}");

        // ref 绑定
        var ref_config = ConfigComponent.Instance.Get<SingleRefConfig>(1);

        Debug.Log($"ref 绑定: {ref_config.ref_one_ref.id}");

        // 本地化使用
        var localize = LocalizeComponent.Instance.GetText("example/one");

        Debug.Log($"本地化: {localize}");

        await LocalizeComponent.Instance.SwitchLanguage(SystemLanguage.English);
        // 本地化使用
        localize = LocalizeComponent.Instance.GetText("example/one");

        Debug.Log($"本地化(语言切换为英语之后): {localize}");

        
        Debug.Log($"ref 绑定: {ref_config.ref_one_ref.id}");
        
        await AssetMgr.LoadSceneAsync(Updater.Instance.gameScene);
    }

    private async UniTask<JSONNode> loader(string fileName)
    {
        TextAsset textAsset =await AssetMgr.LoadAsync<TextAsset>(fileName);
        
        // string msg = AssetMgr.Load<TextAsset>(fileName).text;
            
        // AssetOperationHandle assetOperationHandle = mian.LoadAssetAsync(mian.GetAssetInfo("fileName"));
        // string  filePath = File.ReadAllText(Application.dataPath + "/Res/Config/json/" + fileName + ".json");
        return JSON.Parse( textAsset.text );
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
