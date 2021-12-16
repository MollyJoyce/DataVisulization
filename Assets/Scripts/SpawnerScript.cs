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
    




    


    


   
    void Start(){

        
        
       
       
        






       for (int i = 0; i < total; i++){

                
            NavMeshAgent ag = Instantiate(agent);
            

            float typenum = Random.Range(1f,100f);

            if (typenum <= 50f){
                ag.tag = "Z";
                ag.GetComponent<Renderer>().material = TOneMat;
                
                float destnum = Random.Range(1f, 100f);
                 if (destnum <= 20){
                     ag.SetDestination(Dest.position);
                 } else if (destnum <= 40){
                     ag.SetDestination(Dest1.position);
                 } else if (destnum <= 60){
                     ag.SetDestination(Dest2.position);
                 } else if (destnum <= 80){
                     ag.SetDestination(Dest3.position);
                 } else if (destnum <= 100){
                     ag.SetDestination(Dest4.position);
                 }
                 //Destroy(ag);
                // ag.GetComponent<Renderer>().enabled = false;

            } else {
                ag.tag = "X";
                ag.GetComponent<Renderer>().material = TTwoMat;
                
                float destnum = Random.Range(1f, 100f);
                 if (destnum <= 20){
                     ag.SetDestination(Dest.position);
                     //DataCount.OXCount++;
                 } else if (destnum <= 40){
                     ag.SetDestination(Dest1.position);
                 } else if (destnum <= 60){
                     ag.SetDestination(Dest2.position);
                 } else if (destnum <= 80){
                     ag.SetDestination(Dest3.position);
                 } else if (destnum <= 100){
                     ag.SetDestination(Dest4.position);
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
        OX.text = Mathf.Round((DataCount.OXCount / total)*100).ToString() + "% X";
        THX.text = Mathf.Round((DataCount.THXCount / total)*100).ToString() + "% X";
        FX.text = Mathf.Round((DataCount.FXCount / total)*100).ToString() + "% X";
        FIX.text = Mathf.Round((DataCount.FIXCount / total)*100).ToString() + "% X";

}

}
    
