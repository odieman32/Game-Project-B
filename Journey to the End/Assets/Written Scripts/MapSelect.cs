using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MapSelect : MonoBehaviour
{
    public void OpenLevel(int mapID)
    {
        string mapName = "Map " + mapID;
        SceneManager.LoadScene(mapName);
    }
}

//https://www.youtube.com/watch?v=2XQsKNHk1vk&t=295s by Rehope Games