using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SenderHot : MonoBehaviour
{
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
        //2 key activates the item
        if (Input.GetKeyDown("2"))
        {
            itemEfect.SetActive(true);
            itemCollider.enabled = itemCollider.enabled;

        }

        // Release shuts down the item
        if (Input.GetKeyUp("2"))
        {
            itemEfect.SetActive(false);
            itemCollider.enabled = !itemCollider.enabled;
        }


    }

    //Colider tells listener to do the thing. 
    private void OnTriggerEnter2D(Collider2D collision)
    {

        GameObject other = collision.gameObject;
        //print(other.name + " is Hot");

        //Change Hot to the bool that you need to alter. 
        other.GetComponent<Listener>().Hot = true;
    }
}
