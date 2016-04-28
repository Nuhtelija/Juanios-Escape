using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour {

	public string startLevel;

	public void NewGame(){
		SceneManager.LoadScene (startLevel);

	}

	public void QuitGame() {
		Application.Quit ();
	}


}
