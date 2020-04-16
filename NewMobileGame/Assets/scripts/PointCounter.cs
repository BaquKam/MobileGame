using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices.ComTypes;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class PointCounter : MonoBehaviour
{
    public Text pointText;
    private int points = 0;
    void Update()
    {
        pointText.text = "scare:" + points.ToString();
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if(other.gameObject.tag == "Box")
        {
            points += 1;
            Destroy(other.gameObject);
        }
    }

    public void RestartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
