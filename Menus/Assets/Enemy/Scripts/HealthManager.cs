
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthManager : MonoBehaviour
{
    [SerializeField]
    float maxhitpoints = 100f;
    float hitPoints;

    public Slider healthslider;


    private void Start()
    {
        hitPoints =maxhitpoints;
    }
    void Hit(float rawDamage)
    {
        hitPoints -= rawDamage;
        SetHealthSlider();
        Debug.Log("OUCH: " + hitPoints.ToString());

        if (hitPoints <= 0)
        {
            Debug.Log("TODO: GAME OVER - YOU DIED");
        }

    }
    public void SetHP(float hp)
    {
        hitPoints -= hp;
        Debug.Log("hit from trap" + hitPoints.ToString());

        if (hitPoints <= 0)
        {
            Debug.Log("TODO: GAME OVER - YOU DIED");
        }
    }
    void SetHealthSlider()
    {
        if(healthslider != null)
        {
            healthslider.value = NormalisedHitPoints();
        }
    }
    float NormalisedHitPoints()
    {
        return hitPoints / maxhitpoints;
    }
}
