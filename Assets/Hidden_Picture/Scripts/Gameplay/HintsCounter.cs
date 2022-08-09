using System;
using UnityEngine;

namespace Assets.Hidden_Picture.Scripts.Gameplay
{
    public class HintsCounter : MonoBehaviour
    {
        public int Counter { get; set; } = 3;

        public event Action HintsChange;

        public void ChangeNumberOfHints(int newNumber)
        {
            Counter = newNumber;
            HintsChange?.Invoke();
        }
    }
}
