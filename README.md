# Brain Scan Machine Learning.


## Discription:
---
This is a project that demonstrates a Proof-of-concept of a Machine Learning model that can determine from na image whether a brain is healthy or has tumor by using 
Image classification in ML.NET

<br>

## Task:

Modellen skal ud fra et billede kunne opfange om en hjerne har en svulst eller ej.

<br>

## Data:

Datasættet Kommer fra Kaggle.com og indeholder scanningsbilleder af raske hjerner og hjerner der har en form for svulst.

<br>

## Checklist:
- [x] Make ML model.
- [x] Make sure it works.
- [x] Make Blazor.
- [x] Make Frontend.
- [x] Make Backend.
- [x] Improve iteration #1 95% - 96% Accuracy
- [ ] Improve iteration #2

<br>

## Roadmap:

- [x] Collect Data(check for noise) 
- [ ] ~~~~Make Object Detection model. 
- [x] Make a useable model with high enough accuracy.
- [x] Create a simple ConsoleApp to make a demo on.
- [x] Create a web application with frontend.
  - [ ] ~~Blazor Webassembly and API with JSON 
  - [ ] ~~Blazor Server and API with JSON.
  - [x] Blazor Server with ML Model in razor component.
- [x] Make 2-3 Iterrations to see an improvement in model accuracy.

<br>

## Folder Structure:

```
ML_Project
| README.md
├── ML_Project
├── MLBlazorServer
└── TumorClassificationModel_Console
    └── TumorClassificationModel.mbconfig

```
<br>

## Tools:

| Name      | Version   |
|-----------|-----------|
| Blazor server | net6.0|
| ML.NET | 16.13.10.2241902 |
