using UnityEngine;

namespace Houses.Scripts
{
    public interface IHouseController
    {
        HouseModel GetModel(int id);
        void Spawn(Vector2 position);
        void Despawn();
    }
}