using System;
using Runtime.Keys;
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
        
        public UnityAction<InputParams> Oninputtaken=delegate {  };
    }
}