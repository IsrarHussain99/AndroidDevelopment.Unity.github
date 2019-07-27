using UnityEngine;
using System.Collections;

public class SplashScreenScript : MonoBehaviour {

	public float delay = 15;
	public string NewLevelString= "PlayScene";
	void Start()
	{
		StartCoroutine(LoadLevelAfterDelay(delay));     
	}

	IEnumerator LoadLevelAfterDelay(float delay)
	{
		yield return new WaitForSeconds (delay);
		Application.LoadLevel (NewLevelString);
	
	}
}