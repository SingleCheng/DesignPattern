# Adapter Mode

## Feature
 - 意圖：使控制範圍之外的一個原有物件與某個介面匹配。
 - 問題：系統的資料和行為都正確，但介面不符。通常用於必須從抽象類別衍生時。
 - 解決方案：Adapter 模式提供了具有所需介面的wrapper(包裝)類別
 - 參與者與協作者：Adapter 改變了Adaptee 的介面，使Adaptee 與Adapter 的基礎類別Target 匹配。如此Client 就可以使用Adaptee 了，好像它是Target 類型
 - 效果：Adapter 模式使原有物件譨夠適應新的類別結構，不受其介面的限制。
 - 實作：將原有類別包含在另一個類別之中。讓包含類別與需要的介面匹配，呼叫被複合類別的方法。