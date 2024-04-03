using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinCollector : MonoBehaviour
{
    public float points;

    public GameManager gameManager;

    private void OnTriggerEnter2D(Collider2D collision)
    {

        if (collision.GetComponent<MovebyVelocity>())
        {
            gameManager.SumPoints(points);
            Destroy(this.gameObject);
        }
    }
}
