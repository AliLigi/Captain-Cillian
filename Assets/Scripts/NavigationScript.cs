using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class NavigationScript : MonoBehaviour {

   // public GameObject waveFact;
   // public GameObject starfishFact;

    // Manages the navigations between different scenes
    public void loadExploreScene() {
       SceneManager.LoadScene("Explore");
    }

    public void loadMainMenu() {
        SceneManager.LoadScene("MainMenu");
    }

    public void loadLearnScene() {
        SceneManager.LoadScene("Learn");
    }

    public void loadCreateScene() {
        SceneManager.LoadScene("Create");
    }
    public void loadMatchUp()
    {
        SceneManager.LoadScene("Main");
    }
    public void loadslidingpuzzle()
    {
        SceneManager.LoadScene("PM Sliding Pieces Example");
    }
    public void loadpickAndPlacepuzzle()
    {
        SceneManager.LoadScene("PM Pick And Place Example");
    }
    public void loadjoinpuzzle()
    {
        SceneManager.LoadScene("PM Join Pieces Example");
    }

    /* public void loadFunScene() {
         SceneManager.LoadScene("Fun");
     }*/
    public void websiteBook1()
    {
        Application.OpenURL("http://www.captaincillian.com/store/p2/Stormy_Sea_Adventure.html");
    }
    public void websiteBook2()
    {
        Application.OpenURL("http://www.captaincillian.com/store/p4/Surfing_Adventure.html");
    }
    public void websiteBook3()
    {
        Application.OpenURL("http://www.captaincillian.com/store/p5/Hidden_Caves_Adventure.html");
    }

    /*public void enableDisableText()
    {
        //waveFact.gameObject.GetComponent<Text>().enabled = true;
        starfishFact.gameObject.GetComponent<Text>().enabled = true;
    }*/
}
