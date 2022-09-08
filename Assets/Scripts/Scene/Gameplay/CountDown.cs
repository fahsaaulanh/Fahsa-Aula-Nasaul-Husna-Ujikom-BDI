using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace Game.Scene.Gameplay
{
    public class CountDown : MonoBehaviour
    {
        [SerializeField] private Slider _timerValue;
        private float _timer = 30;

        private void Start()
        {
            _timerValue.value = 1f;
        }

        private void Update()
        {
            _timer -= Time.deltaTime;
            _timerValue.value = _timer / 30;
        }
    }

}