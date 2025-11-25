using System;
using System.Collections.Generic;
using GameZone.Scripts;
using Houses.Scripts;
using UnityEngine.Pool;
using VContainer;
using VContainer.Unity;

namespace DragObjects
{
    public class DragObjectController : IdragObjectController,ITickable
    {
        private readonly ObjectPool<DragObject> _pool;
        private readonly ICellController _cellController;
        private readonly IHouseController _houseController;
        private readonly DragObject _dragObject;
        private readonly IObjectResolver _objectResolver;

        private HouseModel currentModel;
        private List<CellView> _cellViews = new();
        public DragObjectController( 
            ICellController cellController,
            IHouseController houseController,
            DragObject dragObject,
            IObjectResolver objectResolver)
        {
            _cellController = cellController;
            _houseController = houseController;
            _dragObject = dragObject;
            _dragObject.OnCellSelected += SelectCells;
            _dragObject.OnCellDiSelected += DiSelectCells;
            _objectResolver = objectResolver;
            _pool = new ObjectPool<DragObject>(SpawnDragObject, OnSpawned, OnReleased);
        }
        public void Spawn()
        {
            OnSpawned(_dragObject);
        }

        public void ActivateDrag(int id)
        {
            if (!_dragObject.gameObject.activeSelf)
            {
                OnSpawned(_dragObject);
               
            }
            else
            {
                ChangeModel(id);
            }
        }
        
        public void Despawn()
        {
            OnReleased(_dragObject);
        }

        public bool IsActive()
        {
            return _dragObject.gameObject.activeSelf;
        }

        public bool CheckAllCells()
        {
            if (_cellController.ChekAllCells(_cellViews))
            {
                return true;
            }
                return false;
        }

        private void OnReleased(DragObject dragObject) => dragObject.gameObject.SetActive(false);

        private void OnSpawned(DragObject dragObject)
        {
            dragObject.gameObject.SetActive(true);
        }

        private DragObject SpawnDragObject() =>
            _objectResolver.Instantiate(_dragObject);
        
        private void ChangeModel(int id)
        {
            currentModel = _houseController.GetModel(id);
            _dragObject.SpriteRenderer.sprite = currentModel.Sprite;
            _dragObject.id = id;
        }
        private void DiSelectCells(CellView cell)
        {
            _cellViews.Remove(cell);  
            _cellController.DefaultCell(cell);
        }

        private void SelectCells(CellView cell)
        {
            _cellViews.Add(cell); 
            _cellController.CheckCell(cell);
        }

        public void Tick()
        {
        }
    }
}