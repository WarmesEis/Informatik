using Unity.VisualScripting;
using UnityEngine;

public class WaffeScript : MonoBehaviour

{
    public GameObject Waffe; // In unitz das objekt waffe reinziehen
    public Collider2D Trigger;
    public Collider2D Player;
    public bool PlayerhasWaffe = false;
    public float time;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        Timer();
        
        if (PlayerhasWaffe == true){ //zerstoert die aufm boden liegende waffe, wenn sie aufgesammelt wird
            Destroy(Waffe);
            time=0;
        }
        else if (time >= 9){ //Zerstoert die waffe nach 9 sekunden, um platz zu schaffen
            Destroy(Waffe);
            time =0;
        }
    }

    void OnTriggerEnter2D(Collider2D Player){ //Wenn der collider des spielers mit dem trigger der waffe collidiert, wird der bolean wert geaendert und die Waffe despawnt
        PlayerhasWaffe = true;
    }

    void Timer(){
            time = time + Time.deltaTime; //Time/deltaTime stellt sicher, dass es unabhaengig von der framerate hochzaelt
    }
    }
