using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class UIControl : MonoBehaviour
{
    public GameObject end;
    public Text scoreText;
    float cumulativeScore = 0;
    public void CumulativeScore(float num)
    {
        cumulativeScore += num;
        scoreText.text = "" + Mathf.Round(cumulativeScore);
    }
    public void End()
    {
        end.SetActive(true);
    }
    public void Button_Reset()
    {
        SceneManager.LoadScene("SampleScene");
    }
}
