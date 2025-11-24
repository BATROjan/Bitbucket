using UnityEngine;

namespace PlayerInputSystem
{
    public interface IControllConfigs
    {
        KeyCode LeftKey { get; }
        KeyCode RightKey { get; }
        KeyCode UpKey { get; }   
        KeyCode DownKey { get; }   
    }
}