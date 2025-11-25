using DragObjects;
using UnityEngine;
using UnityEngine.Pool;
using VContainer;
using VContainer.Unity;

namespace Houses.Scripts
{
    public class HouseController : IHouseController, ITickable
    {
        private readonly HouseView _houseView;
        private readonly IObjectResolver _objectResolver;
        private readonly IHouseConfig _houseConfig;
        private readonly ObjectPool<HouseView> _pool;
        public HouseController(
            HouseView houseView,
            IObjectResolver objectResolver,
            IHouseConfig houseConfig)
        {
            _houseView = houseView;
            _objectResolver = objectResolver;
            _houseConfig = houseConfig;
            _pool = new ObjectPool<HouseView>(SpawnObject, OnSpawned, OnReased);
        }

        private HouseView SpawnObject() 
            => _objectResolver.Instantiate(_houseView);

        private void OnSpawned(HouseView view)
        {
        }

        private void OnReased(HouseView obj)
        {
            
        }

        public HouseModel GetModel(int id)
        {
            return _houseConfig.GetModelById(id);
        }

        public void Spawn(Vector2 position)
        {
            var houseView = SpawnObject();
            houseView.Transform.position = position;
        }

        public void Despawn()
        {
        }

        public void Tick()
        {
           
        }
    }
}