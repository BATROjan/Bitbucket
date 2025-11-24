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


        public void SpawnCell(Transform transform)
        {
            Spawn();
        }

        public void DespawnCell(CellView view)
        {
            throw new System.NotImplementedException();
        }
    }
}