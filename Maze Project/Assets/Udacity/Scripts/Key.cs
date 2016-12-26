using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Key : MonoBehaviour 

{
    //Create a reference to the KeyPoofPrefab and Door
	public GameObject keyPoof;
	public Door door;
	public GameObject keyPrefab;
	public static bool isCollected;

	void Update()
	{
		//Bonus: Key Animation
		transform.position = new Vector3 (transform.position.x, 2.5f + Mathf.Sin (Time.time), transform.position.z);

	}

	public void OnKeyClicked()
	{
		isCollected = true;
        // Instatiate the KeyPoof Prefab where this key is located
		// Make sure the poof animates vertically
		Instantiate(keyPoof, transform.position, keyPoof.transform.rotation);

		// Call the Unlock() method on the Door
		door.Unlock();
		// Destroy the key. Check the Unity documentation on how to use Destroy
		Destroy(keyPrefab);
    }

}
