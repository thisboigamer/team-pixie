using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerHealth : MonoBehaviour
{
    //UI Slider with Max value of 100 and min value of 0
    [SerializeField] Slider HealthSlider;

    //Base Starting Health
    [SerializeField] public float Health = 100f;

    //ManagerObject
    private GameObject Manager;
    void Start()
    {
        HealthSlider.value = Health;
        HealthSet();
        //Game Manager needs Manager Tag
        Manager = GameObject.FindGameObjectWithTag("Manager");
    }

    // Update is called once per frame
    void Update()
    {

        //Callse DecayHealth Every Second
        Invoke("DecayHealth", 0);

        //Checks to see when Health is Depleted
        if (Health <= 1)
        {
            Manager.GetComponent<ManagerScript>().GameOver();
        }
    }

    void OnTriggerEnter(Collider collide)
    {
        if (collide.tag == "PixieStick")
        {
            HealthUp();
            Destroy(collide.gameObject);
        }
    }


    //Decaying health Function
    void DecayHealth()
    {
        Health -= 0.1f;
        UpdateUI();
    }

    //Clamps Health Between 0 and 100
    void HealthSet()
    {
        Health = Mathf.Clamp(Health, 0f, 100f);
    }

    //Updates UI
    void UpdateUI()
    {
        HealthSlider.value = Health;
    }

    //ResetsHealth 
    //Should be called whenever player Picks up PixieStix
    public void HealthUp()
    {
        Health = 100;
    }
}
