using UnityEngine;
using VContainer.Unity;

namespace PlayerInputSystem
{
    public class KeyboardInputSystem: IInputSystem
    {
        public float HorizontalDirection => GetHorDirection();
        public float VerticalDirection => GetVerDirection();
        
        private readonly IControllConfigs _controlsConfigses;
        
        public KeyboardInputSystem(
            IControllConfigs controllConfigs)
        {
            _controlsConfigses = controllConfigs;
        }
        private float GetHorDirection()
        {
            return Input.anyKey switch
            {
                true when Input.GetKey(_controlsConfigses.RightKey) => 1f,
                true when Input.GetKey(_controlsConfigses.LeftKey) => -1f,
                _ => 0f
            };
        }
        private float GetVerDirection()
        {
            return Input.anyKey switch
            {
                true when Input.GetKey(_controlsConfigses.UpKey) => 1f,
                true when Input.GetKey(_controlsConfigses.DownKey) => -1f,
                _ => 0f
            };
        }
    }
}