using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class LevelSelect : MonoBehaviour {

	public string levelPrefix = "Level_";

	public void loadLevel(int levelID) {
		SceneManager.LoadScene (levelPrefix + levelID);
	}

}
