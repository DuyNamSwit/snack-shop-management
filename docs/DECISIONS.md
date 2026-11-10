# DECISIONS — Nhật ký quyết định

Ghi lại **quyết định** kèm lý do, để sau này không phải đoán "vì sao lại làm thế".

| ID | Ngày | Quyết định | Lý do | Phương án đã cân nhắc | Trạng thái |
|---|---|---|---|---|---|
| D-001 | 2026-11-10 | Dùng harness docs (`AGENTS.md` + `docs/`) làm nguồn sự thật để AI đọc mỗi phiên | AI không quên ngữ cảnh giữa các phiên; user chỉ cần trỏ AI đọc | Chỉ dựa vào chat; dùng memory tool | accepted |
| D-002 | 2026-11-10 | Tech stack FE/BE/DB | — | — | **pending** |

## D-002 — Chưa chốt

Các lựa chọn đang cân nhắc:

| Thành phần | Phương án |
|---|---|
| Backend | ASP.NET Core Web API, Node.js (Express/NestJS), Java Spring Boot |
| Frontend | React + Vite, Next.js, Vue |
| Database | SQL Server, MySQL, PostgreSQL, SQLite |

Tiêu chí: quen tay nhất, chạy local trên Windows dễ, ít cấu hình, đủ cho demo.

→ Khi user chốt: cập nhật dòng D-002 (trạng thái `accepted`), cập nhật `PROJECT.md` và `TASKS.md` (T-001).
