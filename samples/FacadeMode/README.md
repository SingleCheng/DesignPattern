# Facade Mode

## Feature
 - 意圖：希望簡化原有系統的使用方式。需要定義自己的介面。
 - 問題：只需要使某個複雜系統的子集，或者，需要以一種特殊的方式與系統交流。
 - 解決方案：Facade 為原有系統的客戶提供了一個新的介面。
 - 參與者與協作者：為客戶提供的一個簡化介面，使系統更容易使用。
 - 效果：Facade 模式簡化了對所需的子系統的使用過程。但是，由於Facade 並不完整，因此客戶可能無法使用某些功能。
 - 實作：
    - 定義一個(或多個)具備所需介面的新類別。
    - 讓新的類別使用原有的系統。