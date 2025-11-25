using UnityEngine;

namespace Houses.Scripts
{
    public class HouseView: MonoBehaviour, IHouseView
    {
      [field: SerializeField] public SpriteRenderer SpriteRenderer { get; set; }
      [field: SerializeField] public Transform Transform { get; set; }
      [field: SerializeField] public BoxCollider2D BoxCollider2D { get; set; }
    }
}