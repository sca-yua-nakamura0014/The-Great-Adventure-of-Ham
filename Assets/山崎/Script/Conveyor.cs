using System.Collections.Generic;
using UnityEngine;

namespace ConveyorSamples
{
    public class Conveyor : MonoBehaviour
    {

        // ベルトコンベアの判定動いているか
        public bool IsOn = false;


        // ベルトコンベアの設定速度
        public float TargetDriveSpeed = 3.0f;

        // 現在のベルトコンベアの速度
        public float CurrentSpeed { get { return _currentSpeed; } }

        // ベルトコンベアが物体を動かす方向
        public Vector3 DriveDirection = Vector3.forward;

        // コンベアが物体を押す力（加速力）
        [SerializeField] private float _forcePower = 50f;

        private float _currentSpeed = 0;
        private List<Rigidbody> _rigidbodies = new List<Rigidbody>();

        void Start()
        {
            //方向は正規化しておくらしい
            DriveDirection = DriveDirection.normalized;
        }

        void FixedUpdate()
        {
            _currentSpeed = IsOn ? TargetDriveSpeed : 0;

            //消滅したオブジェクトは除去する
            _rigidbodies.RemoveAll(r => r == null);

            foreach (var r in _rigidbodies)
            {
                //物体の移動速度のベルトコンベア方向の成分だけを取り出す
                var objectSpeed = Vector3.Dot(r.velocity, DriveDirection);

                //目標値以下なら加速する
                if (objectSpeed < Mathf.Abs(TargetDriveSpeed))
                {
                    r.AddForce(DriveDirection * _forcePower, ForceMode.Acceleration);
                }
            }
        }

        void OnCollisionEnter(Collision collision)
        {
            var rigidBody = collision.gameObject.GetComponent<Rigidbody>();
            _rigidbodies.Add(rigidBody);
        }

        void OnCollisionExit(Collision collision)
        {
            var rigidBody = collision.gameObject.GetComponent<Rigidbody>();
            _rigidbodies.Remove(rigidBody);
        }
    }
}
