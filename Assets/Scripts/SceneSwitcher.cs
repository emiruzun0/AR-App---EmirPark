using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneSwitcher : MonoBehaviour
{
    public void switchSecond(){
    	SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1 );
    }

    public void switchThree(){
    	SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1 );
    }

    public void switchMain(){
    	SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 2 );
    }
}
