using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class NavigationScript : MonoBehaviour {

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
    public void loadOceanAnimal()
    {
        SceneManager.LoadScene("oceanAnimals");
    }

    public void loadFunScene() {
        SceneManager.LoadScene("Fun");
    }
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
}
