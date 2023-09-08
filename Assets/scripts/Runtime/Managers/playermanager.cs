using System;
using Runtime.Controllers;
using Runtime.data.UnityObjects;
using Runtime.data.Valueobject;
using Runtime.signals;
using UnityEngine;

namespace Runtime.Managers
{
    public class playermanager : MonoBehaviour
    {
        [SerializeField] private playermovementcontroller movementcontroller;
        public static playerdata _playerdata;

        private void Awake()
        {
            getplayerdata();
            sendDataToControllers();
            
        }

        private  void getplayerdata()
        {
            _playerdata= Resources.Load<CD_PLAYER>("Data/CD_Player").data;
        }

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

        

        private static void sendDataToControllers()
        {
            playermovementcontroller.setmovementdata(_playerdata.movementdata);
        }
    }
}