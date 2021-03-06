# Singleton Mode

## Feature
 - 意圖：希望物件只有一個實體，但沒有控制物件實體化的全域物件。還希望確保所有實體使用該物件相同的實體，而無須將參照傳給它們。
 - 問題：幾個不同的客戶物件需要參照同一物件，而且希望確保這種類型的物件數目不超過一個。
 - 解決方案：保證一個時體。
 - 參與者與協作者：Client 物件只能夠過getInstance 方法建立Singleton 實體。
 - 效果：Client 物件無需操心使否已經存在Singleton 實體。這是由Singleton 自己控制的。
 - 實作：
  - 增加一個類別的私有的靜態成員變數，參照所需的物件(初始值為null)
  - 增加一個公共靜態方法，它在成員變數的值為null 時實體化這個類別(並設定成員變數的值)，然後返回該成員變數的值。
  - 將建構函數的狀態設定為保護或者私有，防止任何人直接實體化這個類別，繞過靜態建構函數機制。