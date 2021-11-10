using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class player_behavior : MonoBehaviour
{
    public static int health;
    public static int points;
    public static int ammo;
    

    public GameObject healthText;
    public GameObject pointsText;
    public GameObject ammoText;
    
    // Start is called before the first frame update
    void Start()
    {
        health = 100;
        points = 0;
        ammo = 150;
    }

    // Update is called once per frame
    void Update()
    {
        healthText.GetComponent<Text>().text = "Health " + health;
        pointsText.GetComponent<Text>().text = "Points " + points;
        ammoText.GetComponent<Text>().text = "Ammo " + ammo;
    }

    public static void Fire()
    {
        Debug.Log("Fire");
        ammo -= 1;
    }

    public static void TakeDamage()
    {
        Debug.Log("Take Damage..");
        health -= 5;      
        

        if(health == 0)
        {
            Debug.Log("Dead.");
        }
        
    }
}
