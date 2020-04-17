using System;
using System.Collections;
using UnityEngine;

namespace Behavioral.Observer
{
    public class Timer : MonoBehaviour
    {
        private float _duration = 10.0f;
        private float _halfTime;

        public delegate void TimerStarted();
        public static event TimerStarted OnTimerStarted;

        public delegate void HalfTime();
        public static event HalfTime OnHalfTime;

        public delegate void TimerEnded();
        public static event TimerEnded OnTimerEnded;

        private IEnumerator _coroutine;

        private IEnumerator Start()
        {
            _halfTime = _duration / 2;
            OnTimerStarted?.Invoke();
            yield return StartCoroutine(WaitAndPrint(1.0F));
            OnTimerEnded?.Invoke();
        }

        private IEnumerator WaitAndPrint(float waitTime)
        {
            while (Time.time < _duration)
            {
                yield return new WaitForSeconds(waitTime);
                Debug.Log("Seconds: " + Mathf.Round(Time.time));
                if (Mathf.Round(Time.time) == Mathf.Round(_halfTime))
                {
                    OnHalfTime?.Invoke();
                }
            }
        }
    }
}