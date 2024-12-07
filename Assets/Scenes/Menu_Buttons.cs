using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu_Buttons : MonoBehaviour
{
    // Start is called before the first frame update
    public void Main_Menu()
    {
        //loads the scene1 using the method called LoadScene
        SceneManager.LoadScene("Main_Menu");
    }

    public void LoadChooseCar()
    {
        //loads the scene1 using the method called LoadScene
        SceneManager.LoadScene("ChooseCar");
    }
    public void LoadCarRace1()
    {
        //loads the scene1 using the method called LoadScene
        SceneManager.LoadScene("CarRace1");
    }
    public void LoadPlayerSelection()
    {
        //loads the scene1 using the method called LoadScene
        SceneManager.LoadScene("PlayerSelection");
    }
    public void LoadInstructions()
    {
        //loads the scene1 using the method called LoadScene
        SceneManager.LoadScene("Instructions");
    }
    public void LoadCredits()
    {
        //loads the scene1 using the method called LoadScene
        SceneManager.LoadScene("Credits");
    }
}
