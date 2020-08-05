using UnityEngine;
using System.Collections;
using System;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;
using UnityEngine.SceneManagement;

public class PersistentManager : MonoBehaviour {
	
	public static PersistentManager dataStore;
	
	//Instance Variables
	public int currentLevelID;

	//Persisted Variables
	public int gemsCollected;
	public int highestLevelCompleted;
	
	void Awake() {
		if (dataStore == null) {
			DontDestroyOnLoad (gameObject);
			dataStore = this;
			//Load();
		} else if (dataStore != this) {
			Destroy (gameObject);
		}
	}
	public void endGameWithWin() {
		Debug.Log ("Game over - win");
		Debug.Log (SceneManager.GetActiveScene ().name);
		SceneManager.LoadScene ("MainMenu");
	}

	public void endGameWithLoss() {
		Debug.Log ("Game over - loss");
		Debug.Log (SceneManager.GetActiveScene ().name);
		SceneManager.LoadScene ("MainMenu");
	}
}