using System;
using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
public class LevelManager : MonoBehaviour
{

	public float LoadAfter;

	private void Start()
	{
		
	}

	public void LoadLevel(string name){
	//	Debug.Log ("New Level load: " + name);
		Application.LoadLevel (name);
	}

	public void QuitRequest(){
		Debug.Log ("Quit requested");
		Application.Quit ();
	}
	public void LoadNextLevel()
	{
		SceneManager.LoadScene(1);
	}

}
