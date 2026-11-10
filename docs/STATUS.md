# STATUS — Đang ở đâu

**Cập nhật lần cuối:** 2026-11-10

## Giai đoạn

Phase 2 — Backend đã kết nối DB + scaffold, chưa có API.

## Đang làm

- (trống)

## Đã xong

- Spec v1.1 (DB + API + 23 quy ước).
- Backend ASP.NET Core (.NET 10): packages, skeleton, build OK.
- Kết nối PostgreSQL local `SnackShopManagementSystem`; scaffold 8 entity + `AppDbContext` (gồm `RefreshToken`); đăng ký DbContext; `dotnet ef dbcontext info` xác nhận.
- Chốt token: access **10 phút**, refresh **7 ngày**; script tạo `refresh_tokens` nằm trong `DATABASE.md`.

## Tiếp theo (ưu tiên từ trên xuống)

1. T-011 — JWT, CORS, static files.
2. T-101 — đăng ký/đăng nhập.
3. T-107 — refresh token + logout.
4. T-009 — body AD-1, CUS-6, CUS-13.
5. T-001 — chốt FE stack → T-010.

## Cần user quyết

- FE stack: React + Vite? Next.js? Vue?

## Đang chặn

- T-010 — chờ FE stack.
