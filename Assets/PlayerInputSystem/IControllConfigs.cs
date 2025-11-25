using UnityEngine;

namespace PlayerInputSystem
{
    public interface IControllConfigs
    {
        KeyCode LeftKey { get; }
        KeyCode RightKey { get; }
        KeyCode UpKey { get; }   
        KeyCode DownKey { get; }   
        KeyCode FirstIconKey { get; }   
        KeyCode SecondIconKey { get; }   
        KeyCode ThirtIconKey { get; }   
        KeyCode ForthIconKey { get; }   
    }
}