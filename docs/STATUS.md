# STATUS — Đang ở đâu

**Cập nhật lần cuối:** 2026-11-10

## Giai đoạn

Phase 1 — Đã có **spec v1.1** (DB + API + quy ước), **chưa có code**.

## Đang làm

- (trống)

## Đã xong

- Repo GitHub `snack-shop-management`, nhánh `main`; khung `frontend/`, `backend/`.
- Harness: `AGENTS.md` + `docs/*` + file cấu hình root.
- Nhập spec v1.0 từ Excel (API) + Word (ERD 7 bảng).
- **Bổ sung spec v1.1** và cập nhật `docs/specs/SnackShopManagement.xlsx`:
  - Thêm CUS-11 Refresh Token, CUS-12 Logout, CUS-13 Guest Order Lookup, CUS-14 Cancel Order, AD-7 Upload Image.
  - Cập nhật CUS-8 (yêu cầu đăng nhập, chủ đơn/Admin) và AD-1 (lọc from/to/topLimit).
  - Thêm mục "5. Quy ước chung" 23 điểm: auth, phân quyền, response, phân trang, trạng thái đơn, tồn kho, giá, giảm giá, xoá, upload, bảo mật, COD, mã lỗi, CORS, bảng `refresh_tokens`.
- Cập nhật `API.md`, `DATABASE.md` (thêm `refresh_tokens`), `PROJECT.md`, `TASKS.md`, `DECISIONS.md` theo v1.1.
- Archive bản Excel v1.0 tại `docs/specs/archive/SnackShopManagement_v1.0.xlsx`.

## Tiếp theo (ưu tiên từ trên xuống)

1. T-001 — chốt tech stack FE/BE/DB.
2. T-003 — scaffold `frontend/` + `backend/`.
3. T-008 — schema vật lý + migration + seed (8 bảng).
4. T-009 — đặc tả request/response body (ưu tiên AD-1, CUS-6, CUS-13).
5. Làm module: T-101…T-108 (Customer) → T-201…T-208 (Admin).

## Cần user quyết

- Stack FE/BE/DB (ERD dùng schema `public` → có thể PostgreSQL).
- Xác nhận lại 7 quyết định v1.1 (D-004…D-010) nếu muốn đổi — hiện đã ghi vào spec.
- File Excel trong `Downloads` đang mở nên chưa ghi đè được; bản v1.1 nằm ở `docs/specs/` (cần đóng Excel nếu muốn sync).

## Đang chặn

- T-003, T-008 chờ T-001.
