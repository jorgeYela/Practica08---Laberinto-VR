using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Key : MonoBehaviour {
    
    public GameObject keyPoofPrefab;
    public GameObject key;


	void Update () {

	}


	public void OnKeyClicked () {

		Debug.Log ("'Key.OnKeyClicked()' was called");

        Object.Instantiate(keyPoofPrefab, transform.position, Quaternion.identity);

        GameObject door = GameObject.Find("Door_Main");
        door.GetComponent<Door>().Unlock();

        Invoke("KeyObtained", 0.5f);
    }

    void KeyObtained() {

        Destroy(this.key);

    }

}
