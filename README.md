# BackendTest - 員工管理系統 API
本專案為一個基於 ASP.NET Core 10.0 開發的後端 RESTful API 範例，主要展示與資料庫的完整 CRUD 互動、資源導向的路由設計，以及自動化 API 測試介面的整合。

## 技術棧 (Tech Stack)
Framework: .NET 10.0 (Web API)
ORM: Entity Framework Core
Database: SQL Server
API Documentation: OpenAPI (Scalar & Scalar UI)
Architecture: Resource-based RESTful API

## API 端點說明 (Endpoints)
方法,路徑,說明
GET,/api/myofficeacpd,取得所有員工清單
GET,/api/myofficeacpd/{id},取得指定編號的員工詳細資料
POST,/api/myofficeacpd,新增一名員工 (Body 需含 JSON)
PUT,/api/myofficeacpd/{id},修改指定員工資料
DELETE,/api/myofficeacpd/{id},刪除指定員工

## 快速開始 (Quick Start)
1. 資料庫設定：
* 請確保 SQL Server 內已建立 MercuryFire 資料庫及 MyOffice_ACPD 資料表。
* 修改 appsettings.json 中的 DefaultConnection 連線字串。
2. 啟動專案：
* 在 Visual Studio 中按 F5。
* 瀏覽器將自動開啟至 https://localhost:7195/scalar/v1。
3. 進行測試：
* 點擊 API 方法後選擇 Test Request。
* POST 與 PUT 已內建測試用 JSON 資料範本（如 A001, 秋天）。

## 測試範例 (JSON Example)
在進行 POST 測試時，可使用以下範本：
{
  "acpdSid": "A001",
  "acpdCname": "秋天",
  "acpdStatus": 1
}
