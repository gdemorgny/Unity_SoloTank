using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
   [SerializeField] private Image _HealthBar;
   [SerializeField] private PlayerDatas _playerDatas;

   private void OnEnable()
   {
      TankController.OnUpdateHealth += UpdateHealthBar;
   }
   private void OnDisable()
   {
      TankController.OnUpdateHealth -= UpdateHealthBar;
   }

   private void UpdateHealthBar()
   {
      _HealthBar.fillAmount = _playerDatas.LifePoint / _playerDatas.MaxLifePoint;
   }
   
}
