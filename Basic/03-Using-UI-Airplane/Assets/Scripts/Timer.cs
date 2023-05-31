using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    public Slider timerSlider;
    private float gameTime = 60f;
    private float bonusTime = 5f;

    public Text counter;
    private int counterPoints = 0;
    private int maxPoints = 4;

    // Start is called before the first frame update
    void Start()
    {
        timerSlider.maxValue = gameTime;
        timerSlider.value = gameTime;

        counter.text = $"{counterPoints} / {maxPoints}";

    }

    // Update is called once per frame
    void Update()
    {
        timerSlider.value -= Time.deltaTime;
    }

    public void UpdateTimer()
    {
        timerSlider.value += bonusTime;
    }

    public void UpdateCounter()
    {
        counterPoints++;
        counter.text = $"{counterPoints} / {maxPoints}";
    }
}
