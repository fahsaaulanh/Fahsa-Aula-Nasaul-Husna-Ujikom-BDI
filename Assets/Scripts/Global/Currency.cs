using Game.Global.Database;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Game.Scene.Gameplay
{
    public class Currency : MonoBehaviour
    {
        public int _currentCoin;

        private void Start()
        {
            _currentCoin = PlayerPrefs.GetInt("PlayerCoin");
        }

        public void AddCoin(int coin)
        {
            _currentCoin += coin;
            PlayerPrefs.SetInt("PlayerCoin", _currentCoin);
        }
    }
}