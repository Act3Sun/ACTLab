
using System;
using UdonSharp;
using UnityEngine;
using UnityEngine.UI;
using VRC.SDKBase;
using VRC.Udon;
using VRC.Udon.Common.Interfaces;
using System.Diagnostics;

public class ReceivedCP : UdonSharpBehaviour
{
    public Text inputtxt ;
    public int[] rvVal = new int[1];
    VRCPlayerApi[] players = new VRCPlayerApi[20];

    void Start()
    {
        UnityEngine.Debug.Log("HelloWorld");
    }
    public void Update()
    {
        inputtxt.text = rvVal[0].ToString();   
    }
}
