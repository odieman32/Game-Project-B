using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MapSelect : MonoBehaviour
{
    //This code loads the correct scene in the Map Selector panel by using Map name and their build ID
    public void OpenLevel(int mapID)
    {
        string mapName = "Map " + mapID;
        SceneManager.LoadScene(mapName);
    }
}

//https://www.youtube.com/watch?v=2XQsKNHk1vk&t=295s by Rehope Games