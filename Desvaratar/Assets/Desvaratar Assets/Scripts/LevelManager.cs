using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelManager : MonoBehaviour
{


	public void PlayLevelFire()
	{
		SceneManager.LoadScene("LevelFire", LoadSceneMode.Single);
	}

	public void PlayLevelWater()
	{
		SceneManager.LoadScene("LevelWater", LoadSceneMode.Single);
	}

}
