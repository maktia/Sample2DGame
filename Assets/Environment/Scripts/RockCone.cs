using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace MAY
{
    /// <summary>
    /// ����y�����
    /// </summary>
    public class RockCone : MonoBehaviour
    {
        [Header("�M���ɶ�")]
        [SerializeField] float destoryTime = 1f;
        private void OnEnable()
        {
            Destroy(this, destoryTime);
        }


       
    }


}