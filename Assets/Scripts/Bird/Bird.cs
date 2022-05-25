using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(BirdMover))]
public class Bird : MonoBehaviour
{
    private BirdMover _mover;
    private int _score;

    public void IncreaseScore()
    {
        _score++;
    }

    public void ResetPlayer()
    {
        _score = 0;
        _mover.ResetBird();
    }

    public void Die()
    {
        Time.timeScale = 0;
    }

    private void Start()
    {
        _mover = GetComponent<BirdMover>();
    }
}
