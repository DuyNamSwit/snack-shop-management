# API — Hợp đồng giữa FE và BE

> Trạng thái: **draft** — chưa chốt (T-005). Cập nhật mỗi khi thêm/sửa endpoint.

## Quy ước chung

- Base URL dev: `http://localhost:<port>/api/v1` (port chốt sau khi scaffold).
- Auth: JWT Bearer (đề xuất) — header `Authorization: Bearer <token>`.
- Định dạng response và mã lỗi: xem `docs/CONVENTIONS.md`.

## Endpoints dự kiến

| Method | Path | Mô tả | Auth | Ghi chú |
|---|---|---|---|---|
| POST | `/auth/login` | Đăng nhập | Không | Trả token |
| GET | `/auth/me` | Thông tin user hiện tại | Có | |
| GET | `/categories` | Danh sách danh mục | Có | |
| POST | `/categories` | Thêm danh mục | Admin | |
| PUT | `/categories/{id}` | Sửa danh mục | Admin | |
| DELETE | `/categories/{id}` | Xoá danh mục | Admin | Chặn nếu còn sản phẩm |
| GET | `/products` | Danh sách sản phẩm | Có | `?search=&category_id=&page=&limit=` |
| POST | `/products` | Thêm sản phẩm | Admin | |
| PUT | `/products/{id}` | Sửa sản phẩm | Admin | |
| DELETE | `/products/{id}` | Xoá sản phẩm | Admin | |
| GET | `/suppliers` | Danh sách nhà cung cấp | Có | |
| POST | `/purchase-orders` | Tạo phiếu nhập | Có | Tăng tồn kho |
| GET | `/customers` | Danh sách khách hàng | Có | |
| POST | `/orders` | Tạo hoá đơn bán | Có | Giảm tồn kho |
| GET | `/orders/{id}` | Chi tiết hoá đơn | Có | |
| GET | `/reports/revenue` | Báo cáo doanh thu | Admin | `?from=&to=` |

## Ghi chú nghiệp vụ (draft)

- Bán hàng phải kiểm tra tồn kho trước khi tạo hoá đơn.
- Huỷ hoá đơn → hoàn lại tồn kho (chốt với user).
- Xoá sản phẩm đã phát sinh hoá đơn: chặn hay xoá mềm? (chốt với user).

## Lịch sử thay đổi

| Ngày | Thay đổi | Ghi chú |
|---|---|---|
| 2026-11-10 | Draft endpoint đầu tiên | Chưa chốt, chỉ để hình dung |
