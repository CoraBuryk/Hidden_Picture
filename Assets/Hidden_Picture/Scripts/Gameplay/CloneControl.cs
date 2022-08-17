using System;
using UnityEngine;

public class CloneControl : MonoBehaviour
{
    public static event Action Change;
    public static int NumberOfClone { get; set; } = 10;

    public static void End(int number)
    {
        number = NumberOfClone;
        Change?.Invoke();
    }
}
