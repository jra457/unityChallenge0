using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreManager : MonoBehaviour
{
    public int score;

    public void increaseScore (int amount)
    {
        score += amount;
    }
}
