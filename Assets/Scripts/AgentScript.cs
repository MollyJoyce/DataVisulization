using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class AgentScript : MonoBehaviour
{

    public NavMeshAgent agent;
    
    public Transform Dest;
    public Transform Dest1;
    public Transform Dest2;
    public Transform Dest3;
    public Transform Dest4;

    int wait = 0;


    
//TESTTTTTT
   

    void Start(){

        if(wait = 5){
            agent = this.GetComponent<NavMeshAgent>();

        Instantiate(agent); 

        int AssignNum = UnityEngine.Random.Range(0f,100f);


        if(agent.gameObject.CompareTag ("Type1")){
            if(AssignNum < 50){
             agent.SetDestination(Dest4.position);
        } else {
            agent.SetDestination(Dest3.position);
        }
    }
        }
        //agent = this.GetComponent<NavMeshAgent>();

       // Instantiate(agent); 

        //int AssignNum = UnityEngine.Random.Range(0,100);

        //if(agent.gameObject.CompareTag ("Type1")){
             //agent.SetDestination(Dest4.position);
    

        //if(agent.gameObject.CompareTag ("Type1")){
            
            // agent.SetDestination(Dest4.position);
        }
    
    
    
    
        
       
    
    }

