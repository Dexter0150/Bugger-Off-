using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Frog : MonoBehaviour
{
    public string names;

    public float fireRate = 1;
    public float radius = 1;

    public int damage = 1;
    public float speed = 11;

    public int cost = 15;
    public GameObject radiusDisplay;
    public Projectile proj;
    public GameObject mesh;

    private void fire(Bug b)
    {
        float dist = Vector2.Distance(transform.position, b.transform.position);
        Vector2 prediction = (Vector2)b.transform.position - (b.velocity * dist / speed) * 2;
        transform.up = (prediction - (Vector2)transform.position);
        Projectile p = Instantiate(proj, transform.position, transform.rotation);
        p.parent = this;
    } 
}
