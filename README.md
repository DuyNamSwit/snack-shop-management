# Snack Shop Management

Hệ thống quản lý và bán hàng cho cửa hàng bánh kẹo / đồ ăn vặt, gồm **website đặt hàng cho khách** và **trang quản trị cho chủ cửa hàng**. Đây là dự án cá nhân, phát triển theo hướng **backend-first**: hoàn thiện REST API trước, sau đó mới làm giao diện.

## Giới thiệu

- **Khách hàng:** đăng ký / đăng nhập, xem và tìm kiếm sản phẩm theo tên, danh mục và giá; đặt hàng (kể cả khách vãng lai); tra cứu trạng thái đơn; huỷ đơn khi còn `Pending`; xem lịch sử mua hàng; cập nhật hồ sơ và đổi mật khẩu.
- **Quản trị viên:** đăng nhập riêng; xem dashboard doanh thu – tiền vốn – chi phí – lợi nhuận – sản phẩm bán chạy; quản lý sản phẩm (giá, giảm giá, tồn kho, ảnh), danh mục, đơn hàng, người dùng và các khoản chi phí phát sinh.
- **Nghiệp vụ chính:** giá bán và giá nhập được chụp lại tại thời điểm đặt hàng để báo cáo cũ không bị lệch; tồn kho được kiểm tra và trừ ngay khi tạo đơn; huỷ đơn hoàn kho; khách vãng lai vẫn đặt được hàng.
- **Bảo mật:** JWT access token 10 phút + refresh token 7 ngày (lưu hash, xoay vòng, thu hồi khi logout), phân quyền Customer/Admin.

Dự án ưu tiên sự đơn giản, dễ đọc và chạy được (KISS) hơn là kiến trúc phức tạp.

## Tech stack

| Thành phần | Công nghệ |
|---|---|
| Ngôn ngữ / runtime | C# · .NET 10 (SDK 10.0.402) |
| Web framework | ASP.NET Core Web API (controllers) |
| ORM | EF Core 10 — DB-first (`dotnet ef dbcontext scaffold`) |
| Database | PostgreSQL (Npgsql) |
| Auth | JWT Bearer — access 10 phút, refresh 7 ngày |
| Hash mật khẩu | BCrypt.Net-Next |
| API docs | Swagger / Swashbuckle |
| Công cụ | dotnet-ef (local tool), user-secrets |
| Frontend | Chưa chốt |

## Tiến độ hiện tại

> Chi tiết đầy đủ: [`docs/STATUS.md`](docs/STATUS.md)

**Đã xong**

- [x] Đặc tả v1.1: 14 chức năng Customer, 8 nhóm chức năng Admin, 23 quy ước API.
- [x] PostgreSQL local `SnackShopManagementSystem` với 8 bảng (gồm `refresh_tokens`).
- [x] Backend .NET 10: EF Core, Npgsql, Swagger, JWT, BCrypt; build 0 warning / 0 error.
- [x] Scaffold DB-first: 8 entity + `AppDbContext`, đăng ký DbContext; Swagger chạy thử HTTP 200.

**Đang làm / tiếp theo**

- [ ] Cấu hình JWT, CORS, static files (T-011).
- [ ] API auth: register, login, admin-login, refresh, logout.
- [ ] API Customer: sản phẩm, danh mục, đặt hàng, lịch sử & huỷ đơn, hồ sơ.
- [ ] API Admin: sản phẩm, danh mục, đơn hàng, người dùng, chi phí, upload, dashboard.
- [ ] Frontend (chưa chọn stack).

## Cách chạy

### Yêu cầu

- .NET SDK **10.0.402**
- PostgreSQL đang chạy, database `SnackShopManagementSystem` đã có bảng và dữ liệu
- (tuỳ chọn) pgAdmin hoặc công cụ tương đương

### Các bước

```bash
cd backend
dotnet tool restore
```

Lưu connection string vào user-secrets (không commit vào repo):

```bash
cd SnackShop.Api
dotnet user-secrets set "ConnectionStrings:DefaultConnection" "Host=localhost;Port=5432;Database=SnackShopManagementSystem;Username=postgres;Password=<mat-khau>"
cd ..
```

Build và chạy:

```bash
dotnet build
dotnet run --project SnackShop.Api
```

- API: `http://localhost:5261`
- Swagger: `http://localhost:5261/swagger`

Kiểm tra kết nối DB:

```bash
dotnet ef dbcontext info --project SnackShop.Api
```

> Hiện chưa có endpoint nghiệp vụ nên Swagger mới chỉ hiển thị khung. Hướng dẫn chi tiết (secrets, scaffold DB-first) nằm ở [`docs/SETUP.md`](docs/SETUP.md).

## Cấu trúc

```
.
├── backend/                  # ASP.NET Core Web API (đã scaffold)
│   ├── SnackShop.slnx
│   └── SnackShop.Api/
│       ├── Controllers/      # API endpoints (sẽ thêm)
│       ├── Services/         # nghiệp vụ (sẽ thêm)
│       ├── DTOs/             # request/response models (sẽ thêm)
│       ├── Data/             # AppDbContext (DB-first)
│       ├── Models/Entities/  # entity scaffold từ DB
│       └── wwwroot/uploads/  # ảnh sản phẩm
├── frontend/                 # giao diện người dùng (chưa khởi tạo)
├── docs/                     # STATUS, TASKS, LOG, API, DATABASE, ...
├── AGENTS.md                 # luật làm việc cho AI (đọc đầu tiên)
└── README.md
```
