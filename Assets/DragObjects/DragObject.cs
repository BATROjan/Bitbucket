using UnityEngine;

namespace DragObjects
{
    public class DragObject: MonoBehaviour, IDragObject
    {
        [field:SerializeField] public SpriteRenderer SpriteRenderer { get; set; }
        [field:SerializeField]public Transform Transform { get; set; }
        public int id { get; set; }
    }
}