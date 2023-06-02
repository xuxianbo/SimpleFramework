using System.Collections;
using System.Collections.Generic;
using Core;
using Google.Protobuf;
using TMPro;
using UnityEngine;

public class test : MonoBehaviour
{
    // Start is called before the first frame update

    private TextMeshProUGUI _textMeshProUGUI;
    void Start()
    {
        _textMeshProUGUI = transform.GetComponent<TextMeshProUGUI>();
        
        RstUserInfo rstUserInfo = new RstUserInfo();
        rstUserInfo.Name = "xuxianbo";
        rstUserInfo.Gold = 5;
        rstUserInfo.Position = 12;
        byte[] tBytes = rstUserInfo.ToByteArray();

        // typeof()
        RstUserInfo temp = ProtobufHeler.FromBytes(typeof(RstUserInfo), tBytes, 0, tBytes.Length) as RstUserInfo;


        _textMeshProUGUI.text = temp.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
