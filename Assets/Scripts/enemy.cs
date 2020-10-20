using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class enemy : MonoBehaviour {

    public Text healthText;

    void Start()
    {
        healthText.text = "EnemyHealth : " + attack.enemyHealth.ToString();
    }

    void Update()
    {

        if(attack.enemyHealth > 0) healthText.text = "EnemyHealth : " + attack.enemyHealth.ToString();
        if(attack.enemyHealth < 0) healthText.text = "EnemyHealth : 0";

        if (attack.enemyHealth == 0) Destroy(gameObject, 0.5f);
    }
}