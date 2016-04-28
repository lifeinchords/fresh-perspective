using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;


public class loadOriginalScene : MonoBehaviour {

	public void loadMyNewScene () {
		Debug.Log("My New Scene");
		SceneManager.LoadScene("originScene");
	}
}
