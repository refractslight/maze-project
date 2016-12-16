using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : MonoBehaviour 
{
    // Create a boolean value called "locked" that can be checked in Update() 
	public bool locked;

    void Update() {
        // If the door is unlocked and it is not fully raised
		if(locked == false) 
		{
		// Animate the door raising up
			transform.Translate(0, -2.5f * Time.deltaTime, 0);
		}
}


    public void Unlock()
    {
        // You'll need to set "locked" to true here
		locked == true;
    }
}
