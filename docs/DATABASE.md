# DATABASE — Thiết kế dữ liệu

> Trạng thái: **draft** — chưa chốt. Cập nhật ngay khi schema thật được tạo (T-004).
> Khi có stack: ghi rõ nơi chứa schema/migration (ví dụ `backend/db/init.sql` hoặc thư mục migrations).

## Thực thể dự kiến

| Bảng | Mô tả | Bắt buộc? |
|---|---|---|
| `users` | Tài khoản đăng nhập (admin, nhân viên) | Có |
| `categories` | Danh mục sản phẩm (bánh, kẹo, nước...) | Có |
| `products` | Sản phẩm snack | Có |
| `suppliers` | Nhà cung cấp | Tuỳ |
| `purchase_orders` | Phiếu nhập hàng | Có |
| `purchase_order_items` | Chi tiết phiếu nhập | Có |
| `customers` | Khách hàng | Có |
| `orders` | Hoá đơn bán hàng | Có |
| `order_items` | Chi tiết hoá đơn | Có |
| `promotions` | Khuyến mãi | Chưa chắc |

## Gợi ý cột (chưa chốt)

**products:** `id`, `sku`, `name`, `category_id`, `price`, `cost_price`, `stock_quantity`, `unit`, `image_url`, `is_active`, `created_at`, `updated_at`

**orders:** `id`, `code`, `customer_id` (nullable), `user_id`, `total_amount`, `discount_amount`, `paid_amount`, `status`, `created_at`

**order_items:** `id`, `order_id`, `product_id`, `quantity`, `unit_price`, `subtotal`

## Quan hệ chính

- `categories 1—n products`
- `orders 1—n order_items n—1 products`
- `purchase_orders 1—n purchase_order_items n—1 products`
- `customers 1—n orders`
- `users 1—n orders` (nhân viên lập hoá đơn)

## Quy tắc

- Tồn kho chỉ thay đổi qua phiếu nhập và hoá đơn bán — không sửa tay tuỳ tiện (chốt lại với user).
- Mọi thay đổi cấu trúc phải ghi vào file này kèm ngày.

## Lịch sử thay đổi schema

| Ngày | Thay đổi | Ghi chú |
|---|---|---|
| 2026-11-10 | Tạo bản draft đầu tiên | Chưa có DB thật |
