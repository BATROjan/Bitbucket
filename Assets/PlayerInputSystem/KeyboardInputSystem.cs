using System;
using DragObjects;
using Unity.VisualScripting;
using UnityEngine;
using VContainer.Unity;

namespace PlayerInputSystem
{
    public class KeyboardInputSystem: IInputSystem
    {
        public float HorizontalDirection => GetHorDirection();
        public float VerticalDirection => GetVerDirection();
        public Action<int> OnGetIconID { get; set; }

        private readonly IdragObjectController _dragObjectController;
        private readonly IControllConfigs _controlsConfigses;

        private int _currentID = 1;
        public KeyboardInputSystem(
            IdragObjectController dragObjectController,
            IControllConfigs controllConfigs)
        {
            _dragObjectController = dragObjectController;
            _controlsConfigses = controllConfigs;
            //OnGetIconID += GetCurrentIconID;
        }
        private float GetHorDirection()
        {
            return Input.anyKey switch
            {
                true when Input.GetKey(_controlsConfigses.RightKey) => 1f,
                true when Input.GetKey(_controlsConfigses.LeftKey) => -1f,
                _ => 0f
            };
        }
        private float GetVerDirection()
        {

            return Input.anyKey switch
            {
                true when Input.GetKey(_controlsConfigses.UpKey) => 1f,
                true when Input.GetKey(_controlsConfigses.DownKey) => -1f,
                _ => 0f
            };
        }

        public void GetCurrentIconID()
        {
            if (Input.GetKeyDown(KeyCode.Alpha1))
            {
                OnGetIconID?.Invoke(0);
                _dragObjectController.ActivateDrag(0);
            }
            if (Input.GetKeyDown(KeyCode.Alpha2))
            {
                OnGetIconID?.Invoke(1);
                _dragObjectController.ActivateDrag(1);
            }
            if (Input.GetKeyDown(KeyCode.Alpha3))
            {
                OnGetIconID?.Invoke(2);
                _dragObjectController.ActivateDrag(2);
            }
            if (Input.GetKeyDown(KeyCode.Alpha4))
            {
                OnGetIconID?.Invoke(3);
                _dragObjectController.Despawn();
            }
        }
    }
}