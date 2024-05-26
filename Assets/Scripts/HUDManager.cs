using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class HUDManager : MonoBehaviour
{
    public TMP_Text txtScore;
    public GameData gm;

    private void Start()
    {
        txtScore.text = gm.score.ToString();
    }

    public void ChangeScore(int ponto)
    {
        txtScore.text = ponto.ToString();
    }
}
