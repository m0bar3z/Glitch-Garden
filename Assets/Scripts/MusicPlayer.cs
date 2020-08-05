using UnityEngine;
using System.Collections;
using UnityEditor.Build.Content;
using UnityEngine.SceneManagement;


public class MusicPlayer : MonoBehaviour {
	public AudioClip[] LevelsMusic;
	private AudioSource audiosource;

	void Awake()
	{
		GameObject.DontDestroyOnLoad(gameObject);
	}

	void Start()
	{	
		audiosource = GetComponent<AudioSource>();
	}

	void OnEnable()
	{
		//Tell our 'OnLevelFinishedLoading'
		//function to start listening for a
		//scene change as soon as this script is enabled.
		SceneManager.sceneLoaded += OnLevelFinishedLoading;
		
	}

	public void ChangeVolume(float Value)
	{
		audiosource.volume = Value;
	}

	void myTest(Scene test1, LoadSceneMode test2)
	{
		print("MyTest");
	}
	void OnLevelFinishedLoading(Scene scene, LoadSceneMode mode)
	{
	//	Debug.Log("Level Loaded " + scene.name);
		int LevelIndex = scene.buildIndex;
		if (LevelsMusic[LevelIndex] && LevelIndex != 2)
		{
			audiosource.clip = LevelsMusic[LevelIndex];
			audiosource.loop = false;
		    audiosource.Play();
		}

	}
	
	void OnDisable()
	{
		//Tell our 'OnLevelFinishedLoading' function to stop listening for a scene
		//change as soon as this script is disabled. Remember to always have an
		//unsubscription for every delegate you subscribe to!
		SceneManager.sceneLoaded -= OnLevelFinishedLoading;
	}
	
}
