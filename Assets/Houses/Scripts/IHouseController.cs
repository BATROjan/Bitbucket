namespace Houses.Scripts
{
    public interface IHouseController
    {
        HouseModel GetModel(int id);
        void Spawn();
        void Despawn();
    }
}