using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

namespace MAY
{
    /// <summary>
    /// �U�����y��
    /// </summary>

    public class SpawnObjectsInCollider : MonoBehaviour
    {
        [Header("�ͦ�������")]
        [SerializeField] GameObject spawnObject = null;
        [Header("�ͦ��d��")]
        [SerializeField] BoxCollider boxCollider = null;

        void Awake()
        {
            if (boxCollider == null || spawnObject == null)
            {
                boxCollider = this.gameObject.GetComponent<BoxCollider>();
            }

            //�ͦ�
            InvokeRepeating("SawapObject", 1f, 1f);

        }

        private void Update()
        {
            
        }

        /// <summary>
        /// �ͦ��U������
        /// </summary>
        void SawapObject() {

            Vector3 min = boxCollider.bounds.min;
            Vector3 max = boxCollider.bounds.max;

            //�H����m
            float randomX = Random.Range(min.x, max.x);
            float randomY = Random.Range(min.y, max.y);
            float randomZ = Random.Range(min.z, max.z);

            Vector3 spawnPos= new Vector3(randomX, randomY, randomZ);

            Instantiate(spawnObject, spawnPos, spawnObject.transform.rotation);

        }

    }



}