using UnityEngine;
using UnityEngine.AI;
public class EnemyChase : MonoBehaviour
{
    public Transform player;
    private NavMeshAgent navMeshAgent;
    public Transform fish;
    public Vector3 playerPos;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        navMeshAgent = GetComponent<NavMeshAgent>();
    }

    // Update is called once per frame
    void Update()
    {
        playerPos = player.position;
        if (player != null)
        {
            navMeshAgent.SetDestination(playerPos);
            fish.Rotate(0,0,0);
        }
    }
}
