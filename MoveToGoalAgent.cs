using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Unity.MLAgents; // import library
using Unity.MLAgents.Actuators;
using Unity.MLAgents.Sensors;

public class MoveToGoalAgent : Agent  // inherite from agent class instead of MonoBehaviour
{
    [SerializeField] private Transform targetTransform; // goal position
    // visualize for training 
    [SerializeField] private Material winMaterial;
    [SerializeField] private Material loseMaterial;
    [SerializeField] private MeshRenderer floorMeshRenderer;

    public override void OnEpisodeBegin()
    {
        //transform.localPosition = Vector3.zero; // transform the local position instead of global position
        transform.localPosition = new Vector3(Random.Range(-13f, +13f), 0f, Random.Range(-13f, 13f)); // character starts with a random position
        targetTransform.localPosition = new Vector3(Random.Range(-13f, +13f), 0f, Random.Range(-13f, 13f)); // goal starts with a random position

    }

    // how the agents observe its environment
    public override void CollectObservations(VectorSensor sensor)
    {
        // control my character move to the goal (pass Vector3 position values)
        sensor.AddObservation(transform.localPosition); // where is my character
        sensor.AddObservation(targetTransform.localPosition); // where is my goal
    }

    // read players' actions as int or float
    public override void OnActionReceived(ActionBuffers actions)
    {
        /*Debug.Log(actions.DiscreteActions[0]); // I have only one branch which means I have one value in this array
        Debug.Log(actions.ContinuousActions[0]);*/

        // for 2 continuous actions: grab X an Z values 
        float moveX = actions.ContinuousActions[0]; // X
        float moveZ = actions.ContinuousActions[1]; // Z

        float moveSpeed = 10f; // moveSpeed
        transform.localPosition += new Vector3(moveX, 0, moveZ) * Time.deltaTime * moveSpeed; // control the character by keyboard
    }

    // validate: testing 
    public override void Heuristic(in ActionBuffers actionsOut)
    {
        ActionSegment<float> continuousActions = actionsOut.ContinuousActions;
        // move character with array key
        continuousActions[0] = Input.GetAxisRaw("Horizontal"); // move Z vector with array key 
        continuousActions[1] = Input.GetAxisRaw("Vertical"); // move X vector with array key
    }

    // do something after hitting the collider
    void OnTriggerEnter(Collider other)
    {
        // find goal's collider
        if (other.TryGetComponent<Goal>(out Goal goal))
        {
            SetReward(+1f); // set the reward with specific amount. i only have a single goal so use SetReward instead of AddReward
            floorMeshRenderer.material = winMaterial;
            //print("win");
            EndEpisode(); // reset but not quit the training, so that I can train again
        }
        // find walls' collider
        if (other.TryGetComponent<Wall>(out Wall wall))
        {
            SetReward(-1f);
            floorMeshRenderer.material = loseMaterial;
            EndEpisode();
        }
    }

}
