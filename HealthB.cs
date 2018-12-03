using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthB : MonoBehaviour {

    public Image HealthFG;
    float maxHealth = 100f;
    public float health;
    public Text Txt;

    // Use this for initialization
    void Start()
    {
        HealthFG = GetComponent<Image>();
        health = 100f;
    }

    // Update is called once per frame
    void Update()
    {

        HealthFG.fillAmount = health / maxHealth;
        //Debug.Log("FA: " + HealthFG.fillAmount);

    }
}