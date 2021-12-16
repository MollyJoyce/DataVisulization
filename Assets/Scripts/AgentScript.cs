using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class AgentScript : MonoBehaviour
{
  

    void OnTriggerEnter(Collider other){
       // if (other.gameObject.CompareTag ("Destination")){
             Destroy(gameObject);
      // }

      if (this.gameObject.CompareTag ("X")){
        DataCount.XCount++;
        if (this.NavMeshAgent.Destination == SpawnerScript.Dest){
          DataCount.OXCount++;
        }
    }

      
    }
}

