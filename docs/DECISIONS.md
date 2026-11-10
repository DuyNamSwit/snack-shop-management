# DECISIONS — Nhật ký quyết định

Ghi lại **quyết định** kèm lý do, để sau này không phải đoán "vì sao lại làm thế".

| ID | Ngày | Quyết định | Lý do | Phương án đã cân nhắc | Trạng thái |
|---|---|---|---|---|---|
| D-001 | 2026-11-10 | Dùng harness docs (`AGENTS.md` + `docs/`) làm nguồn ngữ cảnh cho AI | AI không quên giữa các phiên | Chỉ dựa vào chat; memory tool | accepted |
| D-002 | 2026-11-10 | Tech stack FE/BE/DB | — | — | **pending** |
| D-003 | 2026-11-10 | Spec gốc (`docs/specs/*`) là nguồn sự thật | Yêu cầu gốc của user, tránh AI suy diễn | Giữ draft tự đề xuất | accepted |
| D-004 | 2026-11-10 | Auth: JWT access 8h + refresh token 7d, bảng `refresh_tokens`, logout thu hồi, rotate khi refresh | Có logout/refresh đúng nghĩa, không lưu token thô | Access token dài hạn không refresh; session | accepted |
| D-005 | 2026-11-10 | Trừ kho khi tạo đơn, hoàn khi huỷ; thiếu kho → 409; không sửa đơn; khách huỷ chỉ khi `Pending` | Chống bán quá tồn; đơn giản, không cần luồng sửa đơn | Trừ kho lúc `Completed`; cho sửa đơn | accepted |
| D-006 | 2026-11-10 | Giá chụp tại thời điểm đặt; `total = Σ(unit_price × qty)`; COD; không phí ship/thuế; `discount_percent` ưu tiên hơn `discount_price` | Báo cáo cũ không lệch; demo đơn giản | Tính theo giá hiện tại; cộng phí ship | accepted |
| D-007 | 2026-11-10 | Sản phẩm xoá mềm (`is_active=false`); danh mục chặn xoá nếu còn sản phẩm; chi phí xoá cứng; user chỉ khoá/mở | Giữ lịch sử đơn; tránh mất dữ liệu | Xoá cứng tất cả | accepted |
| D-008 | 2026-11-10 | `GET /orders/{id}` chỉ chủ đơn/Admin; khách vãng lai dùng `POST /orders/lookup` (orderId + phone, 5 lần/phút/IP); rate limit login 5 lần/phút/IP; admin không tự khoá | Chặn đoán ID xem đơn người khác | Để công khai; dùng mã đơn ngẫu nhiên | accepted |
| D-009 | 2026-11-10 | Chuẩn API: envelope `{success,data,message}`, phân trang `page/pageSize` (20, max 100), trạng thái đơn là chuỗi, mã lỗi 400/401/403/404/409/429/500 | FE/BE thống nhất, dễ sinh code | Trả mảng trần; không phân trang | accepted |
| D-010 | 2026-11-10 | Upload ảnh local: multipart `file`, ≤5MB, jpg/png/webp, trả URL tương đối `/uploads/products/...` | Không phụ thuộc dịch vụ ngoài | Cloudinary/S3 | accepted |

## Thứ tự ưu tiên khi mâu thuẫn

1. Spec gốc trong `docs/specs/`.
2. Tài liệu mô tả trong `docs/` (API, DATABASE, PROJECT).
3. Ghi chú miệng trong chat.

Code lệch spec = bug (trừ khi user đổi ý và đã ghi quyết định mới).

## D-002 — Chưa chốt

| Thành phần | Phương án đang cân nhắc |
|---|---|
| Backend | ASP.NET Core Web API, Node.js (Express/NestJS), Java Spring Boot |
| Frontend | React + Vite, Next.js, Vue |
| Database | PostgreSQL, SQL Server, MySQL, SQLite |

Tiêu chí: quen tay nhất, chạy local trên Windows dễ, ít cấu hình.

Gợi ý từ spec: ERD hiển thị schema `public` → nhiều khả năng PostgreSQL.

→ Khi user chốt: cập nhật dòng D-002 (`accepted`), `PROJECT.md`, `STATUS.md`, rồi làm T-003.
