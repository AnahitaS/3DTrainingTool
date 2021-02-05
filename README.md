# 3DTrainingTool Demo
### Objective: 
Developing and validating a novel domain-agnostic, computer-based training game in Unity for enhancing 2D cross-section understanding of complex 3D structures. 

### Background: 
Understanding 2D cross-sections of 3D structures is a crucial skill in many disciplines, from geology to medical imaging (e.g., 3D image segmentation). It requires a complex set of spatial/visualization skills including mental rotation, spatial structure understanding, and viewpoint projection. Prior studies show that experts differ from novices in these skills. We designed a novel 3D/interactive training game based on a hierarchical model that captures difficulty levels for the different required spatial skills, such as viewpoint manipulation. Our tool steadily increases the difficulty level of individual spatial skills (viewpoint, orientation of the slicing plane, etc.) through a series of guided tasks. We use both geometric and organic (e.g., structures with branching) 3D models in the training to match the segmentation task more closely. Within each guided task, participants infer the 2D cross-section of a 3D object while interacting with 3D models (viewpoint change), observing how a cross-section shape changes after adjusting the slicing plane location and/or orientation. The participants can request help as needed and receive corrective feedback before moving on to the next task.

### Implmentaion:
We used Unity/C# for developing the training game. We created 3D models using 3D Studio Max and ZBrush.
