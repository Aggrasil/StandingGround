using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class clProjectile : MonoBehaviour
{
    //Variables begin
    protected float velocity = 10.0f;
    protected int damage;
    protected bool explosive = false;
    protected bool magic = false;

    //Variables end

    //Properties begin
    public float Velocity { get; set; }
    public int Damage { get; set; }
    public bool Explosive { get; set; }
    public bool Magic { get; set; }
    //Properties end

    //methods begin
    virtual public void ApplyDamage()
    { }
    //methods end
}
