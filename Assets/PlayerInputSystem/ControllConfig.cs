using UnityEngine;

namespace PlayerInputSystem
{
    [CreateAssetMenu(fileName = "ControllConfig", menuName = "configs/ControllConfig")]

    public class ControllConfig : ScriptableObject, IControllConfigs
    {
       [field: SerializeField] public KeyCode LeftKey { get; set; }
       [field: SerializeField] public KeyCode RightKey { get; set; }
       [field: SerializeField] public KeyCode UpKey { get; set; }
       [field: SerializeField] public KeyCode DownKey { get; set; }
    }
}