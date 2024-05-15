using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UIElements;

public class MenuMenedger : MonoBehaviour
{
    public GameObject storiButton;
    public GameObject Options;

    private bool setActiviti = false;
    public void PlayGame()
    {
        SceneManager.LoadScene("Game");
    }

    public void ExitGame()
    {
        Application.Quit();
    }

    public void OptionsButton()
    {    
        if(setActiviti == false)
        { 
            Options.SetActive(true);
            setActiviti = true;
        } 
       else
        {
            Options.SetActive(false);
            setActiviti= false;
        }    
            
        
    }
}
