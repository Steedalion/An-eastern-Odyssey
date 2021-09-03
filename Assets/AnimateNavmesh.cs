using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class AnimateNavmesh : MonoBehaviour
{
        NavMeshAgent agent;
        private Animator anim;

        void Start()
    {
        anim = GetComponent<Animator>();
        agent = GetComponent<NavMeshAgent>();
        agent.updateRotation = false;
		agent.updateUpAxis = false;
    }

    // Update is called once per frame
    void Update()
    {
        anim.SetFloat("vertical",agent.velocity.y);
        anim.SetFloat("horizontal",agent.velocity.x);
        anim.SetFloat("speed",agent.velocity.magnitude);
    }
}
