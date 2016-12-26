using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(AudioSource))]

public class Door : MonoBehaviour {
	
    // Create a boolean value called "locked" that can be checked in Update() 
	private bool locked;
	private bool raised;
	public GameObject keyPrefab;
	public AudioClip doorOpened;
	public AudioClip doorLocked;
	public AudioSource doorSoundPlayer;


	void Start() {
	}

    void Update() {
		
        // If the door is unlocked and it is not fully raised
		if (locked && raised == true) {
			// Animate the door raising up
			transform.Translate (0, 2.5f * Time.deltaTime, 0);
		}
	}	
		
    public void Unlock() {
        // You'll need to set "locked" to true here
		if (Key.isCollected == true) {
			locked = true;
			doorSoundPlayer.clip = doorOpened;
			doorSoundPlayer.Play();
			Debug.Log ("Unlocked!");
		}
		else {
			doorSoundPlayer.clip = doorLocked;
			doorSoundPlayer.Play();
			Debug.Log ("No Key Collected. Staying shut.");
		}
    }

	public void Raise() {
		//if there's no key, the door can be raised
		if (keyPrefab == null) {
			raised = true;
			/*doorSoundPlayer.clip = doorOpened;
			doorSoundPlayer.Play();*/
			Debug.Log ("Key collected! Up we go!");

		} 
		else {
			doorSoundPlayer.clip = doorLocked;
			doorSoundPlayer.Play();
			Debug.Log ("No Key Collected. Staying shut.");
		}

	}
}
