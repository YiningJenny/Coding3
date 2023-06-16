# 7/June - virtual environment setup and basic training

- I follow the [ML-Agents GitHub page](https://github.com/Unity-Technologies/ml-agents) to set up the virtual environment. With the help of Rebecca, I set up the environment with anaconda. (I rebuild the virtual environment for three time, so the name shows differently in the final presentation video.)

- Build a py3.8 virtual environment called "coding3Final":

```conda create -n "coding3Final" python=3.8.13```

- Activate conda: (run this everytime before Unity)

```(base) C:\Users\dell>conda activate coding3Final```

- Then I run this in Anaconda terminal to train the model in virtual space:

`(coding3Final) E:\UnityHub\Unity Project\Coding3MLAgent2>mlagents-learn`
- This is how ```mlagents-learn``` run in conda terminal (I like the Unity Logo shows here)

![image](https://github.com/YiningJenny/Coding3/assets/119497753/2df2f05f-7a76-4f19-9789-ce51b1590f32)

![image](https://github.com/YiningJenny/Coding3/assets/119497753/4df3edef-e985-45f5-8f14-89af8fa5a4b2)

- __[Everything in Anaconda terminal on the first day(conclude some errors and solutions)](https://github.com/YiningJenny/Coding3/blob/main/Day1_Terminal.md)__ 
- The problems I meet are several:
1. I need specific Python version, torch version and Unity version to work together, otherwise it doesn't work.
2. The virtual environment should be in the same folder with unity project, otherwise the training results can't be stored.
3. Seems like I don't need same version ML Agent Package in unity as [ML-Agents Github install](https://github.com/Unity-Technologies/ml-agents/blob/develop/com.unity.ml-agents.extensions/Documentation~/com.unity.ml-agents.extensions.md) says. I'm just using the newest version. (like below)

![image](https://github.com/YiningJenny/Coding3/assets/119497753/45c7ec28-4473-4b6c-b938-94470278e702)

# 15/June - Read the ML-Agents and train the AI

- To train the AI in Unity, I use ML-agent model, here is [the definition of agent class](https://github.com/YiningJenny/Coding3/blob/main/Agents_Definition.md).
- ML-agent learning is through reinforcement learning, so it's based on a relatively simple loop of observation where the agent gathers data from its environment, then it makes a decision based on the data that has, and then takes an action. If it does the right action then it gets a reward. Basically, this is a continuous cycle where the agent grows to learn based on its observations and what actions lead to the highest rewards.
- This is the component that attached to my agent. `Discrete` means integer while `Continuous` means float. The branch here means the actions I take. For example, for this project I need two branches which mean X vector value and Z vector value. If I need Y vector value, then I need one more branch.

![image](https://github.com/YiningJenny/Coding3/assets/119497753/6250cfad-5f84-4fb1-b6b1-26937e493816)

- In Unity:

```C#
Debug.Log(actions.DiscreteActions[0]); // I have only one branch which means I have one value in this array
Debug.Log(actions.ContinuousActions[0]);
```

- The difference between this two is ```DiscreteActions``` outpts integer value while ```ContinuousActions``` outputs float values.
- To train it again, I use`(coding3Final) E:\UnityHub\Unity Project\Coding3MLAgent2>mlagents-learn --run-id=Test3` with a new specific ID
- This is part of the console I get from Unity

![image](https://github.com/YiningJenny/Coding3/assets/119497753/c4cb4fa1-22bb-47e1-bdd9-f21d37e09709)
 
- To train the game character move towards the target, I need to use the position values of the target object to let AI observe the environment. I'm sending two Vector3 velues to AI, so it's actually 6 floats.

```C#
[SerializeField] private Transform targetTransform; // goal position
// how the agents observe its environment
    public override void CollectObservations(VectorSensor sensor)
    {
        // control my character move to the goal (pass Vector3 position values)
        sensor.AddObservation(transform.localPosition); // where is my character
        sensor.AddObservation(targetTransform.localPosition); // where is my goal
    }
```

- This is how character moves toward the goal:

```C#
public override void OnActionReceived(ActionBuffers actions)
    {
        // for 2 continuous actions: grab X an Z values 
        float moveX = actions.ContinuousActions[0]; // X
        float moveZ = actions.ContinuousActions[1]; // Z

        float moveSpeed = 10f; // moveSpeed
        transform.Position += new Vector3(moveX, 0, moveZ) * Time.deltaTime * moveSpeed;
    }
```

- To let character hit the goal, I add a triggerable collider to the goal. At the same time I also add triggerable colliders to the walls. Everytime when character hits the goal or walls, the floor changes color and game reset(reset but not quit).

![image](https://github.com/YiningJenny/Coding3/assets/119497753/969a21f1-0828-4eb1-bd9b-ca9587fe6cdb)

```C#
public override void OnEpisodeBegin()
    {
        transform.localPosition = Vector3.zero; // transform the local position instead of global position
    }

void OnTriggerEnter(Collider other)
    {
        // find goal's collider
        if (other.TryGetComponent<Goal>(out Goal goal))
        {
            SetReward(+1f); // set the reward with specific amount. i only have a single goal so use SetReward instead of AddReward
            floorMeshRenderer.material = winMaterial;
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
```

- Before start training, I can do test with keyboard controlling:

```C#
 public override void Heuristic(in ActionBuffers actionsOut)
    {
        ActionSegment<float> continuousActions = actionsOut.ContinuousActions;
        // move character with array key
        continuousActions[0] = Input.GetAxisRaw("Horizontal"); // move Z vector with array key 
        continuousActions[1] = Input.GetAxisRaw("Vertical"); // move X vector with array key
    }
```
#   

### [First time training video record](https://artslondon-my.sharepoint.com/:v:/g/personal/y_jiang0220224_arts_ac_uk/EXRzcGJKDPhAvRKXo5d5-kgBiscj_4F_kcCcB2LBWNkKvA?e=ktx1Ld)

- I thought my character is just going nowhere, not going toward the goal either not avoiding the walls. Then I ask supervisor team, Jasper said that reinforcement training takes time, and what I need to do is wait.
- To train faster, I duplicate the whole scene and train all the agents together.

![image](https://github.com/YiningJenny/Coding3/assets/119497753/a8f5eded-b2d6-4d0d-ad75-f7afdcd4e9c8)

### [Before massive training, I test it with keyboard. (Video record)](https://artslondon-my.sharepoint.com/:v:/g/personal/y_jiang0220224_arts_ac_uk/EY6p-ZBPZXxGhELZREBgVFEBYNTk3R633f_rrbVwFi1n-A?e=CetfzL)

- I set max step to 1000 in case AI never touches the goal, instead it just simply learn avoid the wall and just stay in palce forever.

![image](https://github.com/YiningJenny/Coding3/assets/119497753/9fb62b91-a121-4a89-97f6-9363203a95e4)

### [Then I massively train the model.(Video record)](https://artslondon-my.sharepoint.com/:v:/g/personal/y_jiang0220224_arts_ac_uk/EUYFxJcdsU9PqJNtFknwABUBOBPBSdL1PAK1d9D_UMh2rw?e=hR8nUT)

- Actually, I failed many times in progress. (I even rebuild the virtual environment as well as unity project, that's why my game scene looks in different colors). Sometimes I get error in terminal, like 

`[WARNING] Behavior name MoveToGoal does not match any behaviors specified in the trainer configuration file. A default configuration will be used.`

`RuntimeError: CUDA error: CUBLAS_STATUS_NOT_INITIALIZED when calling `cublasCreate(handle)``

`RuntimeError: CUDA out of memory. Tried to allocate 2.00 MiB (GPU 0; 6.00 GiB total capacity; 3.78 MiB already allocated; 4.70 GiB free; 4.00 MiB reserved in total by PyTorch)`

- Sometimes I get errors from unity, like

![image](https://github.com/YiningJenny/Coding3/assets/119497753/5f2a593d-d67c-4361-835d-9fece36359df)

- Once my unity project crashed... I don't remember how, but I solved all of these issues by myself. There's one thing that I remember very important, I used to choose "GPU" or "CPU" instead of default, but only default works for my project.

![image](https://github.com/YiningJenny/Coding3/assets/119497753/bb6b199e-26fc-4d18-9515-8fd027e98fe0)

- To actually train the character move to the goal instead of moving to a specific position, I use random position to episode both character and goal.

```C#
public override void OnEpisodeBegin()
    {
        transform.localPosition = new Vector3(Random.Range(-13f, +5f), 0f, Random.Range(13f, 5f)); // character starts with a random position
        targetTransform.localPosition = new Vector3(Random.Range(-13f, +13f), 0f, Random.Range(-13f, 13f)); // goal starts with a random position
    }
```

### [Second time massively train the model](https://artslondon-my.sharepoint.com/:v:/g/personal/y_jiang0220224_arts_ac_uk/EY_cxt_qrhFDlsue9PVL7PgBU5H00whVw-NIlhJ6da-vVg?e=x5E6Yz)

- This is my most successful training result, I duplicate the result file into unity and apply to my agent character

![image](https://github.com/YiningJenny/Coding3/assets/119497753/88d0263d-dba7-47a4-be90-b4b61c769e9a)

![image](https://github.com/YiningJenny/Coding3/assets/119497753/48e0ad51-d222-47d0-b995-817537431664)

[Final training result presentation (use the result from my training to run the project)](https://artslondon-my.sharepoint.com/:v:/g/personal/y_jiang0220224_arts_ac_uk/ETxXufDhNetMggU7t70LXBoBgcm9m1fTo3sFv-p9aQaJ-Q?e=Jw1mS5)

- At last I run this in a new anaconda terminal to see the training results visualization:

```
(base) C:\Users\dell>cd../..

(base) C:\>e:

(base) E:\>cd E:\MScTerm3\Coding3\Coding3MLAgent3

(base) E:\MScTerm3\Coding3\Coding3MLAgent3>conda activate venv

(venv) E:\MScTerm3\Coding3\Coding3MLAgent3>tensorboard --logdir results
TensorFlow installation not found - running with reduced feature set.
Serving TensorBoard on localhost; to expose to the network, use a proxy or pass --bind_all
TensorBoard 2.13.0 at http://localhost:6006/ (Press CTRL+C to quit)
```

- The Cumulative reward here shows that the training result is getting better.

![image](https://github.com/YiningJenny/Coding3/assets/119497753/a1cf1030-a34a-4d59-ba78-9f6920fea7d9)

- Additionally, the episode length is hardly going down which means AI is not learning how to get the goal faster.

![image](https://github.com/YiningJenny/Coding3/assets/119497753/65bbd29d-541f-464a-b872-6f99b7d552c6)

- Inner works of AI:

![image](https://github.com/YiningJenny/Coding3/assets/119497753/220d64a8-7d63-4bc2-8c59-6874547a44e6)

# In the future
- __Config__.According to Jasper's advice, I can try to [configure](https://unity-technologies.github.io/ml-agents/Getting-Started/#training-the-environment) my training by specifying a `*.yaml` file when executing the training. I tried to follow the steps but my unity project just crashed once again. I'm sure that it would be benefit to my training if my equipment is able to run it. I plan to try this in the future.
- __More time and better equipment.__ 
- __Unity__ I plan to develop the unity project to make it more completed and do something fun. I can think about how to apply it into a game.
