using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    private float timer = 0f;
    public float timerDuration = 120f; //setting the time

    [SerializeField] Text countdownText;
    [SerializeField] Text coinText;

    void Start()
    {
        timer = timerDuration;
    }

    void Update()
    {
        timer -= 1 * Time.deltaTime;
        countdownText.text = timer.ToString ("0");

        if (timer <= 0)
        {
            timer = 0;
            countdownText.text = "Time's Up! Game Over";
        }

        if (GameObject.FindGameObjectsWithTag("coin").Length <= 0)
        {
            coinText.text = "You found all the batteries! You win!";
        }
    }
}
