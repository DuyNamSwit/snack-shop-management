# DECISIONS — Nhật ký quyết định

Ghi lại **quyết định** kèm lý do, để sau này không phải đoán "vì sao lại làm thế".

| ID | Ngày | Quyết định | Lý do | Phương án đã cân nhắc | Trạng thái |
|---|---|---|---|---|---|
| D-001 | 2026-11-10 | Dùng harness docs (`AGENTS.md` + `docs/`) làm nguồn ngữ cảnh cho AI | AI không quên giữa các phiên; user chỉ cần trỏ AI đọc | Chỉ dựa vào chat; memory tool | accepted |
| D-002 | 2026-11-10 | Tech stack FE/BE/DB | — | — | **pending** |
| D-003 | 2026-11-10 | Spec gốc (`docs/specs/*.xlsx`, `*.docx`) là nguồn sự thật về nghiệp vụ, DB, API | Đây là yêu cầu gốc của user; tránh AI tự suy diễn | Giữ bản draft tự đề xuất | accepted |

## Thứ tự ưu tiên khi mâu thuẫn

1. Spec gốc trong `docs/specs/`.
2. Tài liệu mô tả trong `docs/` (DATABASE, API, PROJECT).
3. Ghi chú miệng trong chat.

Code lệch spec = bug (trừ khi user đổi ý và đã ghi lại quyết định mới).

## D-002 — Chưa chốt

| Thành phần | Phương án đang cân nhắc |
|---|---|
| Backend | ASP.NET Core Web API, Node.js (Express/NestJS), Java Spring Boot |
| Frontend | React + Vite, Next.js, Vue |
| Database | PostgreSQL, SQL Server, MySQL, SQLite |

Tiêu chí: quen tay nhất, chạy local trên Windows dễ, ít cấu hình.

Gợi ý từ spec: ERD hiển thị schema `public` → nhiều khả năng PostgreSQL.

→ Khi user chốt: cập nhật dòng D-002 (`accepted`), `PROJECT.md`, `STATUS.md`, rồi làm T-003.
