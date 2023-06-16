# 7/June - virtual environment setup and basic training

- I follow the [ML-Agents GitHub page](https://github.com/Unity-Technologies/ml-agents) to set up the virtual environment. With the help of Rebecca, I set up the environment with anaconda. (I rebuild the virtual environment for three time, so the name shows differently in the final presentation video.)

- Build a py3.8 virtual environment called "coding3Final":

```conda create -n "coding3Final" python=3.8.13```

- Activate conda: (run this everytime before Unity)

```(base) C:\Users\dell>conda activate coding3Final```

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

```C#
Debug.Log(actions.DiscreteActions[0]);
Debug.Log(actions.ContinuousActions[0]);
```

The difference between this two is ```DiscreteActions``` outpts integer value while ```ContinuousActions``` outputs float values.

- I'm using ML-agent model, here is [the definition of agent class]().



ML-agent learning is through reinforcement learning, so it's based on a relatively simple loop of observation where the agent gathers data from its environment, then it makes a decision based on the data that has, and then takes an action. If it does the right action then it gets a reward. Basically, this is a continuous cycle where the agent grows to learn based on its observations and what actions lead to the highest rewards.

![image](https://github.com/YiningJenny/Coding3/assets/119497753/6250cfad-5f84-4fb1-b6b1-26937e493816)

- This is the component that attached to my agent. `Discrete` means integer while `Continuous` means float.

- Then I run this in terminal to train the model in virtual space:

`
(coding3Final) E:\UnityHub\Unity Project\Coding3MLAgent2>mlagents-learn
`

![image](https://github.com/YiningJenny/Coding3/assets/119497753/2df2f05f-7a76-4f19-9789-ce51b1590f32)

- In Unity:

```C#
Debug.Log(actions.DiscreteActions[0]); // I have only one branch which means I have one value in this array
Debug.Log(actions.ContinuousActions[0]);
```
- To train it again, I use`(coding3Final) E:\UnityHub\Unity Project\Coding3MLAgent2>mlagents-learn --run-id=Test3` with a new specific ID

![image](https://github.com/YiningJenny/Coding3/assets/119497753/c4cb4fa1-22bb-47e1-bdd9-f21d37e09709)
 
- This is part of the console I get from Unity

- To train faster, I duplicate the whole scene and train all the agents together.
![image](https://github.com/YiningJenny/Coding3/assets/119497753/a8f5eded-b2d6-4d0d-ad75-f7afdcd4e9c8)

- I set max step to 1000 in case AI never touches the goal, instead it just simply learn avoid the wall and just stay in palce forever.
![image](https://github.com/YiningJenny/Coding3/assets/119497753/9fb62b91-a121-4a89-97f6-9363203a95e4)

- This is my training result, I duplicate the file into unity:

![image](https://github.com/YiningJenny/Coding3/assets/119497753/88d0263d-dba7-47a4-be90-b4b61c769e9a)

[The training record video](https://artslondon-my.sharepoint.com/:v:/g/personal/y_jiang0220224_arts_ac_uk/EUYFxJcdsU9PqJNtFknwABUBOBPBSdL1PAK1d9D_UMh2rw?e=znUfW1)

- To actually train the character move to the goal instead of moving to a specific position, I use random position to episode both character and goal.
```C#
public override void OnEpisodeBegin()
    {
        transform.localPosition = new Vector3(Random.Range(-13f, +5f), 0f, Random.Range(13f, 5f)); // character starts with a random position
        targetTransform.localPosition = new Vector3(Random.Range(-13f, +13f), 0f, Random.Range(-13f, 13f)); // character starts with a random position
    }
```

- At last I run this in anaconda terminal to see the training results visualization:
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


