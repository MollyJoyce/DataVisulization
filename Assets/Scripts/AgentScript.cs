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

    public int wait = 0;


    


   
   void Start(){

        
        agent = this.GetComponent<NavMeshAgent>();

        

        //int AssignNum = UnityEngine.Random.Range(0,100);

        if(agent.gameObject.CompareTag ("Type1")){
             agent.SetDestination(Dest4.position);
    

        if(agent.gameObject.CompareTag ("Type2")){
            
             agent.SetDestination(Dest3.position);
        }

        
        }

        Instantiate(agent); 
   }
   
    
    
   /* 
    void Update {

        if(wait == 5) {
            agent = this.GetComponent<NavMeshAgent>();

        Instantiate(agent); 

        int AssignNum = UnityEngine.Random.Range(1,2);


        if(agent.gameObject.CompareTag ("Type1")){
            if(AssignNum < 2f){
             agent.SetDestination(Dest4.position);
        } else {
            agent.SetDestination(Dest3.position);
        }
        wait = 0;
    } 
        } else {
            wait++;
        }
    }
    
       */ 
       
    
    }

