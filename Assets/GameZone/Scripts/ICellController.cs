using System.Collections.Generic;
using UnityEngine;

namespace GameZone.Scripts
{
    public interface ICellController
    {
        void DefaultCell(CellView cellView);
        void CheckCell(CellView cellView);
        bool ChekAllCells(List<CellView> list);
        void SpawnCell(Transform transform, Vector3 point);
        void DespawnCell(CellView view);
    }
}