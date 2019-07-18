using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;


public class LevelManager : MonoBehaviour
{

    public void LoadLevel(string name)
    {
       
        Debug.Log("New Level load: " + name);
        Brick_01.brickCount = 0;
        SceneManager.LoadScene(name);
        
    }

    public void QuitRequest()
    {
        Debug.Log("Quit requested");
        Application.Quit();
    }

    public void BrickDestroy()
    {
        if(Brick_01.brickCount<=0)
        {
          
            LoadNextScene();
        }

    }

    public void LoadNextScene()
    {

        int current_index = SceneManager.GetActiveScene().buildIndex;
        Brick_01.brickCount = 0;
        SceneManager.LoadScene(current_index + 1);
    }

}
