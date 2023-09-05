using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bug : MonoBehaviour
{
    public float speed = 1.5f;
    public int damage = 1;
    public int health = 3;
    public int worth = 5;
    public Bug[] children;
    public Vector2 velocity;
}
