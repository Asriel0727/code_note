using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EXObserver : MonoBehaviour
{
    private void Start()
    {
        CEOHelper ceoHelper = new CEOHelper();
        //新建同事 觀察者角色
        Observer tongshi1 = new PlanningObserver("Anne", ceoHelper);
        Observer tongshi2 = new ArtObserver("Bruce", ceoHelper);
        //ceoHelper要知道哪些同事要通知（主題要知道所有自己的觀察者）
        ceoHelper.Add(tongshi1);
        ceoHelper.Add(tongshi2);
        //主題狀態更改了
        ceoHelper.SubjectState = "Ian回來了！";
        //呼叫主題的通知方法
        ceoHelper.Notify();
    }

    //主體定義
    public interface ISubject
    {

        //新增觀察者
        void Add(Observer observer);
        //刪除觀察者
        void Remove(Observer observer);
        //主題狀態
        string SubjectState { get; set; }
        //通知方法
        void Notify();
    }

    //具體主體
    public class CEOHelper : ISubject
    {
        //CEOHelper要知道通知哪些同事
        private IList<Observer> observers = new List<Observer>();

        public void Add(Observer observer)  //新增同事實作
        {
            observers.Add(observer);
        }
        public void Remove(Observer observer)   //刪除同事實作
        {
            observers.Remove(observer);
        }
        public string SubjectState { get; set; }
        public void Notify()
        {
            foreach (Observer i in observers)
            {
                i.Update();
            }
        }
    }
    //觀察者
    public abstract class Observer
    {
        //同事名字
        protected string name;
        //觀察者要知道自己應該要收到怎麼樣的通知(根據部門)
        protected ISubject sub;
        public Observer(string name, ISubject sub)
        {
            this.name = name;
            this.sub = sub;
        }
        //接受到通知後的更新方法
        public abstract void Update();
    }
    //企劃部門的同事
    public class PlanningObserver : Observer
    {
        public PlanningObserver(string name, ISubject sub) : base(name, sub) { }
        public override void Update()
        {
            Debug.Log($"Erica：{sub.SubjectState},反應：{name}繼續企劃測試！");
        }
    }
    //美術部門的同事
    public class ArtObserver : Observer
    {
        public ArtObserver(string name, ISubject sub) : base(name, sub) { }
        public override void Update()
        {
           Debug.Log($"Erica：{sub.SubjectState},反應：{name}繼續繪圖！");
        }
    }
}
