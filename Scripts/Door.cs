using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(AudioSource))]
public class Door : MonoBehaviour {

    public Transform leftDoor;
    public Transform rightDoor;
    public AudioClip audioDataOpen;
    public AudioClip audioDataClose;
    
    bool locked = true;
    bool opening = false;
    
    Quaternion leftInit;
    Quaternion leftEnd;
    Quaternion rightInit;
    Quaternion rightEnd;

    void Start () {

	}


	void Update () {

        if((transform.position.y < 7.8f) & (opening == true)) {

            leftInit = Quaternion.Euler(-90f, 0f, 90.037f);
            leftEnd = Quaternion.Euler(-90f, 100f, 90.037f);
            leftDoor.transform.rotation = Quaternion.Slerp(leftInit, leftEnd, Time.time / 80);

            rightInit = Quaternion.Euler(-90f, 0f, -90.031f);
            rightEnd = Quaternion.Euler(-90f, -100f, -90.031f);
            rightDoor.transform.rotation = Quaternion.Slerp(rightInit, rightEnd, Time.time / 80f);
        }
    }


	public void OnDoorClicked () {

		Debug.Log ("'Door.OnDoorClicked()' was called");

        if(locked == false) {
            opening = true;
            Debug.Log("Door is Opened");
            AudioSource.PlayClipAtPoint(audioDataOpen, new Vector3(0,0,0));
        } else {
            Debug.Log("Door is locked");
            AudioSource.PlayClipAtPoint(audioDataClose, new Vector3(0, 0, 0));
        }
    }


	public void Unlock () {

		Debug.Log ("'Door.Unlock()' was called");
        locked = false;

	}
}
