
using System.Numerics;
using UdonSharp;
using UnityEngine;
using VRC.SDKBase;
using VRC.Udon;
using Vector3 = UnityEngine.Vector3;//これやらないとVector3でエラーになる

public class ObjectRoll : UdonSharpBehaviour
{
    public int x=0;
    public int y=0;
    public int z=0;
    void Start(){}
    private void Update()
    {
        //this.gameObject.transform.Rotate(x,y,z);
        this.gameObject.transform.Rotate(Vector3.up,y * Time.deltaTime);
    }
}
