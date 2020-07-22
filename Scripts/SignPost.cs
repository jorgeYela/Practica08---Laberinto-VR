using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class SignPost : MonoBehaviour {

    int contador = 0;

	public void ResetScene () {

		Debug.Log ("'SignPost.ResetScene()' was called");

        SceneManager.LoadScene("Main");

    }

    public void addCoin(GameObject signPost) {

        contador++;

        Debug.Log("Monedas Totales: " + contador);

    }
}
