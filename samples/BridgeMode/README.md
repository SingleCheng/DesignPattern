# Bridge Mode

## Feature
 - 意圖：將一組實作與另一組使與它的們物件分離。
 - 問題：一個抽象類別的衍生類別必須使用多個實作，但不能出現類別數量爆炸性成長。
 - 解決方案：為所有實作定義一個介面，供抽象類別的所有衍生類別使用。
 - 參與者與協作者：Abstraction 為要實作的物件定義介面，Implementor 為具體的實作類別定義介面。Abstraction 的衍生類別使與Implementor 的衍生類別，卻無需知道自己具體使用哪一個ConcreteImplementot。
 - 效果：實作與使用時做的物件以解耦，提供了可擴展性，客戶物件無需操心實作問題。
 - 實作：
    - 將實作封裝在一個抽象類別中。
    - 在要時做的抽象的基礎類別中包含一個實作的控制碼。