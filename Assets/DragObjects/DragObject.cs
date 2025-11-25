using System;
using GameZone.Scripts;
using UnityEngine;

namespace DragObjects
{
    public class DragObject: MonoBehaviour, IDragObject
    {
        public Action<CellView> OnCellSelected;
        public Action<CellView> OnCellDiSelected;
        [field:SerializeField] public SpriteRenderer SpriteRenderer { get; set; }
        [field:SerializeField]public Transform Transform { get; set; }
        public int id { get; set; }

        private void OnTriggerEnter2D(Collider2D other)
        {
            var cell =  other.GetComponent<CellView>();
            if (cell)
            {
                OnCellSelected?.Invoke(cell);
            }
        }

        private void OnTriggerExit2D(Collider2D other)
        {
            var cell =  other.GetComponent<CellView>();
            if (cell)
            {
                OnCellDiSelected?.Invoke(cell);
            }
        }
    }
}