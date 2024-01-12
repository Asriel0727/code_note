Serializable相關語法

[System.Serializable]
---
> 在 Unity 編輯器中顯示在屬性面板中，並可以方便地進行序列化和反序列化操作。

###1. 使用情境
> 目的是使一個類別（class）或結構（struct）能夠被序列化（serialization），通常是為了方便在不同的環境之間傳遞數據，或者在 Unity 中使其可在編輯器中顯示和修改。

###2. 語法結構
```
[System.Serializable]
public class YourSerializableClass
{
    // Your class members here
}
```

###3. 用途
- 該特性通常應用在需要在不同環境中進行數據序列化和反序列化的類別上。
- 在 Unity 中，它通常應用在自定義的腳本類別，以便在編輯器中顯示類別的實例並允許對其進行序列化。

###4. 效果
- 被標記為 [System.Serializable] 的類別可以被序列化為 JSON、XML 等格式，以便在不同的環境中進行數據交換。
- 在 Unity 編輯器中，被標記為 [System.Serializable] 的類別的實例將在屬性面板中顯示，並允許你直接修改其字段值。

###5. 注意事項
- 該特性僅標記類別為可序列化，並不添加任何實際的代碼邏輯。
- 在 Unity 中，如果你希望在編輯器中顯示和修改自定義類別的實例，通常需要將該類別標記為 [System.Serializable]。

---

[Serializable]
---
###1. 語法結構
```
[Serializable]
public class YourSerializableClass
{
    // Your class members here
}
```