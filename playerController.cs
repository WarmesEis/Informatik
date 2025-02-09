using Unity.VisualScripting;
using UnityEngine;

public class playerController : MonoBehaviour
{

                                
    [Header ("Bewegungssystem")]                            //Deklarierungen und Variablen fürs nach links und rechts bewegen
    [SerializeField] private float _speed = 100f;           //Geschwindigkeit
    private float _horizontalInput;                         //deklarierung von inputs



    private Rigidbody2D _rb;                                //der rigidbody ist der Teil des spielers der bewegt wird



    Vector2 vecGravity;                                     //Deklarierung einer Gravitationsvariable
                                                            //Vector2 wird verwendet um einfache Positionen und Bewegungen im 2-Dimensionalem Raum darzustellen

                                
    [Header ("Jump System")]                                //Deklarierungen und Variablen fürs springen    
    [SerializeField] float jumpTime;                        //variable, wie schnell der spieler springen kann
    [SerializeField] float jumpMultiplier;                  //variable, wie hoch der spieler springen kann
    [SerializeField] public float jumpHeight = 6.5f;        //Variable für Höhe des Sprunges
    bool isJumping;                                         //ist der Spieler am springen???
    float jumpCounter;                                      //Variable, um den Spieler bis zur einer bestimmten Distanz nach oben befördert
    [SerializeField] float fallMultiplier;                  //Variable, wie schnell der Spieler nach dem Höhepunkt des Sprungs wieder runterfällt
    [SerializeField] private Transform _groundCheck;        //Variable um zu gucken, ob der spieler den boden berührt
    public LayerMask _groundLayer;                          //Layer für den Boden des Spielers




    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {   
        
        vecGravity = new Vector2(0, -Physics.gravity.y);    // Hier wird die Gravitationsvariable initialisiert
        _rb = GetComponent<Rigidbody2D>();                  //greife auf den rigidbody komponenten zu
    }

    private void FixedUpdate(){
        //Input und Velocity(bewegung nach links und rechts)
        _horizontalInput = Input.GetAxisRaw("Horizontal");                              //Die Tasten a und d werden initialisiert //GetAxisRaw sorgt für den Input, die Werte, die da aufgerufen werden sind -1, 0 oder 1
        float horizontalMovement = _horizontalInput * _speed * Time.deltaTime;          //eine neue variable die horizontalmovement heißt wird geschaffen
        _rb.linearVelocity = new Vector2(horizontalMovement, _rb.linearVelocity.y);     // der rigidbody wird dann 2-dimensionalem Vector um die Werte innerhalb der klammern bewegt

    }


    // Update is called once per frame
    void Update()
    {   

        if (Input.GetButtonDown("Jump") && isGrounded()){
            _rb.linearVelocity = new Vector2(_rb.linearVelocity.x, jumpHeight);
            isJumping = true;
            jumpCounter = 0;
        }

        if (_rb.linearVelocity.y < 0){
            _rb.linearVelocity -= vecGravity * fallMultiplier * Time.deltaTime;
        }

        if (_rb.linearVelocity.y > 0 && isJumping){
            jumpCounter += Time.deltaTime;

            float t = jumpCounter / jumpTime;
            float currentJumpM = jumpMultiplier;

            if (t > 0.5f){
                currentJumpM = jumpMultiplier * (1 - t);
            }

            if (jumpCounter > jumpTime) isJumping = false;
            _rb.linearVelocity += vecGravity * currentJumpM * Time.deltaTime;
        }

        if (Input.GetButtonUp("Jump")){
            isJumping = false;
        }
    }

    bool isGrounded(){                                                                  //befindet sich unser spieler auf dem boden?
        return Physics2D.OverlapCapsule(_groundCheck.position, new Vector2(1.8f, 0.3f), CapsuleDirection2D.Horizontal, 0, _groundLayer);
        
    }
}
