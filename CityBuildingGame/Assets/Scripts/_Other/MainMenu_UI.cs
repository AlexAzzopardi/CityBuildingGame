using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MainMenu_UI : MonoBehaviour {

    //Reference to button
    public Button button_play;
    public Button button_exit;
	
	// Update is called once per frame
	void Update ()
    {
        //When button is clicked call the method.
        button_play.onClick.AddListener(Play_Game);
        button_exit.onClick.AddListener(Exit_Game);
	}

    void Play_Game()
    {
        //Load level "Game_Level"
        Application.LoadLevel("Game_Level");
    }

    void Exit_Game()
    {
        //Exits the game
        Application.Quit();
        print("Exits Game");
    }
}
