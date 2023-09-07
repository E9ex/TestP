using System;
using Unity.Mathematics;
using UnityEngine;
using UnityEngine.Events;

namespace Runtime.signals
{
    public class inputsignals : MonoBehaviour
    {
        #region singelton

        public static inputsignals instance;

        private void Awake()
        {
            if (instance!=null && instance!=this)
            {
                Destroy(gameObject);
            }

            instance = this;
        }

        #endregion
        
        public UnityAction<float2> Oninputtaken=delegate {  };
    }
}