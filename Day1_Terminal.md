# First day terminal inputs and outputs (include errors and solutions)
```
Active code page: 65001

(base) C:\Users\dell>conda create -n "coding3Final" python=3.8.13
Retrieving notices: ...working... done
Collecting package metadata (current_repodata.json): done
Solving environment: failed with repodata from current_repodata.json, will retry with next repodata source.
Collecting package metadata (repodata.json): done
Solving environment: done


==> WARNING: A newer version of conda exists. <==
  current version: 23.1.0
  latest version: 23.5.0

Please update conda by running

    $ conda update -n base -c defaults conda

Or to minimize the number of packages updated during conda update use

     conda install conda=23.5.0



## Package Plan ##

  environment location: E:\Miniconda\envs\coding3Final

  added / updated specs:
    - python=3.8.13


The following packages will be downloaded:

    package                    |            build
    ---------------------------|-----------------
    pip-23.0.1                 |   py38haa95532_0         2.7 MB  https://mirrors.tuna.tsinghua.edu.cn/anaconda/pkgs/main
    python-3.8.13              |       h6244533_1        16.5 MB  https://mirrors.tuna.tsinghua.edu.cn/anaconda/pkgs/main
    setuptools-67.8.0          |   py38haa95532_0         1.0 MB  https://mirrors.tuna.tsinghua.edu.cn/anaconda/pkgs/main
    sqlite-3.41.2              |       h2bbff1b_0         894 KB  https://mirrors.tuna.tsinghua.edu.cn/anaconda/pkgs/main
    wheel-0.38.4               |   py38haa95532_0          83 KB  https://mirrors.tuna.tsinghua.edu.cn/anaconda/pkgs/main
    ------------------------------------------------------------
                                           Total:        21.2 MB

The following NEW packages will be INSTALLED:

  ca-certificates    anaconda/pkgs/main/win-64::ca-certificates-2023.01.10-haa95532_0
  openssl            anaconda/pkgs/main/win-64::openssl-1.1.1t-h2bbff1b_0
  pip                anaconda/pkgs/main/win-64::pip-23.0.1-py38haa95532_0
  python             anaconda/pkgs/main/win-64::python-3.8.13-h6244533_1
  setuptools         anaconda/pkgs/main/win-64::setuptools-67.8.0-py38haa95532_0
  sqlite             anaconda/pkgs/main/win-64::sqlite-3.41.2-h2bbff1b_0
  vc                 anaconda/pkgs/main/win-64::vc-14.2-h21ff451_1
  vs2015_runtime     anaconda/pkgs/main/win-64::vs2015_runtime-14.27.29016-h5e58377_2
  wheel              anaconda/pkgs/main/win-64::wheel-0.38.4-py38haa95532_0


Proceed ([y]/n)? y


Downloading and Extracting Packages

Preparing transaction: done
Verifying transaction: done
Executing transaction: done
#
# To activate this environment, use
#
#     $ conda activate coding3Final
#
# To deactivate an active environment, use
#
#     $ conda deactivate


(base) C:\Users\dell>conda activate coding3Final

(coding3Final) C:\Users\dell>cd../..

(coding3Final) C:\>e:

(coding3Final) E:\>cd E:\UnityHub\Unity Project\Coding3MLAgent2

(coding3Final) E:\UnityHub\Unity Project\Coding3MLAgent2>git clone --branch release_20 https://github.com/Unity-Technologies/ml-agents.git
fatal: destination path 'ml-agents' already exists and is not an empty directory.

(coding3Final) E:\UnityHub\Unity Project\Coding3MLAgent2>pip3 install torch~=1.7.1 -f https://download.pytorch.org/whl/torch_stable.html
Looking in links: https://download.pytorch.org/whl/torch_stable.html
Collecting torch~=1.7.1
  Downloading https://download.pytorch.org/whl/cu110/torch-1.7.1%2Bcu110-cp38-cp38-win_amd64.whl (2050.2 MB)
     ━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━ 2.1/2.1 GB ? eta 0:00:00
Collecting typing-extensions
  Using cached typing_extensions-4.6.3-py3-none-any.whl (31 kB)
Collecting numpy
  Downloading numpy-1.24.3-cp38-cp38-win_amd64.whl (14.9 MB)
     ━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━ 14.9/14.9 MB 12.1 MB/s eta 0:00:00
Installing collected packages: typing-extensions, numpy, torch
Successfully installed numpy-1.24.3 torch-1.7.1+cu110 typing-extensions-4.6.3

(coding3Final) E:\UnityHub\Unity Project\Coding3MLAgent2>pip install mlagents
Collecting mlagents
  Downloading mlagents-0.30.0.tar.gz (131 kB)
     ━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━ 132.0/132.0 kB 7.6 MB/s eta 0:00:00
  Preparing metadata (setup.py) ... done
Collecting grpcio>=1.11.0
  Downloading grpcio-1.54.2-cp38-cp38-win_amd64.whl (4.1 MB)
     ━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━ 4.1/4.1 MB 11.4 MB/s eta 0:00:00
Collecting h5py>=2.9.0
  Downloading h5py-3.8.0-cp38-cp38-win_amd64.whl (2.7 MB)
     ━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━ 2.7/2.7 MB 14.2 MB/s eta 0:00:00
Collecting mlagents_envs==0.30.0
  Downloading mlagents_envs-0.30.0.tar.gz (56 kB)
     ━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━ 56.7/56.7 kB ? eta 0:00:00
  Preparing metadata (setup.py) ... done
Requirement already satisfied: numpy<2.0,>=1.13.3 in e:\miniconda\envs\coding3final\lib\site-packages (from mlagents) (1.24.3)
Collecting Pillow>=4.2.1
  Downloading Pillow-9.5.0-cp38-cp38-win_amd64.whl (2.5 MB)
     ━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━ 2.5/2.5 MB 12.5 MB/s eta 0:00:00
Collecting protobuf>=3.6
  Downloading protobuf-4.23.2-cp38-cp38-win_amd64.whl (422 kB)
     ━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━ 422.5/422.5 kB 27.5 MB/s eta 0:00:00
Collecting pyyaml>=3.1.0
  Downloading PyYAML-6.0-cp38-cp38-win_amd64.whl (155 kB)
     ━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━ 155.4/155.4 kB 9.1 MB/s eta 0:00:00
Collecting tensorboard>=1.15
  Using cached tensorboard-2.13.0-py3-none-any.whl (5.6 MB)
Collecting attrs>=19.3.0
  Using cached attrs-23.1.0-py3-none-any.whl (61 kB)
Collecting pypiwin32==223
  Using cached pypiwin32-223-py3-none-any.whl (1.7 kB)
Collecting cattrs<1.7,>=1.1.0
  Using cached cattrs-1.5.0-py3-none-any.whl (19 kB)
Collecting cloudpickle
  Using cached cloudpickle-2.2.1-py3-none-any.whl (25 kB)
Collecting gym>=0.21.0
  Downloading gym-0.26.2.tar.gz (721 kB)
     ━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━ 721.7/721.7 kB 15.1 MB/s eta 0:00:00
  Installing build dependencies ... done
  Getting requirements to build wheel ... done
  Preparing metadata (pyproject.toml) ... done
Collecting pettingzoo==1.15.0
  Downloading PettingZoo-1.15.0.tar.gz (756 kB)
     ━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━ 756.7/756.7 kB 16.2 MB/s eta 0:00:00
  Preparing metadata (setup.py) ... done
Collecting numpy<2.0,>=1.13.3
  Downloading numpy-1.21.2-cp38-cp38-win_amd64.whl (14.0 MB)
     ━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━ 14.0/14.0 MB 8.6 MB/s eta 0:00:00
Collecting filelock>=3.4.0
  Using cached filelock-3.12.0-py3-none-any.whl (10 kB)
Collecting pywin32>=223
  Downloading pywin32-306-cp38-cp38-win_amd64.whl (9.4 MB)
     ━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━ 9.4/9.4 MB 12.8 MB/s eta 0:00:00
Requirement already satisfied: wheel>=0.26 in e:\miniconda\envs\coding3final\lib\site-packages (from tensorboard>=1.15->mlagents) (0.38.4)
Collecting werkzeug>=1.0.1
  Using cached Werkzeug-2.3.4-py3-none-any.whl (242 kB)
Collecting markdown>=2.6.8
  Using cached Markdown-3.4.3-py3-none-any.whl (93 kB)
Collecting google-auth-oauthlib<1.1,>=0.5
  Using cached google_auth_oauthlib-1.0.0-py2.py3-none-any.whl (18 kB)
Collecting tensorboard-data-server<0.8.0,>=0.7.0
  Using cached tensorboard_data_server-0.7.0-py3-none-any.whl (2.4 kB)
Collecting requests<3,>=2.21.0
  Using cached requests-2.31.0-py3-none-any.whl (62 kB)
Requirement already satisfied: setuptools>=41.0.0 in e:\miniconda\envs\coding3final\lib\site-packages (from tensorboard>=1.15->mlagents) (67.8.0)
Collecting absl-py>=0.4
  Using cached absl_py-1.4.0-py3-none-any.whl (126 kB)
Collecting google-auth<3,>=1.6.3
  Using cached google_auth-2.19.1-py2.py3-none-any.whl (181 kB)
Collecting pyasn1-modules>=0.2.1
  Using cached pyasn1_modules-0.3.0-py2.py3-none-any.whl (181 kB)
Collecting urllib3<2.0
  Using cached urllib3-1.26.16-py2.py3-none-any.whl (143 kB)
Collecting six>=1.9.0
  Using cached six-1.16.0-py2.py3-none-any.whl (11 kB)
Collecting rsa<5,>=3.1.4
  Using cached rsa-4.9-py3-none-any.whl (34 kB)
Collecting cachetools<6.0,>=2.0.0
  Using cached cachetools-5.3.1-py3-none-any.whl (9.3 kB)
Collecting requests-oauthlib>=0.7.0
  Using cached requests_oauthlib-1.3.1-py2.py3-none-any.whl (23 kB)
Collecting importlib-metadata>=4.8.0
  Downloading importlib_metadata-6.6.0-py3-none-any.whl (22 kB)
Collecting gym-notices>=0.0.4
  Downloading gym_notices-0.0.8-py3-none-any.whl (3.0 kB)
Collecting idna<4,>=2.5
  Using cached idna-3.4-py3-none-any.whl (61 kB)
Collecting charset-normalizer<4,>=2
  Downloading charset_normalizer-3.1.0-cp38-cp38-win_amd64.whl (96 kB)
     ━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━ 96.4/96.4 kB ? eta 0:00:00
Collecting certifi>=2017.4.17
  Using cached certifi-2023.5.7-py3-none-any.whl (156 kB)
Collecting MarkupSafe>=2.1.1
  Downloading MarkupSafe-2.1.3-cp38-cp38-win_amd64.whl (17 kB)
Collecting zipp>=0.5
  Using cached zipp-3.15.0-py3-none-any.whl (6.8 kB)
Collecting pyasn1<0.6.0,>=0.4.6
  Using cached pyasn1-0.5.0-py2.py3-none-any.whl (83 kB)
Collecting oauthlib>=3.0.0
  Using cached oauthlib-3.2.2-py3-none-any.whl (151 kB)
Building wheels for collected packages: mlagents, mlagents_envs, pettingzoo, gym
  Building wheel for mlagents (setup.py) ... done
  Created wheel for mlagents: filename=mlagents-0.30.0-py3-none-any.whl size=168464 sha256=02be701d437e081152def01f79edb1748c09b605d6265575c74517c0b1cfa15e
  Stored in directory: c:\users\dell\appdata\local\pip\cache\wheels\49\7d\20\fb38c6b62eabe3a513b7e2dd5b8c3448bace07c50dd4fd3189
  Building wheel for mlagents_envs (setup.py) ... done
  Created wheel for mlagents_envs: filename=mlagents_envs-0.30.0-py3-none-any.whl size=88769 sha256=5d5bc913393e97eaccefeb9cb5586018d2d4827b1217f574880b0e47ec02feda
  Stored in directory: c:\users\dell\appdata\local\pip\cache\wheels\22\4f\9e\6ea15537d075a8192e311275de9075bad97f5a47e5459ff54b
  Building wheel for pettingzoo (setup.py) ... done
  Created wheel for pettingzoo: filename=PettingZoo-1.15.0-py3-none-any.whl size=875651 sha256=ed77bae580713a78064521741a3a184beda4a3f21dc2afd7cadacaf7d9f5f2b9
  Stored in directory: c:\users\dell\appdata\local\pip\cache\wheels\a2\34\c9\a037b6115f93c2833fd6b2c7ce80b588b932987a7827fe9380
  Building wheel for gym (pyproject.toml) ... done
  Created wheel for gym: filename=gym-0.26.2-py3-none-any.whl size=827645 sha256=569ddd86e1523af1c86b36d9bcdddb9c83086f730999cbbf6c13fa45c18c7efc
  Stored in directory: c:\users\dell\appdata\local\pip\cache\wheels\17\79\65\7afedc162d858b02708a3b8f7a6dd5b1000dcd5b0f894f7cc1
Successfully built mlagents mlagents_envs pettingzoo gym
Installing collected packages: pywin32, gym-notices, zipp, urllib3, tensorboard-data-server, six, pyyaml, pypiwin32, pyasn1, protobuf, Pillow, oauthlib, numpy, MarkupSafe, idna, grpcio, filelock, cloudpickle, charset-normalizer, certifi, cachetools, attrs, absl-py, werkzeug, rsa, requests, pyasn1-modules, importlib-metadata, h5py, cattrs, requests-oauthlib, markdown, gym, google-auth, pettingzoo, google-auth-oauthlib, tensorboard, mlagents_envs, mlagents
  Attempting uninstall: numpy
    Found existing installation: numpy 1.24.3
    Uninstalling numpy-1.24.3:
      Successfully uninstalled numpy-1.24.3
Successfully installed MarkupSafe-2.1.3 Pillow-9.5.0 absl-py-1.4.0 attrs-23.1.0 cachetools-5.3.1 cattrs-1.5.0 certifi-2023.5.7 charset-normalizer-3.1.0 cloudpickle-2.2.1 filelock-3.12.0 google-auth-2.19.1 google-auth-oauthlib-1.0.0 grpcio-1.54.2 gym-0.26.2 gym-notices-0.0.8 h5py-3.8.0 idna-3.4 importlib-metadata-6.6.0 markdown-3.4.3 mlagents-0.30.0 mlagents_envs-0.30.0 numpy-1.21.2 oauthlib-3.2.2 pettingzoo-1.15.0 protobuf-4.23.2 pyasn1-0.5.0 pyasn1-modules-0.3.0 pypiwin32-223 pywin32-306 pyyaml-6.0 requests-2.31.0 requests-oauthlib-1.3.1 rsa-4.9 six-1.16.0 tensorboard-2.13.0 tensorboard-data-server-0.7.0 urllib3-1.26.16 werkzeug-2.3.4 zipp-3.15.0

(coding3Final) E:\UnityHub\Unity Project\Coding3MLAgent2>mlagents-learn --help
Traceback (most recent call last):
  File "E:\Miniconda\envs\coding3Final\lib\runpy.py", line 194, in _run_module_as_main
    return _run_code(code, main_globals, None,
  File "E:\Miniconda\envs\coding3Final\lib\runpy.py", line 87, in _run_code
    exec(code, run_globals)
  File "E:\Miniconda\envs\coding3Final\Scripts\mlagents-learn.exe\__main__.py", line 4, in <module>
  File "E:\Miniconda\envs\coding3Final\lib\site-packages\mlagents\trainers\learn.py", line 2, in <module>
    from mlagents import torch_utils
  File "E:\Miniconda\envs\coding3Final\lib\site-packages\mlagents\torch_utils\__init__.py", line 1, in <module>
    from mlagents.torch_utils.torch import torch as torch  # noqa
  File "E:\Miniconda\envs\coding3Final\lib\site-packages\mlagents\torch_utils\torch.py", line 6, in <module>
    from mlagents.trainers.settings import TorchSettings
  File "E:\Miniconda\envs\coding3Final\lib\site-packages\mlagents\trainers\settings.py", line 25, in <module>
    from mlagents.trainers.cli_utils import StoreConfigFile, DetectDefault, parser
  File "E:\Miniconda\envs\coding3Final\lib\site-packages\mlagents\trainers\cli_utils.py", line 5, in <module>
    from mlagents_envs.environment import UnityEnvironment
  File "E:\Miniconda\envs\coding3Final\lib\site-packages\mlagents_envs\environment.py", line 12, in <module>
    from mlagents_envs.side_channel.side_channel import SideChannel
  File "E:\Miniconda\envs\coding3Final\lib\site-packages\mlagents_envs\side_channel\__init__.py", line 5, in <module>
    from mlagents_envs.side_channel.default_training_analytics_side_channel import (  # noqa
  File "E:\Miniconda\envs\coding3Final\lib\site-packages\mlagents_envs\side_channel\default_training_analytics_side_channel.py", line 7, in <module>
    from mlagents_envs.communicator_objects.training_analytics_pb2 import (
  File "E:\Miniconda\envs\coding3Final\lib\site-packages\mlagents_envs\communicator_objects\training_analytics_pb2.py", line 35, in <module>
    _descriptor.FieldDescriptor(
  File "E:\Miniconda\envs\coding3Final\lib\site-packages\google\protobuf\descriptor.py", line 561, in __new__
    _message.Message._CheckCalledFromGeneratedFile()
TypeError: Descriptors cannot not be created directly.
If this call came from a _pb2.py file, your generated code is out of date and must be regenerated with protoc >= 3.19.0.If you cannot immediately regenerate your protos, some other possible workarounds are:
 1. Downgrade the protobuf package to 3.20.x or lower.
 2. Set PROTOCOL_BUFFERS_PYTHON_IMPLEMENTATION=python (but this will use pure-Python parsing and will be much slower).

More information: https://developers.google.com/protocol-buffers/docs/news/2022-05-06#python-updates

(coding3Final) E:\UnityHub\Unity Project\Coding3MLAgent2>pip install protobuf==3.20
Collecting protobuf==3.20
  Downloading protobuf-3.20.0-cp38-cp38-win_amd64.whl (904 kB)
     ━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━ 904.4/904.4 kB 8.2 MB/s eta 0:00:00
Installing collected packages: protobuf
  Attempting uninstall: protobuf
    Found existing installation: protobuf 4.23.2
    Uninstalling protobuf-4.23.2:
      Successfully uninstalled protobuf-4.23.2
Successfully installed protobuf-3.20.0

(coding3Final) E:\UnityHub\Unity Project\Coding3MLAgent2>mlagents-learn --help
usage: mlagents-learn.exe [-h] [--env ENV_PATH] [--resume] [--deterministic] [--force] [--run-id RUN_ID]
                          [--initialize-from RUN_ID] [--seed SEED] [--inference] [--base-port BASE_PORT]
                          [--num-envs NUM_ENVS] [--num-areas NUM_AREAS] [--debug] [--env-args ...]
                          [--max-lifetime-restarts MAX_LIFETIME_RESTARTS]
                          [--restarts-rate-limit-n RESTARTS_RATE_LIMIT_N]
                          [--restarts-rate-limit-period-s RESTARTS_RATE_LIMIT_PERIOD_S] [--torch] [--tensorflow]
                          [--results-dir RESULTS_DIR] [--width WIDTH] [--height HEIGHT]
                          [--quality-level QUALITY_LEVEL] [--time-scale TIME_SCALE]
                          [--target-frame-rate TARGET_FRAME_RATE] [--capture-frame-rate CAPTURE_FRAME_RATE]
                          [--no-graphics] [--torch-device DEVICE]
                          [trainer_config_path]

positional arguments:
  trainer_config_path

optional arguments:
  -h, --help            show this help message and exit
  --env ENV_PATH        Path to the Unity executable to train (default: None)
  --resume              Whether to resume training from a checkpoint. Specify a --run-id to use this option. If set,
                        the training code loads an already trained model to initialize the neural network before
                        resuming training. This option is only valid when the models exist, and have the same behavior
                        names as the current agents in your scene. (default: False)
  --deterministic       Whether to select actions deterministically in policy. `dist.mean` for continuous action
                        space, and `dist.argmax` for deterministic action space (default: False)
  --force               Whether to force-overwrite this run-id's existing summary and model data. (Without this flag,
                        attempting to train a model with a run-id that has been used before will throw an error.
                        (default: False)
  --run-id RUN_ID       The identifier for the training run. This identifier is used to name the subdirectories in
                        which the trained model and summary statistics are saved as well as the saved model itself. If
                        you use TensorBoard to view the training statistics, always set a unique run-id for each
                        training run. (The statistics for all runs with the same id are combined as if they were
                        produced by a the same session.) (default: ppo)
  --initialize-from RUN_ID
                        Specify a previously saved run ID from which to initialize the model from. This can be used,
                        for instance, to fine-tune an existing model on a new environment. Note that the previously
                        saved models must have the same behavior parameters as your current environment. (default:
                        None)
  --seed SEED           A number to use as a seed for the random number generator used by the training code (default:
                        -1)
  --inference           Whether to run in Python inference mode (i.e. no training). Use with --resume to load a model
                        trained with an existing run ID. (default: False)
  --base-port BASE_PORT
                        The starting port for environment communication. Each concurrent Unity environment instance
                        will get assigned a port sequentially, starting from the base-port. Each instance will use the
                        port (base_port + worker_id), where the worker_id is sequential IDs given to each instance
                        from 0 to (num_envs - 1). Note that when training using the Editor rather than an executable,
                        the base port will be ignored. (default: 5005)
  --num-envs NUM_ENVS   The number of concurrent Unity environment instances to collect experiences from when training
                        (default: 1)
  --num-areas NUM_AREAS
                        The number of parallel training areas in each Unity environment instance. (default: 1)
  --debug               Whether to enable debug-level logging for some parts of the code (default: False)
  --env-args ...        Arguments passed to the Unity executable. Be aware that the standalone build will also process
                        these as Unity Command Line Arguments. You should choose different argument names if you want
                        to create environment-specific arguments. All arguments after this flag will be passed to the
                        executable. (default: None)
  --max-lifetime-restarts MAX_LIFETIME_RESTARTS
                        The max number of times a single Unity executable can crash over its lifetime before ml-agents
                        exits. Can be set to -1 if no limit is desired. (default: 10)
  --restarts-rate-limit-n RESTARTS_RATE_LIMIT_N
                        The maximum number of times a single Unity executable can crash over a period of time (period
                        set in restarts-rate-limit-period-s). Can be set to -1 to not use rate limiting with restarts.
                        (default: 1)
  --restarts-rate-limit-period-s RESTARTS_RATE_LIMIT_PERIOD_S
                        The period of time --restarts-rate-limit-n applies to. (default: 60)
  --torch               (Removed) Use the PyTorch framework. (default: False)
  --tensorflow          (Removed) Use the TensorFlow framework. (default: False)
  --results-dir RESULTS_DIR
                        Results base directory (default: results)

Engine Configuration:
  --width WIDTH         The width of the executable window of the environment(s) in pixels (ignored for editor
                        training). (default: 84)
  --height HEIGHT       The height of the executable window of the environment(s) in pixels (ignored for editor
                        training) (default: 84)
  --quality-level QUALITY_LEVEL
                        The quality level of the environment(s). Equivalent to calling QualitySettings.SetQualityLevel
                        in Unity. (default: 5)
  --time-scale TIME_SCALE
                        The time scale of the Unity environment(s). Equivalent to setting Time.timeScale in Unity.
                        (default: 20)
  --target-frame-rate TARGET_FRAME_RATE
                        The target frame rate of the Unity environment(s). Equivalent to setting
                        Application.targetFrameRate in Unity. (default: -1)
  --capture-frame-rate CAPTURE_FRAME_RATE
                        The capture frame rate of the Unity environment(s). Equivalent to setting
                        Time.captureFramerate in Unity. (default: 60)
  --no-graphics         Whether to run the Unity executable in no-graphics mode (i.e. without initializing the
                        graphics driver. Use this only if your agents don't use visual observations. (default: False)

Torch Configuration:
  --torch-device DEVICE
                        Settings for the default torch.device used in training, for example, "cpu", "cuda", or
                        "cuda:0" (default: None)

(coding3Final) E:\UnityHub\Unity Project\Coding3MLAgent2>mlagents-learn

            ┐  ╖
        ╓╖╬│╡  ││╬╖╖
    ╓╖╬│││││┘  ╬│││││╬╖
 ╖╬│││││╬╜        ╙╬│││││╖╖                               ╗╗╗
 ╬╬╬╬╖││╦╖        ╖╬││╗╣╣╣╬      ╟╣╣╬    ╟╣╣╣             ╜╜╜  ╟╣╣
 ╬╬╬╬╬╬╬╬╖│╬╖╖╓╬╪│╓╣╣╣╣╣╣╣╬      ╟╣╣╬    ╟╣╣╣ ╒╣╣╖╗╣╣╣╗   ╣╣╣ ╣╣╣╣╣╣ ╟╣╣╖   ╣╣╣
 ╬╬╬╬┐  ╙╬╬╬╬│╓╣╣╣╝╜  ╫╣╣╣╬      ╟╣╣╬    ╟╣╣╣ ╟╣╣╣╙ ╙╣╣╣  ╣╣╣ ╙╟╣╣╜╙  ╫╣╣  ╟╣╣
 ╬╬╬╬┐     ╙╬╬╣╣      ╫╣╣╣╬      ╟╣╣╬    ╟╣╣╣ ╟╣╣╬   ╣╣╣  ╣╣╣  ╟╣╣     ╣╣╣┌╣╣╜
 ╬╬╬╜       ╬╬╣╣      ╙╝╣╣╬      ╙╣╣╣╗╖╓╗╣╣╣╜ ╟╣╣╬   ╣╣╣  ╣╣╣  ╟╣╣╦╓    ╣╣╣╣╣
 ╙   ╓╦╖    ╬╬╣╣   ╓╗╗╖            ╙╝╣╣╣╣╝╜   ╘╝╝╜   ╝╝╝  ╝╝╝   ╙╣╣╣    ╟╣╣╣
   ╩╬╬╬╬╬╬╦╦╬╬╣╣╗╣╣╣╣╣╣╣╝                                             ╫╣╣╣╣
      ╙╬╬╬╬╬╬╬╣╣╣╣╣╣╝╜
          ╙╬╬╬╣╣╣╜
             ╙

 Version information:
  ml-agents: 0.30.0,
  ml-agents-envs: 0.30.0,
  Communicator API: 1.5.0,
  PyTorch: 1.7.1+cu110
[INFO] Listening on port 5004. Start training by pressing the Play button in the Unity Editor.
Traceback (most recent call last):
  File "E:\Miniconda\envs\coding3Final\lib\runpy.py", line 194, in _run_module_as_main
    return _run_code(code, main_globals, None,
  File "E:\Miniconda\envs\coding3Final\lib\runpy.py", line 87, in _run_code
    exec(code, run_globals)
  File "E:\Miniconda\envs\coding3Final\Scripts\mlagents-learn.exe\__main__.py", line 7, in <module>
  File "E:\Miniconda\envs\coding3Final\lib\site-packages\mlagents\trainers\learn.py", line 264, in main
    run_cli(parse_command_line())
  File "E:\Miniconda\envs\coding3Final\lib\site-packages\mlagents\trainers\learn.py", line 260, in run_cli
    run_training(run_seed, options, num_areas)
  File "E:\Miniconda\envs\coding3Final\lib\site-packages\mlagents\trainers\learn.py", line 136, in run_training
    tc.start_learning(env_manager)
  File "E:\Miniconda\envs\coding3Final\lib\site-packages\mlagents_envs\timers.py", line 305, in wrapped
    return func(*args, **kwargs)
  File "E:\Miniconda\envs\coding3Final\lib\site-packages\mlagents\trainers\trainer_controller.py", line 172, in start_learning
    self._reset_env(env_manager)
  File "E:\Miniconda\envs\coding3Final\lib\site-packages\mlagents_envs\timers.py", line 305, in wrapped
    return func(*args, **kwargs)
  File "E:\Miniconda\envs\coding3Final\lib\site-packages\mlagents\trainers\trainer_controller.py", line 105, in _reset_env
    env_manager.reset(config=new_config)
  File "E:\Miniconda\envs\coding3Final\lib\site-packages\mlagents\trainers\env_manager.py", line 68, in reset
    self.first_step_infos = self._reset_env(config)
  File "E:\Miniconda\envs\coding3Final\lib\site-packages\mlagents\trainers\subprocess_env_manager.py", line 446, in _reset_env
    ew.previous_step = EnvironmentStep(ew.recv().payload, ew.worker_id, {}, {})
  File "E:\Miniconda\envs\coding3Final\lib\site-packages\mlagents\trainers\subprocess_env_manager.py", line 101, in recv
    raise env_exception
mlagents_envs.exception.UnityTimeOutException: The Unity environment took too long to respond. Make sure that :
         The environment does not need user interaction to launch
         The Agents' Behavior Parameters > Behavior Type is set to "Default"
         The environment and the Python interface have compatible versions.
         If you're running on a headless server without graphics support, turn off display by either passing --no-graphics option or build your Unity executable as server build.

(coding3Final) E:\UnityHub\Unity Project\Coding3MLAgent2>mlagents-learning
'mlagents-learning' is not recognized as an internal or external command,
operable program or batch file.

(coding3Final) E:\UnityHub\Unity Project\Coding3MLAgent2>mlagents-learn

            ┐  ╖
        ╓╖╬│╡  ││╬╖╖
    ╓╖╬│││││┘  ╬│││││╬╖
 ╖╬│││││╬╜        ╙╬│││││╖╖                               ╗╗╗
 ╬╬╬╬╖││╦╖        ╖╬││╗╣╣╣╬      ╟╣╣╬    ╟╣╣╣             ╜╜╜  ╟╣╣
 ╬╬╬╬╬╬╬╬╖│╬╖╖╓╬╪│╓╣╣╣╣╣╣╣╬      ╟╣╣╬    ╟╣╣╣ ╒╣╣╖╗╣╣╣╗   ╣╣╣ ╣╣╣╣╣╣ ╟╣╣╖   ╣╣╣
 ╬╬╬╬┐  ╙╬╬╬╬│╓╣╣╣╝╜  ╫╣╣╣╬      ╟╣╣╬    ╟╣╣╣ ╟╣╣╣╙ ╙╣╣╣  ╣╣╣ ╙╟╣╣╜╙  ╫╣╣  ╟╣╣
 ╬╬╬╬┐     ╙╬╬╣╣      ╫╣╣╣╬      ╟╣╣╬    ╟╣╣╣ ╟╣╣╬   ╣╣╣  ╣╣╣  ╟╣╣     ╣╣╣┌╣╣╜
 ╬╬╬╜       ╬╬╣╣      ╙╝╣╣╬      ╙╣╣╣╗╖╓╗╣╣╣╜ ╟╣╣╬   ╣╣╣  ╣╣╣  ╟╣╣╦╓    ╣╣╣╣╣
 ╙   ╓╦╖    ╬╬╣╣   ╓╗╗╖            ╙╝╣╣╣╣╝╜   ╘╝╝╜   ╝╝╝  ╝╝╝   ╙╣╣╣    ╟╣╣╣
   ╩╬╬╬╬╬╬╦╦╬╬╣╣╗╣╣╣╣╣╣╣╝                                             ╫╣╣╣╣
      ╙╬╬╬╬╬╬╬╣╣╣╣╣╣╝╜
          ╙╬╬╬╣╣╣╜
             ╙

 Version information:
  ml-agents: 0.30.0,
  ml-agents-envs: 0.30.0,
  Communicator API: 1.5.0,
  PyTorch: 1.7.1+cu110
Traceback (most recent call last):
  File "E:\Miniconda\envs\coding3Final\lib\runpy.py", line 194, in _run_module_as_main
    return _run_code(code, main_globals, None,
  File "E:\Miniconda\envs\coding3Final\lib\runpy.py", line 87, in _run_code
    exec(code, run_globals)
  File "E:\Miniconda\envs\coding3Final\Scripts\mlagents-learn.exe\__main__.py", line 7, in <module>
  File "E:\Miniconda\envs\coding3Final\lib\site-packages\mlagents\trainers\learn.py", line 264, in main
    run_cli(parse_command_line())
  File "E:\Miniconda\envs\coding3Final\lib\site-packages\mlagents\trainers\learn.py", line 260, in run_cli
    run_training(run_seed, options, num_areas)
  File "E:\Miniconda\envs\coding3Final\lib\site-packages\mlagents\trainers\learn.py", line 75, in run_training
    validate_existing_directories(
  File "E:\Miniconda\envs\coding3Final\lib\site-packages\mlagents\trainers\directory_utils.py", line 25, in validate_existing_directories
    raise UnityTrainerException(
mlagents.trainers.exception.UnityTrainerException: Previous data from this run ID was found. Either specify a new run ID, use --resume to resume this run, or use the --force parameter to overwrite existing data.

(coding3Final) E:\UnityHub\Unity Project\Coding3MLAgent2>mlagents-learn --run-id=test2

            ┐  ╖
        ╓╖╬│╡  ││╬╖╖
    ╓╖╬│││││┘  ╬│││││╬╖
 ╖╬│││││╬╜        ╙╬│││││╖╖                               ╗╗╗
 ╬╬╬╬╖││╦╖        ╖╬││╗╣╣╣╬      ╟╣╣╬    ╟╣╣╣             ╜╜╜  ╟╣╣
 ╬╬╬╬╬╬╬╬╖│╬╖╖╓╬╪│╓╣╣╣╣╣╣╣╬      ╟╣╣╬    ╟╣╣╣ ╒╣╣╖╗╣╣╣╗   ╣╣╣ ╣╣╣╣╣╣ ╟╣╣╖   ╣╣╣
 ╬╬╬╬┐  ╙╬╬╬╬│╓╣╣╣╝╜  ╫╣╣╣╬      ╟╣╣╬    ╟╣╣╣ ╟╣╣╣╙ ╙╣╣╣  ╣╣╣ ╙╟╣╣╜╙  ╫╣╣  ╟╣╣
 ╬╬╬╬┐     ╙╬╬╣╣      ╫╣╣╣╬      ╟╣╣╬    ╟╣╣╣ ╟╣╣╬   ╣╣╣  ╣╣╣  ╟╣╣     ╣╣╣┌╣╣╜
 ╬╬╬╜       ╬╬╣╣      ╙╝╣╣╬      ╙╣╣╣╗╖╓╗╣╣╣╜ ╟╣╣╬   ╣╣╣  ╣╣╣  ╟╣╣╦╓    ╣╣╣╣╣
 ╙   ╓╦╖    ╬╬╣╣   ╓╗╗╖            ╙╝╣╣╣╣╝╜   ╘╝╝╜   ╝╝╝  ╝╝╝   ╙╣╣╣    ╟╣╣╣
   ╩╬╬╬╬╬╬╦╦╬╬╣╣╗╣╣╣╣╣╣╣╝                                             ╫╣╣╣╣
      ╙╬╬╬╬╬╬╬╣╣╣╣╣╣╝╜
          ╙╬╬╬╣╣╣╜
             ╙

 Version information:
  ml-agents: 0.30.0,
  ml-agents-envs: 0.30.0,
  Communicator API: 1.5.0,
  PyTorch: 1.7.1+cu110
[INFO] Listening on port 5004. Start training by pressing the Play button in the Unity Editor.
[INFO] Connected to Unity environment with package version 2.0.1 and communication version 1.5.0
[INFO] Connected new brain: MoveToGoal?team=0
[WARNING] Behavior name MoveToGoal does not match any behaviors specified in the trainer configuration file. A default configuration will be used.
[INFO] Hyperparameters for behavior name MoveToGoal:
        trainer_type:   ppo
        hyperparameters:
          batch_size:   1024
          buffer_size:  10240
          learning_rate:        0.0003
          beta: 0.005
          epsilon:      0.2
          lambd:        0.95
          num_epoch:    3
          shared_critic:        False
          learning_rate_schedule:       linear
          beta_schedule:        linear
          epsilon_schedule:     linear
        network_settings:
          normalize:    False
          hidden_units: 128
          num_layers:   2
          vis_encode_type:      simple
          memory:       None
          goal_conditioning_type:       hyper
          deterministic:        False
        reward_signals:
          extrinsic:
            gamma:      0.99
            strength:   1.0
            network_settings:
              normalize:        False
              hidden_units:     128
              num_layers:       2
              vis_encode_type:  simple
              memory:   None
              goal_conditioning_type:   hyper
              deterministic:    False
        init_path:      None
        keep_checkpoints:       5
        checkpoint_interval:    500000
        max_steps:      500000
        time_horizon:   64
        summary_freq:   50000
        threaded:       False
        self_play:      None
        behavioral_cloning:     None
[WARNING] Restarting worker[0] after 'The Unity environment took too long to respond. Make sure that :
         The environment does not need user interaction to launch
         The Agents' Behavior Parameters > Behavior Type is set to "Default"
         The environment and the Python interface have compatible versions.
         If you're running on a headless server without graphics support, turn off display by either passing --no-graphics option or build your Unity executable as server build.'
[INFO] Listening on port 5004. Start training by pressing the Play button in the Unity Editor.
[INFO] Exported results\test2\MoveToGoal\MoveToGoal-1792.onnx
[INFO] Copied results\test2\MoveToGoal\MoveToGoal-1792.onnx to results\test2\MoveToGoal.onnx.
Traceback (most recent call last):
  File "E:\Miniconda\envs\coding3Final\lib\runpy.py", line 194, in _run_module_as_main
    return _run_code(code, main_globals, None,
  File "E:\Miniconda\envs\coding3Final\lib\runpy.py", line 87, in _run_code
    exec(code, run_globals)
  File "E:\Miniconda\envs\coding3Final\Scripts\mlagents-learn.exe\__main__.py", line 7, in <module>
  File "E:\Miniconda\envs\coding3Final\lib\site-packages\mlagents\trainers\learn.py", line 264, in main
    run_cli(parse_command_line())
  File "E:\Miniconda\envs\coding3Final\lib\site-packages\mlagents\trainers\learn.py", line 260, in run_cli
    run_training(run_seed, options, num_areas)
  File "E:\Miniconda\envs\coding3Final\lib\site-packages\mlagents\trainers\learn.py", line 136, in run_training
    tc.start_learning(env_manager)
  File "E:\Miniconda\envs\coding3Final\lib\site-packages\mlagents_envs\timers.py", line 305, in wrapped
    return func(*args, **kwargs)
  File "E:\Miniconda\envs\coding3Final\lib\site-packages\mlagents\trainers\trainer_controller.py", line 175, in start_learning
    n_steps = self.advance(env_manager)
  File "E:\Miniconda\envs\coding3Final\lib\site-packages\mlagents_envs\timers.py", line 305, in wrapped
    return func(*args, **kwargs)
  File "E:\Miniconda\envs\coding3Final\lib\site-packages\mlagents\trainers\trainer_controller.py", line 233, in advance
    new_step_infos = env_manager.get_steps()
  File "E:\Miniconda\envs\coding3Final\lib\site-packages\mlagents\trainers\env_manager.py", line 124, in get_steps
    new_step_infos = self._step()
  File "E:\Miniconda\envs\coding3Final\lib\site-packages\mlagents\trainers\subprocess_env_manager.py", line 420, in _step
    self._restart_failed_workers(step)
  File "E:\Miniconda\envs\coding3Final\lib\site-packages\mlagents\trainers\subprocess_env_manager.py", line 328, in _restart_failed_workers
    self.reset(self.env_parameters)
  File "E:\Miniconda\envs\coding3Final\lib\site-packages\mlagents\trainers\env_manager.py", line 68, in reset
    self.first_step_infos = self._reset_env(config)
  File "E:\Miniconda\envs\coding3Final\lib\site-packages\mlagents\trainers\subprocess_env_manager.py", line 446, in _reset_env
    ew.previous_step = EnvironmentStep(ew.recv().payload, ew.worker_id, {}, {})
  File "E:\Miniconda\envs\coding3Final\lib\site-packages\mlagents\trainers\subprocess_env_manager.py", line 101, in recv
    raise env_exception
mlagents_envs.exception.UnityTimeOutException: The Unity environment took too long to respond. Make sure that :
         The environment does not need user interaction to launch
         The Agents' Behavior Parameters > Behavior Type is set to "Default"
         The environment and the Python interface have compatible versions.
         If you're running on a headless server without graphics support, turn off display by either passing --no-graphics option or build your Unity executable as server build.
```
