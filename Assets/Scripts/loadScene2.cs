using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;


public class loadScene2 : MonoBehaviour {

	public void loadMyNewScene () {
		Debug.Log("My New Scene");
		SceneManager.LoadScene("scene2");
	}
}
