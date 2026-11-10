# LOG — Nhật ký làm việc

> Mới nhất ở **trên**. Không sửa entry cũ, chỉ thêm entry mới.

<!-- Mẫu entry:

## YYYY-MM-DD — Tiêu đề ngắn
- **Làm:** ...
- **File:** ...
- **Quyết định:** D-xxx (nếu có)
- **Tiếp theo:** ...
- **Chặn:** ...

-->

## 2026-11-10 — Tạo bảng refresh_tokens + scaffold

- **Làm:** đã chạy SQL tạo `refresh_tokens`; scaffold lại sinh entity `RefreshToken` (tổng 8 entity); build 0 warning/error.
- **Tiếp theo:** T-011 JWT/CORS/static files.

## 2026-11-10 — Chốt thời hạn token + bảng refresh_tokens

- **Chốt:** access token **10 phút**, refresh token **7 ngày**; cập nhật `appsettings.json`, `API.md`, `CONVENTIONS.md`, `DECISIONS.md`.
- **DB:** thêm script tạo `refresh_tokens` vào `DATABASE.md`; T-107 mở lại.
- **Tiếp theo:** chạy SQL, re-scaffold entity `RefreshToken`, rồi T-011 JWT/CORS.

## 2026-11-10 — Kết nối DB + scaffold DB-first

- **Làm:** lưu connection string vào user-secrets; scaffold 7 entity + `AppDbContext` từ PostgreSQL `SnackShopManagementSystem`; đăng ký DbContext; build OK; `dotnet ef dbcontext info` xác nhận đúng DB.
- **File:** `backend/SnackShop.Api/Data/AppDbContext.cs`, `Models/Entities/*`, `Program.cs`.
- **Phát hiện:** DB chưa có bảng `refresh_tokens` (spec v1.1) → T-107 blocked.
- **Tiếp theo:** T-011 JWT/CORS/static, T-101 auth.

## 2026-11-10 — Scaffold backend ASP.NET Core (DB-first)

- **Làm:**
  - Tạo solution `backend/SnackShop.slnx` + project `SnackShop.Api` (`net10.0`, controllers).
  - Cài packages: EF Core Design 10.0.14, Npgsql EF Core 10.0.3, Swashbuckle 10.3.1, JwtBearer 10.0.14, BCrypt.Net-Next 4.2.0.
  - Tạo folder skeleton: Controllers, Services, DTOs, Models/Entities, Data, Middleware, Extensions, Helpers, wwwroot/uploads/products.
  - Cài `dotnet-ef` local tool, khởi tạo user-secrets, thêm `global.json`.
  - Viết `Program.cs` tối thiểu (controllers + Swagger), `appsettings.json` có ConnectionStrings/Jwt để trống.
  - Xoá code mẫu WeatherForecast; build 0 warning / 0 error.
  - Cập nhật `docs/SETUP.md` với lệnh chạy và lệnh scaffold DB-first.
- **File:** `backend/*`, `.gitignore`, `docs/SETUP.md`, `docs/PROJECT.md`, `docs/DECISIONS.md`, `docs/TASKS.md`, `docs/STATUS.md`.
- **Quyết định:** D-011 (DB-first), D-012 (1 project, không Repository); cập nhật D-002.
- **Tiếp theo:** T-008 scaffold entities (cần connection string), T-011 cấu hình, T-101 auth.
- **Chặn:** chưa có connection string DB; FE chưa chọn stack.

## 2026-11-10 — Bổ sung spec v1.1 + cập nhật Excel

- **Làm:** rà soát khoảng trống của spec v1.0 và chốt bổ sung:
  - API mới: CUS-11 Refresh Token, CUS-12 Logout, CUS-13 Guest Order Lookup, CUS-14 Cancel Order, AD-7 Upload Image.
  - Sửa: CUS-8 yêu cầu đăng nhập (chủ đơn/Admin); AD-1 thêm `from/to/topLimit`.
  - Thêm mục "5. Quy ước chung" 23 điểm (auth, phân quyền, envelope, phân trang, trạng thái đơn, kho, giá, giảm giá, xoá, upload, bảo mật, COD, lỗi, CORS, `refresh_tokens`).
  - Cập nhật Excel bằng Office tool, verify và lưu thành công.
- **File:** `docs/specs/SnackShopManagement.xlsx` (v1.1), `docs/specs/archive/SnackShopManagement_v1.0.xlsx`, `docs/API.md`, `docs/DATABASE.md`, `docs/PROJECT.md`, `docs/TASKS.md`, `docs/STATUS.md`, `docs/DECISIONS.md`.
- **Quyết định:** D-004…D-010.
- **Tiếp theo:** T-001 chốt stack; T-003 scaffold; T-009 body chi tiết.
- **Chặn:** file Excel trong `Downloads` đang mở (bị khoá) nên chưa sync đè; bản v1.1 đã có trong repo.
- **Lưu ý:** Word ERD v1.0 chưa có bảng `refresh_tokens` — cần vẽ lại nếu dùng cho báo cáo.

## 2026-11-10 — Nhập yêu cầu từ Excel + Word

- **Làm:** trích đặc tả API (Customer CUS-1…10, Admin AD-0…6) từ `SnackShopManagement.xlsx` và ERD 7 bảng từ ảnh trong `SnackManagementDocuments.docx`; copy bản gốc vào `docs/specs/`.
- **File:** `docs/specs/*`, `docs/API.md`, `docs/DATABASE.md`, `docs/PROJECT.md`, `docs/TASKS.md`, `docs/STATUS.md`, `docs/DECISIONS.md`, `README.md`, `AGENTS.md`.
- **Quyết định:** D-003 (spec gốc là nguồn sự thật).
- **Tiếp theo:** T-001 chốt stack, T-007 chốt câu hỏi nghiệp vụ.
- **Chặn:** chưa có tech stack nên chưa scaffold FE/BE.

## 2026-11-10 — Khởi tạo harness

- **Làm:** dựng bộ tài liệu harness ở root để AI/dev đọc mỗi phiên.
- **File:** `AGENTS.md`, `docs/{PROJECT,STATUS,TASKS,LOG,DECISIONS,CONVENTIONS,DATABASE,API,SETUP}.md`, `.gitignore`, `.editorconfig`, `.gitattributes`, `README.md`.
- **Quyết định:** D-001 (harness là nguồn ngữ cảnh).
- **Tiếp theo:** chốt stack (T-001) và phạm vi MVP (T-002).
- **Chặn:** chưa có tech stack nên chưa scaffold FE/BE.
