using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public int score = 0;
    public HUDManager hud;
    public GameData gm;

    #region Singleton
    public static GameManager Instance;

    void Awake()
    {
        if (!Instance)
        {
            Instance = this;
        }
        else
        {
            Destroy(this.gameObject);
        }
    }
    #endregion

    private void Start()
    {
        score = PlayerPrefs.GetInt("ponto");
    }

    public void SetScore(int value)
    {
        gm.score += value;
        hud.ChangeScore(gm.score);
    }

    public void LoadScene(string sceneName)
    {
        SceneManager.LoadScene(sceneName);
    }
}
