using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using cfg;
using cfg.item;
using SimpleJSON;
using UnityEngine;

public class InitGame : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Tables tables = new Tables(loader);
        Item item = tables.TbItem.Get(10010);
        Debug.Log($"{item.Name}  {item.Desc}");
    }

    private JSONNode loader(string fileName)
    {
        string  filePath = File.ReadAllText(Application.dataPath + "/Res/Config/json/" + fileName + ".json");
        return JSON.Parse(filePath);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
