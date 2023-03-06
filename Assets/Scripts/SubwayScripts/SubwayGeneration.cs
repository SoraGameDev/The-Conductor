using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SubwayGeneration : MonoBehaviour
{
    public GameObject subwayTunnelPrefab;
    public GameObject spawnPosition;
    public Transform spawnPos;
    [SerializeField] float moveSpeed;
    public bool trainMoving = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        if(trainMoving == true)
        {
            transform.Translate(-moveSpeed * Time.deltaTime * Vector3.forward);
        }
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            GameObject subwayTunnel = Instantiate(subwayTunnelPrefab, spawnPos.position, spawnPos.rotation);
            Debug.Log("TriggerEntered");

            Invoke(nameof(SelfDestruct), 7.6f);
        }
    }

    void SelfDestruct()
    {
        Destroy(gameObject);
    }
}
