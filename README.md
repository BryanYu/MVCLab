# MVCLab
ASP.NET MVC 教學程式碼

資料夾說明：
* DB: 放範例資料庫(OneCenter)的SQL語法檔
* OneCenter 
* OneCenter.Basic ：示範C#語法的專案
* OneCenter.DAL ：EntityFramework 專案
* OneCenter.Utility ： 共用工具專案

`OneCenter.DAL` 中有`OneCenter.mdf`檔，可以自行使用`localdb`掛載，目前DAL專案是連線到`localdb`，如果要改連自己的本地資料庫，
請自行修改 `OneCenter.DAL\App.Config` 的 `connectionStrings` 字串。
          
          
            
