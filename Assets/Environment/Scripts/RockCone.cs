using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace MAY
{
    /// <summary>
    /// 控制尖刺消失
    /// </summary>
    public class RockCone : MonoBehaviour
    {
        [Header("清除時間")]
        [SerializeField] float destoryTime = 1f;
        private void OnEnable()
        {
            Destroy(this, destoryTime);
        }


       
    }


}