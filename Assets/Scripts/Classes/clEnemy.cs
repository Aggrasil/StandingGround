using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class clEnemy : MonoBehaviour
{
    //Parent class for all enemy objects
    //Variables begin
    protected int health;
    protected bool isDead = false;
    protected float speed = 1.0f;
    protected float range = 1.0f;
    protected Vector3 targetMove;
    //Variables end

    //Properties begin
    public int Health { get; set; }
    public bool IsDead { get; set; } 
    public Vector3 TargetMove { get; set; }
    public float Speed { get; set; }
    //Properties end

    //Methods begin
    virtual public void ApplyDamage()
    { }
    //Methods end
}
