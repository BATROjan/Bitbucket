using UnityEngine;

namespace GameZone.Scripts
{
    [CreateAssetMenu (fileName = "GameZoneConfig", menuName = "configs")]
    
    public class GameZoneConfig : ScriptableObject, IGameZoneSetting
    {
       [field: SerializeField] public int VerticalCount { get; set; }
       [field: SerializeField] public int HorizontalCount { get; set; }
    }
}