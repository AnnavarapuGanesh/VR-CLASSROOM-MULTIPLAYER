using System;
using UnityEngine;
using UnityEngine.SceneManagement; 

public class connectTochatbot : MonoBehaviour
{
    public void loadScene(String sceneName){
        SceneManager.LoadScene(sceneName);
    }
}
