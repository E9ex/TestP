using System;
using Runtime.Managers;
using Unity.Mathematics;
using UnityEngine;

namespace Runtime.Controllers
{
    public class playermovementcontroller : MonoBehaviour
    {
        private float2 _inputvalues;
        [SerializeField] private playermanager manager;
        private Rigidbody _rigidbody;
        [SerializeField] private float speed;

        private void Awake()
        {
            getreference();
        }

        private void getreference()
        {
            _rigidbody = GetComponent<Rigidbody>();
        }

        internal void onInputtaken(float2 ınputparams)
        {
            _inputvalues = ınputparams;
        }
        private void FixedUpdate()
        {
            MovePlayer();
        }
        private void MovePlayer()
        {
            _rigidbody.velocity += new Vector3(_inputvalues.x, 0, _inputvalues.y) * (speed * Time.fixedDeltaTime);
        }
    }
}