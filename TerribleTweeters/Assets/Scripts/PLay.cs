using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PLay : MonoBehaviour
{
    [SerializeField] string _nextLevelName; 
    [SerializeField] string _nextLevelName1; 

    public void GoToLevel()
    {
        SceneManager.LoadScene(_nextLevelName);
    }

    public void GoToStart()
    {
        SceneManager.LoadScene(_nextLevelName1);
    }
}
