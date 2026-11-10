# Snack Shop Management

Website bán bánh kẹo / đồ ăn vặt: khách đặt hàng online + admin quản trị cửa hàng (dự án cá nhân).

## Cấu trúc

```
.
├── frontend/        # giao diện người dùng (chưa khởi tạo)
├── backend/         # ASP.NET Core Web API (.NET 10) — đã scaffold
├── docs/            # harness + đặc tả dự án
│   ├── specs/       # file gốc: Excel (API spec) + Word (ERD)
│   └── *.md         # STATUS, TASKS, LOG, DECISIONS, API, DATABASE, ...
├── AGENTS.md        # luật làm việc cho AI (đọc đầu tiên)
└── README.md
```

## Đặc tả gốc

- [`docs/specs/SnackShopManagement.xlsx`](docs/specs/SnackShopManagement.xlsx) — API spec **v1.1**: Customer (CUS-1…14) + Admin (AD-0…7) + quy ước chung.
- [`docs/specs/SnackManagementDocuments.docx`](docs/specs/SnackManagementDocuments.docx) — ERD v1.0 (7 bảng; v1.1 thêm `refresh_tokens`).
- Bản v1.0 được lưu tại `docs/specs/archive/`.

Bản mô tả dễ đọc: [`docs/API.md`](docs/API.md), [`docs/DATABASE.md`](docs/DATABASE.md).

## Làm việc với AI

1. Mở AI agent tại thư mục gốc của repo.
2. Prompt khởi động:
   > Đọc AGENTS.md và docs/STATUS.md, cho tôi biết dự án đang ở đâu và 3 việc tiếp theo cần làm.
3. Kết thúc phiên: yêu cầu AI cập nhật `STATUS.md`, `TASKS.md`, `LOG.md`.

## Trạng thái hiện tại

Xem [`docs/STATUS.md`](docs/STATUS.md).

- Spec v1.1 đã chốt (DB + API + quy ước).
- Backend ASP.NET Core (.NET 10) đã scaffold — **chưa có code nghiệp vụ**.
- Frontend chưa scaffold (chờ chọn stack).

## Chạy backend

```bash
cd backend
dotnet tool restore
dotnet build
dotnet run --project SnackShop.Api
```

- API: `http://localhost:5261`
- Swagger: `http://localhost:5261/swagger`
- Secrets + scaffold DB-first: xem [`docs/SETUP.md`](docs/SETUP.md)
