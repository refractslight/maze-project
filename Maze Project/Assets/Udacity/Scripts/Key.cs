using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Key : MonoBehaviour 

{
    //Create a reference to the KeyPoofPrefab and Door
	public GameObject keyPoof;
	public GameObject door;

	void Update()
	{
		//Bonus: Key Animation
		transform.position = new Vector3 (transform.position.x, 2.5f + Mathf.Sin (Time.time), transform.position.z);

	}

	public void OnKeyClicked()
	{
        // Instatiate the KeyPoof Prefab where this key is located
		Instantiate(keyPoof, transform.position, Quaternion.identity);
        // Make sure the poof animates vertically
		// Call the Unlock() method on the Door
		door.Unlock();
		// Destroy the key. Check the Unity documentation on how to use Destroy
		Destroy(gameObject);
    }

}
