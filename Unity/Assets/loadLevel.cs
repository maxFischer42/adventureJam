using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class loadLevel : MonoBehaviour {


    public string level;
    public void LoadLevel()
    {
        SceneManager.LoadScene(level);
    }


}
