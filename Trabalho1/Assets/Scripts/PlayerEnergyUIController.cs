using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class PlayerEnergyUIController: MonoBehaviour
{
   private Slider energySlider;

   private void OnEnable()
   {
      PlayerObserver.OnEnergyChanged += UpdateEnergy;
   }

   private void OnDisable()
   {
      PlayerObserver.OnEnergyChanged -= UpdateEnergy;
   }

   private void Awake()
   {
      energySlider = GetComponent<Slider>();
   }

   private void UpdateEnergy(int value )
   {
      energySlider.value = value;
   }
}
