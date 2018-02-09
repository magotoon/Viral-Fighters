using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Bullet : MonoBehaviour
{
    protected float speed;
    public float speedModifier = 2.0f;
    public LayerMask collisionMask;

    public GameObject Owner { get; private set; }
    public Vector2 Direction { get; private set; }
    public float BaseSpeed { get; private set; }

    public void Initialize(GameObject owner, Vector2 direction, float baseSpeed)
    {
        Owner = owner;
        Direction = direction;
        BaseSpeed = baseSpeed;
        OnInitialized();
    }

    protected virtual void OnInitialized()
    {
        speed = BaseSpeed * speedModifier;
    }

    //write collision clauses
    //check 2d unity tutorial for finishing class
}
