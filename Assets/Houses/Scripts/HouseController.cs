using VContainer.Unity;

namespace Houses.Scripts
{
    public class HouseController : IHouseController, ITickable
    {
        private readonly IHouseConfig _houseConfig;

        public HouseController(IHouseConfig houseConfig)
        {
            _houseConfig = houseConfig;
        }
        public HouseModel GetModel(int id)
        {
            return _houseConfig.GetModelById(id);
        }

        public void Spawn()
        {
            throw new System.NotImplementedException();
        }

        public void Despawn()
        {
            throw new System.NotImplementedException();
        }

        public void Tick()
        {
           
        }
    }
}