[RequireComponent(typeof())]
===
> 在 Unity 編輯器中使用腳本時，相應的遊戲物件上將始終存在一個 對應Script組件。


###1. 語法結構
```
[RequireComponent(typeof(要配在一起的Script))]
public class YourScript : MonoBehaviour
{
    // Your script logic here
}
```

###2. 用途
- 這個特性通常應用在繼承自 MonoBehaviour 的腳本類別上。
- 當你將這個腳本添加到 Unity 編輯器中的遊戲物件上時，Unity 將自動確保該遊戲物件上有一個 Script 組件。

###3. 效果
- 如果添加了 [RequireComponent(typeof(Script))]，但是在遊戲物件上找不到Script組件時，Unity 將自動將 Script 組件添加到該遊戲物件上。
- 如果遊戲物件上已經有 Script 組件，Unity 不會額外添加。

###4. 注意事項
- 該特性僅在遊戲物件上添加腳本時生效，而不是在代碼中動態添加組件的情況下。
- 在使用這個特性時，請確保腳本的適用情境是確實需要 Movement 組件的存在。