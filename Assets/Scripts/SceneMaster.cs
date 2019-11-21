using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class SceneMaster : MonoBehaviour
{
	private Scene currentScene;

	private void Start()
	{
		currentScene = SceneManager.GetActiveScene();
	}

	// Update is called once per frame
	void Update()
    {
        if(Input.anyKeyDown)
		{
			if(currentScene.buildIndex.Equals(7))
			{
				SceneManager.LoadScene(0);
			}
			else
			{
				NextScene();
			}
			
		}
    }

	private void NextScene()
	{
		SceneManager.LoadScene(currentScene.buildIndex + 1);
	}
}
