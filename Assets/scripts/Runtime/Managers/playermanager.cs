using System;
using Runtime.Controllers;
using Runtime.signals;
using UnityEngine;

namespace Runtime.Managers
{
    public class playermanager : MonoBehaviour
    {
        [SerializeField] private playermovementcontroller movementcontroller;

        private void OnEnable()
        {
            subscribeEvent();
        }

        void subscribeEvent()
        {
            inputsignals.instance.Oninputtaken += movementcontroller.onInputtaken;
        }

        void unsubscribeevent()
        {
            inputsignals.instance.Oninputtaken -= movementcontroller.onInputtaken;
        }

        private void OnDisable()
        {
            unsubscribeevent();
        }
    }
}