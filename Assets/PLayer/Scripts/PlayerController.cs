using DefaultNamespace;
using UnityEngine;
using VContainer.Unity;

namespace PlayerInputSystem
{
    public class PlayerController : IPlayerController, ITickable
    {
        private readonly IInputSystem _inputSystem;
        private readonly IPlayerView _playerView;

        public PlayerController(
            IInputSystem inputSystem,
            IPlayerView playerView)
        {
            _inputSystem = inputSystem;
            _playerView = playerView;
        }
        public void Tick()
        {
            var direction = new Vector3();
            if(!Mathf.Approximately(_inputSystem.HorizontalDirection, 0f))
            {
                direction.x = 5 * Time.deltaTime * _inputSystem.HorizontalDirection;
            }
            if(!Mathf.Approximately(_inputSystem.VerticalDirection, 0f))
            {
                direction.y += 5 * Time.deltaTime * _inputSystem.VerticalDirection;
            }
            _playerView.Position += direction;
        }
    }
}