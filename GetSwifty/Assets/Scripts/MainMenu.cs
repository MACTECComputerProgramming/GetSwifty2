using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour {

    //Used by buttons to progress the scenes once
	public void PlayGame(){
		SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
	}

    //Used by buttons when the player dies or wins
    public void Restart()
    {
        SceneManager.LoadScene(2);
    }

}
