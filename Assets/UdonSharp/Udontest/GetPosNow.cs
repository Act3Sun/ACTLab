
using System;
using UdonSharp;
using UnityEngine;
using UnityEngine.UI;
using VRC.SDKBase;
using VRC.Udon;
using VRC.Udon.Common.Interfaces;
using System.Diagnostics;

public class GetPosNow : UdonSharpBehaviour
{
    public Text debugtxt;
    VRCPlayerApi[] players = new VRCPlayerApi[20];

    void Start()
    {
        UnityEngine.Debug.Log("HelloWorld");
    }
    private void Update()
    {
        var player = Networking.LocalPlayer;
        if (player != null)//Unityの再生ボタンで実行すると変数がnullになるらしいよ
        {
            //playerの位置を取得（位置は頭の位置を使用）
            var headData = player.GetTrackingData(VRCPlayerApi.TrackingDataType.Head);
            debugtxt.text = string.Format("Head-Pos: {0}\r\n", headData.position.ToString());
        }
    }
}
