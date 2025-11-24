using UnityEngine;

namespace GameZone.Scripts
{
    [CreateAssetMenu (fileName = "GameZoneConfig", menuName = "configs")]
    
    public class GameZoneConfig : ScriptableObject, IGameZoneConfig
    {
       [field: SerializeField] public int VerticalCount { get; set; }
       [field: SerializeField] public int HorizontalCount { get; set; }
       [field: SerializeField] public int offset { get; set;}
       [field: SerializeField] public Vector3 StartPoint { get; set; }
    }
}