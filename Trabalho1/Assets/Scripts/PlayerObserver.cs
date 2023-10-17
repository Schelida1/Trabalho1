using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static  class PlayerObserver
{
    public static Action<int> OnPointsChanged;

    public static void PointsChanged(int points)
    {
        OnPointsChanged?.Invoke(points);
    }

    public static Action<int> OnEnergyChanged;

    public static void EnergyChanged(int energy)
    {
        OnEnergyChanged?.Invoke(energy);
    }
}
