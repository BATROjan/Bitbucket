using UnityEngine;

namespace GameZone.Scripts
{
    public interface ICellController
    {
        void SpawnCell(Transform transform, Vector3 point);
        void DespawnCell(CellView view);
    }
}