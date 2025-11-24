using UnityEngine;

namespace GameZone.Scripts
{
    public interface ICellController
    {
        void SpawnCell(Transform transform);
        void DespawnCell(CellView view);
    }
}