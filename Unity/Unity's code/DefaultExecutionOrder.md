DefaultExecutionOrder相關語法

[DefaultExecutionOrder]
---
> 腳本執行順序，越小越先執行，可以為負數

###1. 使用情境
> 用於指定腳本類別的默認執行順序。這可以影響 Unity 引擎在遊戲執行時呼叫腳本中的方法的順序。

###2. 語法結構
```
[DefaultExecutionOrder(-10)]
public class YourScript : MonoBehaviour
{
    // Your script logic here
}
```

###3. 用途
- 這個特性用於指定 MonoBehaviours 的默認執行順序。MonoBehaviours 是 Unity 中用於附加到遊戲物件的腳本類別。

###4. 效果
- 默認情況下，Unity 根據腳本類別的添加順序來確定其執行順序。
- 使用 [DefaultExecutionOrder(-10)] 可以將指定的腳本類別的執行順序設定為優先於默認順序的位置（-10 較優先於默認順序）。

###5. 注意事項
- [DefaultExecutionOrder] 可以用於避免依賴順序導致的問題，確保某些腳本的方法在其他腳本之前或之後執行。
- 默認順序為 0，負數值表示更早執行，正數值表示更晚執行。
