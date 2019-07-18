using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class SenceLoader : MonoBehaviour {


    public static void LoadNextScene()
    {
        int current_index = SceneManager.GetActiveScene().buildIndex;
        SceneManager.LoadScene(current_index + 1);



    }

    public void LoadFirstScene()
    {
      
        SceneManager.LoadScene(0);



    }



}
