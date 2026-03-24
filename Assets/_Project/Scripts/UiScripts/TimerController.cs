using System;
using TMPro;
using UnityEngine;
public class TimerController : MonoBehaviour
{
    [Header("Time")]
    [SerializeField] private int minutes;
    [SerializeField] private float seconds;
    private bool isOver = false;

    public static event Action<int,float> Timer;

    private void Update()
    {
      if (!isOver) Counter();
    }
    private void Counter()
    {
        seconds -= Time.deltaTime;
        if (minutes <= 0 && seconds <= 0)
        {
            isOver = true;
        }
        if (!isOver)
        {
            if (seconds <= 0)
            {
                seconds = 60f; //non ho fatto -seconds come suggerito perchè ho notato che qunado partiva faceva -*- diventando +, risultando 1,60.2
                minutes -= 1;
            }
        }
        Timer?.Invoke(minutes, seconds);
    }

}
