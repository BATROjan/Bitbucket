using UnityEngine;

namespace Houses.Scripts
{
    public interface IHouseController
    {
        HouseModel GetModel(int id);
        void Spawn(int id,Vector2 position);
        void Despawn();
    }
}