using System;
using Houses.Scripts;
using UnityEngine.Pool;
using VContainer;
using VContainer.Unity;

namespace DragObjects
{
    public class DragObjectController : IdragObjectController,ITickable
    {
        private readonly ObjectPool<DragObject> _pool;
        private readonly IHouseController _houseController;
        private readonly DragObject _dragObject;
        private readonly IObjectResolver _objectResolver;

        private HouseModel currentModel;
        public DragObjectController( IHouseController houseController,
            DragObject dragObject,
            IObjectResolver objectResolver)
        {
            _houseController = houseController;
            _dragObject = dragObject;
            _objectResolver = objectResolver;
            _pool = new ObjectPool<DragObject>(SpawnDragObject, OnSpawned, OnReleased);
        }
        private void OnReleased(DragObject dragObject) => dragObject.gameObject.SetActive(false);

        private void OnSpawned(DragObject dragObject)
        {
            dragObject.gameObject.SetActive(true);
        }

        private DragObject SpawnDragObject() =>
            _objectResolver.Instantiate(_dragObject);

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

        private void ChangeModel(int id)
        {
            currentModel = _houseController.GetModel(id);
            _dragObject.SpriteRenderer.sprite = currentModel.Sprite;
            _dragObject.id = id;
        }

        public void Despawn()
        {
            OnReleased(_dragObject);
        }

        public void Tick()
        {
            
            
        }
    }
}