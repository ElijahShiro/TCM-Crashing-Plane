using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    //public Text text;

    public float totalPoints;

    private void Update()
    {
        //text.text = text.text + totalPoints;
        Debug.Log("Punts: " + totalPoints);
    }

    public void SumPoints(float points)
    {
        totalPoints += points;
    }


}
