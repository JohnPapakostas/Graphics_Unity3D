# Graphics_Unity3D

A Unity3D project exploring graphics / shader work in Unity.  
This repository contains the Unity project, C# scripts, and HLSL/ShaderLab assets used to build and experiment with rendering techniques.

## Table of Contents

- [About](#about)  
- [Features](#features)  
- [Getting Started](#getting-started)  
- [Project Structure](#project-structure)  
- [Requirements](#requirements)  
- [Usage](#usage)  
- [Contributing](#contributing)  
- [License](#license)  

## About

The Graphics_Unity3D project aims to serve as a sandbox for investigating advanced graphics effects in Unity, including custom shaders (HLSL / ShaderLab) and C# script integration.  
The project is built primarily using C# (≈ 15 %) and ShaderLab / HLSL (≈ 85 %) according to language breakdown. :contentReference[oaicite:2]{index=2}

## Features

- Custom ShaderLab / HLSL shader examples  
- Unity configured project with assets organised  
- C# scripts demonstrating interaction between Unity engine and shader logic  
- A playground for exploring rendering pipelines, materials & graphics programming  
- Easy to extend for your own experiments

## Getting Started

### Requirements

- Unity (version: please use the version you developed with — e.g. Unity 2021.x or newer)  
- Compatible graphics hardware supporting shaders  
- Git (to clone the repository)  

### Installation

```bash
git clone https://github.com/JohnPapakostas/Graphics_Unity3D.git
cd Graphics_Unity3D
```
### Project Structure 
Graphics_Unity3D/

├─ Assets/             ← Unity asset folder (scenes, scripts, shaders, materials)

├─ Packages/           ← Unity packages and dependencies

├─ ProjectSettings/    ← Unity project configuration

├─ obj/Debug/          ← Build/debug artefacts (auto-generated)

├─ Assembly-CSharp.csproj

├─ Graphics2.sln       ← Visual Studio solution (if applicable)

└─ README.md

### Usage

- Explore the scenes inside the Assets/ folder.
- Open any shader in Assets/Shaders/ (or similar folder) to view HLSL/ShaderLab code.
- Inspect C# scripts to see how Unity objects, materials and shaders interact.
- Modify or extend the shaders to experiment with new effects (e.g., lighting models, post-processing, custom rendering passes).
- Build & run the project to preview results in Unity’s Play mode.
