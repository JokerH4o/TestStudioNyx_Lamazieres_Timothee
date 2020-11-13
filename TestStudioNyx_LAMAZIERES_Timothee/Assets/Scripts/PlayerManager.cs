using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerManager : MonoBehaviour
{
    // Attributes definition
    #region Attributes
    public Material stripeMat;
    public int maxHealth = 100;
    public Color damageColor = Color.red;
    public float damageColorDuration = 1f;
    public Color healColor = Color.green;
    public float healColorDuration = 1f;
    public Slider slider;
    public Gradient colorHealthBarGradient;
    public Image fillSlider; 
    private int currentHealth;
    private Color mainColorPlayer;
    private bool dmgBoolCheck = false;
    private bool healBoolCheck = false;
    #endregion

    // The coroutine that change the color to damageColor for the damageColorDuration duration, also change the color of the health bar
    IEnumerator Damage()
    {
        dmgBoolCheck = true;
        stripeMat.SetColor("_Color1", damageColor);
        fillSlider.color = colorHealthBarGradient.Evaluate(0f);
        yield return new WaitForSeconds(damageColorDuration);
        stripeMat.SetColor("_Color1", mainColorPlayer);
        fillSlider.color = Color.red;
        dmgBoolCheck = false;
    }

    // A coroutine that change the color to healColor for the damageColorDuration duration, also change the color of the health bar
    private IEnumerator Heal()
    {
        healBoolCheck = true;
        stripeMat.SetColor("_Color1", healColor);
        fillSlider.color = colorHealthBarGradient.Evaluate(1f);
        yield return new WaitForSeconds(healColorDuration);
        stripeMat.SetColor("_Color1", mainColorPlayer);
        fillSlider.color = Color.red;
        healBoolCheck = false;
    }

    // Initiate values at game Awake
    private void Awake()
    {
        currentHealth = maxHealth;
        slider.maxValue = maxHealth;
        stripeMat.SetInt("_Tiling", currentHealth / 10);
        mainColorPlayer = stripeMat.GetColor("_Color1");
    }

    // Update is called once per frame, check if the player press a key and execute actions accordingly
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.T))
        {
            currentHealth -= 30;
            stripeMat.SetInt("_Tiling", currentHealth / 10);
            if(!dmgBoolCheck)
            {
                StartCoroutine("Damage");
            }
        }
        if (Input.GetKeyDown(KeyCode.H))
        {
            currentHealth += 20;
            stripeMat.SetInt("_Tiling", currentHealth / 10);
            if (!healBoolCheck)
            {
                StartCoroutine("Heal");
            }
        }

        // If HP are 0 or lower, destroy the player
        if (currentHealth < 1)
        {
            Destroy(gameObject);
        }

        slider.value = currentHealth;
    }
}
