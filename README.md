# OLED漢字轉換
![xbm_banner](https://github.com/user-attachments/assets/aecdf75e-17e3-4a85-8f5d-d8235d22831d)

## 需求
[.NET 8.0 Desktop Runtime (v8.0.12)](https://dotnet.microsoft.com/zh-tw/download/dotnet/thank-you/runtime-desktop-8.0.12-windows-x64-installer?cid=getdotnetcore) <br>
本軟體僅能運行在Windows上！  
<b>為了獲得最佳的使用體驗，請至Windows設定將顯示比例調整為100%，以避免生成的圖片發生錯位！(很重要！！)</b>  
![image](https://github.com/user-attachments/assets/0c03697a-7356-411b-b0f7-da9d89586cc9)


## 核心功能
- [x] 將各種文字(如漢字)轉換成點陣格式(XBM)
- [x] 輸入一串文字來選取其中需要的文字
- [x] 輸入過程自動轉換
- [x] 適配各種像素大小

## 文字功能
- [x] 修改字體
- [x] 修改大小
- [x] 英文全形半形調整
- [x] 顏色反轉(黑底白或白底黑)
- [x] 一鍵複製到剪貼簿
- [x] 調整容許值

## 儲存功能
- [x] 儲存為圖片檔
- [x] 儲存為二進制檔
- [x] 儲存為點陣格式檔(XBM)

## 額外功能
- [x] 模擬顯示到OLED上的效果(SSD1306 0.96吋)
- [x] 手動像素編輯功能

## 相關截圖
原始畫面  
![image](https://github.com/user-attachments/assets/a8fd28d8-b9d1-400f-85be-2dc1f82b94a7)  

漢字測試  
![image](https://github.com/user-attachments/assets/2ef0a39b-7035-45a5-92fd-115a6cea33ae)  

支持一個句子並從中選擇要轉換的文字  
![image](https://github.com/user-attachments/assets/6cf86368-5413-498b-9017-69bb19277d21)  

容許值功能展示與對比  
![容許值](https://github.com/user-attachments/assets/23f4451a-8217-4583-9c31-4a5e7ff9abc8)  

模擬預覽功能  
![image](https://github.com/user-attachments/assets/792bb92a-50e7-4465-973c-076a938d7e4a)  

手動畫布編輯功能  
![image](https://github.com/user-attachments/assets/bd1f527a-990d-47f0-92b0-c766cd70cb6d)  

## 備註
這項目是2023年11月的時候開始製作的，原因是我們在做專題時測試Arduino OLED的文字的時候遇到中文字無法顯示的問題，但是如果要透過老師的方法要許多繁瑣的步驟才能把中文字顯示在上面，所以我們反覆測試發現有XBM這個格式可以上傳至OLED上顯示圖片內容，那時候我就在想如果可以把文字轉成圖片後再轉換成XBM格式就好了，因此我花了幾天的時間就把這個專案給搞出來了，也順利完美解決掉中文字的問題。  
另外如果你遇到文字從中間上下翻轉的話，不妨試試把專用格式關閉看看，可能會有奇效。  
你可能還有一個疑問是為什麼隔兩年才上傳到github，<s>絕對不是我忘了傳了</s>  

<b>本專案使用GPL3.0，若需要轉傳或分發請同樣使用GPL開源，若你是學生請註明本專案網址，且嚴禁商用！</b>  
