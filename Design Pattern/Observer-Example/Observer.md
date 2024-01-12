# Observer-Example
觀察者模式範例紀錄

*當多個 Class 都需要接收同一種資料的變化時，就適合使用 Observer Pattern*

「多個 Class 」指的就是「觀察者」，而「同一種資料」指的就是觀察者們想了解的「主題」。

Observer Pattern 實作的原理就是把獲取資料的部分抽離出來，並在資料改變時，同步送給所有的觀察者。

且觀察者可以在任何時候決定是否要繼續接收資料。

## 實做大至分類:
主體類別

* 設計觀察者的 Interface (*例如訂閱者*)
``` C#
public interface IObserver{
    
    //更新方法
    void update(string message);
}
```
實作觀察者類別 (*實作IObserver*)
```C#
public class YoutubeSubscriber : IObserver
{
    // 觀察者的名字
    public string Name { get; private set; }

    // YoutubeSubscriber 類別的建構函式
    public YoutubeSubscriber(string name)
    {
        // 初始化觀察者的名字
        Name = name;
    }

    // 實作觀察者更新方法
    public void Update(string message)
    {
        Console.WriteLine($"{Name} 收到通知：{message}");
        // 在這裡可以添加觀察者收到通知後的其他處理邏輯
    }
}
```
---
* 設計主題的 Interface (*例如 Youtuber*)
``` C#
public interface IYoutuber { //Subject
    
    // 註冊方法
    void RegisterObserver(IObserver observer);

    // 取消註冊方法
    void RemoveObserver(IObserver observer);

    // 通知方法（執行 Observer 的更新方法）
    void NotifyObservers();
}
```

實作主題類別 (*實作 IYoutuber*)
``` C#
public class Youtuber : IYoutuber{   //Subject 實例
    
    // 觀察者列表
    private List<IObserver> observers;

    // Youtuber 的名字
    public string Name { get; private set; }

    // Youtuber 類別的建構函式
    public Youtuber(string name)
    {
        // 初始化 Youtuber 的名字
        Name = name;

        // 初始化觀察者列表
        observers = new List<IObserver>();
    }

    // 註冊觀察者的方法
    public void RegisterObserver(IObserver observer)
    {
        observers.Add(observer);
    }

    // 取消註冊觀察者的方法
    public void RemoveObserver(IObserver observer)
    {
        int targetIndex = observers.IndexOf(observer);
        if (targetIndex != -1)
        {
            observers.RemoveAt(targetIndex);
        }
    }

    // 通知觀察者的方法
    public void NotifyObserver()
    {
        foreach (IObserver observer in observers)
        {
            observer.Update($"{Name} 有新影片了！");
        }
    }

    // 發佈新影片的方法
    public void PublishVideo()
    {
        NotifyObserver();
    }
}

