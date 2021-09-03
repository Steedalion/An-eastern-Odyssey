using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class NavmeshClicker : MonoBehaviour
{
    private NavMeshAgent agent;
    [SerializeField] private float xoffset, yoffset;

    // Start is called before the first frame update
    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
    }

    // Update is called once per frame
    void Update()
    {
          if (Input.GetMouseButtonDown(0))
        {
                    Vector3 worldPosition;
            worldPosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            Debug.Log("Clicked: " + worldPosition);
            agent.destination = new Vector2(Mathf.Round(worldPosition.x)+xoffset, Mathf.Round(worldPosition.y)+yoffset);
        }
    }
}
