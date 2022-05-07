using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public static GameManager manager;

    public Slider barrahp;
    private int score;
    public Text scoreText;

    public GameoverScreen GameOverScreen;
    private void Awake()
    {
        manager = this;
        score = 0;
        UpdatedScore();
    }

    public int vidas;
   public void GameOver()
    {
        print("EndGame");
        GameOverScreen.Setup(score);
    }


    public void WinGame()
    {

    }

    public void ResetearJuego()
    {

    }

    public void QuitarVidas()
    {
        vidas--;
        barrahp.value = vidas;

        if(vidas < 1)
        {
            GameOver();
            //Over.Show();
        }
    }

    void UpdatedScore()
    {
        scoreText.text = "Score: " + score;
    }

    public void AddScore(int puntajesumaar)
    {
        score += puntajesumaar;
        UpdatedScore();
    }

}
