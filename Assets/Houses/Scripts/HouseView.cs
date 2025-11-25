using DragObjects;
using UnityEngine;

namespace Houses.Scripts
{
    public class HouseView: MonoBehaviour, IHouseView, IDragObject
    {
      [field: SerializeField] public SpriteRenderer SpriteRenderer { get; set; }
      [field: SerializeField] public Transform Transform { get; set; }
      public int id { get; }
      [field: SerializeField] public BoxCollider2D BoxCollider2D { get; set; }
    }
}