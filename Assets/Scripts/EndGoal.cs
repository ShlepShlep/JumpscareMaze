using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EndGoal : MonoBehaviour
{
    public string nextSceneName;
    void OnMouseEnter()
    {
        if(nextSceneName != "")
        {
            SceneManager.LoadScene(nextSceneName);
        }
    }
}
