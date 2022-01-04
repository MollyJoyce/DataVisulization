using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using TMPro;
using static UnityEngine.Mathf;

public class SpawnerScript : MonoBehaviour
{

    

    [SerializeField]
    NavMeshAgent agent;
    
    NavMeshAgent[] agents;

    public Transform Dest;
    public Transform Dest1;
    public Transform Dest2;
    public Transform Dest3;
    public Transform Dest4;

    public Material TOneMat;
    public Material TTwoMat;

    public float total = 20;


    public TextMeshProUGUI OX;
    public TextMeshProUGUI TX;
    public TextMeshProUGUI THX;
    public TextMeshProUGUI FX;
    public TextMeshProUGUI FIX;

    public TextMeshProUGUI OZ;
    public TextMeshProUGUI TZ;
    public TextMeshProUGUI THZ;
    public TextMeshProUGUI FZ;
    public TextMeshProUGUI FIZ;

   

   
    void Start(){

        

       for (int i = 0; i < total; i++){

                
            NavMeshAgent ag = Instantiate(agent);
            

            float typenum = Random.Range(1f,100f);

            if (typenum <= 50f){
                ag.tag = "Z";
                ag.GetComponent<Renderer>().material = TOneMat;
                
                float destnum = Random.Range(1f, 100f);
                 if (destnum <= 9){
                     ag.SetDestination(Dest.position);
                     DataCount.OZCount++;
                 } else if (destnum <= 46){
                     ag.SetDestination(Dest1.position);
                     DataCount.TZCount++;
                 } else if (destnum <= 75){
                     ag.SetDestination(Dest2.position);
                     DataCount.THZCount++;
                 } else if (destnum <= 91){
                     ag.SetDestination(Dest3.position);
                     DataCount.FZCount++;
                 } else if (destnum <= 100){
                     ag.SetDestination(Dest4.position);
                     DataCount.FIZCount++;
                 }
                 //Destroy(ag);
                // ag.GetComponent<Renderer>().enabled = false;

            } else {
                ag.tag = "X";
                ag.GetComponent<Renderer>().material = TTwoMat;
                
                float destnum = Random.Range(1f, 100f);
                 if (destnum <= 32){
                     ag.SetDestination(Dest.position);
                     DataCount.OXCount++;
                 } else if (destnum <= 61){
                     ag.SetDestination(Dest1.position);
                     DataCount.TXCount++;
                 } else if (destnum <= 85){
                     ag.SetDestination(Dest2.position);
                     DataCount.THXCount++;
                 } else if (destnum <= 96){
                     ag.SetDestination(Dest3.position);
                     DataCount.FXCount++;
                 } else if (destnum <= 100){
                     ag.SetDestination(Dest4.position);
                     DataCount.FIXCount++;
                 }
            }                
        }

         
        
              }

               void OnTriggerEnter(Collider other){
                for (int h = 0; h < agents.Length; h++){
                if (other.gameObject.CompareTag ("Destination")){
                    Destroy(agents[h]);
                }
                }
            }
                
            
    


    void Update () {
        OX.text = Mathf.Round((DataCount.OXCount / total)*100).ToString() + "% R";
        TX.text = Mathf.Round((DataCount.TXCount / total)*100).ToString() + "% R";
        THX.text = Mathf.Round((DataCount.THXCount / total)*100).ToString() + "% R";
        FX.text = Mathf.Round((DataCount.FXCount / total)*100).ToString() + "% R";
        FIX.text = Mathf.Round((DataCount.FIXCount / total)*100).ToString() + "% R";

        OZ.text = Mathf.Round((DataCount.OZCount / total)*100).ToString() + "% P";
        TZ.text = Mathf.Round((DataCount.TZCount / total)*100).ToString() + "% P";
        THZ.text = Mathf.Round((DataCount.THZCount / total)*100).ToString() + "% P";
        FZ.text = Mathf.Round((DataCount.FZCount / total)*100).ToString() + "% P";
        FIZ.text = Mathf.Round((DataCount.FIZCount / total)*100).ToString() + "% P";


}

}
    
