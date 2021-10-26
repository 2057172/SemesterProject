using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerMovement : MonoBehaviour
{

    [Header("Ship Settings")]
    public float driftFactor = 0.95f;
    public float accelerationFactor = 30.0f;
    public float turnFactor = 3.5f;
    public float maxSpeed = 20f;

    float accelerationInput = 0;
    float steeringInput = 0f;

    float rotationAngle = 0f;

    float velocityVsUp = 0f;

    Rigidbody2D rb;


    //FUEL AND HEALTH STATS
    public health_and_fuel Health_And_Fuel;

    public int maxHealth = 100;
    public int currentHealth;
    public int shipDamage = 10;

    public int maxFuel = 100;
    public int currentFuel;
    public int fuel = 2;
    public float totalVelocity;

    void Start()
    {
        currentHealth = maxHealth;
        Health_And_Fuel.setMaxHealth(maxHealth);

        currentFuel = maxFuel;
        Health_And_Fuel.setMaxFuel(maxFuel);
    }


    void Update()
    {
        if (Input.GetKeyDown(KeyCode.W))
        {
            currentFuel -= fuel;
            Health_And_Fuel.setCurrentFuel(currentFuel);

            if (currentFuel < 0)
            {
                currentFuel = 0;
            }
        }
        totalVelocity = rb.velocity.x + rb.velocity.y;
       
    }

    void ShipCollision()
    {
        currentHealth -= shipDamage;
        Health_And_Fuel.setCurrentHealth(currentHealth);
        if (currentHealth < 0)
        {
            currentHealth = 0;
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Collision")
        {
            ShipCollision();
        }
    }
    /////
    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
    }
    public void FixedUpdate()
    {
        ApplyEngineForce();
        killOrthogonalVelocity();
        ApplySteeringForce();
    }
    void ApplyEngineForce()
    {
        velocityVsUp = Vector2.Dot(transform.up, rb.velocity);

        if (velocityVsUp > maxSpeed && accelerationInput > 0)
        {
            return;
        }
        if (velocityVsUp < -maxSpeed * 0.5f && accelerationInput < 0)
            return;
        if (rb.velocity.sqrMagnitude > maxSpeed * maxSpeed && accelerationInput > 0)
            return;

        if (accelerationInput == 0)
        {
            rb.drag = Mathf.Lerp(rb.drag, 3.0f, Time.fixedDeltaTime * 3);
        }
        else rb.drag = 0;

        Vector2 engineForceVector = transform.up * accelerationInput * accelerationFactor;

        rb.AddForce(engineForceVector, ForceMode2D.Force);
    }
    void ApplySteeringForce()
    {
        rotationAngle -= steeringInput * turnFactor;
        rb.MoveRotation(rotationAngle);
    }

    public void killOrthogonalVelocity()
    {
        Vector2 forwardVelocity = transform.up * Vector2.Dot(rb.velocity, transform.up);
        Vector2 rightVelocity = transform.right * Vector2.Dot(rb.velocity, transform.right);

        rb.velocity = forwardVelocity + rightVelocity * driftFactor;
    }

    public void SetInputVector(Vector2 inputVector)
    {
        steeringInput = inputVector.x;
        accelerationInput = inputVector.y;
    }


}
