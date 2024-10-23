using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class PrizePlayerCollision : MonoBehaviour
{

    //References to GameObjects to appear in inventory GUI
    public GameObject PumpkinIcon;
    public GameObject EggIcon;
    public GameObject WheatIcon;
    public GameObject MilkIcon;
    public GameObject CinnamonIcon;

    public GameObject PumpkinPie; //in scene

    AudioManager audioManager;

    // private void Awake() {
    //     audioManager = GameObject.FindGameObjectWithTag("Audio").GetComponent<AudioManager>();
    // }
    

    void Start() {

        //Initialize all icons and pumpkin pie as false to "hide" them

        PumpkinIcon.SetActive(false);
        EggIcon.SetActive(false);
        WheatIcon.SetActive(false);
        MilkIcon.SetActive(false);
        CinnamonIcon.SetActive(false);

        PumpkinPie.SetActive(false);
    }

    //Runs every time player collides with rigidbody of any prize
    void OnTriggerStay(Collider other)
    {
    
        if (other.gameObject.tag == "Player") { 

           /*add scene-specific audio stuff here later*/
            
            if (this.gameObject.tag == "Pumpkin") { 

                //Pumpkin icon should appear in inventory
                PumpkinIcon.SetActive(true);
                this.gameObject.SetActive(false); //item in scene disappears

                /*add audio stuff here later*/
            } 
            
            if (this.gameObject.tag == "Egg") { 

                //Egg icon should appear in inventory
                EggIcon.SetActive(true);
                this.gameObject.SetActive(false); //item in scene disappears

                /*add audio stuff here later*/
            } 

            if (this.gameObject.tag == "Wheat") { 

                //Wheat icon should appear in inventory
                WheatIcon.SetActive(true);
                this.gameObject.SetActive(false); //item in scene disappears

                /*add audio stuff here later*/
            } 

            if (this.gameObject.tag == "Milk") { 

                //Milk icon should appear in inventory
                MilkIcon.SetActive(true);
                this.gameObject.SetActive(false); //item in scene disappears

                /*add audio stuff here later*/
            } 

            if (this.gameObject.tag == "Cinnamon") { 

                //Cinnamon icon should appear on HUD/GUI
                CinnamonIcon.SetActive(true);
                this.gameObject.SetActive(false); //item in scene disappears

                /*add audio stuff here later*/
            } 

        }
    }

    void Update() {

        if (PumpkinIcon.activeInHierarchy && EggIcon.activeInHierarchy && WheatIcon.activeInHierarchy && MilkIcon.activeInHierarchy && CinnamonIcon.activeInHierarchy) {
            PumpkinPie.SetActive(true);
        }
        

    }
}


