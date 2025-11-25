using System;

namespace PlayerInputSystem
{
    public interface IInputSystem
    {
        float HorizontalDirection { get; }
        float VerticalDirection { get; }
        public Action<int> OnGetIconID  { get; set; }
        public void GetCurrentIconID();
    }
}