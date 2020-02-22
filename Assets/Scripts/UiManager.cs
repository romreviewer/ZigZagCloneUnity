using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class UiManager : MonoBehaviour
{
    public static UiManager instance;
    public GameObject zigzagPannel;
    public GameObject gameOverPanel;
    public GameObject tapText;
    public Text score;
    public Text highScore1;
    public Text highScore2;
    // Start is called before the first frame update
    private void Awake() {
        if(instance==null)
        {
            instance=this;
        }
    }
    void Start()
    {
        highScore1.text="High Score: "+PlayerPrefs.GetInt("highScore").ToString();

    }
    public void GameStart()
    {
        tapText.SetActive(false);
        zigzagPannel.GetComponent<Animator>().Play("panelUp");
    }
    public void GameOver()
    {
        score.text=PlayerPrefs.GetInt("score").ToString();
        highScore2.text= PlayerPrefs.GetInt("highScore").ToString();
        gameOverPanel.SetActive(true);
    }
    public void Reset()
    {
        SceneManager.LoadScene(0);
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
