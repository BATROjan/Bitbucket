using DefaultNamespace;
using DragObjects;
using GameZone.Scripts;
using Houses;
using Houses.Scripts;
using UnityEngine;
using VContainer.Unity;

namespace PlayerInputSystem
{
    public class MouseInputSystem : IMouseInputSystem, ITickable
    {
        private readonly IdragObjectController _dragObjectController;
        private readonly IHouseController _houseController;
        private readonly IDragObject _dragObject;
        public MouseInputSystem(
            IdragObjectController dragObjectController,
            IHouseController houseController,
            IDragObject dragObject)
        {
            _dragObjectController = dragObjectController;
            _houseController = houseController;
            _dragObject = dragObject;
        }

        public void ChechCells()
        {
            throw new System.NotImplementedException();
        }

        public void Tick()
        {
            Vector2 mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            _dragObject.Transform.position = mousePosition;
            
            if (Input.GetMouseButtonDown(0))
            {
                RaycastHit2D hit = Physics2D.Raycast(Camera.main.transform.position, mousePosition);                                                                                 

                if (hit.transform) 
                {
                    if (_dragObjectController.CheckAllCells())
                    {
                        _houseController.Spawn(mousePosition);
                    }
                }
                else
                {
                    Debug.Log("Луч ни во что не попал.");
                }
            }
        }
    }
}