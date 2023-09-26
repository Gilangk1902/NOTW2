using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectPhasingDetector : MonoBehaviour
{
    private PlayerInteraction player_interaction;
    [SerializeField] private float max_phase_radius;
    public bool isEnabled = false;
    private int ground_layer_mask;

    private void Start()
    {
        player_interaction = GameObject.Find("Player").GetComponent<PlayerInteraction>();
        ground_layer_mask = LayerMask.GetMask("Ground");
    }

    void Update()
    {
        if (isEnabled)
        {
            CheckIfPhasing();
        }
    }

    private void CheckIfPhasing()
    {
        if(Physics.CheckSphere(transform.position, max_phase_radius, ground_layer_mask))
        {
            test();
            player_interaction.ResetGrab();
        }
    }

    void test()
    {
        Debug.Log("phasing");
    }
}
