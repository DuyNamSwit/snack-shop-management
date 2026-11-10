# STATUS — Đang ở đâu

**Cập nhật lần cuối:** 2026-11-10

## Giai đoạn

Phase 2 — Backend ASP.NET Core đã scaffold, **chưa có code nghiệp vụ**.

## Đang làm

- (trống)

## Đã xong

- Spec v1.1 (DB + API + 23 quy ước) và Excel v1.1.
- Backend:
  - Solution `backend/SnackShop.slnx` + project `SnackShop.Api` (`net10.0`).
  - Packages: EF Core Design 10.0.14, Npgsql EF Core 10.0.3, Swashbuckle 10.3.1, JwtBearer 10.0.14, BCrypt.Net-Next 4.2.0.
  - Folder skeleton: Controllers, Services, DTOs, Models/Entities, Data, Middleware, Extensions, Helpers, wwwroot/uploads/products.
  - `dotnet-ef` local tool, user-secrets, `global.json`, `Program.cs` tối thiểu, `appsettings.json` (connection string/JWT để trống).
  - Build thành công: 0 warning, 0 error.
- `docs/SETUP.md`: lệnh chạy + cấu hình secrets + lệnh scaffold DB-first.

## Tiếp theo (ưu tiên từ trên xuống)

1. T-008 — scaffold `AppDbContext` + entities từ DB (cần connection string).
2. T-011 — cấu hình DbContext, JWT, CORS, static files.
3. T-101 — đăng ký/đăng nhập.
4. T-001 — chốt FE stack → T-010 scaffold frontend.

## Cần user quyết

- Connection string PostgreSQL (hoặc xác nhận DB engine) để chạy scaffold.
- FE stack: React + Vite? Next.js? Vue?
- JWT key/issuer/audience (có thể đặt khi làm T-101).

## Đang chặn

- T-008, T-011: chưa có connection string.
- T-010: chưa chọn FE stack.
