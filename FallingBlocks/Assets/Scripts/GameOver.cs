using UnityEngine;
using System.Collections;
using UnityEngine.UI;				//allows to use UI text space and allows to create public text variable
using UnityEngine.SceneManagement;  //allows access to scene manager 


public class GameOver : MonoBehaviour {

	public GameObject gameOverScreen;
	public Text secondsSurvivedUI;				//reference to text object 
	bool gameOver;								//creates true/false boolean variable called gameOver


	// Use this for initialization
	void Start () {
		FindObjectOfType<PlayerController> ().OnPlayerDeath += OnGameOver; //subscribing the OnGameOver method to the OnPLayerDeath event
	
	}
	
	// Update is called once per frame
	void Update () {
		if (gameOver == true) {
			if (Input.GetKeyDown (KeyCode.Space)) {
				SceneManager.LoadScene (0);     //loads first scene , it goes by index or name of the scene
			}
		}
	
	}

	 void OnGameOver(){
		gameOverScreen.SetActive (true);				//enable object
		secondsSurvivedUI.text = Mathf.RoundToInt(Time.timeSinceLevelLoad).ToString ();	//converts to string since time is a float
		gameOver = true;
	}
}
