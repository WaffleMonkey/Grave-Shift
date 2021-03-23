using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class mainMenu : MonoBehaviour
{
    public void startGame ()
        
    {
        SceneManager.LoadScene("Edward"); //Change to your name if you want the pause menu ability in your scene
        //SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1); 
        // menu will be indext 0 and the main scene is index 1 in build settings
    }

}
