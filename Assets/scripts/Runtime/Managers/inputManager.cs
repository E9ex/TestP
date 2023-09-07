using Runtime.signals;
using Unity.Mathematics;
using UnityEngine;

namespace Runtime.Managers
{
    public class inputManager: MonoBehaviour
    {
        private float2 _inputvalues;
        void Update()
        {
            getInputValues();
            if (!Input.anyKey) return;
                SendInput();
        }

        private void SendInput()
        {
            inputsignals.instance.Oninputtaken?.Invoke(_inputvalues);
        }

        private void getInputValues()
        {
            _inputvalues = new float2(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical"));
        }
    }
}