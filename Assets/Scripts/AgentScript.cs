using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class AgentScript : MonoBehaviour
{
    public NavMeshAgent self;

    public Transform Dest;
    public Transform Dest1;
    public Transform Dest2;
    public Transform Dest3;
    public Transform Dest4;

    

    void OnTriggerEnter(Collider other){
       if (other.gameObject.CompareTag ("Destination")){
             Destroy(gameObject, 3f);

        if (this.gameObject.CompareTag ("X")){
          DataCount.XCount++;

          if(self.destination == Dest.position){
            DataCount.OXCount++;
          }
       }

       if (this.gameObject.CompareTag ("Z")){
          DataCount.ZCount++;
        }

      
    }
}
}

