using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class SplashManager : MonoBehaviour {




	void Start ()
	{
	Invoke("LoadMainMenu",3f);
	}

	void LoadMainMenu()
	{
	SceneManager.LoadScene("MainMenu");
	}

	}