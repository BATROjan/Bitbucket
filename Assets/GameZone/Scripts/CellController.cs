using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Pool;
using VContainer;
using VContainer.Unity;

namespace GameZone.Scripts
{
    public class CellController : ICellController
    {
        private readonly CellView _cellView;
        private readonly IObjectResolver _resolver;
        private readonly ObjectPool<CellView> _pool;

        private List<CellView> _listCellViews = new();
        public CellController(
            ICellView cellView,
            IObjectResolver resolver
            )
        {
            _cellView = (CellView)cellView;
            _resolver = resolver;
            _pool = new ObjectPool<CellView>(Spawn);
        }

        private CellView Spawn() => _resolver.Instantiate(_cellView);


        public void SpawnCell(Transform transform, Vector3 point)
        {
            var cell = Spawn();
            cell.transform.position = point;
            cell.transform.SetParent(transform);
            _listCellViews.Add(cell);
        }

        public void DefaultCell(CellView cellView)
        {
            cellView.SpriteRenderer.color = Color.white; 
        }

        public void CheckCell(CellView cellView)
        {
            if (cellView.IsFeel)
            {
                cellView.SpriteRenderer.color = Color.red;
            }
            else
            {
                cellView.SpriteRenderer.color = Color.green;
            }
        }

        public bool ChekAllCells(List<CellView> list)
        {
            bool status = true;
            foreach (var cell in list)
            {
                if (cell.IsFeel)
                {
                    status = false;
                }
            }

            if (status)
            {
                foreach (var cell in list)
                {
                    cell.IsFeel = status;
                }
            }
            return status;
        }

        public void DespawnCell(CellView view)
        {
            throw new System.NotImplementedException();
        }
    }
}