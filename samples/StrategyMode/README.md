# Strategy Mode

## Feature
 - 意圖：可以根據所處上下文，使用不同的業務規則與演算法。
 - 問題：對所需的演算法的選則取決於發出請求的客戶或者要處理的資料。如果只有一寫不會變化的演算法，就不需要Startegy 模式
 - 解決方案：將對演算法的選擇和演算法的實作相分離。允許根據上下文進行選擇。
 - 參與者與協作者：
   - Strategy 指定了如何使用不同的演算法。
   - 各ConcreteStrategy 時做了這些不同的演算法。
   - Context 透過類型為Strategy 的參照使用具體的ConcreteStrategy。Strategy 與各Context 將來自Client 的請求轉發給Strategy。
 - 效果：
   - Strategy 模式定義了一系列的演算法。
   - 可以不使用switch 語句或條件陳述式。
   - 必須以相同方式呼將所有的眼算法(他們必須與有相同的介面)。各ConcreteStrategy 與Context 之間的相互作用可能需要在Context 中加入獲取狀態的方法。 
 - 實作：讓使用演算法的類別(Context)包含一個抽象類別(Strategy)，該抽象類別有一個抽象方指定如何呼叫演算法。每個衍生類別依需要實作演算法。
 注意，在原型Strategy 模式中，選擇所用具體實作的職責由Client 物件承擔，並轉給Strategy 模式的Context 物件