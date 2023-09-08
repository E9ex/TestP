using System;
using Runtime.data.Valueobject;
using Runtime.Keys;
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
        [SerializeField] private static playermovementdata data;

        private void Awake()
        {
            getreference();
        }

        private void getreference()
        {
            _rigidbody = GetComponent<Rigidbody>();
        }

        internal void onInputtaken(InputParams ınputparams)
        {
            _inputvalues = ınputparams.InputValues;
        }
        private void FixedUpdate()
        {
            MovePlayer();
        }
        private void MovePlayer()
        {
            _rigidbody.velocity += new Vector3(_inputvalues.x, 0, _inputvalues.y) * (data.speed * Time.fixedDeltaTime);
        }

        public static void setmovementdata(playermovementdata playermovementdata)
        {
            data = playermovementdata;
        }
    }
}