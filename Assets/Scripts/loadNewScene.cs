using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class loadNewScene : MonoBehaviour {

	public void loadMyNewScene () {
		Debug.Log("My New Scene");
		SceneManager.LoadScene("scene1");
	}
}
