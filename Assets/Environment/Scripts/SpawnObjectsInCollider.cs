using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

namespace MAY
{
    /// <summary>
    /// 下落的尖刺
    /// </summary>

    public class SpawnObjectsInCollider : MonoBehaviour
    {
        [Header("生成的物件")]
        [SerializeField] GameObject spawnObject = null;
        [Header("生成範圍")]
        [SerializeField] BoxCollider boxCollider = null;

        void Awake()
        {
            if (boxCollider == null || spawnObject == null)
            {
                boxCollider = this.gameObject.GetComponent<BoxCollider>();
            }

            //生成
            InvokeRepeating("SawapObject", 1f, 1f);

        }

        private void Update()
        {
            
        }

        /// <summary>
        /// 生成下落物件
        /// </summary>
        void SawapObject() {

            Vector3 min = boxCollider.bounds.min;
            Vector3 max = boxCollider.bounds.max;

            //隨機位置
            float randomX = Random.Range(min.x, max.x);
            float randomY = Random.Range(min.y, max.y);
            float randomZ = Random.Range(min.z, max.z);

            Vector3 spawnPos= new Vector3(randomX, randomY, randomZ);

            Instantiate(spawnObject, spawnPos, spawnObject.transform.rotation);

        }

    }



}