using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace MAY
{
    /// <summary>
    /// 角色控制腳本
    /// </summary>
    public class PlayerCtrl : MonoBehaviour
    {
        [SerializeField] float moveSpeed = 10.0f; // 移動速度
        [SerializeField] float jumpForce = 5.0f; // 跳躍力量
        private Rigidbody rb;

        void Start()
        {
            rb = GetComponent<Rigidbody>();
        }

        void Update()
        {
            
            float horizontalInput = Input.GetAxis("Horizontal");

        //移動
            Vector3 movement = new Vector3(0.0f, 0.0f, horizontalInput) * moveSpeed * Time.deltaTime;

            // 使用Rigidbody移動角色
            rb.MovePosition(transform.position + movement);

            // 空白鍵跳躍
            if (Input.GetKeyDown(KeyCode.Space))
            {
                // 用addForce
                rb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
            }
        }
    }

}