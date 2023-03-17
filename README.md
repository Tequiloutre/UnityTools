# UnityTools
Just some tools for Unity Engine

## EditCondition
EditCondition is a CustomAttribute used to show or hide fields depending on another value  
ex : The field "value" is only showed when the bool field "condition" is true
```cs
[SerializeField] private bool condition = false;
[SerializeField, EditCondition("condition")] private int value = 0;
```
![screenshot condition false](https://github.com/Tequiloutre/UnityTools/blob/main/Screenshots/Screen_EditCondition_False.png?raw=true)
![screenshot condition true](https://github.com/Tequiloutre/UnityTools/blob/main/Screenshots/Screen_EditCondition_True.png?raw=true)

[📥Download Package](https://github.com/Tequiloutre/UnityTools/releases/download/v1/Unity_EditCondition.unitypackage)  
[📥Source code](https://github.com/Tequiloutre/UnityTools/tree/main/UnityTools/Assets/Scripts/EditCondition)
