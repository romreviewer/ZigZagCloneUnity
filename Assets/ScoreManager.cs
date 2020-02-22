using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreManager : MonoBehaviour
{
    // Start is called before the first frame update
    public static ScoreManager instance;
    public int score;
    private void Awake() {
        if(instance==null)
        {
            instance=this;
        }
    }
    void Start()
    {
        score=0;
        PlayerPrefs.SetInt("score",score);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void incrementScore()
    {
        score+=1;
    }
    public void startScore()
    {
        InvokeRepeating("incrementScore",0.1f,0.5f);
    }
    public void StopScore()
    {
        CancelInvoke("incrementScore");
        PlayerPrefs.SetInt("score",score);
        if(PlayerPrefs.HasKey("highScore"))
        {
            if(score>PlayerPrefs.GetInt("highScore"))
            {
                PlayerPrefs.SetInt("highScore",score);
            }
        }
        else{
            PlayerPrefs.SetInt("highScore",score);
        }
    }
}
