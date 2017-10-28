using OneCenter.Basic.Model;
using OneCenter.Basic.Partial;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OneCenter.Basic.Extension;

namespace OneCenter.Basic
{
    /// <summary>
    /// 示範C#基礎
    /// </summary>
    public class BasicDemo
    {
        /// <summary>
        /// 取得名稱多載
        /// </summary>
        /// <param name="id">Id</param>
        /// <returns></returns>
        public string GetName(int id)
        {
            return id.ToString();
        }

        /// <summary>
        /// 取得名稱多載
        /// </summary>
        /// <param name="id">Id</param>
        /// <returns></returns>
        public string GetName(int id, string name)
        {
            return id.ToString() + name;
        }

        /// <summary>
        /// 取得名稱多載
        /// </summary>
        /// <param name="id">Id</param>
        /// <returns></returns>
        public string GetName(int id, string name, string mobile = "")
        {
            return id.ToString() + name + mobile;
        }

        /// <summary>
        /// 示範
        /// </summary>
        public void Run()
        {
            #region 多載

            ///多載：使用同一個方法名稱，但參數可以不同，即可呼叫其他的多載方法
            ///可以搭配optional parameter 減少撰寫多餘的多載方法
            ///請看GetName(int id, string name, string mobile = "") 的 mobile
            ///https://docs.microsoft.com/zh-tw/dotnet/csharp/programming-guide/classes-and-structs/named-and-optional-arguments
            this.GetName(1);
            this.GetName(1, "Bryan");
            this.GetName(1, "Bryan"); /// 第三個參數可丟可不丟

            #endregion 多載

            #region 泛型

            ///泛型可以指定不同的型別，具有型別安全等優點，可以讓你有彈性的運用
            ///https://docs.microsoft.com/zh-tw/dotnet/csharp/programming-guide/generics/
            ///下面List<T> 的 <T> ,T 指的是泛型的型別 (可以是你自己建的類別或是其他型別)
            ///一旦指定泛型型別後，就可以強制使用該型別，就像testAList一定不能加入TestB的類別
            List<TestA> testAList = new List<TestA>();
            List<TestB> testBList = new List<TestB>();
            //testAList.Add(new TestB()); ->Error

            #endregion 泛型

            #region 條件式編譯

            ///條件式編譯可以讓你在程式編譯時選擇你要的區塊
            ///例如我們現在是Debug組態，下面的Debug是沒有反灰的，但RELEASE是反灰的
            ///所以當我們使用Debug輸出，裡面的dll只會包含沒有反灰的區塊
            ///
#if DEBUG
            Console.WriteLine("Debug");
#endif

#if RELEASE
            Console.WriteLine("Release");
#endif

            #endregion 條件式編譯

            #region 部分類別(Partial Class)

            ///Partial Class 可以讓你在不同的檔案中編輯同一個類別
            ///編譯器在編譯時會將這些檔案合併成同一個類別
            ///要注意的是Partial Class 必須都存在同一個命名空間下(namespace)

            var demoA = new DemoA();
            //DemoA.cs裡面的方法
            demoA.MethodA();
            //Partial.DemoA.cs裡面的方法
            demoA.MethodB();

            #endregion 部分類別(Partial Class)

            #region 擴充方法(Extension)

            ///擴充方法可以讓你自己開發對於該型別的一些方法
            ///在這個例子中，我們對Enum型別開發了一個取得Description的Name的方法
            ///要注意的是擴充方法必須為static 方法參數第一個要為要擴充的型別
            ///(參考EnumExtension寫法)

            DemoEnum.One.GetDescription(); // 擴充方法(在EnumExtension.cs)
            int i = 0;
            i = i.GetNextNumber(); // 擴充方法(在IntergerExtension.cs)

            int j = 5;
            j = j.GetMutiple(10);

            #endregion 擴充方法(Extension)
        }
    }
}