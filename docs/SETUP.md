# SETUP — Cách chạy dự án

## Yêu cầu môi trường

- Windows 10/11
- .NET SDK **10.0.402** (đã pin trong `backend/global.json`)
- PostgreSQL — DB đã có sẵn (làm theo hướng DB-first)
- Node.js v24 (cho frontend — chưa scaffold)
- `dotnet-ef` là local tool trong `backend/dotnet-tools.json`

## Cấu trúc backend

```
backend/
├── SnackShop.slnx
├── global.json
├── dotnet-tools.json          # dotnet-ef
└── SnackShop.Api/
    ├── Program.cs             # pipeline tối thiểu, chưa có nghiệp vụ
    ├── appsettings.json       # connection string + JWT (để trống)
    ├── Controllers/
    ├── Services/
    ├── DTOs/
    ├── Models/Entities/       # entity do scaffold sinh ra
    ├── Data/                  # AppDbContext do scaffold sinh ra
    ├── Middleware/
    ├── Extensions/
    ├── Helpers/
    └── wwwroot/uploads/products/
```

## Chạy backend

```bash
cd backend
dotnet tool restore
dotnet build
dotnet run --project SnackShop.Api
```

- HTTP: `http://localhost:5261`
- Swagger (Development): `http://localhost:5261/swagger`
- HTTPS: `dotnet run --project SnackShop.Api --launch-profile https` → `https://localhost:7228`

## Cấu hình bí mật (user-secrets)

```bash
cd backend/SnackShop.Api
dotnet user-secrets set "ConnectionStrings:DefaultConnection" "Host=localhost;Port=5432;Database=<db>;Username=<user>;Password=<pass>"
dotnet user-secrets set "Jwt:Issuer" "SnackShop"
dotnet user-secrets set "Jwt:Audience" "SnackShopClient"
dotnet user-secrets set "Jwt:Key" "<chuoi-bi-mat-toi-thieu-32-ky-tu>"
```

Không commit connection string / JWT key. `appsettings.json` chỉ để giá trị rỗng hoặc mặc định không nhạy cảm.

## DB-first — scaffold entity từ DB

> Chưa chạy bước này cho đến khi có connection string.

```bash
cd backend
dotnet tool restore
dotnet ef dbcontext scaffold "Host=localhost;Port=5432;Database=<db>;Username=<user>;Password=<pass>" Npgsql.EntityFrameworkCore.PostgreSQL \
  --project SnackShop.Api \
  --context AppDbContext \
  --context-dir Data \
  --output-dir Models/Entities \
  --no-onconfiguring
```

Ghi chú:

- `--no-onconfiguring`: không sinh `OnConfiguring`; sau đó đăng ký DbContext trong `Program.cs`.
- Chạy lại khi DB thay đổi: thêm `-f` (ghi đè `Data/` và `Models/Entities/`).
- Không sửa trực tiếp file generated; dùng `partial class` nếu cần mở rộng.
- Nếu DB là SQL Server: cài `Microsoft.EntityFrameworkCore.SqlServer` và thay provider trong lệnh scaffold.

## Chưa có (sẽ làm ở task sau)

- Chưa có `AppDbContext`, entity, controller hay service nào.
- Chưa cấu hình DI cho DbContext, JWT, CORS, static files.
- Chưa có middleware response/error chung.

## Tài khoản mẫu

(TBD — phụ thuộc dữ liệu DB hiện có)
