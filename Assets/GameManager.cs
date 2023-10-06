using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public GameObject player;

    public GameObject gameOverScreen;
    // Start is called before the first frame update

    void Awake()
    {
        Time.timeScale = 1;
    }

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (!player)
        {
            Time.timeScale = 0;
            gameOverScreen.SetActive(true);
        }
    }

    public void Restart()
    {
        SceneManager.LoadScene("Game");
    }
}
