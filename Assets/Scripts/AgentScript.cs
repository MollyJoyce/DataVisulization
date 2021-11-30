

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class AgentScript : MonoBehaviour
{

    public NavMeshAgent agent;
    
    NavMeshAgent[] agents;

    public Transform Dest;
    public Transform Dest1;
    public Transform Dest2;
    public Transform Dest3;
    public Transform Dest4;

    


    


   
   void Start(){

        
        agent = this.GetComponent<NavMeshAgent>();


         if(agent.CompareTag ("Spawn")){

            for(int i = 0; i < 20; i++){
            
            NavMeshAgent ag = agents[i] = Instantiate(agent);
            ag.tag = "Clone";
            float typenum = Random.Range(1f,100f);
            
            if(typenum <= 50){
                ag.tag = "Z";
            } else {
                ag.tag = "X";
            }

            }

           
            
         }

         
        
        }
   }

        
   
   
    
    
  
    
    

