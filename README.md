# Brain Scan Machine Learning.


## Discription:
---
This is a project that demonstrates a Proof-of-concept of a Machine Learning model that can determine from na image whether a brain is healthy or has tumor by using 
Image classification in ML.NET

<br>

## Task:

This ML Model should predict if a brain is healthy or has a tumor.

<br>

## Data:

The Dataset is from Kaggle.com and contains MRI images of healthy brains and brains with tumor somewhere in it.

## Instructions:

To make a prediction, you must follow these instructions for the program to work properly.
- Click the "Vælg fil"
- Choose an image you want to make a prediction on.  
- **NOTE** The chosen image has to be an MRI scanning, any other image confuse the model.
- When ready click the upload button and wait a few seconds.
- If all above steps were done correctly, you should now see the image you chose and percentage of how sure the program is.


<br>

## Checklist:
- [x] Make ML model.
- [x] Make sure it works.
- [x] Make Blazor.
- [x] Make Frontend.
- [x] Make Backend.
- [x] Improve iteration #1 95,80% - 96,22% Accuracy
- [x] Iteration #2 96,65% - 96,9% Accuracy (AKA: BrainClassificationModel_V1)

<br>

## Roadmap:

- [x] Collect Data(check for noise) 
- [ ] ~~~Make Object Detection model. 
- [x] Make a useable model with high enough accuracy.
- [x] Create a simple ConsoleApp to make a demo on.
- [x] Create a web application with frontend.
  - [ ] ~~~Blazor Webassembly and API with JSON 
  - [ ] ~~~Blazor Server and API with JSON.
  - [x] Blazor Server with ML Model in razor component.
- [x] Make 2-3 Iterrations to see an improvement in model accuracy.

<br>

## Folder Structure:

```
## Main Project

ML_Project
| README.md
├── ML_Project
└── TumorClassificationModel.mbconfig
├── MLBlazorServer
└── TumorClassificationModel_Console
    └── TumorClassificationModel.mbconfig
    
## Folder structure different iterations

ML_Project
|
├── BrainClassificationModel_v1_ConsoleApp
|   └── BrainClassificationModel_v1.mbconfig
├── ML_Project
|   ├── BrainClassificationModel_v1.mbconfig
|   └── TumorClassificationModel.mbconfig
└── MLBlazorServer
```
<br>

## Tools:

| Name      | Version   |
|-----------|-----------|
| Blazor server | net6.0|
| ML.NET | 16.13.10.2241902 |
