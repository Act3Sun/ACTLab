
using UdonSharp;
using UnityEngine;
using VRC.SDKBase;
using VRC.Udon;
using VRC.SDK3.Components;
using UnityEngine.UI;

namespace UdonSharp.Examples.Utilities
{
    [UdonBehaviourSyncMode(BehaviourSyncMode.Manual)]
    public class SyncedObject : UdonSharpBehaviour
    {
        //同期変数 bHoge
        [UdonSynced] private bool bHoge;

        //ワールドの Directional Light オブジェクト
        [SerializeField] public GameObject WorldLigth;
        //public GameObject toggleObject;

        private bool localHoge = false;
        void Start()
        {
            //bHoge = WorldLigth.activeSelf;
        }
        
        /// <summary>
        /// 同期変数変更時のイベント
        /// </summary>
        public override void OnDeserialization()
        {
                if (localHoge != bHoge) 
                {
                    localHoge = bHoge;
                    
                    WorldLigth.SetActive(!WorldLigth.activeSelf);
                    // 同期変数が変化した場合のローカル処理。
                    Debug.Log("Call2");
                }
                //WorldLigth.SetActive(bHoge);
        }

        /// <summary>
        /// インタラクト処理(オブジェクトへのアクセス)
        /// </summary>
        public override void Interact()
        {
            if (!Networking.LocalPlayer.IsOwner(this.gameObject))
            {
                Networking.SetOwner(Networking.LocalPlayer, gameObject);
            }
            Debug.Log("Call1");
            //同期変数を更新;
            bHoge = !bHoge;
            RequestSerialization();
        }
    }

}

