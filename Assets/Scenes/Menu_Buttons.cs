using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu_Buttons : MonoBehaviour
{
    // Start is called before the first frame update
    public void LoadScene()
    {
        //loads the scene1 using the method called LoadScene
        SceneManager.LoadScene("CarRace");
    }
}
