using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class clCharacter : MonoBehaviour
{
    //Parent class for all player characters
    // Variables begin
    [SerializeField]
    protected GameObject projectile;
    protected int health;
    protected float minRange = 0.0f;
    protected float maxRange;
    protected float shootFrequency = 1.0f;
    protected int amountProjectiles = 1;
    protected bool isDead = false;
    protected Vector3 targetShoot;
    protected bool isChosen = false;
    //Variables end

    //Properties begin
    public int Health { get; set; }
    public bool IsDead { get; set; }
    public bool IsChosen { get; set; }
    public Vector3 TargetShoot { get; set; }
    public float MinRange { get; set; }
    public float MaxRange { get; set; }
    public float ShootFrequency { get; set; }
    public int AmountProjectiles { get; set; }
    //Properties end
}
