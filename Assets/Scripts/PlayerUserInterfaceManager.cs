
using System;
using UnityEngine;
using UnityEngine.PlayerLoop;
using UnityEngine.UI;

public class PlayerUserInterfaceManager : MonoBehaviour
{
    public PlayerHealthManager _playerHealth;
    //public Image _heart1, _heart2, _heart3;
    public Image[] hearts;

    private void Update()
    {
        for (int i = 0; i < hearts.Length; i++)
        {
            hearts[i].color = i < _playerHealth.lives ? new Color(1, 1, 1, 1) : new Color(1, 1, 1, 0.1f);
        }
    }
}
/* if (_playerHealth.lives == 3)
       {
           // red, green, blue, alpha
           _heart3.color = new Color(1, 1, 1,1);
       }

       if (_playerHealth.lives == 2)
       {
           _heart3.color = new Color(1, 1, 1, 0.5f);
           _heart2.color = new Color(1, 1, 1, 1);
       }

       if (_playerHealth.lives == 1)
       {
           _heart2.color = new Color(1, 1, 1, 0.5f);
           _heart1.color = new Color(1, 1, 1, 1);
       }

       if (_playerHealth.lives == 0)
       {
           _heart1.color = new Color(1, 1, 1, 0.5f);
       }*/