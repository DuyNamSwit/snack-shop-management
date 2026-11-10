# STATUS — Đang ở đâu

**Cập nhật lần cuối:** 2026-11-10

## Giai đoạn

Phase 1 — Đã có đặc tả database + API, **chưa có code**.

## Đang làm

- (trống)

## Đã xong

- Repo GitHub `snack-shop-management`, nhánh `main`; khung `frontend/`, `backend/`.
- Harness: `AGENTS.md` + `docs/*` + file cấu hình root.
- Nhập yêu cầu từ 2 file spec, lưu bản gốc tại `docs/specs/`:
  - `SnackShopManagement.xlsx` → 10 chức năng Customer + 7 nhóm chức năng Admin.
  - `SnackManagementDocuments.docx` → ERD 7 bảng.
- Cập nhật `DATABASE.md` (7 bảng), `API.md` (CUS-1…10, AD-0…6), `PROJECT.md` (tác nhân & scope).

## Tiếp theo (ưu tiên từ trên xuống)

1. T-001 — chốt tech stack FE/BE/DB.
2. T-007 — chốt 5 câu hỏi nghiệp vụ còn mở.
3. T-003 — scaffold `frontend/` + `backend/`.
4. T-008 — schema vật lý + migration + seed (roles, admin).
5. T-009 — đặc tả request/response body.
6. Làm module: T-101…T-106 (Customer) → T-201…T-207 (Admin).

## Cần user quyết

- Stack FE/BE/DB (ERD dùng schema `public` → có thể PostgreSQL, cần xác nhận).
- Auth dùng JWT Bearer hay session?
- 5 câu hỏi trong `DATABASE.md` mục "Câu hỏi chưa chốt" (guest, discount, trừ kho, xoá sản phẩm, DB engine).
- Ngoài Admin + Customer có cần role Nhân viên không?

## Đang chặn

- T-003, T-008 chờ T-001.
