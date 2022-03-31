using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class HealthController : MonoBehaviour
{
    int health;
    int resetHealth;
    int healthInc;
    [SerializeField] Text healthText;
    [SerializeField] Text incrementUpText;
    [SerializeField] Text incrementDownText;
    [SerializeField] Slider incrementSlider;
    private void Start()
    {
        ResetHealth();
        UpdateHealth();
        UpdateIncrement();
    }
    public void IncreaseHealth()
    {
        health += healthInc;
        UpdateHealth();
    }
    public void DecreaseHealth()
    {
        health -= healthInc;
        UpdateHealth();
    }
    public void SetMTG20()
    {
        resetHealth = 20;
        ResetHealth();
    }
    public void SetMTG40()
    {
        resetHealth = 40;
        ResetHealth();
    }
    public void SetHeroRealms()
    {
        resetHealth = 50;
        ResetHealth();
    }
    public void ResetHealth()
    {
        health = resetHealth;
        UpdateHealth();
    }
    public void UpdateHealth()
    {
        healthText.text = health.ToString("00");
    }
    public void UpdateIncrement()
    {
        if(incrementSlider.value == 1)
        {
            healthInc = 1;
        }
        else if(incrementSlider.value == 2)
        {
            healthInc = 2;
        }
        else if(incrementSlider.value == 3)
        {
            healthInc = 5;
        }
        else if(incrementSlider.value == 4)
        {
            healthInc = 10;
        }
        incrementUpText.text = "+" + healthInc.ToString("00");
        incrementDownText.text = "-" + healthInc.ToString("00");
    }

}
