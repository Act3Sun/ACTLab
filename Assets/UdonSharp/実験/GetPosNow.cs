
using UdonSharp;
using UnityEngine;
using VRC.SDKBase;
using VRC.Udon;
using UnityEngine.UI;

public class GetPosNow : UdonSharpBehaviour
{
    public Text debugtxt;
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
