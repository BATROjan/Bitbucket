using DefaultNamespace;
using Houses;
using UnityEngine;
using VContainer.Unity;

namespace PlayerInputSystem
{
    public class MouseInputSystem : IMouseInputSystem, ITickable
    {
        private readonly IHouseView _houseView;
        private readonly IPlayerView _playerView;
        
        private float rayDistance = 100f;
        private LayerMask whatToHit;

        public MouseInputSystem(
            IHouseView houseView,
            IPlayerView playerView)
        {
            _houseView = houseView;
            _playerView = playerView;
        }

        public void ChechCells()
        {
            throw new System.NotImplementedException();
        }

        public void Tick()
        {
            Vector2 mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            _houseView.Transform.position = mousePosition;
            if (Input.GetMouseButtonDown(0))
            {
                RaycastHit2D hit = Physics2D.Raycast(Camera.main.transform.position, mousePosition);                                                                                 

                if (hit.transform) 
                {
                    Debug.Log($"Луч попал в объект: {hit.collider.gameObject.name} в точке {hit.point}");
                }
                else
                {
                    Debug.Log("Луч ни во что не попал.");
                }
            }
        }
    }
}