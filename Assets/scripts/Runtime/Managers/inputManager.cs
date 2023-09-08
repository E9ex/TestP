using Runtime.Keys;
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
           _inputvalues= getInputValues();
            if (!Input.anyKey) return;
                SendInput();
        }

        private void SendInput()
        {
            inputsignals.instance.Oninputtaken?.Invoke(new InputParams()
            {
                InputValues = _inputvalues
            });
        }

        private float2 getInputValues()
        {
            return new float2(_inputvalues = new float2(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical")));
        }
    }
}