
using System;
using TMPro.Examples;
using UdonSharp;
using UnityEngine;
using UnityEngine.UI;
using VRC.SDKBase;
using VRC.Udon;

public class SendCP : UdonSharpBehaviour
{
    [SerializeField] 
    private ReceivedCP _rvCP;
    private int[] _rvCP_rvVal = null;

    void Start()
    {
        _rvCP_rvVal = _rvCP.rvVal;
    }
    public override void Interact()
    {
        int inc = _rvCP_rvVal[0];
        _rvCP_rvVal[0] = inc + 1; 
    }
}
