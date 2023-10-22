using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ReplayButton : MonoBehaviour
{
    public string firstScene;
    public GameObject startScreen;
    void OnMouseDown()
    {

    }

    void OnMouseUp()
    {
        SceneManager.LoadScene(firstScene);
        startScreen.SetActive(true);

    }
}
