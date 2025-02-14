using UnityEngine;

public class Lebensanzeigescript : MonoBehaviour
{
    
    public GameObject L1;
    public GameObject L2;
    public GameObject L3;
    public int leben = 3;

    //public bulletscript Bulletscript;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
     if (leben == 2){
        Destroy(L3);
     }
     if (leben == 1){
        Destroy(L2);
     }
     if (leben == 0){
        Destroy(L1);
     }

     /*if (Bulletscript.leben == 2){
        Destroy(L3);
     }
     if (Bulletscript.leben == 1){
        Destroy(L3);
     }
     if (Bulletscript.leben == 0){
        Destroy(L3);
     }*/
     
        }
}
