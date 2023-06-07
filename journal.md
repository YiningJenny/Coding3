# 7/June 
- 配置python环境，问了rebacca。可以直接用mini conda 配置环境。

```conda create -n "coding3Final" python=3.8.13```
- 在conda terminal输入这行命令就可以直接下载并创建一个py3.8的名叫coding3Final的环境

```(base) C:\Users\dell>conda activate coding3Final```
- 激活这个环境（每次打开项目前需要做这一步）

![image](https://github.com/YiningJenny/Coding3/assets/119497753/2df2f05f-7a76-4f19-9789-ce51b1590f32)

This is how ```mlagents-learn``` run in conda terminal

![image](https://github.com/YiningJenny/Coding3/assets/119497753/4df3edef-e985-45f5-8f14-89af8fa5a4b2)

```C#
Debug.Log(actions.DiscreteActions[0]);
Debug.Log(actions.ContinuousActions[0]);
```

The difference between this two is ```DiscreteActions``` outpts integer value while ```ContinuousActions``` outputs float values.
