unsing System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

pubclic class playGame :  MonoBehaviour{
  public void StartGame(){
    SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1); // remember to go to file -> build settings and order your scenes
  }
  public void QuitGame(){
    Application.Quit();
  }
}
