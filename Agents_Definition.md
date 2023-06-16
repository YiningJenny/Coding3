# Agents definition

```C#
#region Assembly Unity.ML-Agents, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// E:\UnityHub\Unity Project\Coding3MLAgent2\Library\ScriptAssemblies\Unity.ML-Agents.dll
#endregion

using System.Collections.ObjectModel;
using Unity.Barracuda;
using Unity.MLAgents.Actuators;
using Unity.MLAgents.Policies;
using Unity.MLAgents.Sensors;
using UnityEngine;
using UnityEngine.Serialization;

namespace Unity.MLAgents
{
    [HelpURL("https://github.com/Unity-Technologies/ml-agents/blob/release_17_docs/docs/Learning-Environment-Design-Agents.md")]
    [RequireComponent(typeof(BehaviorParameters))]
    public class Agent : MonoBehaviour, ISerializationCallbackReceiver, IActionReceiver, IHeuristicProvider
    {
        [FormerlySerializedAs("maxStep")]
        [HideInInspector]
        public int MaxStep;

        public Agent();

        public int StepCount { get; }
        public int CompletedEpisodes { get; }

        protected static float ScaleAction(float rawAction, float min, float max);
        public void AddReward(float increment);
        public virtual void CollectObservations(VectorSensor sensor);
        public void EndEpisode();
        public void EpisodeInterrupted();
        public float GetCumulativeReward();
        public ReadOnlyCollection<float> GetObservations();
        public ActionBuffers GetStoredActionBuffers();
        public virtual void Heuristic(in ActionBuffers actionsOut);
        public virtual void Initialize();
        public void LazyInitialize();
        public virtual void OnActionReceived(ActionBuffers actions);
        public void OnAfterDeserialize();
        public void OnBeforeSerialize();
        public virtual void OnEpisodeBegin();
        public void RequestAction();
        public void RequestDecision();
        public void SetModel(string behaviorName, NNModel model, InferenceDevice inferenceDevice = InferenceDevice.Default);
        public void SetReward(float reward);
        public virtual void WriteDiscreteActionMask(IDiscreteActionMask actionMask);
        protected virtual void OnDisable();
        protected virtual void OnEnable();
    }
}
```
