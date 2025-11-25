using UnityEngine;
using VContainer;

namespace GameZone.Scripts
{
    public class CellView : MonoBehaviour, ICellView
    {
        public bool IsFeel { get; set; }
        [field: SerializeField] public SpriteRenderer SpriteRenderer { get;set; }
       [field: SerializeField] public BoxCollider2D BoxCollider2D { get;set; }
       
    }
}