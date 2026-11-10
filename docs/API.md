# API — Hợp đồng giữa FE và BE

> **Nguồn sự thật:** sheet `Sheet1` của `docs/specs/SnackShopManagement.xlsx`.
> **Trạng thái:** route + method + query đã chốt theo spec; request/response body chưa đặc tả (T-009).

## Quy ước chung

- Base URL: `/api` (dev: `http://localhost:<port>/api`).
- Auth: spec trả "Token xác thực" → đề xuất JWT Bearer (`Authorization: Bearer <token>`), chờ chốt ở T-007.
- Response envelope: đề xuất theo `CONVENTIONS.md`.
- Mã `CUS-x` / `AD-x` giữ nguyên theo file spec để đối chiếu.

## Customer Module

| ID | Chức năng | Mô tả | Method | Route | Auth |
|---|---|---|---|---|---|
| CUS-1 | User Register | Đăng ký tài khoản khách hàng mới | POST | `/api/auth/register` | Không |
| CUS-2 | User Login | Đăng nhập tài khoản khách hàng | POST | `/api/auth/login` | Không |
| CUS-3 | View Products | Danh sách sản phẩm; tìm theo tên, lọc danh mục, sắp xếp giá | GET | `/api/products?search={kw}&categoryId={id}&sortBy={price_asc\|price_desc}` | Không |
| CUS-4 | View Product Detail | Chi tiết 1 sản phẩm | GET | `/api/products/{id}` | Không |
| CUS-5 | View Categories | Danh sách danh mục để hiển thị menu/filter | GET | `/api/categories` | Không |
| CUS-6 | Create Order | Đặt hàng — áp dụng cho cả khách đã đăng nhập và khách vãng lai | POST | `/api/orders` | Không bắt buộc |
| CUS-7 | View History Orders | Khách xem lịch sử đơn của mình | GET | `/api/orders/history` | Có |
| CUS-8 | View Order Process | Xem trạng thái chi tiết 1 đơn theo ID | GET | `/api/orders/{id}` | Không (theo spec — xem khoảng trống) |
| CUS-9 | Update Profile | Cập nhật họ tên, SĐT, địa chỉ | PUT | `/api/users/profile` | Có |
| CUS-10 | Change Password | Đổi mật khẩu | PUT | `/api/users/change-password` | Có |

## Admin Module

| ID | Chức năng | Mô tả | Method | Route | Auth |
|---|---|---|---|---|---|
| AD-0 | Admin Login | Đăng nhập admin, lấy token | POST | `/api/auth/admin-login` | Không |
| AD-1 | View Report | Dashboard: doanh thu, tiền vốn, chi phí, lợi nhuận ròng, top bán chạy | GET | `/api/admin/reports/dashboard` | Admin |
| AD-2a | Product List | Danh sách + tìm kiếm sản phẩm | GET | `/api/admin/products?search=&categoryId=&isActive=` | Admin |
| AD-2b | Product Create | Thêm sản phẩm (giảm giá theo % hoặc số tiền) | POST | `/api/admin/products` | Admin |
| AD-2c | Product Update | Sửa sản phẩm, chỉnh tồn kho, cập nhật giảm giá | PUT | `/api/admin/products/{id}` | Admin |
| AD-2d | Product Delete | Xoá hoặc ẩn sản phẩm | DELETE | `/api/admin/products/{id}` | Admin |
| AD-3a | Category List | Danh sách danh mục | GET | `/api/admin/categories` | Admin |
| AD-3b | Category Create | Thêm danh mục | POST | `/api/admin/categories` | Admin |
| AD-3c | Category Update | Sửa tên / mô tả danh mục | PUT | `/api/admin/categories/{id}` | Admin |
| AD-3d | Category Delete | Xoá danh mục | DELETE | `/api/admin/categories/{id}` | Admin |
| AD-4a | Order List | Danh sách + tìm kiếm đơn (search, status, fromDate, toDate) | GET | `/api/admin/orders?search=&status=&fromDate=&toDate=` | Admin |
| AD-4b | Order Detail | Chi tiết đơn: sản phẩm, giá nhập thời điểm đó, thông tin khách | GET | `/api/admin/orders/{id}` | Admin |
| AD-4c | Order Status | Cập nhật trạng thái `Pending → Shipping → Completed / Cancelled` | PATCH | `/api/admin/orders/{id}/status` | Admin |
| AD-5a | User List | Danh sách + tìm kiếm người dùng | GET | `/api/admin/users?search=&roleId=&isActive=` | Admin |
| AD-5b | User Status | Khóa / mở khóa tài khoản | PATCH | `/api/admin/users/{id}/status` | Admin |
| AD-6a | Expense List | Danh sách chi phí phát sinh | GET | `/api/admin/expenses` | Admin |
| AD-6b | Expense Create | Ghi nhận chi phí (bao bì, hàng hỏng/hết hạn, vận chuyển...) | POST | `/api/admin/expenses` | Admin |
| AD-6c | Expense Delete | Xoá khoản chi phí | DELETE | `/api/admin/expenses/{id}` | Admin |

## Khoảng trống trong spec (cần bổ sung khi code)

- Chưa có logout / refresh token.
- Chưa có API upload ảnh — `image_url` hiện là chuỗi.
- Chưa có API khách tự huỷ / sửa đơn.
- `GET /api/orders/{id}` không nêu cơ chế xác thực → nguy cơ đoán ID xem đơn người khác.
- AD-1 chưa mô tả cấu trúc response.
- Chưa nêu phân trang cho các API danh sách.
- Trạng thái đơn lưu dạng chữ hay số chưa chốt.

## Lịch sử thay đổi

| Ngày | Thay đổi |
|---|---|
| 2026-11-10 | Nhập toàn bộ route/method từ file Excel (CUS-1…10, AD-0…6) |
