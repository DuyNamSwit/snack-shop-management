# API — Hợp đồng giữa FE và BE

> **Nguồn sự thật:** sheet `Sheet1` của `docs/specs/SnackShopManagement.xlsx` — **spec v1.1 (2026-11-10)**.
> Request/response body chi tiết từng endpoint vẫn cần đặc tả thêm khi code (T-009).

## Quy ước chung (v1.1)

- Base URL: `/api` (dev: `http://localhost:<port>/api`).
- **Auth:** JWT access token 8 giờ + refresh token 7 ngày (xoay vòng mỗi lần refresh), dùng chung Customer/Admin. Header `Authorization: Bearer <accessToken>`.
- **Response OK:** `{ "success": true, "data": ..., "message": "..." }`
- **Response lỗi:** `{ "success": false, "message": "...", "errors": [{ "field": "...", "message": "..." }] }`
- **Danh sách:** `data = { items, page, pageSize, totalItems, totalPages }`
- **Phân trang:** `page` mặc định 1; `pageSize` mặc định 20, tối đa 100; `sortBy` + `sortDir=asc|desc`.
- **Định dạng:** ngày giờ ISO 8601; tiền VND số nguyên; id số nguyên.
- **Mã lỗi:** 400 dữ liệu sai, 401 chưa đăng nhập/hết token, 403 không quyền, 404 không thấy, 409 trùng dữ liệu/thiếu kho, 429 quá nhiều request, 500 lỗi server.
- Mã `CUS-x` / `AD-x` giữ nguyên theo file spec để đối chiếu.

## Customer Module

| ID | Chức năng | Mô tả | Method | Route | Auth |
|---|---|---|---|---|---|
| CUS-1 | User Register | Đăng ký tài khoản khách hàng mới | POST | `/api/auth/register` | Không |
| CUS-2 | User Login | Đăng nhập tài khoản khách hàng | POST | `/api/auth/login` | Không |
| CUS-3 | View Products | Danh sách sản phẩm; tìm theo tên, lọc danh mục, sắp xếp giá | GET | `/api/products?search={kw}&categoryId={id}&sortBy={price_asc\|price_desc}` | Không |
| CUS-4 | View Product Detail | Chi tiết 1 sản phẩm | GET | `/api/products/{id}` | Không |
| CUS-5 | View Categories | Danh sách danh mục để hiển thị menu/filter | GET | `/api/categories` | Không |
| CUS-6 | Create Order | Đặt hàng — cả khách đã đăng nhập và khách vãng lai | POST | `/api/orders` | Không bắt buộc |
| CUS-7 | View History Orders | Khách xem lịch sử đơn của mình | GET | `/api/orders/history` | Có |
| CUS-8 | View Order Process | Xem trạng thái chi tiết 1 đơn — chỉ chủ đơn hoặc Admin | GET | `/api/orders/{id}` | Có |
| CUS-9 | Update Profile | Cập nhật họ tên, SĐT, địa chỉ | PUT | `/api/users/profile` | Có |
| CUS-10 | Change Password | Đổi mật khẩu | PUT | `/api/users/change-password` | Có |
| CUS-11 | Refresh Token | Đổi refresh token lấy access token mới; xoay vòng refresh token | POST | `/api/auth/refresh-token` | Không (dùng refresh token trong body) |
| CUS-12 | Logout | Thu hồi refresh token hiện tại | POST | `/api/auth/logout` | Có |
| CUS-13 | Guest Order Lookup | Khách vãng lai tra cứu đơn bằng mã đơn + SĐT (giới hạn 5 lần/phút/IP) | POST | `/api/orders/lookup` | Không |
| CUS-14 | Cancel Order | Khách huỷ đơn khi `Pending`; hoàn tồn kho | PATCH | `/api/orders/{id}/cancel` | Có (chủ đơn) |

## Admin Module

| ID | Chức năng | Mô tả | Method | Route | Auth |
|---|---|---|---|---|---|
| AD-0 | Admin Login | Đăng nhập admin, lấy token | POST | `/api/auth/admin-login` | Không |
| AD-1 | View Report | Dashboard: doanh thu, tiền vốn, chi phí, lợi nhuận ròng, top bán chạy; lọc theo khoảng ngày | GET | `/api/admin/reports/dashboard?from={date}&to={date}&topLimit={n}` | Admin |
| AD-2a | Product List | Danh sách + tìm kiếm sản phẩm | GET | `/api/admin/products?search=&categoryId=&isActive=` | Admin |
| AD-2b | Product Create | Thêm sản phẩm (giảm giá theo % hoặc số tiền) | POST | `/api/admin/products` | Admin |
| AD-2c | Product Update | Sửa sản phẩm, chỉnh tồn kho, cập nhật giảm giá | PUT | `/api/admin/products/{id}` | Admin |
| AD-2d | Product Delete | Xoá mềm sản phẩm (`is_active = false`) | DELETE | `/api/admin/products/{id}` | Admin |
| AD-3a | Category List | Danh sách danh mục | GET | `/api/admin/categories` | Admin |
| AD-3b | Category Create | Thêm danh mục | POST | `/api/admin/categories` | Admin |
| AD-3c | Category Update | Sửa tên / mô tả danh mục | PUT | `/api/admin/categories/{id}` | Admin |
| AD-3d | Category Delete | Xoá danh mục (chặn nếu còn sản phẩm) | DELETE | `/api/admin/categories/{id}` | Admin |
| AD-4a | Order List | Danh sách + tìm kiếm đơn (search, status, fromDate, toDate) | GET | `/api/admin/orders?search=&status=&fromDate=&toDate=` | Admin |
| AD-4b | Order Detail | Chi tiết đơn: sản phẩm, giá nhập thời điểm đó, thông tin khách | GET | `/api/admin/orders/{id}` | Admin |
| AD-4c | Order Status | Đổi trạng thái `Pending → Shipping → Completed / Cancelled` | PATCH | `/api/admin/orders/{id}/status` | Admin |
| AD-5a | User List | Danh sách + tìm kiếm người dùng | GET | `/api/admin/users?search=&roleId=&isActive=` | Admin |
| AD-5b | User Status | Khóa / mở khóa tài khoản (không tự khoá mình) | PATCH | `/api/admin/users/{id}/status` | Admin |
| AD-6a | Expense List | Danh sách chi phí phát sinh | GET | `/api/admin/expenses` | Admin |
| AD-6b | Expense Create | Ghi nhận chi phí (bao bì, hàng hỏng/hết hạn, vận chuyển...) | POST | `/api/admin/expenses` | Admin |
| AD-6c | Expense Delete | Xoá khoản chi phí | DELETE | `/api/admin/expenses/{id}` | Admin |
| AD-7 | Upload Image | Upload ảnh sản phẩm (multipart `file`, ≤5MB, jpg/png/webp), trả URL | POST | `/api/admin/uploads/images` | Admin |

## Nghiệp vụ đã chốt (v1.1)

- **Phân quyền:** register luôn gán role Customer (client không gửi/đổi role); `admin-login` chỉ cho role Admin; mọi route `/api/admin/*` yêu cầu role Admin.
- **Tồn kho:** kiểm tra + trừ ngay khi tạo đơn trong 1 transaction; thiếu → 409 `INSUFFICIENT_STOCK`; huỷ đơn hoàn kho.
- **Huỷ đơn:** khách chỉ khi `Pending`; Admin khi chưa `Completed`; `Completed`/`Cancelled` là trạng thái cuối.
- **Sửa đơn:** không hỗ trợ — huỷ rồi đặt lại.
- **Giá:** chụp tại thời điểm đặt; `total_amount = Σ(unit_price × quantity)`; không phí ship/thuế; thanh toán COD.
- **Giảm giá:** `discount_percent > 0` ưu tiên, ngược lại `discount_price`; giá cuối `max(0, selling_price - giảm)`.
- **Khách vãng lai:** `user_id = NULL`; bắt buộc tên/SĐT/địa chỉ.
- **Quyền xem đơn:** `GET /api/orders/{id}` chỉ chủ đơn hoặc Admin; khách vãng lai dùng CUS-13.
- **Xoá:** sản phẩm xoá mềm; danh mục chặn nếu còn sản phẩm; chi phí xoá cứng; người dùng chỉ khoá/mở.
- **Upload:** lưu local, trả `image_url` tương đối (`/uploads/products/...`).
- **Bảo mật:** hash mật khẩu bcrypt/argon2 (≥8 ký tự); email/username unique; giới hạn đăng nhập 5 lần/phút/IP; CORS chỉ cho origin FE.
- **DB:** thêm bảng `refresh_tokens` (xem `DATABASE.md`).

## Còn thiếu (T-009)

- Request/response body chi tiết cho từng endpoint.
- Cấu trúc response của AD-1 (doanh thu, vốn, chi phí, lợi nhuận, top sản phẩm, doanh thu theo ngày).
- Quy ước hiển thị trạng thái đơn ở FE.

## Lịch sử thay đổi

| Ngày | Thay đổi |
|---|---|
| 2026-11-10 | v1.1: thêm CUS-11…14, AD-7; cập nhật CUS-8/AD-1; chốt quy ước & nghiệp vụ |
| 2026-11-10 | Nhập route/method từ file Excel v1.0 (CUS-1…10, AD-0…6) |
