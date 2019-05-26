# Observer Mode

## Feature
 - 意圖：在物件之間定義一種一對多的相依關係，如此當一個物件的狀態改變時，所有相依者都將得到通知並自動更新。
 - 問題：當某個事件發生時，需要向一系列變化著的物件發出通知。
 - 解決方案：Observer 將監視某個事件的責任委託給中心物件：Subject。
 - 參與者與協作者：Subject 知道自己的Observer，因為Observer 要向它註冊。Subject 必須在所監視的事件發生時通知Observer。Observer 負責向Subject 註冊，以及在得到通知時從Subject 處獲取資訊。
 - 效果：如果某些Observer 只對事件的一個子集感興趣，那麼Subject 可能會告訴他們不需要知道的事件(參見18.6節)。如果Subject 通知Observer，Observer 還返回請求更多資訊，則可能需要額外的通訊。 
 - 實作：讓某個事件發生時需要知道的物件(Observer)將自己註冊到另一個監視事件發生或自己觸發事件的物件(Subject)上。事件發生時，Subject 告訴Observer 事件已發生。為了對所有Observer類型的物件實作Observer介面，有時候需要使用Adapter模式。