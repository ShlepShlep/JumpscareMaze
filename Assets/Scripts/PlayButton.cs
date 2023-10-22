using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayButton : MonoBehaviour
{
    public GameObject startScreen;
    public GameObject player;
    void OnMouseDown()
    {

    }

    void OnMouseUp()
    {
        startScreen.SetActive(false);
        player.SetActive(true);
    }
}
