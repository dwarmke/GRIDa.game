using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SenderBath : MonoBehaviour
{
    /*
     * This is a Sender which you put on GRIDa to give her powers. 
    It uses a 2D collider to interact with other objects
    Then it will flip a bool in the listener script on the object. 
    Make one for whatever new power you make. 
     */
    public GameObject itemEfect;
    public Collider2D itemCollider;
   

    // Start is called before the first frame update
    void Start()
    {
        //Starts with collider off
        if (itemCollider.enabled == true)
        {
            itemCollider.enabled = !itemCollider.enabled;
        }
    }

    // Update is called once per frame
    void Update()
    {
        //Key 1 activates the item
        if (Input.GetKeyDown("1"))
        {
            itemEfect.SetActive(true);
            itemCollider.enabled = itemCollider.enabled;

        }

        // Release shuts down the item
        if (Input.GetKeyUp("1"))
        {
            itemEfect.SetActive(false);
            itemCollider.enabled = !itemCollider.enabled;
        }


    }

    //Collider tells Listener to do the thing. 
    private void OnTriggerEnter2D(Collider2D collision)
    {


        GameObject other = collision.gameObject;
        //print(other.name + " is Wet");

        //Change Wet to the bool that you need to alter. 
        other.GetComponent<Listener>().Wet = true;
    }
}