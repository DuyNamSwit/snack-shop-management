# DATABASE — Thiết kế dữ liệu

> **Nguồn sự thật:** ERD trong `docs/specs/SnackManagementDocuments.docx` (ảnh "Cấu trúc các bảng trong database").
> **Trạng thái:** schema logic đã có; DB engine + kiểu dữ liệu vật lý chờ chốt (T-001 → T-008).

## Quan hệ tổng quan

```
roles 1──n users 1──n orders 1──n order_items n──1 products n──1 categories

expenses (độc lập, không có FK)
```

## Bảng & cột

### `roles`

| Cột | Ghi chú |
|---|---|
| `id` | PK |
| `name` | Tên vai trò (Admin, Customer) |
| `description` | Mô tả |

### `users`

| Cột | Ghi chú |
|---|---|
| `id` | PK |
| `role_id` | FK → `roles.id` |
| `username` | |
| `email` | |
| `password_hash` | Chỉ lưu hash, không lưu mật khẩu thô |
| `full_name` | |
| `phone_number` | |
| `address` | |
| `is_active` | Khóa / mở khóa tài khoản |
| `created_at` | |

### `categories`

| Cột | Ghi chú |
|---|---|
| `id` | PK |
| `name` | |
| `description` | |

### `products`

| Cột | Ghi chú |
|---|---|
| `id` | PK |
| `category_id` | FK → `categories.id` |
| `name` | |
| `description` | |
| `import_price` | Giá nhập — cơ sở tính tiền vốn |
| `selling_price` | Giá bán |
| `stock_quantity` | Tồn kho |
| `image_url` | |
| `is_active` | Ẩn / ngừng bán |
| `created_at` | |
| `discount_price` | Giảm giá theo số tiền |
| `discount_percent` | Giảm giá theo % |

### `orders`

| Cột | Ghi chú |
|---|---|
| `id` | PK |
| `user_id` | FK → `users.id`; khách vãng lai có thể NULL (chưa chốt) |
| `customer_name` | Lưu trực tiếp để hỗ trợ khách vãng lai |
| `customer_phone` | |
| `customer_address` | |
| `note` | |
| `total_amount` | Tổng tiền đơn |
| `status` | `Pending` → `Shipping` → `Completed` / `Cancelled` |
| `created_at` | |

### `order_items`

| Cột | Ghi chú |
|---|---|
| `id` | PK |
| `order_id` | FK → `orders.id` |
| `product_id` | FK → `products.id` |
| `quantity` | |
| `unit_price` | Giá bán **tại thời điểm đặt** |
| `unit_import_price` | Giá nhập **tại thời điểm đặt** — dùng tính lợi nhuận |

### `expenses`

| Cột | Ghi chú |
|---|---|
| `id` | PK |
| `title` | |
| `amount` | |
| `expense_date` | |
| `note` | |

## Quy tắc suy ra từ spec

- `order_items` chụp lại giá bán + giá nhập tại thời điểm đặt → sửa giá sản phẩm sau này không làm sai báo cáo cũ.
- Lợi nhuận ròng (AD-1) = doanh thu − tiền vốn (`unit_import_price`) − chi phí (`expenses`).
- Đơn hàng lưu thông tin khách trực tiếp → hỗ trợ khách vãng lai.
- Không có bảng phiếu nhập / nhà cung cấp: tồn kho được chỉnh qua cập nhật sản phẩm (AD-2).

## Câu hỏi chưa chốt (T-007)

1. `orders.user_id` của khách vãng lai: NULL hay tạo user ẩn?
2. Có cả `discount_price` và `discount_percent`: ưu tiên cái nào? Cho phép nhập cả hai?
3. Trừ `stock_quantity` lúc tạo đơn hay lúc chuyển `Completed`? Huỷ đơn có hoàn kho không?
4. Xoá sản phẩm (AD-2): xoá cứng hay chỉ set `is_active = false`?
5. DB engine + kiểu dữ liệu (ERD hiển thị schema `public` → gợi ý PostgreSQL, cần xác nhận).

## Lịch sử thay đổi

| Ngày | Thay đổi |
|---|---|
| 2026-11-10 | Nhập schema từ ERD file Word (7 bảng) |
