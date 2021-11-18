using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WetIsWater : MonoBehaviour
{
    /*
     * This is an example of how you change a non-GRIDa object based on Sender input.
    The Sender (on GRIDa or another object) changes a bool on the Listener (on this object). 
    This script is a connected to the Listener script and then does the appropriate thing (in this case makes it a puddle). 
    Different objects can have different reactions to the same bool in the Listener.
    Remember to assign “heyListen” in the editor.  
     */
    public Listener heyListen;
    public GameObject puddle;


    // Update is called once per frame
    void Update()
    {
        if (heyListen.Wet)
        {
            /* Creates a puddle on top of this object, 
               tells you that it did it,
               destroys this object.
             */
            Instantiate(puddle, transform.position, transform.rotation);
            print(gameObject.name + " is wet");
            Destroy(gameObject);
        }
    }
}
