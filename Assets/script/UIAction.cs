using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UIAction : MonoBehaviour
{
    
    public void QuitGame(){
    #if UNITY_EDITOR
            UnityEditor.EditorApplication.isPlaying=false;
    #else
            Application.Quit();
    #endif
    }
    public void PlayGame(){
        SceneManager.LoadScene(1);
    }
}
