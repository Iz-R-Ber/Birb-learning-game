using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Game_logic : MonoBehaviour
{

    public GameObject GameOverScreen; 
    public bool canmod = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private int score;
    public Text theText;

    [ContextMenu("increase score")]
    public void AddScore()
    {
        score++;
        theText.text = score.ToString();
    }
    public void restGame() {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    [ContextMenu("Game over")]
    public void gameOver() {
       GameOverScreen.SetActive(true);
    }
}
