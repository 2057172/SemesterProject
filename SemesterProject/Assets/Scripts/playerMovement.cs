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

    //public int fuel = 2;
    public float totalVelocity;

    public float fuel = 1;
    public float consumption = 0.01f;

    // Timer controls
    private float startTime = 0f;
    private float timer = 0f;
    public float holdTime = 2.0f; // how long you need to hold to trigger the effect

    // Use if you only want to call the method once after holding for the required time
    private bool held = false;

    public string key = "w"; // Whichever key you're using to control the effects. Just hardcode it in if you want


    void Start()
    {
        currentHealth = maxHealth;
        Health_And_Fuel.setMaxHealth(maxHealth);

       currentFuel = maxFuel;
       Health_And_Fuel.setMaxFuel(maxFuel);
    }

    

    void Update()
    {
        //   if (Input.GetKeyDown(KeyCode.W))
        // {
        //   currentFuel -= fuel;
        // Health_And_Fuel.setCurrentFuel(currentFuel);

        //if (currentFuel < 0)
        //{
        //  currentFuel = 0;
        //}
        //}

             // Starts the timer from when the key is pressed
        if (Input.GetKeyDown(key))
        {
            startTime = Time.deltaTime;
            timer = startTime;
           
            currentFuel -= 5;
                Health_And_Fuel.setCurrentFuel(currentFuel);

        }

        // Adds time onto the timer so long as the key is pressed
        if (Input.GetKey(key) && held == false)
        {
            timer += Time.deltaTime;

            // Once the timer float has added on the required holdTime, changes the bool (for a single trigger), and calls the function
            if (timer > (startTime + holdTime))
            {
                held = true;
                ButtonHeld();
            }
        }
        if (Input.GetKeyUp(key))
        {
            held = false;
            //currentFuel -= fuel;
            Health_And_Fuel.setCurrentFuel(currentFuel);
        }

    }

    // Method called after held for required time
    void ButtonHeld()
    {

        //currentFuel -= fuel;
        Health_And_Fuel.setCurrentFuel(currentFuel);
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

    private void OnCollisionEnter2D(Collision2D collision)
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

        fuel -= consumption * Mathf.Abs(rb.velocity.x + rb.velocity.y) * Time.fixedDeltaTime;
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
