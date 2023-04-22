# UnityTools
Just some tools for Unity Engine

## Preview Generator
PreviewGenerator is a tool that generate Sprite images of Prefabs  
Just select some Prefabs & Right Click > Create > Sprite Preview  

![screenshot preview](https://github.com/Tequiloutre/UnityTools/blob/main/Screenshots/Screen_Preview.png?raw=true)  |  ![screenshot sprite](https://github.com/Tequiloutre/UnityTools/blob/main/Screenshots/Screen_Preview_Sprite.png?raw=true)
:-------------------------:|:-------------------------:

[📥Download Package](https://github.com/Tequiloutre/UnityTools/releases/download/preview-generator_v1/PreviewGenerator_v1.unitypackage)  
[📥Source code](https://github.com/Tequiloutre/UnityTools/tree/main/UnityTools/Assets/Scripts/PreviewGenerator)

## EditCondition
EditCondition is a CustomAttribute used to show or hide fields depending on another value  
ex : The field "value" is only showed when the bool field "condition" is true

```cs
[SerializeField] private bool condition = false;
[SerializeField, EditCondition("condition")] private int value = 0;
```

![screenshot condition false](https://github.com/Tequiloutre/UnityTools/blob/main/Screenshots/Screen_EditCondition_False.png?raw=true)  |  ![screenshot condition true](https://github.com/Tequiloutre/UnityTools/blob/main/Screenshots/Screen_EditCondition_True.png?raw=true)
:-------------------------:|:-------------------------:

[📥Download Package](https://github.com/Tequiloutre/UnityTools/releases/download/v1/Unity_EditCondition.unitypackage)  
[📥Source code](https://github.com/Tequiloutre/UnityTools/tree/main/UnityTools/Assets/Scripts/EditCondition)

## SerializableDictionary
SDictionary is a Class working as a classic C# Dictionary but it can be serialized and edited in Inspector

```cs
[SerializeField] private SDictionary<string, int> dico = new SDictionary<string, int>();
```

![screenshot dictionary](https://github.com/Tequiloutre/UnityTools/blob/main/Screenshots/Screen_Dico.png)

[📥Download Package](https://github.com/Tequiloutre/UnityTools/releases/download/v2/SerializableDictionary_v2.unitypackage)  
[📥Source code](https://github.com/Tequiloutre/UnityTools/tree/main/UnityTools/Assets/Scripts/SerializableDictionary)
